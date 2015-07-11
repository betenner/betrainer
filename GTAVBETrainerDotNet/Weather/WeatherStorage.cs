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

namespace GTAVBETrainerDotNet.Weather
{
    /// <summary>
    /// Weather storage
    /// </summary>
    public static class WeatherStorage
    {
        public static readonly WeatherData[] WEATHERS = 
        {
            new WeatherData("Extra Sunny", "EXTRASUNNY"),
            new WeatherData("Clear", "CLEAR"),
		    new WeatherData("Cloudy", "CLOUDS"),
		    new WeatherData("Smog", "SMOG"),
		    new WeatherData("Foggy", "FOGGY"),
		    new WeatherData("Overcast", "OVERCAST"),
		    new WeatherData("Rain", "RAIN"),
		    new WeatherData("Stormy", "THUNDER"),
		    new WeatherData("Clearing", "CLEARING"),
		    new WeatherData("Neutral", "NEUTRAL"),
		    new WeatherData("Snow", "SNOW"),
		    new WeatherData("Blizzard", "BLIZZARD"),
		    new WeatherData("Light Snow", "SNOWLIGHT"),
		    new WeatherData("Christmas", "XMAS"),
        };
    }
}
