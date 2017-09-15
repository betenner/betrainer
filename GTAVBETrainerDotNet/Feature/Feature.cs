//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015-2017
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GTA;
using GTA.Native;
using GTAVBETrainerDotNet.Menu;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Trainer features
    /// </summary>
    public static partial class Feature
    {
        /// <summary>
        /// Updates all features
        /// </summary>
        public static void UpdateFeatures()
        {
            Player.UpdateFeatures();
            Vehicle.UpdateFeatures();
            Weapon.UpdateFeatures();
            DateTimeSpeed.UpdateFeatures();
            World.UpdateFeatures();
            Weather.UpdateFeatures();
            Misc.UpdateFeatures();
        }

        /// <summary>
        /// Initialize features
        /// </summary>
        public static void InitFeatures()
        {
            Player.InitFeatures();
            Location.InitFeatures();
            Vehicle.InitFeatures();
            Weapon.InitFeatures();
            DateTimeSpeed.InitFeatures();
            World.InitFeatures();
            Weather.InitFeatures();
            Misc.InitFeatures();
        }
    }
}
