using KaffeeUtility.Models;
using KaffeeUtility.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KaffeeUtility.Handlers
{
    internal class Injection
    {
        //Credits Echo
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;

        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;

        public static void InjectClient(string client, int delay = 0)
        {
            try
            {
                Utils.Logging.Log($"Attempting to Inject {client}");
                Thread.Sleep(delay * 1000);
                foreach (ClientListStruct Instance in Globals.ClientList)
                {
                    if (client == Instance.displayName)
                    {
                        Utils.Logging.Log("Client name matches displayName from ClientList");
                        Memory.CheckInject();
                        if (Memory.GetVersion().StartsWith(Instance.versionSupported))
                        {
                            Utils.Logging.Log($@"Version matches ({Instance.versionSupported}). Attempting to find {Globals.DataDir}\{Instance.fileName}.dll");
                            if (File.Exists($@"{Globals.DataDir}\{Instance.fileName}.dll"))
                            {
                                Utils.Logging.Log($"{client} found at {Globals.DataDir}\\{Instance.fileName}.dll, injecting");
                                InjectDLL($@"{Globals.DataDir}\{Instance.fileName}.dll");
                            }
                        }
                        else
                        {
                            Logging.Log("Injection failed, client version does not match game version");
                            Utils.Misc.Notify("Client does not support the Minecraft version you are on");
                        }
                    }
                }
            } catch (Exception ex)
            {
                Utils.Misc.Notify("Inject Error:\n" + ex.Message);
            }
        }

        public static void InjectDLL(string path)
        {
            Process[] targetProcessIndex = Process.GetProcessesByName("Minecraft.Windows");
            if (targetProcessIndex.Length > 0)
            {
                if (Utils.Config.GetConfig().AutoOpenMc)
                    Process.Start("minecraft://");

                ApplyAccess(path);

                Process targetProcess = Process.GetProcessesByName("Minecraft.Windows")[0];
                IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

                UIntPtr bytesWritten;
                WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(path), (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);
                CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
                Utils.Logging.Log("Client Injected");
            }
            else
            {
                if (Utils.Config.GetConfig().AutoOpenMc)
                {
                    Process.Start("minecraft://");
                    Thread.Sleep(Utils.Config.GetConfig().LaunchDelay * 1000);
                    InjectDLL(path);
                }
                else
                {
                    Utils.Misc.Notify("Injection", "Minecraft is currently closed (or not detected)");
                    Utils.Logging.Log("Attempted to Inject but 'Auto Focus Minecraft' is Disabled");
                }
            }
        }

        private static void ApplyAccess(string path)
        {
            FileInfo InfoFile = new FileInfo(path);
            FileSecurity fSecurity = InfoFile.GetAccessControl();
            fSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            InfoFile.SetAccessControl(fSecurity);
        }
    }
}
