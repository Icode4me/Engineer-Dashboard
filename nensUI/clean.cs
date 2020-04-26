using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fidling
{
    public static class SpywareRemoval
    {
        private static void RemoveSpywareFiles(string RootPath, string Path, bool Recursive)
        {
            string FullPath = RootPath + Path + "\\";
            if (Directory.Exists(FullPath))
            {
                DirectoryInfo DInfo = new DirectoryInfo(FullPath);
                FileAttributes Attr = DInfo.Attributes;
                DInfo.Attributes = FileAttributes.Normal;
                foreach (string FileName in Directory.GetFiles(FullPath))
                {
                    RemoveSpywareFile(FileName);
                }
                if (Recursive)
                {
                    foreach (string DirName in Directory.GetDirectories(FullPath))
                    {
                        RemoveSpywareFiles("", DirName, true);
                        try { Directory.Delete(DirName); } catch { }
                    }
                }
                DInfo.Attributes = Attr;
            }
        }

        private static void RemoveSpywareFile(string FileName)
        {
            if (File.Exists(FileName))
            {
                try { File.Delete(FileName); } catch { }//Locked by something and you can forget trying to delete index.dat files this way
            }
        }

        private static void DeleteFireFoxFiles(string FireFoxPath)
        {
            RemoveSpywareFile(FireFoxPath + "cookies.sqlite");
            RemoveSpywareFile(FireFoxPath + "content-prefs.sqlite");
            RemoveSpywareFile(FireFoxPath + "downloads.sqlite");
            RemoveSpywareFile(FireFoxPath + "formhistory.sqlite");
            RemoveSpywareFile(FireFoxPath + "search.sqlite");
            RemoveSpywareFile(FireFoxPath + "signons.sqlite");
            RemoveSpywareFile(FireFoxPath + "search.json");
            RemoveSpywareFile(FireFoxPath + "permissions.sqlite");
        }

        public static void RunCleanup()
        {
            try { KillProcess("iexplore"); }
            catch { }//Need to stop incase they have locked the files we want to delete
            try { KillProcess("FireFox"); }
            catch { }//Need to stop incase they have locked the files we want to delete
            string RootPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToLower().Replace("documents", "");
            RemoveSpywareFiles(RootPath, @"AppData\Roaming\Macromedia\Flash Player\#SharedObjects", false);
            RemoveSpywareFiles(RootPath, @"AppData\Roaming\Macromedia\Flash Player\macromedia.com\support\flashplayer\sys\#local", false);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Temporary Internet Files", false);//Not working
            RemoveSpywareFiles("", Environment.GetFolderPath(Environment.SpecialFolder.Cookies), true);
            RemoveSpywareFiles("", Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), true);
            RemoveSpywareFiles("", Environment.GetFolderPath(Environment.SpecialFolder.History), true);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Microsoft\Windows\Wer", true);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Microsoft\Windows\Caches", false);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Microsoft\WebsiteCache", false);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Temp", false);
            RemoveSpywareFiles(RootPath, @"AppData\LocalLow\Microsoft\CryptnetUrlCache", false);
            RemoveSpywareFiles(RootPath, @"AppData\LocalLow\Apple Computer\QuickTime\downloads", false);
            RemoveSpywareFiles(RootPath, @"AppData\Local\Mozilla\Firefox\Profiles", false);
            RemoveSpywareFiles(RootPath, @"AppData\Roaming\Microsoft\Office\Recent", false);
            RemoveSpywareFiles(RootPath, @"AppData\Roaming\Adobe\Flash Player\AssetCache", false);
            if (Directory.Exists(RootPath + @"\AppData\Roaming\Mozilla\Firefox\Profiles"))
            {
                string FireFoxPath = RootPath + @"AppData\Roaming\Mozilla\Firefox\Profiles\";
                DeleteFireFoxFiles(FireFoxPath);
                foreach (string SubPath in Directory.GetDirectories(FireFoxPath))
                {
                    DeleteFireFoxFiles(SubPath + "\\");
                }
            }
        }

        private static void KillProcess(string ProcessName)
        {//We ned to kill Internet explorer and Firefox to stop them locking files
            ProcessName = ProcessName.ToLower();
            foreach (Process P in Process.GetProcesses())
            {
                if (P.ProcessName.ToLower().StartsWith(ProcessName))
                    P.Kill();
            }
        }
    }
}