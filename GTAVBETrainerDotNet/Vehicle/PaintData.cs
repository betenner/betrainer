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

namespace GTAVBETrainerDotNet.Vehicle
{
    /// <summary>
    /// Paint data for vehicle
    /// </summary>
    public class PaintData
    {
        /// <summary>
        /// Name of the paint
        /// </summary>
        public string Name = null;

        /// <summary>
        /// Value of the paint
        /// </summary>
        public int InternalValue = 0;

        /// <summary>
        /// Creates a paint data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internalValue">Internal value</param>
        public PaintData(string name, int internalValue)
        {
            Name = name;
            InternalValue = internalValue;
        }
    }
}
