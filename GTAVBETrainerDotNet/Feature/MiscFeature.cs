//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using GTAVBETrainerDotNet.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;

namespace GTAVBETrainerDotNet
{
    public static partial class Feature
    {
        /// <summary>
        /// Misc features
        /// </summary>
        public static class Misc
        {
            public static bool PortableRadio = false;
            public static bool HideHud = false;

            /// <summary>
            /// Initializes features
            /// </summary>
            public static void InitFeatures()
            {
                SetPortableRadio(MenuStorage.MenuItems.Misc.PortableRadio);
                SetHideHud(MenuStorage.MenuItems.Misc.HideHud);
            }

            /// <summary>
            /// Updates features
            /// </summary>
            public static void UpdateFeatures()
            {
                if (HideHud)
                {
                    Function.Call(Hash.HIDE_HUD_AND_RADAR_THIS_FRAME);
                }
            }

            /// <summary>
            /// Sets portable radio
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetPortableRadio(MenuItem sender)
            {
                PortableRadio = sender.On;
                Config.DoAutoSave();
                Function.Call(Hash.SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY, PortableRadio);
            }

            /// <summary>
            /// Sets hide HUD
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetHideHud(MenuItem sender)
            {
                HideHud = sender.On;
                Config.DoAutoSave();
            }

            /// <summary>
            /// Next radio track
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void NextRadioTrack(MenuItem sender)
            {
                Function.Call(Hash.SKIP_RADIO_FORWARD);
            }
        }
    }
}
