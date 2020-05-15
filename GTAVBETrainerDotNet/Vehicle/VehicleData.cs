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
    /// Vehicle data
    /// </summary>
    public class VehicleData
    {
        /// <summary>
        /// Name of the vehicle
        /// </summary>
        public string Name = null;

        /// <summary>
        /// Internal value of the vehicle
        /// </summary>
        public string InternalValue = null;

        /// <summary>
        /// Creates a vehicle data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internalValue">Internal value</param>
        public VehicleData(string name, string internalValue)
        {
            Name = name;
            InternalValue = internalValue;
        }
    }
}
