using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

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
            Globals.CachedConfig = Config.GetConfig();
            Globals.RootDataDir = Globals.CachedConfig.RootDirectory;
            UpdateProgress("Checking Root Directory");
            if (Globals.RootDataDir == "null")
            {
                try
                {
                    Globals.RootDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FadedSolutions");
                } catch (Exception)
                {
                    Globals.RootDataDir = Path.Combine(Globals.AppDir, "FadedSolutions");
                }
            }
            try
            {
                if (!Directory.Exists(Globals.RootDataDir))
                    Directory.CreateDirectory(Globals.RootDataDir);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Couldn't create or check for Root Directory, do you want to set the Root Directory to a newly created folder in the same directory?", "Fix Attempt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (Config.GetConfig().RootDirectory == $"{Globals.AppDir}\\FadedSolutions")
                        {
                            return $"Couldn't create or check for Root Directory and cannot use local directory:\n{ex.Message}";
                        }
                        else
                        {
                            try
                            {
                                Config.GetConfig().RootDirectory = $"{Globals.AppDir}\\FadedSolutions";
                                if (!Directory.Exists(Globals.RootDataDir))
                                    Directory.CreateDirectory(Globals.RootDataDir);
                                Application.Restart();
                            }
                            catch (Exception wtf)
                            {
                                return $"Couldn't create local Root Directory:\n{wtf.Message}";
                            }
                        }
                        break;
                    case DialogResult.No:
                        return $"Couldn't create or check for Root Directory:\n{ex.Message}";
                    default:
                        return $"Couldn't create or check for Root Directory:\n{ex.Message}";
                }
            }
            Logging.Log("Confirmed RootDataDir");


            if (!FastLaunch)
                await Task.Delay(100);


            UpdateProgress("Checking Data Directory");
            try
            {
                if (!Directory.Exists(Globals.DataDir))
                    Directory.CreateDirectory(Globals.DataDir);
            }
            catch (Exception ex)
            {
                return $"Couldn't create or check for Data Directory:\n{ex.Message}";
            }
            Logging.Log("Confirmed DataDir");


            if (!FastLaunch)
                await Task.Delay(100);


            UpdateProgress("Checking Connection");
            if (!Config.GetConfig().GithubBlocked) // It's gotta be like this until we have our own hosting or Github gets unblocked
            {
                try
                { // Test if we can connect, if you can then save the version and compare it later
                    Globals.LatestVersion = await Network.GetString("https://github.com/Founderroni/Assets/raw/main/Kaffee/Version.txt");
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("Couldn't connect to Github, is it blocked on your device or region?\nClicking Yes will skip tasks that try to connect to Github, but this means you will be missing out on a lot of features (like Spoofer and Client Injection, Custom DLL injection will still work though). If you don't want to miss out, try using a VPN.", "Github Blocked", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            Config.GetConfig().SkipUpdateCheck = true;
                            Config.GetConfig().GithubBlocked = true;
                            Application.Restart();
                            break;
                        case DialogResult.No:
                            return $"Couldn't check for updates:\n{ex.Message}";
                        default:
                            return $"Couldn't check for updates:\n{ex.Message}";
                    }
                }
            }

            UpdateProgress("Checking Log File");
            try
            {
                if (!File.Exists(Globals.LogFile))
                    File.Create(Globals.LogFile);
                Logging.Log("Confirmed LogFile");
            }
            catch (Exception ex)
            {
                return $"Couldn't create or check for log file:\n{ex.Message}";
            }

            UpdateProgress("Clearing Log");
            try
            {
                Logging.Clear();
            }
            catch (Exception ex)
            {
                return $"Could not clear logs:\n{ex.Message}";
            }

            UpdateProgress("Downloading Adverts");
            if (!Config.GetConfig().GithubBlocked && Config.GetConfig().ShowAds)
            {
                try
                {
                    string adList = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Lab/main/Kaffee/testAdList.txt");
                    string[] lines = adList.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(';');
                        string adName = parts[0];
                        string adUrl = parts[1];
                        string adRedirectUrl = parts[2];
                        string adFileName = parts[3];
                        if (Network.IsUrl(adUrl))
                        {
                            adFileName = $"{Globals.DataDir}\\{adFileName}";
                            await Network.DownloadFile(adUrl, adFileName);
                            Logging.Log($"Downloaded ad of {adName} to {adFileName}");
                        }
                        Globals.AdvertData.Add(new Models.AdvertDataStruct(adName, adUrl, adRedirectUrl, adFileName));
                        Logging.Log($"Added {adName} to AdvertList");
                    }
                }
                catch (Exception ex)
                {
                    return $"Could not download adverts:\n{ex.Message}";
                }
            } else
            {
                for (int i = 0; i > 2; i++)
                    Globals.AdvertData.Add(new Models.AdvertDataStruct("Ads Disabled", "https://i.imgur.com/j1oJ6om.png", "https://discord.gg/Rk4RxvmDXa", "null"));
                Logging.Log($"Ads are disabled");
            }

            UpdateProgress("Checking for Updates");
            if (File.Exists($"{Globals.AppDir}/Kaffee.old"))
                File.Delete($"{Globals.AppDir}/Kaffee.old");
            if (!Config.GetConfig().GithubBlocked)
            {
                try
                {
                    if (!Config.GetConfig().SkipUpdateCheck)
                    {
                        if (float.Parse(Globals.LatestVersion) > Globals.Version)
                        {
                            UpdateProgress("Checking for Updates", 0, "There is an Update, Downloading");
                            if (!FastLaunch) // Just so people have time to read the message
                                await Task.Delay(300);
                            await Network.DownloadFile($"https://github.com/Founderroni/Kaffee/releases/tag/{Globals.LatestVersion}", $"{Globals.AppDir}/temp.exe");
                            UpdateProgress("Checking for Updates", 0, "Installing Update");
                            File.Move(Globals.AppPath, Path.ChangeExtension(Globals.AppPath, "old"));
                            File.Move($"{Globals.AppDir}/temp.exe", $"{Globals.AppDir}/Kaffee.exe");
                            Misc.OpenProcess($"{Globals.AppDir}/Kaffee.exe");
                            Application.Exit();
                        }
                        Logging.Log("Checked for Updates");
                    }
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("Couldn't check for updates, would you like to skip the update check?", "Update Check Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            Config.GetConfig().SkipUpdateCheck = true;
                            Application.Restart();
                            break;
                        case DialogResult.No:
                            return $"Couldn't check for updates:\n{ex.Message}";
                        default:
                            return $"Couldn't check for updates:\n{ex.Message}";
                    }
                }
            }


            UpdateProgress("Downloading Client List");
            if (!Config.GetConfig().GithubBlocked)
            {
                try
                {
                    string clientListContent = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Assets/main/Other/ClientList.txt");
                    string[] lines = clientListContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(';');
                        string name = parts[0];
                        string url = parts[1];
                        string version = parts[2];
                        if (Network.IsUrl(version))
                        {
                            string versionContent = await Network.GetString(version);
                            string[] versionContentLines = versionContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                            version = versionContentLines[0];
                            Logging.Log($"Version was a url for client {name}, got {version}");
                        }
                        string fileName = parts[3];
                        Logging.Log($"Adding {name} {version} from {url} to ClientList");
                        Globals.ClientList.Add(new Models.ClientListStruct(name, url, version, fileName));
                    }
                    Logging.Log("Finished ClientList");

                    if (Config.GetConfig().DownloadInParallel)
                    {
                        UpdateProgress("Downloading Client List", 0, "Downloading Clients");
                        List<Task> tasks = new List<Task>();
                        string logTaskCache = "";
                        Parallel.ForEach(Globals.ClientList, async (client) =>
                        {
                            logTaskCache += $"\n[{DateTime.Now}] Downloading {client.displayName} from {client.url} to {Globals.DataDir}\\{client.fileName}.dll";
                            await Network.DownloadFile(client.url, $"{Globals.DataDir}\\{client.fileName}.dll");
                        });
                        /*
                        foreach (var client in Globals.ClientList)
                        {
                            tasks.Add(Task.Run(async () =>
                            {
                                logTaskCache += $"\n[{DateTime.Now}] Downloading {client.displayName} from {client.url} to {Globals.DataDir}\\{client.fileName}.dll";
                                await Network.DownloadFile(client.url, $"{Globals.DataDir}\\{client.fileName}.dll");
                            }));
                        }
                        await Task.WhenAll(tasks);
                        */
                        Logging.Log(logTaskCache);
                    }
                    else
                    {
                        foreach (var client in Globals.ClientList)
                        {
                            UpdateProgress("Downloading Client List", 0, $"Downloading {client.displayName}");
                            Logging.Log($"Downloading {client.displayName} from {client.url} to {Globals.DataDir}\\{client.fileName}.dll");
                            await Network.DownloadFile(client.url, $"{Globals.DataDir}\\{client.fileName}.dll");
                        }
                    }
                    Logging.Log("Finished downloading DLLs");
                }
                catch (Exception ex)
                {
                    return $"Couldn't download client list:\n{ex.Message}";
                }
            }


            UpdateProgress("Downloading Spoof Pointers");
            if (!Config.GetConfig().GithubBlocked)
            {
                try
                {
                    string spoofListContent = await Network.GetString("https://raw.githubusercontent.com/Founderroni/Assets/main/Other/SpoofPtrs.txt");
                    string[] spoofListLines = spoofListContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in spoofListLines)
                    {
                        string[] parts = line.Split(':');
                        string version = parts[0];
                        string didPtr = parts[1];
                        string mcidPtr = parts[2];
                        UpdateProgress("Downloading Spoof Pointers", 0, $"Adding Pointer ({version}: {didPtr} - {mcidPtr})");
                        Logging.Log($"Adding pointers for {version} ({didPtr} - {mcidPtr})");
                        Globals.SpoofList.Add(new Models.SpoofPointersStruct(version, didPtr, mcidPtr));
                    }
                    Logging.Log("Finished SpoofList");
                }
                catch (Exception ex)
                {
                    return $"Couldn't download spoof pointers:\n{ex.Message}";
                }
            }


            UpdateProgress("Initializing Discord RPC");
            try
            {
                if (Config.GetConfig().RpcEnabled && !Handlers.Discord.IsRPCRunning)
                {
                    UpdateProgress("Initializing Discord RPC", 0, "Starting RPC");
                    Handlers.Discord.StartRpc(Config.GetConfig().RpcDetail, Config.GetConfig().RpcState);
                    Logging.Log("RPC Started");
                }
            }
            catch (Exception ex)
            {
                return $"Couldn't start Discord RPC:\n{ex.Message}";
            }


            UpdateProgress("Updating Launches");
            Globals.CachedConfig.Launches += 1;
            Logging.Log("+1 Launch");


            if (Config.GetConfig().UseAnimations)
            {
                await Task.Delay(FastLaunch ? 1 : 300).ContinueWith(t =>
                {
                    Handlers.Animator.Linear(GetLoader.StatusLabel, "Text", "", FastLaunch ? 125 : 300);
                    Handlers.Animator.Linear(GetLoader.StatusLabel, "Top", 334 - 10, FastLaunch ? 225 : 500);
                });
            }


            await Task.Delay(FastLaunch ? 235 : 550);
            return "Complete";
        }
    }
}
