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

namespace GTAVBETrainerDotNet.Weapon
{
    /// <summary>
    /// Weapon data
    /// </summary>
    public class WeaponData
    {
        private string _name = null;
        private string _internal = null;
        private WeaponAttachmentData[] _attachments = null;
        private bool _tint = false;

        /// <summary>
        /// Name of the weapon
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Internal value of the weapon
        /// </summary>
        public string InternalValue
        {
            get
            {
                return _internal;
            }
        }

        /// <summary>
        /// Gets whether this weapon has tint
        /// </summary>
        public bool HasTint
        {
            get
            {
                return _tint;
            }
        }

        /// <summary>
        /// Gets the count of available attachments
        /// </summary>
        public int AttachmentCount
        {
            get
            {
                if (_attachments == null) return 0;
                return _attachments.Length;
            }
        }

        /// <summary>
        /// Gets the specified attachment data of this weapon
        /// </summary>
        /// <param name="index">Index of attachment</param>
        /// <returns></returns>
        public WeaponAttachmentData GetAttachmentData(int index)
        {
            return _attachments[index];
        }

        /// <summary>
        /// Creates a weapon data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internalValue">Internal value</param>
        /// <param name="tint">Can has tint</param>
        /// <param name="attachments">Attachments</param>
        public WeaponData(string name, string internalValue, bool tint = true, params WeaponAttachmentData[] attachments)
        {
            _name = name;
            _internal = internalValue;
            _tint = tint;
            _attachments = attachments;
        }
    }
}
