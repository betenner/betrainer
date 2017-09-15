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
    /// Weather storage
    /// </summary>
    public static class WeatherStorage
    {
        public static readonly WeatherData[] WEATHERS = 
        {
            new WeatherData(Utils.CTML("Extra Sunny", "大晴天"), "EXTRASUNNY"),
            new WeatherData(Utils.CTML("Clear", "晴天"), "CLEAR"),
		    new WeatherData(Utils.CTML("Cloudy", "多雲"), "CLOUDS"),
		    new WeatherData(Utils.CTML("Smog", "霾"), "SMOG"),
		    new WeatherData(Utils.CTML("Foggy", "霧"), "FOGGY"),
		    new WeatherData(Utils.CTML("Overcast", "陰天"), "OVERCAST"),
		    new WeatherData(Utils.CTML("Rain", "雨"), "RAIN"),
		    new WeatherData(Utils.CTML("Stormy", "暴雨"), "THUNDER"),
		    new WeatherData(Utils.CTML("Clearing", "雨後"), "CLEARING"),
		    new WeatherData(Utils.CTML("Neutral", "中立"), "NEUTRAL"),
		    new WeatherData(Utils.CTML("Snow", "雪"), "SNOW"),
		    new WeatherData(Utils.CTML("Blizzard", "暴風雪"), "BLIZZARD"),
		    new WeatherData(Utils.CTML("Light Snow", "小雪"), "SNOWLIGHT"),
		    new WeatherData(Utils.CTML("Christmas", "聖誕"), "XMAS"),
        };
    }
}
