﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PistolWhipModSelector.GamePath;
using PistolWhipModSelector.Settings;

namespace PistolWhipModSelector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PistolWhipModSettings settings = new PistolWhipModSettings();
            FolderPath folderPath = new FolderPath(settings);

            if (folderPath.ForceExit == false)
            {
                GlobalVariables.GameFolderPath = settings.GetGameFolderPath();
                GlobalVariables.SongsFolderPath = settings.GetGameFolderPath() + @"\Pistol Whip_Data\StreamingAssets\Audio\GeneratedSoundBanks\Windows";

                ModsFolder modsFolder = new ModsFolder();

                Application.Run(new MainForm(modsFolder));
            }
        }
    }
}
