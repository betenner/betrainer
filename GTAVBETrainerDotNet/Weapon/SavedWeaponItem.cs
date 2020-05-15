//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015-2020
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVBETrainerDotNet.Weapon
{
    /// <summary>
    /// Saved weapon item
    /// </summary>
    public class SavedWeaponItem
    {
        public int Hash = 0;
        public int AmmoInWeapon = 0;
        public int AmmoInClip = 0;
        public int Tint = 0;
        public bool HasTint = false;
        public bool[] HasAttachment = null;
        public WeaponData Data = null;
    }
}
