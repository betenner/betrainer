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
    /// Data of weapon attachment
    /// </summary>
    public class WeaponAttachmentData
    {
        private string _name = null;
        private string _internal = null;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Internal value
        /// </summary>
        public string InternalValue
        {
            get
            {
                return _internal;
            }
        }

        /// <summary>
        /// Creates an instance of weapon attachment data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internalValue">Internal value</param>
        public WeaponAttachmentData(string name, string internalValue)
        {
            _name = name;
            _internal = internalValue;
        }
    }
}
