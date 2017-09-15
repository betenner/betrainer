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

namespace GTAVBETrainerDotNet.Weather
{
    /// <summary>
    /// Weather data
    /// </summary>
    public class WeatherData
    {
        /// <summary>
        /// Name
        /// </summary>
        public MLString Name = null;

        /// <summary>
        /// Internal name
        /// </summary>
        public string InternalName = null;

        /// <summary>
        /// Creates a weather data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internalName">Internal name</param>
        public WeatherData(MLString name, string internalName)
        {
            Name = name;
            InternalName = internalName;
        }
    }
}
