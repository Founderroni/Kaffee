using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace KaffeeUtility.Utils
{
    internal class Loader
    {
        public static KaffeeUtility.Loader GetLoader => (KaffeeUtility.Loader)Application.OpenForms["Loader"];
        private static bool FastLaunch = Config.GetConfig().FastLaunch;
        public static void UpdateProgress(string status, int increment = 1, string verbose = null)
        {
            GetLoader.ProgressCircle.Increment(increment);
            GetLoader.StatusLabel.Text = status;
            if (verbose == null)
            {
                if (!string.IsNullOrEmpty(GetLoader.VerboseLabel.Text))
                    GetLoader.VerboseLabel.Text = "";
                return;
            }
            else
                GetLoader.VerboseLabel.Text = verbose;
        }

        public static async Task<string> LoaderTask()
        {
            try
            {
                UpdateProgress("Clearing Log");
                Logging.Clear();


                UpdateProgress("Checking Root Directory");
                if (!Directory.Exists(Globals.RootDataDir))
                    Directory.CreateDirectory(Globals.RootDataDir);
                Logging.Log("Confirmed RootDataDir");


                if (!FastLaunch)
                    await Task.Delay(100);


                UpdateProgress("Checking Data Directory");
                if (!Directory.Exists(Globals.DataDir))
                    Directory.CreateDirectory(Globals.DataDir);
                Logging.Log("Confirmed DataDir");


                if (!FastLaunch)
                    await Task.Delay(100);


                UpdateProgress("Checking Log File");
                if (!File.Exists(Globals.LogFile))
                    File.Create(Globals.LogFile);
                Logging.Log("Confirmed LogFile");


                UpdateProgress("Getting Client List");
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
                Logging.Log("Finished ClientList");


                foreach (var client in Globals.ClientList)
                {
                    UpdateProgress("Getting Client List", 0, $"Downloading {client.displayName}");
                    Logging.Log($"Downloading {client.displayName} from {client.url} to {Globals.DataDir}\\{client.fileName}.dll");
                    await Network.DownloadFile(client.url, $"{Globals.DataDir}\\{client.fileName}.dll");
                }
                Logging.Log("Finished downloading DLLs");


                UpdateProgress("Getting Spoof Pointers");
                string spoofListContent = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Assets/main/Other/SpoofPtrs.txt");
                string[] spoofListLines = spoofListContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in spoofListLines)
                {
                    string[] parts = line.Split(':');
                    string version = parts[0];
                    string didPtr = parts[1];
                    string mcidPtr = parts[2];
                    UpdateProgress("Getting Spoof Pointers", 0, $"Adding Pointer ({version}: {didPtr} - {mcidPtr})");
                    Logging.Log($"Adding pointers for {version} ({didPtr} - {mcidPtr})");
                    Globals.SpoofList.Add(new Models.SpoofPointersStruct(version, didPtr, mcidPtr));
                }
                Logging.Log("Finished SpoofList");


                UpdateProgress("Updating Launches");
                Config.GetConfig().Launches += 1;
                Logging.Log("+1 Launch");


                if (Config.GetConfig().UseAnimations)
                {
                    await Task.Delay(FastLaunch ? 1 : 500).ContinueWith(t =>
                    {
                        Handlers.Animator.Linear(GetLoader.StatusLabel, "Text", "", FastLaunch ? 125 : 300);
                        Handlers.Animator.Linear(GetLoader.StatusLabel, "Top", 334 - 10, FastLaunch ? 225 : 500);
                    });
                }


                await Task.Delay(FastLaunch ? 235 : 550);
                return "Complete";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
