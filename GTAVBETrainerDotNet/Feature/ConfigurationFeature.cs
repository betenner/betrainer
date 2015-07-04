//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
using GTAVBETrainerDotNet.Menu;

namespace GTAVBETrainerDotNet
{
    public static partial class Feature
    {
        /// <summary>
        /// Configuration features
        /// </summary>
        public static class Config
        {
            public static bool AutoSave = false;

            /// <summary>
            /// Sets auto save
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetAutoSave(Menu.MenuItem sender)
            {
                AutoSave = sender.On;
            }

            /// <summary>
            /// Do auto save
            /// </summary>
            public static void DoAutoSave()
            {
                if (!AutoSave || Trainer.IsInitializing) return;
                Configuration.Save(false);
            }

            /// <summary>
            /// Save current configuration
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void Save(MenuItem sender)
            {
                Configuration.Save();
            }

            /// <summary>
            /// Load current configuration
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void Load(MenuItem sender)
            {
                Configuration.Load();
                MenuStorage.InitMenus();
                Feature.InitFeatures();
            }
        }
    }
}
