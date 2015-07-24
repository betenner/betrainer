//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using GTAVBETrainerDotNet.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
using GTAVBETrainerDotNet.Weather;

namespace GTAVBETrainerDotNet
{
    public static partial class Feature
    {
        /// <summary>
        /// Weather features
        /// </summary>
        public static class Weather
        {
            private const float WIND_SPEED = 11.99f;

            public static bool Wind = false;
            public static bool Freeze = false;

            private static string _weather = WeatherStorage.WEATHERS[0].InternalName;

            /// <summary>
            /// Initializes features
            /// </summary>
            public static void InitFeatures()
            {
                SetWind(MenuStorage.MenuItems.Weather.Wind);
                SetFreeze(MenuStorage.MenuItems.Weather.Freeze);
            }

            /// <summary>
            /// Updates features
            /// </summary>
            public static void UpdateFeatures()
            {
                if (Freeze)
                {
                    Function.Call(Hash.SET_WEATHER_TYPE_NOW, _weather);
                }
            }

            /// <summary>
            /// Sets wind
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetWind(MenuItem sender)
            {
                Wind = sender.On;
                Config.DoAutoSave();
                if (Wind)
                {
                    Function.Call(Hash.SET_WIND, 1f);
                    Function.Call(Hash.SET_WIND_SPEED, WIND_SPEED);
                    Function.Call(Hash.SET_WIND_DIRECTION, Game.Player.Character.Heading);
                }
                else
                {
                    Function.Call(Hash.SET_WIND, 0f);
                    Function.Call(Hash.SET_WIND_SPEED, 0f);
                }
            }

            /// <summary>
            /// Sets freeze
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetFreeze(MenuItem sender)
            {
                Freeze = sender.On;
                Config.DoAutoSave();
                Function.Call(Hash.CLEAR_OVERRIDE_WEATHER);
                Function.Call(Hash.CLEAR_WEATHER_TYPE_PERSIST);
                Function.Call(Hash.CLEAR_TIMECYCLE_MODIFIER);
            }

            /// <summary>
            /// Sets weather
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetWeather(MenuItem sender)
            {
                WeatherData wd = (sender.Data as WeatherData);
                Function.Call(Hash.CLEAR_OVERRIDE_WEATHER);
                Function.Call(Hash.CLEAR_WEATHER_TYPE_PERSIST);
                Function.Call(Hash.CLEAR_TIMECYCLE_MODIFIER);
                Function.Call(Hash.SET_WEATHER_TYPE_NOW, wd.InternalName);
                Function.Call(Hash.CLEAR_TIMECYCLE_MODIFIER);
                _weather = wd.InternalName;
                Utils.ShowNotificationAboveMap(Utils.FormatML(GlobalConst.Message.WEATHER_SET, wd.Name));
            }
        }
    }
}
