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

namespace GTAVBETrainerDotNet.Weather
{
	/// <summary>
	/// Weather storage
	/// </summary>
	public static class WeatherStorage
	{
		public static readonly WeatherData[] WEATHERS =
		{
			new WeatherData(Utils.CSML("Extra Sunny", "大晴天"), "EXTRASUNNY"),
			new WeatherData(Utils.CSML("Clear", "晴天"), "CLEAR"),
			new WeatherData(Utils.CSML("Cloudy", "多云"), "CLOUDS"),
			new WeatherData(Utils.CSML("Smog", "霾"), "SMOG"),
			new WeatherData(Utils.CSML("Foggy", "雾"), "FOGGY"),
			new WeatherData(Utils.CSML("Overcast", "阴天"), "OVERCAST"),
			new WeatherData(Utils.CSML("Rain", "雨"), "RAIN"),
			new WeatherData(Utils.CSML("Stormy", "暴雨"), "THUNDER"),
			new WeatherData(Utils.CSML("Clearing", "雨后"), "CLEARING"),
			new WeatherData(Utils.CSML("Neutral", "中立"), "NEUTRAL"),
			new WeatherData(Utils.CSML("Snow", "雪"), "SNOW"),
			new WeatherData(Utils.CSML("Blizzard", "暴风雪"), "BLIZZARD"),
			new WeatherData(Utils.CSML("Light Snow", "小雪"), "SNOWLIGHT"),
			new WeatherData(Utils.CSML("Christmas", "圣诞"), "XMAS"),
		};
	}
}

