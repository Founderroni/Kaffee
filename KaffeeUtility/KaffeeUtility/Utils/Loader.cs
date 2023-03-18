using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace KaffeeUtility.Utils
{
    internal class Loader
    {
        public static KaffeeUtility.Loader GetLoader => (KaffeeUtility.Loader)Application.OpenForms["Loader"];
        public static void IncrementLoaderProgress(int amount = 1) => GetLoader.ProgressCircle.Increment(amount);

        public static async Task<string> LoaderTask()
        {
            try
            {
                Logging.Clear();

                if (!Directory.Exists(Globals.RootDataDir))
                    Directory.CreateDirectory(Globals.RootDataDir);
                IncrementLoaderProgress();
                Logging.Log("Confirmed RootDataDir");


                await Task.Delay(100);


                if (!Directory.Exists(Globals.DataDir))
                    Directory.CreateDirectory(Globals.DataDir);
                IncrementLoaderProgress();
                Logging.Log("Confirmed DataDir");


                await Task.Delay(100);


                if (!File.Exists(Globals.LogFile))
                    File.Create(Globals.LogFile);
                IncrementLoaderProgress();
                Logging.Log("Confirmed LogFile");


                string clientListContent = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Assets/main/Other/ClientList.txt");
                string[] lines = clientListContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    string name = parts[0];
                    string url = parts[1];
                    string version = parts[2];
                    string fileName = parts[3];
                    Logging.Log($"Adding {name} {version} from {url} to ClientList");
                    Globals.ClientList.Add(new Models.ClientListStruct(name, url, version, fileName));
                }
                IncrementLoaderProgress();
                Logging.Log("Finished ClientList");


                foreach (var client in Globals.ClientList)
                {
                    Logging.Log($"Installing {client.displayName} from {client.url} to {Globals.DataDir}\\{client.fileName}.dll");
                    await Network.DownloadFile(client.url, $"{Globals.DataDir}\\{client.fileName}.dll");
                }
                IncrementLoaderProgress();
                Logging.Log("Finished downloading DLLs");


                string spoofListContent = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Assets/main/Other/SpoofPtrs.txt");
                string[] spoofListLines = spoofListContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in spoofListLines)
                {
                    string[] parts = line.Split(':');
                    string version = parts[0];
                    string didPtr = parts[1];
                    string mcidPtr = parts[2];
                    Logging.Log($"Adding pointers for {version} ({didPtr} - {mcidPtr})");
                    Globals.SpoofList.Add(new Models.SpoofPointersStruct(version, didPtr, mcidPtr));
                }
                IncrementLoaderProgress();
                Logging.Log("Finished SpoofList");


                Config.GetConfig().Launches += 1;
                IncrementLoaderProgress();
                Logging.Log("+1 Launch");

                await Task.Delay(10);
                return "Complete";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
