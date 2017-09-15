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
using GTAVBETrainerDotNet.Model;
using GTAVBETrainerDotNet.Teleport;
using GTAVBETrainerDotNet.Vehicle;
using GTAVBETrainerDotNet.Weapon;
using GTAVBETrainerDotNet.Weather;

namespace GTAVBETrainerDotNet.Menu
{
    /// <summary>
    /// Storage for menus
    /// </summary>
    public static class MenuStorage
    {
        // Menu stack
        private static Stack<Menu> _menuStack = null;

        /// <summary>
        /// All menus
        /// </summary>
        public static class Menus
        {
            /// <summary>
            /// Main menu
            /// </summary>
            public static Menu Main = null;

            /// <summary>
            /// Player menu
            /// </summary>
            public static Menu Player = null;

            /// <summary>
            /// Player sub menus
            /// </summary>
            public static class Players
            {
                /// <summary>
                /// Player cash menu
                /// </summary>
                public static Menu Cash = null;

                /// <summary>
                /// Player wanted menu
                /// </summary>
                public static Menu Wanted = null;

                /// <summary>
                /// Player Model &amp; Skin &amp; Props menu
                /// </summary>
                public static Menu MSP = null;

                /// <summary>
                /// Model &amp; Skin &amp; Props sub menus
                /// </summary>
                public static class MSPs
                {
                    /// <summary>
                    /// Player Model selector menu
                    /// </summary>
                    public static Menu Model = null;

                    /// <summary>
                    /// Model selecter submenus
                    /// </summary>
                    public static class Models
                    {
                        /// <summary>
                        /// Player Model selector animal menu
                        /// </summary>
                        public static Menu Animals = null;

                        /// <summary>
                        /// Player Model selector character menu
                        /// </summary>
                        public static Menu NPCs = null;
                    }

                    /// <summary>
                    /// Player skin categories menu
                    /// </summary>
                    public static Menu Skin = null;

                    // Skin sub menus
                    public static class Skins
                    {
                        /// <summary>
                        /// Player skin drawable selector menu
                        /// </summary>
                        public static Menu Drawable = null;

                        /// <summary>
                        /// Player skin texture selector menu
                        /// </summary>
                        public static Menu Texture = null;

                    }

                    /// <summary>
                    /// Player Prop categories menu
                    /// </summary>
                    public static Menu Prop = null;

                    /// <summary>
                    /// Props sub menus
                    /// </summary>
                    public static class Props
                    {
                        /// <summary>
                        /// Player Prop selector menu
                        /// </summary>
                        public static Menu Drawable = null;

                        /// <summary>
                        /// Player Prop texture selector menu
                        /// </summary>
                        public static Menu Texture = null;

                    }

                    /// <summary>
                    /// Player model &amp; skin &amp; props custom sets menu
                    /// </summary>
                    public static Menu CustomSet = null;

                    /// <summary>
                    /// Custom sets sub menus
                    /// </summary>
                    public static class CustomSets
                    {
                        /// <summary>
                        /// Player model &amp; skin &amp; props custom set item menu
                        /// </summary>
                        public static Menu Item = null;
                    }
                }
            }

            /// <summary>
            /// Location menu
            /// </summary>
            public static Menu Location = null;

            /// <summary>
            /// Location sub menus
            /// </summary>
            public static class Locations
            {
                /// <summary>
                /// Location Teleporter menu
                /// </summary>
                public static Menu LTeleporter = null;

                /// <summary>
                /// Custom location teleporter menu
                /// </summary>
                public static Menu CLTeleporter = null;

                /// <summary>
                /// Custom location teleporter sub menus
                /// </summary>
                public static class CLTeleporters
                {
                    /// <summary>
                    /// Custom location teleporter item menu
                    /// </summary>
                    public static Menu Item = null;
                }

                /// <summary>
                /// XYZ teleporter menu
                /// </summary>
                public static Menu XyzTeleporter = null;

                /// <summary>
                /// XYZ teleporter sub menus
                /// </summary>
                public static class XyzTeleporters
                {
                    /// <summary>
                    /// XYZ teleporter - teleport by offset menu
                    /// </summary>
                    public static Menu Offset = null;

                    /// <summary>
                    /// XYZ teleporter - teleport to coordinates menu
                    /// </summary>
                    public static Menu Coordinates = null;
                }
            }

            /// <summary>
            /// Vehicle menu
            /// </summary>
            public static Menu Vehicle = null;

            /// <summary>
            /// Vehicle sub menus
            /// </summary>
            public static class Vehicles
            {
                /// <summary>
                /// Spawn vehicle menu
                /// </summary>
                public static Menu SpawnVehicle = null;

                /// <summary>
                /// Custom vehicles menu
                /// </summary>
                public static Menu CustomVehicle = null;

                /// <summary>
                /// Custom vehicle sub menus
                /// </summary>
                public static class CustomVehicles
                {
                    public static Menu Item = null;
                }

                /// <summary>
                /// Vehicle paint menu
                /// </summary>
                public static Menu Paint = null;

                /// <summary>
                /// Paint sub menus
                /// </summary>
                public static class Paints
                {
                    /// <summary>
                    /// Primary color menu
                    /// </summary>
                    public static Menu PrimaryColor = null;

                    /// <summary>
                    /// Secondary color menu
                    /// </summary>
                    public static Menu SecondaryColor = null;

                    /// <summary>
                    /// Pearl topcoat menu
                    /// </summary>
                    public static Menu PearlTopcoat = null;

                    /// <summary>
                    /// Wheels menu
                    /// </summary>
                    public static Menu Wheels = null;

                    /// <summary>
                    /// Vehicle paint livery menu
                    /// </summary>
                    public static Menu Livery = null;
                }

                /// <summary>
                /// Vehicle modifications menu
                /// </summary>
                public static Menu Mod = null;

                /// <summary>
                /// Mods menu
                /// </summary>
                public static class Mods
                {
                    /// <summary>
                    /// Mod item menu item
                    /// </summary>
                    public static Menu ModItem = null;
                }

                /// <summary>
                /// Vehicle doors menu
                /// </summary>
                public static Menu Doors = null;

                /// <summary>
                /// Vehicle speed meter menu
                /// </summary>
                public static Menu SpeedMeter = null;
            }

            /// <summary>
            /// Weapon menu
            /// </summary>
            public static Menu Weapon = null;

            /// <summary>
            /// Weapon sub menus
            /// </summary>
            public static class Weapons
            {
                /// <summary>
                /// Get specific weapon menu
                /// </summary>
                public static Menu GetSpecificWeapon = null;
            }

            /// <summary>
            /// Date time speed menu
            /// </summary>
            public static Menu DateTimeSpeed = null;

            /// <summary>
            /// Date time speed sub menus
            /// </summary>
            public static class DateTimeSpeeds
            {
                public static Menu SetDateTime = null;
                public static Menu SetGameSpeed = null;
                public static Menu SetAimingSpeed = null;
            }

            /// <summary>
            /// World menu
            /// </summary>
            public static Menu World = null;

            /// <summary>
            /// Weather menu
            /// </summary>
            public static Menu Weather = null;

            /// <summary>
            /// Misc menu
            /// </summary>
            public static Menu Misc = null;

            /// <summary>
            /// Configuration menu
            /// </summary>
            public static Menu Configuration = null;

            /// <summary>
            /// Lanugage menu
            /// </summary>
            public static Menu Language = null;
        }

        /// <summary>
        /// Menu items
        /// </summary>
        public static class MenuItems
        {
            /// <summary>
            /// Player menu items
            /// </summary>
            public static class Player
            {
                public static MenuItem Invincible = null;
                public static MenuItem InfiniteAbility = null;
                public static MenuItem FastRun = null;
                public static MenuItem FastSwim = null;
                public static MenuItem SuperJump = null;
                public static MenuItem Noiseless = null;

                /// <summary>
                /// Wanted menu items
                /// </summary>
                public static class Wanted
                {
                    public static MenuItem NeverWanted = null;
                    public static MenuItem PoliceIgnored = null;
                    public static MenuItem EveryoneIgnored = null;
                }

                /// <summary>
                /// Model & Skin & Props custom set menu items
                /// </summary>
                public static class MSPCustomSet
                {
                    public static MenuItem Create = null;

                    /// <summary>
                    /// Item
                    /// </summary>
                    public static class Item
                    {
                        public static MenuItem Apply = null;
                        public static MenuItem Rename = null;
                        public static MenuItem Overwrite = null;
                        public static MenuItem Delete = null;
                    }
                }
            }

            /// <summary>
            /// Location menu items
            /// </summary>
            public static class Location
            {
                public static MenuItem ShowCoordinate = null;

                /// <summary> 
                /// Custom locatoin teleporter menu items
                /// </summary>
                public static class CustomLocationTeleporter
                {
                    public static MenuItem SaveCurrentLocation = null;

                    /// <summary>
                    /// Custom location teleporter item menu items
                    /// </summary>
                    public static class Item
                    {
                        public static MenuItem Teleport = null;
                        public static MenuItem Rename = null;
                        public static MenuItem Overwrite = null;
                        public static MenuItem Delete = null;
                    }
                }

                /// <summary>
                /// XYZ teleporter menu items
                /// </summary>
                public static class XyzTeleporter
                {
                    /// <summary>
                    /// Teleport by offsets menu items
                    /// </summary>
                    public static class Offset
                    {
                        public static MenuItem X = null;
                        public static MenuItem Y = null;
                        public static MenuItem Z = null;
                    }

                    /// <summary>
                    /// Teleport by coordinates menu items
                    /// </summary>
                    public static class Coordinates
                    {
                        public static MenuItem X = null;
                        public static MenuItem Y = null;
                        public static MenuItem Z = null;
                    }
                }
            }
        
            /// <summary>
            /// Vehicle menu items
            /// </summary>
            public static class Vehicle
            {
                public static MenuItem Invincible = null;
                public static MenuItem SeatBelt = null;
                public static MenuItem SpawnIntoVehicle = null;
                public static MenuItem Boost = null;

                /// <summary>
                /// Custom vehicle menu items
                /// </summary>
                public static class CustomVehicle
                {
                    public static MenuItem SaveCurrent = null;
                    
                    /// <summary>
                    /// Custom vehicle item menu items
                    /// </summary>
                    public static class Item
                    {
                        public static MenuItem Spawn = null;
                        public static MenuItem Rename = null;
                        public static MenuItem Overwrite = null;
                        public static MenuItem Delete = null;
                    }
                }

                /// <summary>
                /// Paint menu items
                /// </summary>
                public static class Paint
                {
                    public static MenuItem PrimaryColor = null;
                    public static MenuItem SecondaryColor = null;
                    public static MenuItem PearlTopcoat = null;
                    public static MenuItem Wheels = null;
                    public static MenuItem Livery = null;
                }

                /// <summary>
                /// Mod menu items
                /// </summary>
                public static class Mod
                {
                    public static MenuItem AllPerformance = null;
                    public static MenuItem AllArmor = null;
                    public static MenuItem RemoveAll = null;
                }

                /// <summary>
                /// Speed meter menu items
                /// </summary>
                public static class SpeedMeter
                {
                    public static MenuItem Show = null;
                    public static MenuItem ShowInMetric = null;
                    public static MenuItem ShowWithoutVehicle = null;
                }
            }
        
            /// <summary>
            /// Weapon menu items
            /// </summary>
            public static class Weapon
            {
                public static MenuItem GetAllWeapons = null;
                public static MenuItem GetSpecificWeapon = null;
                public static MenuItem InfiniteAmmo = null;
                public static MenuItem PermanentParachute = null;
                public static MenuItem NoReload = null;
                public static MenuItem FireAmmo = null;
                public static MenuItem ExplosiveAmmo = null;
                public static MenuItem ExplosiveMelee = null;
                public static MenuItem VehicleRockets = null;
            }

            /// <summary>
            /// Date time speed menu items
            /// </summary>
            public static class DateTimeSpeed
            {
                public static MenuItem SetDateTime = null;
                public static MenuItem SetGameSpeed = null;
                public static MenuItem SetAimingSpeed = null;
                public static MenuItem HourForward = null;
                public static MenuItem HourBackward = null;
                public static MenuItem DayForward = null;
                public static MenuItem DayBackward = null;
                public static MenuItem ShowTime = null;
                public static MenuItem Paused = null;
                public static MenuItem SyncWithSystem = null;

                /// <summary>
                /// Set date time menu items
                /// </summary>
                public static class SetDateTimeMenu
                {
                    public static MenuItem Year = null;
                    public static MenuItem Month = null;
                    public static MenuItem Day = null;
                    public static MenuItem Hour = null;
                    public static MenuItem Minute = null;
                    public static MenuItem Second = null;
                    public static MenuItem SetToCurrent = null;
                    public static MenuItem SetToSystem = null;
                }

                /// <summary>
                /// Set game speed menu items
                /// </summary>
                public static class SetGameSpeedMenu
                {
                    public static MenuItem Speed = null;
                    public static MenuItem SetTo100 = null;
                    public static MenuItem SetTo075 = null;
                    public static MenuItem SetTo050 = null;
                    public static MenuItem SetTo025 = null;
                    public static MenuItem SetTo010 = null;
                    public static MenuItem SetTo000 = null;
                }

                /// <summary>
                /// Set aiming speed menu items
                /// </summary>
                public static class SetAimingSpeedMenu
                {
                    public static MenuItem Speed = null;
                    public static MenuItem SetTo100 = null;
                    public static MenuItem SetTo075 = null;
                    public static MenuItem SetTo050 = null;
                    public static MenuItem SetTo025 = null;
                    public static MenuItem SetTo010 = null;
                    public static MenuItem SetTo000 = null;
                }
            }

            /// <summary>
            /// World menu items
            /// </summary>
            public static class World
            {
                public static MenuItem MoonGravity = null;
                public static MenuItem RandomCops = null;
                public static MenuItem RandomTrains = null;
                public static MenuItem RandomBoats = null;
                public static MenuItem GarbageTrucks = null;
                public static MenuItem RestrictedZones = null;
            }

            /// <summary>
            /// Weather menu items
            /// </summary>
            public static class Weather
            {
                public static MenuItem Wind = null;
                public static MenuItem Freeze = null;
            }

            /// <summary>
            /// Misc menu items
            /// </summary>
            public static class Misc
            {
                public static MenuItem PortableRadio = null;
                public static MenuItem HideHud = null;
                public static MenuItem NextRadioTrack = null;
            }

            /// <summary>
            /// Configuration menu items
            /// </summary>
            public static class Configuration
            {
                public static MenuItem AutoSave = null;
            }

            /// <summary>
            /// Language menu items
            /// </summary>
            public static class Language
            {
                public static MenuItem English = null;
                public static MenuItem ChineseTraditional = null;
            }
        }

        /// <summary>
        /// Plays menu beep
        /// </summary>
        public static void PlayMenuBeep()
        {
            Utils.PlaySound("NAV_UP_DOWN", "HUD_FRONTEND_DEFAULT_SOUNDSET");
        }

        /// <summary>
        /// Gets whether the specified menu is in the menu stack
        /// </summary>
        /// <param name="menu">Menu object</param>
        /// <returns>true if in the menu stack; otherwise false</returns>
        public static bool IsMenuInStack(Menu menu)
        {
            return _menuStack.Contains(menu);
        }

        /// <summary>
        /// Gets the current menu
        /// </summary>
        /// <returns></returns>
        public static Menu GetCurrentMenu()
        {
            if (_menuStack.Count > 0) return _menuStack.Peek();
            else return null;
        }

        /// <summary>
        /// Returns to the specified menu in certain depth
        /// </summary>
        /// <param name="depth">Depth of the menu</param>
        public static void ReturnToMenuByDepth(int depth)
        {
            if (depth <= 0 && Trainer.ShowingTrainerMenu)
            {
                PlayMenuBeep();
                Trainer.ShowingTrainerMenu = false;
            }
            if (_menuStack.Count > depth)
            {
                for (int i = 0; i < _menuStack.Count - depth; i++)
                {
                    _menuStack.Pop();
                }
                PlayMenuBeep();
            }
        }

        /// <summary>
        /// Returns to the previous menu.
        /// If there's no previous menu then nothing will happen.
        /// </summary>
        public static void ReturnToPrevMenu()
        {
            if (_menuStack.Count > 1)
            {
                _menuStack.Pop();
                PlayMenuBeep();
            }
            else if (_menuStack.Count == 1 && Trainer.ShowingTrainerMenu)
            {
                PlayMenuBeep();
                Trainer.ShowingTrainerMenu = false;
            }
        }

        /// <summary>
        /// Enters a new menu
        /// </summary>
        /// <param name="menu">Sub menu</param>
        public static void EnterMenu(Menu menu)
        {
            _menuStack.Push(menu);
            if (menu != null && menu.SelectedItem != null)
            {
                menu.SelectedItem.OnHighlighted();
            }
        }

        /// <summary>
        /// Initialize all menus
        /// </summary>
        public static void InitMenus()
        {
            _menuStack = new Stack<Menu>();
            InitPlayerMenu();
            InitLocationMenu();
            InitVehicleMenu();
            InitWeaponMenu();
            InitDateTimeSpeedMenu();
            InitWorldMenu();
            InitWeatherMenu();
            InitMiscMenu();
            InitConfigurationMenu();
            InitLanguageMenu();
            InitMainMenu();
        }

        /// <summary>
        /// Initializes misc menu
        /// </summary>
        private static void InitMiscMenu()
        {
            Menus.Misc = new Menu(MenuText.Misc.I00_TITLE);
            MenuItems.Misc.PortableRadio = AddMenuItem(Menus.Misc, MenuText.Misc.I01_PORTABLE_RADIO, true, Feature.Misc.PortableRadio, null, Feature.Misc.SetPortableRadio);
            MenuItems.Misc.HideHud = AddMenuItem(Menus.Misc, MenuText.Misc.I02_HIDE_HUD, true, Feature.Misc.HideHud, null, Feature.Misc.SetHideHud);
            MenuItems.Misc.NextRadioTrack = AddMenuItem(Menus.Misc, MenuText.Misc.I03_NEXT_RADIO_TRACK, false, false, null, Feature.Misc.NextRadioTrack);
        }

        /// <summary>
        /// Initializes weather menu
        /// </summary>
        private static void InitWeatherMenu()
        {
            Menus.Weather = new Menu(MenuText.Weather.I00_TITLE);
            MenuItems.Weather.Wind = AddMenuItem(Menus.Weather, MenuText.Weather.I01_WIND, true, Feature.Weather.Wind, null, Feature.Weather.SetWind);
            MenuItems.Weather.Freeze = AddMenuItem(Menus.Weather, MenuText.Weather.I02_FREEZE_WEATHER, true, Feature.Weather.Freeze, null, Feature.Weather.SetFreeze);
            for (int i = 0; i < WeatherStorage.WEATHERS.Length; i++)
            {
                AddMenuItem(Menus.Weather, WeatherStorage.WEATHERS[i].Name, false, false, null, Feature.Weather.SetWeather, null, null, WeatherStorage.WEATHERS[i]);
            }
        }

        
        /// <summary>
        /// Initializes world menu
        /// </summary>
        private static void InitWorldMenu()
        {
            Menus.World = new Menu(MenuText.World.I00_TITLE);
            MenuItems.World.MoonGravity = AddMenuItem(Menus.World, MenuText.World.I01_MOON_GRAVITY, true, Feature.World.MoonGravity, null, Feature.World.SetMoonGravity);
            MenuItems.World.RandomCops = AddMenuItem(Menus.World, MenuText.World.I02_RANDOM_COPS, true, Feature.World.RandomCops, null, Feature.World.SetRandomCops);
            MenuItems.World.RandomTrains = AddMenuItem(Menus.World, MenuText.World.I03_RANDOM_TRAINS, true, Feature.World.RandomTrains, null, Feature.World.SetRandomTrains);
            MenuItems.World.RandomBoats = AddMenuItem(Menus.World, MenuText.World.I04_RANDOM_BOATS, true, Feature.World.RandomBoats, null, Feature.World.SetRandomBoats);
            MenuItems.World.GarbageTrucks = AddMenuItem(Menus.World, MenuText.World.I05_GARBAGE_TRUCKS, true, Feature.World.GarbageTrucks, null, Feature.World.SetGarbageTrucks);
            MenuItems.World.RestrictedZones = AddMenuItem(Menus.World, MenuText.World.I06_RESTRICTED_ZONES, true, Feature.World.RestrictedZones, null, Feature.World.SetRestrictedZones);
        }

        /// <summary>
        /// Initializes date time speed menu
        /// </summary>
        private static void InitDateTimeSpeedMenu()
        {
            Menus.DateTimeSpeed = new Menu(MenuText.DateTimeSpeed.I00_TITLE);
            InitSetDateTimeMenu();
            MenuItems.DateTimeSpeed.SetDateTime = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I01_SET_DATETIME, false, false, Menus.DateTimeSpeeds.SetDateTime, null, Feature.DateTimeSpeed.PreEnterSetDateTime);
            InitSetGameSpeedMenu();
            MenuItems.DateTimeSpeed.SetGameSpeed = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I02_SET_GAME_SPEED, false, false, Menus.DateTimeSpeeds.SetGameSpeed);
            InitSetAimingSpeedMenu();
            MenuItems.DateTimeSpeed.SetAimingSpeed = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I03_SET_AIMING_SPEED, false, false, Menus.DateTimeSpeeds.SetAimingSpeed);
            MenuItems.DateTimeSpeed.HourForward = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I04_HOUR_FORWARD, false, false, null, Feature.DateTimeSpeed.HourForward);
            MenuItems.DateTimeSpeed.HourBackward = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I05_HOUR_BACKWARD, false, false, null, Feature.DateTimeSpeed.HourBackward);
            MenuItems.DateTimeSpeed.DayForward = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I06_DAY_FORWARD, false, false, null, Feature.DateTimeSpeed.DayForward);
            MenuItems.DateTimeSpeed.DayBackward = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I07_DAY_BACKWARD, false, false, null, Feature.DateTimeSpeed.DayBackward);
            MenuItems.DateTimeSpeed.ShowTime = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I08_SHOW_TIME, true, Feature.DateTimeSpeed.ShowTime, null, Feature.DateTimeSpeed.SetShowTime);
            MenuItems.DateTimeSpeed.Paused = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I09_TIME_PAUSED, true, Feature.DateTimeSpeed.Paused, null, Feature.DateTimeSpeed.SetPaused);
            MenuItems.DateTimeSpeed.SyncWithSystem = AddMenuItem(Menus.DateTimeSpeed, MenuText.DateTimeSpeed.I10_SYNC_WITH_SYSTEM, true, Feature.DateTimeSpeed.SyncWithSystem, null, Feature.DateTimeSpeed.SetSyncWithSystem);
        }

        /// <summary>
        /// Initializes set aiming speed menu
        /// </summary>
        private static void InitSetAimingSpeedMenu()
        {
            Menus.DateTimeSpeeds.SetAimingSpeed = new Menu(MenuText.DateTimeSpeed.I03_SET_AIMING_SPEED);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.Speed = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, null);
            Feature.DateTimeSpeed.UpdateAimingSpeed();
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.Speed.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.Speed.LeftPressed += Feature.DateTimeSpeed.DecAimingSpeed;
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.Speed.RightPressed += Feature.DateTimeSpeed.IncAimingSpeed;
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo100 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I02_SET_TO_100, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo100);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo075 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I03_SET_TO_75, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo075);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo025 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I04_SET_TO_50, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo050);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo050 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I05_SET_TO_25, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo025);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo010 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I06_SET_TO_10, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo010);
            MenuItems.DateTimeSpeed.SetAimingSpeedMenu.SetTo000 = AddMenuItem(Menus.DateTimeSpeeds.SetAimingSpeed, MenuText.DateTimeSpeed.SetAimingSpeed.I07_SET_TO_0, false, false, null, Feature.DateTimeSpeed.SetAimingSpeedTo000);
        }

        /// <summary>
        /// Initializes set game speed menu
        /// </summary>
        private static void InitSetGameSpeedMenu()
        {
            Menus.DateTimeSpeeds.SetGameSpeed = new Menu(MenuText.DateTimeSpeed.I02_SET_GAME_SPEED);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.Speed = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, null);
            Feature.DateTimeSpeed.UpdateGameSpeed();
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.Speed.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.Speed.LeftPressed += Feature.DateTimeSpeed.DecGameSpeed;
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.Speed.RightPressed += Feature.DateTimeSpeed.IncGameSpeed;
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo100 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I02_SET_TO_100, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo100);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo075 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I03_SET_TO_75, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo075);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo025 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I04_SET_TO_50, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo050);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo050 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I05_SET_TO_25, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo025);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo010 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I06_SET_TO_10, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo010);
            MenuItems.DateTimeSpeed.SetGameSpeedMenu.SetTo000 = AddMenuItem(Menus.DateTimeSpeeds.SetGameSpeed, MenuText.DateTimeSpeed.SetGameSpeed.I07_SET_TO_0, false, false, null, Feature.DateTimeSpeed.SetGameSpeedTo000);
        }

        /// <summary>
        /// Initializes set date time menu
        /// </summary>
        private static void InitSetDateTimeMenu()
        {
            Menus.DateTimeSpeeds.SetDateTime = new Menu(MenuText.DateTimeSpeed.SetDateTime.I00_TITLE);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Year = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Year.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Year.LeftPressed += Feature.DateTimeSpeed.DecYear;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Year.RightPressed += Feature.DateTimeSpeed.IncYear;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Month = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Month.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Month.LeftPressed += Feature.DateTimeSpeed.DecMonth;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Month.RightPressed += Feature.DateTimeSpeed.IncMonth;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Day = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Day.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Day.LeftPressed += Feature.DateTimeSpeed.DecDay;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Day.RightPressed += Feature.DateTimeSpeed.IncDay;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Hour = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Hour.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Hour.LeftPressed += Feature.DateTimeSpeed.DecHour;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Hour.RightPressed += Feature.DateTimeSpeed.IncHour;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Minute = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Minute.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Minute.LeftPressed += Feature.DateTimeSpeed.DecMinute;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Minute.RightPressed += Feature.DateTimeSpeed.IncMinute;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Second = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, null, false, false, null, Feature.DateTimeSpeed.Set);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Second.ShowLeftRightAdjustableSign = true;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Second.LeftPressed += Feature.DateTimeSpeed.DecSecond;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.Second.RightPressed += Feature.DateTimeSpeed.IncSecond;
            MenuItems.DateTimeSpeed.SetDateTimeMenu.SetToCurrent = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, MenuText.DateTimeSpeed.SetDateTime.I07_SET_TO_CURRENT, false, false, null, Feature.DateTimeSpeed.SetToCurrent);
            MenuItems.DateTimeSpeed.SetDateTimeMenu.SetToSystem = AddMenuItem(Menus.DateTimeSpeeds.SetDateTime, MenuText.DateTimeSpeed.SetDateTime.I08_SET_TO_SYSTEM, false, false, null, Feature.DateTimeSpeed.SetToSystem);
        }

        /// <summary>
        /// Initializes weapon menu
        /// </summary>
        private static void InitWeaponMenu()
        {
            Menus.Weapon = new Menu(MenuText.Weapon.I00_TITLE);
            MenuItems.Weapon.GetAllWeapons = AddMenuItem(Menus.Weapon, MenuText.Weapon.I01_GET_ALL_WEAPONS, false, false, null, Feature.Weapon.GetAllWeapons);
            InitSpecificWeaponMenu();
            MenuItems.Weapon.GetSpecificWeapon = AddMenuItem(Menus.Weapon, MenuText.Weapon.I02_GET_SPECIFIC_WEAPON, false, false, Menus.Weapons.GetSpecificWeapon);
            MenuItems.Weapon.InfiniteAmmo = AddMenuItem(Menus.Weapon, MenuText.Weapon.I03_INFINITE_AMMO, true, Feature.Weapon.InfiniteAmmo, null, Feature.Weapon.SetInfiniteAmmo);
            MenuItems.Weapon.PermanentParachute = AddMenuItem(Menus.Weapon, MenuText.Weapon.I04_PERMANENT_PARACHUTE, true, Feature.Weapon.PermanentParachute, null, Feature.Weapon.SetPermanentParachute);
            MenuItems.Weapon.NoReload = AddMenuItem(Menus.Weapon, MenuText.Weapon.I05_NO_RELOAD, true, Feature.Weapon.NoReload, null, Feature.Weapon.SetNoReload);
            MenuItems.Weapon.FireAmmo = AddMenuItem(Menus.Weapon, MenuText.Weapon.I06_FIRE_AMMO, true, Feature.Weapon.FireAmmo, null, Feature.Weapon.SetFireAmmo);
            MenuItems.Weapon.ExplosiveAmmo = AddMenuItem(Menus.Weapon, MenuText.Weapon.I07_EXPLOSIVE_AMMO, true, Feature.Weapon.FireAmmo, null, Feature.Weapon.SetFireAmmo);
            MenuItems.Weapon.ExplosiveMelee = AddMenuItem(Menus.Weapon, MenuText.Weapon.I08_EXPLOSIVE_MELEE, true, Feature.Weapon.ExplosiveMelee, null, Feature.Weapon.SetExplosiveMelee);
            MenuItems.Weapon.VehicleRockets = AddMenuItem(Menus.Weapon, MenuText.Weapon.I09_VEHICLE_ROCKETS, true, Feature.Weapon.VehicleRocket, null, Feature.Weapon.SetVehicleRocket);
        }

        /// <summary>
        /// Initializes get specific weapon menu
        /// </summary>
        private static void InitSpecificWeaponMenu()
        {
            Menus.Weapons.GetSpecificWeapon = new Menu(MenuText.Weapon.SpecificWeapon.I00_TITLE);
            Menu[] mCategory = new Menu[WeaponStorage.WEAPON_CATEGORY_COUNT];
            for (int i = 0; i < WeaponStorage.WEAPON_CATEGORY_COUNT; i++)
            {
                mCategory[i] = new Menu(WeaponStorage.WEAPON_CATEGORY_NAMES[i]);
                Menu[] mWeapon = new Menu[Weapon.WeaponStorage.WEAPONS[i].Length];
                for (int j = 0; j < WeaponStorage.WEAPONS[i].Length; j++)
                {
                    mWeapon[j] = new Menu(WeaponStorage.WEAPONS[i][j].Name);
                    AddMenuItem(mCategory[i], WeaponStorage.WEAPONS[i][j].Name, false, false, mWeapon[j], null, Feature.Weapon.PreEnterSpecificWeaponMenu, null, WeaponStorage.WEAPONS[i][j]);
                }
                AddMenuItem(Menus.Weapons.GetSpecificWeapon, WeaponStorage.WEAPON_CATEGORY_NAMES[i], false, false, mCategory[i]);
            }
        }

        /// <summary>
        /// Initialize player menu
        /// </summary>
        private static void InitPlayerMenu()
        {
            const int DEFAULT_CASH_AMOUNT = 10000;
            const string POSITIVE_SIGN = "+";

            Menus.Player = new Menu(MenuText.Player.I00_TITLE);

            InitPlayerModelSkinPropsMenu();
            AddMenuItem(Menus.Player, MenuText.Player.I01_MODEL_SKIN_PROPS, false, false, Menus.Players.MSP);

            InitPlayerWantedMenu();
            AddMenuItem(Menus.Player, MenuText.Player.I02_WANTED, false, false, Menus.Players.Wanted);

            // Cash menu
            MenuItem miCash = AddMenuItem(Menus.Player, MenuText.Player.I03_CASH, false, false, null, Feature.Player.ChangeCash, null, null, DEFAULT_CASH_AMOUNT);
            miCash.ShowLeftRightAdjustableSign = true;
            miCash.LeftPressed += Feature.Player.DecreaseCash;
            miCash.RightPressed += Feature.Player.IncreaseCash;
            miCash.Text = Utils.FormatML(MenuText.Player.I03_CASH, POSITIVE_SIGN, DEFAULT_CASH_AMOUNT);

            AddMenuItem(Menus.Player, MenuText.Player.I04_HEAL, false, false, null, Feature.Player.QuickHeal);
            MenuItems.Player.Invincible = AddMenuItem(Menus.Player, MenuText.Player.I05_INVINCIBLE, true, Feature.Player.Invincible, null, Feature.Player.SetInvincible);
            MenuItems.Player.InfiniteAbility = AddMenuItem(Menus.Player, MenuText.Player.I06_INFINITE_ABILITY, true, Feature.Player.InfiniteAbility, null, Feature.Player.SetInfiniteAbility);
            MenuItems.Player.FastRun = AddMenuItem(Menus.Player, MenuText.Player.I07_FAST_RUN, true, Feature.Player.FastRun, null, Feature.Player.SetFastRun);
            MenuItems.Player.FastSwim = AddMenuItem(Menus.Player, MenuText.Player.I08_FAST_SWIM, true, Feature.Player.FastSwim, null, Feature.Player.SetFastSwim);
            MenuItems.Player.SuperJump = AddMenuItem(Menus.Player, MenuText.Player.I09_SUPER_JUMP, true, Feature.Player.SuperJump, null, Feature.Player.SetSuperJump);
            MenuItems.Player.Noiseless = AddMenuItem(Menus.Player, MenuText.Player.I10_NOISELESS, true, Feature.Player.Noiseless, null, Feature.Player.SetNoiseless);
        }

        /// <summary>
        /// Initialize player wanted menu
        /// </summary>
        private static void InitPlayerWantedMenu()
        {
            Menus.Players.Wanted = new Menu(MenuText.Player.Wanted.I00_TITLE);
            MenuItems.Player.Wanted.NeverWanted = AddMenuItem(Menus.Players.Wanted, MenuText.Player.Wanted.I01_NEVER_WANTED, true, Feature.Player.Wanted.NeverWanted, null, Feature.Player.Wanted.SetNeverWanted);
            MenuItems.Player.Wanted.PoliceIgnored = AddMenuItem(Menus.Players.Wanted, MenuText.Player.Wanted.I02_POLICE_IGNORED, true, Feature.Player.Wanted.PoliceIgnored, null, Feature.Player.Wanted.SetPoliceIgnored);
            MenuItems.Player.Wanted.EveryoneIgnored = AddMenuItem(Menus.Players.Wanted, MenuText.Player.Wanted.I03_EVERYONE_IGNORED, true, Feature.Player.Wanted.EveryoneIgnored, null, Feature.Player.Wanted.SetEveryoneIgonred);
            AddMenuItem(Menus.Players.Wanted, MenuText.Player.Wanted.I04_WANTED_UP, false, false, null, Feature.Player.Wanted.WantedLevelUp);
            AddMenuItem(Menus.Players.Wanted, MenuText.Player.Wanted.I05_WANTED_DOWN, false, false, null, Feature.Player.Wanted.WantedLevelDown);
        }

        /// <summary>
        /// Initialize player model & skin & props menu
        /// </summary>
        private static void InitPlayerModelSkinPropsMenu()
        {
            Menus.Players.MSP = new Menu(MenuText.Player.ModelSkinProps.I00_TITLE);
            InitPlayerMSPCustomSetsMenu();
            InitPlayerMSPCustomSetItemMenu();
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I01_CUSTOM_SETS, false, false, Menus.Players.MSPs.CustomSet, null, Feature.Player.MSPCustomSets.GenerateItemList);
            InitPlayerModelSelectorMenu();
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I02_SET_MODEL, false, false, Menus.Players.MSPs.Model);
            InitPlayerSkinCategoryMenu();
            InitPlayerSkinDrawableSelectorMenu();
            InitPlayerSkinTextureSelectorMenu();
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I03_SET_SKIN, false, false, Menus.Players.MSPs.Skin, null, Feature.Player.Skin.GenerateSkinCategoriesMenu);
            InitPlayerPropCategoryMenu();
            InitPlayerPropSelectorMenu();
            InitPlayerPropTextureSelectorMenu();
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I04_SET_PROPS, false, false, Menus.Players.MSPs.Prop, null, Feature.Player.Prop.GeneratePropCategoriesMenu);
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I05_RANDOM_MODEL, false, false, null, Feature.Player.PlayerModel.SetToRandomModel);
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I06_RANDOM_SKIN, false, false, null, Feature.Player.Skin.RandomSkin);
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I07_RANDOM_PROPS, false, false, null, Feature.Player.Prop.RandomProps);
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I08_RESET_SKIN, false, false, null, Feature.Player.PlayerModel.ResetSkin);
            AddMenuItem(Menus.Players.MSP, MenuText.Player.ModelSkinProps.I09_CLEAR_PROPS, false, false, null, Feature.Player.Prop.ClearProps); 
        }

        /// <summary>
        /// Initialize player Prop category menu
        /// </summary>
        private static void InitPlayerPropCategoryMenu()
        {
            Menus.Players.MSPs.Prop = new Menu(MenuText.Player.ModelSkinProps.PropCategories.I00_TITLE);
        }

        /// <summary>
        /// Initialize player Prop selector menu
        /// </summary>
        private static void InitPlayerPropSelectorMenu()
        {
            Menus.Players.MSPs.Props.Drawable = new Menu(MenuText.Player.ModelSkinProps.PropCategories.PropsSelector.I00_TITLE);
        }

        /// <summary>
        /// Initialize player Prop texture selector menu
        /// </summary>
        private static void InitPlayerPropTextureSelectorMenu()
        {
            Menus.Players.MSPs.Props.Texture = new Menu(MenuText.Player.ModelSkinProps.PropCategories.PropsSelector.TextureSelector.I00_TITLE);
        }

        /// <summary>
        /// Initialize player skin category menu
        /// </summary>
        private static void InitPlayerSkinCategoryMenu()
        {
            Menus.Players.MSPs.Skin = new Menu(MenuText.Player.ModelSkinProps.SkinCategories.I00_TITLE);
        }

        /// <summary>
        /// Initialize player skin drawable selector menu
        /// </summary>
        private static void InitPlayerSkinDrawableSelectorMenu()
        {
            Menus.Players.MSPs.Skins.Drawable = new Menu(MenuText.Player.ModelSkinProps.SkinCategories.DrawableSelector.I00_TITLE);
        }

        /// <summary>
        /// Initialize player skin texture selector menu
        /// </summary>
        private static void InitPlayerSkinTextureSelectorMenu()
        {
            Menus.Players.MSPs.Skins.Texture = new Menu(MenuText.Player.ModelSkinProps.SkinCategories.DrawableSelector.TextureSelector.I00_TITLE);
        }

        /// <summary>
        /// Initialize player Model selector menu
        /// </summary>
        private static void InitPlayerModelSelectorMenu()
        {
            Menus.Players.MSPs.Model = new Menu(MenuText.Player.ModelSkinProps.ModelSelector.I00_TITLE);
            AddMenuItem(Menus.Players.MSPs.Model, MenuText.Player.ModelSkinProps.ModelSelector.I01_MICHAEL, false, false, null, Feature.Player.PlayerModel.SetToMichael);
            AddMenuItem(Menus.Players.MSPs.Model, MenuText.Player.ModelSkinProps.ModelSelector.I02_FRANKLIN, false, false, null, Feature.Player.PlayerModel.SetToFranklin);
            AddMenuItem(Menus.Players.MSPs.Model, MenuText.Player.ModelSkinProps.ModelSelector.I03_TREVOR, false, false, null, Feature.Player.PlayerModel.SetToTrevor);
            InitPlayerModelSelectorAnimalsMenu();
            AddMenuItem(Menus.Players.MSPs.Model, MenuText.Player.ModelSkinProps.ModelSelector.I04_ANIMALS, false, false, Menus.Players.MSPs.Models.Animals);
            InitPlayerModelSelectorNPCsMenu();
            AddMenuItem(Menus.Players.MSPs.Model, MenuText.Player.ModelSkinProps.ModelSelector.I05_NPCS, false, false, Menus.Players.MSPs.Models.NPCs);
        }

        /// <summary>
        /// Initialize player Model selector animals menu
        /// </summary>
        private static void InitPlayerModelSelectorAnimalsMenu()
        {
            Menus.Players.MSPs.Models.Animals = new Menu(MenuText.Player.ModelSkinProps.ModelSelector.Animals.I00_TITLE);
            foreach (ModelData Model in ModelStorage.MODEL_ANIMALS)
            {
                MenuItem mi = AddMenuItem(Menus.Players.MSPs.Models.Animals, Model.Name, false, false, null, Feature.Player.PlayerModel.SetToModel, null, null, Model);
            }
        }

        /// <summary>
        /// Initialize player Model selector NPCs menu
        /// </summary>
        private static void InitPlayerModelSelectorNPCsMenu()
        {
            Menus.Players.MSPs.Models.NPCs = new Menu(MenuText.Player.ModelSkinProps.ModelSelector.NPCs.I00_TITLE);
            Menus.Players.MSPs.Models.NPCs.Width = 350;
            Menus.Players.MSPs.Models.NPCs.PageTextOffset = new System.Drawing.Point(275, 5);
            foreach (ModelData Model in ModelStorage.MODEL_NPCS)
            {
                MenuItem mi = AddMenuItem(Menus.Players.MSPs.Models.NPCs, Model.Name, false, false, null, Feature.Player.PlayerModel.SetToModel, null, null, Model);
            }
        }

        /// <summary>
        /// Initialize player model &amp; skin &amp; props custom sets menu
        /// </summary>
        private static void InitPlayerMSPCustomSetsMenu()
        {
            Menus.Players.MSPs.CustomSet = new Menu(MenuText.Player.ModelSkinProps.CustomSet.I00_TITLE);
            Menus.Players.MSPs.CustomSet.Width = 600;
            Menus.Players.MSPs.CustomSet.HasSubmenuSignOffset = new System.Drawing.Point(570, 5);
            Menus.Players.MSPs.CustomSet.PageTextOffset = new System.Drawing.Point(535, 5);
            MenuItems.Player.MSPCustomSet.Create = AddMenuItem(Menus.Players.MSPs.CustomSet, MenuText.Player.ModelSkinProps.CustomSet.I01_CREATE, false, false, null, Feature.Player.MSPCustomSets.Create);
        }

        /// <summary>
        /// Initialize player model &amp; skin &amp; props custom set item menu
        /// </summary>
        private static void InitPlayerMSPCustomSetItemMenu()
        {
            Menus.Players.MSPs.CustomSets.Item = new Menu(null);
            Menus.Players.MSPs.CustomSets.Item.Width = 700;
            Menus.Players.MSPs.CustomSets.Item.HasSubmenuSignOffset = new System.Drawing.Point(670, 5);
            MenuItems.Player.MSPCustomSet.Item.Apply = AddMenuItem(Menus.Players.MSPs.CustomSets.Item, MenuText.Player.ModelSkinProps.CustomSet.Item.I01_APPLY, false, false, null, Feature.Player.MSPCustomSets.Apply);
            MenuItems.Player.MSPCustomSet.Item.Rename = AddMenuItem(Menus.Players.MSPs.CustomSets.Item, MenuText.Player.ModelSkinProps.CustomSet.Item.I02_RENAME, false, false, null, Feature.Player.MSPCustomSets.Rename);
            MenuItems.Player.MSPCustomSet.Item.Overwrite = AddMenuItem(Menus.Players.MSPs.CustomSets.Item, MenuText.Player.ModelSkinProps.CustomSet.Item.I03_OVERWRITE, false, false, null, Feature.Player.MSPCustomSets.Overwrite);
            MenuItems.Player.MSPCustomSet.Item.Delete = AddMenuItem(Menus.Players.MSPs.CustomSets.Item, MenuText.Player.ModelSkinProps.CustomSet.Item.I04_DELETE, false, false, null, Feature.Player.MSPCustomSets.Delete);
        }

        /// <summary>
        /// Initialize location menu
        /// </summary>
        private static void InitLocationMenu()
        {
            Menus.Location = new Menu(MenuText.Location.I00_TITLE);
            InitLocationTeleporterMenu();
            AddMenuItem(Menus.Location, MenuText.Location.I01_LOCATION_TELEPORTER, false, false, Menus.Locations.LTeleporter);
            InitCustomLocationTeleporterMenu();
            InitCustomLocationTeleporterItemMenu();
            AddMenuItem(Menus.Location, MenuText.Location.I02_CUSTOM_LOCATION_TELEPORTER, false, false, Menus.Locations.CLTeleporter, null, Feature.Location.CustomLocationTeleporter.GenerateTargetList);
            InitXyzTeleporterMenu();
            AddMenuItem(Menus.Location, MenuText.Location.I03_XYZ_TELEPORTER, false, false, Menus.Locations.XyzTeleporter);
            MenuItems.Location.ShowCoordinate = AddMenuItem(Menus.Location, MenuText.Location.I04_SHOW_COORDINATE, true, Feature.Location.ShowCoordinates, null, Feature.Location.SetShowCoordinates);
        }

        /// <summary>
        /// Initialize location - location teleporter menu
        /// </summary>
        private static void InitLocationTeleporterMenu()
        {
            Menus.Locations.LTeleporter = new Menu(MenuText.Location.LocationTeleporter.I00_TITLE);
            AddMenuItem(Menus.Locations.LTeleporter, MenuText.Location.LocationTeleporter.I01_MAP_MARKER, false, false, null, Feature.Location.LocationTeleporter.MapMarker);
            foreach (TeleportCategory tc in TeleportTargetStorage.CATEGORIES)
            {
                Menu menu = new Menu(tc.Name);
                AddTeleportTargetsToMenu(menu, tc.Targets);
                AddMenuItem(Menus.Locations.LTeleporter, tc.Name, false, false, menu);
            }
        }

        /// <summary>
        /// Initialize location - custom location teleporter menu
        /// </summary>
        private static void InitCustomLocationTeleporterMenu()
        {
            Menus.Locations.CLTeleporter = new Menu(MenuText.Location.CustomLocationTeleporter.I00_TITLE);
            Menus.Locations.CLTeleporter.Width = 600;
            Menus.Locations.CLTeleporter.HasSubmenuSignOffset = new System.Drawing.Point(570, 5);
            Menus.Locations.CLTeleporter.PageTextOffset = new System.Drawing.Point(535, 5);
            MenuItems.Location.CustomLocationTeleporter.SaveCurrentLocation = AddMenuItem(Menus.Locations.CLTeleporter, MenuText.Location.CustomLocationTeleporter.I01_SAVE, false, false, null, Feature.Location.CustomLocationTeleporter.SaveCurrentLocation);
        }

        /// <summary>
        /// Initialize location - custom location teleporter - item menu
        /// </summary>
        private static void InitCustomLocationTeleporterItemMenu()
        {
            Menus.Locations.CLTeleporters.Item = new Menu(null);
            Menus.Locations.CLTeleporters.Item.Width = 700;
            Menus.Locations.CLTeleporters.Item.HasSubmenuSignOffset = new System.Drawing.Point(670, 5);
            MenuItems.Location.CustomLocationTeleporter.Item.Teleport = AddMenuItem(Menus.Locations.CLTeleporters.Item, MenuText.Location.CustomLocationTeleporter.Item.I01_TELEPORT, false, false, null, Feature.Location.CustomLocationTeleporter.Teleport);
            MenuItems.Location.CustomLocationTeleporter.Item.Rename = AddMenuItem(Menus.Locations.CLTeleporters.Item, MenuText.Location.CustomLocationTeleporter.Item.I02_RENAME, false, false, null, Feature.Location.CustomLocationTeleporter.Rename);
            MenuItems.Location.CustomLocationTeleporter.Item.Overwrite = AddMenuItem(Menus.Locations.CLTeleporters.Item, MenuText.Location.CustomLocationTeleporter.Item.I03_OVERWRITE, false, false, null, Feature.Location.CustomLocationTeleporter.Overwrite);
            MenuItems.Location.CustomLocationTeleporter.Item.Delete = AddMenuItem(Menus.Locations.CLTeleporters.Item, MenuText.Location.CustomLocationTeleporter.Item.I04_DELETE, false, false, null, Feature.Location.CustomLocationTeleporter.Delete);
        }

        /// <summary>
        /// Initialize xyz teleporter menu
        /// </summary>
        private static void InitXyzTeleporterMenu()
        {
            Menus.Locations.XyzTeleporter = new Menu(MenuText.Location.XyzTeleporter.I00_TITLE);
            InitXyzTeleporterOffsetMenu();
            AddMenuItem(Menus.Locations.XyzTeleporter, MenuText.Location.XyzTeleporter.I01_OFFSET, false, false, Menus.Locations.XyzTeleporters.Offset);
            InitXyzTeleporterCoordinatesMenu();
            AddMenuItem(Menus.Locations.XyzTeleporter, MenuText.Location.XyzTeleporter.I02_COORDINATES, false, false, Menus.Locations.XyzTeleporters.Coordinates, Feature.Location.XyzTeleporter.Coordinates.EnterMenu);
            AddMenuItem(Menus.Locations.XyzTeleporter, MenuText.Location.XyzTeleporter.I03_RANDOM, false, false, null, Feature.Location.XyzTeleporter.Random);
        }

        /// <summary>
        /// Initialize xyz teleporter offset menu
        /// </summary>
        private static void InitXyzTeleporterOffsetMenu()
        {
            Menus.Locations.XyzTeleporters.Offset = new Menu(MenuText.Location.XyzTeleporter.Offset.I00_TITLE);
            MenuItems.Location.XyzTeleporter.Offset.X = AddMenuItem(Menus.Locations.XyzTeleporters.Offset, MenuText.Location.XyzTeleporter.Offset.I01_X, false, false, null, Feature.Location.XyzTeleporter.Offset.SetX);
            MenuItems.Location.XyzTeleporter.Offset.X.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Offset.X.LeftPressed += Feature.Location.XyzTeleporter.Offset.DecX;
            MenuItems.Location.XyzTeleporter.Offset.X.RightPressed += Feature.Location.XyzTeleporter.Offset.IncX;
            MenuItems.Location.XyzTeleporter.Offset.Y = AddMenuItem(Menus.Locations.XyzTeleporters.Offset, MenuText.Location.XyzTeleporter.Offset.I02_Y, false, false, null, Feature.Location.XyzTeleporter.Offset.SetY);
            MenuItems.Location.XyzTeleporter.Offset.Y.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Offset.Y.LeftPressed += Feature.Location.XyzTeleporter.Offset.DecY;
            MenuItems.Location.XyzTeleporter.Offset.Y.RightPressed += Feature.Location.XyzTeleporter.Offset.IncY;
            MenuItems.Location.XyzTeleporter.Offset.Z = AddMenuItem(Menus.Locations.XyzTeleporters.Offset, MenuText.Location.XyzTeleporter.Offset.I03_Z, false, false, null, Feature.Location.XyzTeleporter.Offset.SetZ);
            MenuItems.Location.XyzTeleporter.Offset.Z.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Offset.Z.LeftPressed += Feature.Location.XyzTeleporter.Offset.DecZ;
            MenuItems.Location.XyzTeleporter.Offset.Z.RightPressed += Feature.Location.XyzTeleporter.Offset.IncZ;
            AddMenuItem(Menus.Locations.XyzTeleporters.Offset, MenuText.Location.XyzTeleporter.Offset.I04_RESET, false, false, null, Feature.Location.XyzTeleporter.Offset.Reset);
            AddMenuItem(Menus.Locations.XyzTeleporters.Offset, MenuText.Location.XyzTeleporter.Offset.I05_TELEPORT, false, false, null, Feature.Location.XyzTeleporter.Offset.Teleport);
            Feature.Location.XyzTeleporter.Offset.UpdateXMenuText();
            Feature.Location.XyzTeleporter.Offset.UpdateYMenuText();
            Feature.Location.XyzTeleporter.Offset.UpdateZMenuText();
        }

        /// <summary>
        /// INitialize xyz teleporter coordinates menu
        /// </summary>
        private static void InitXyzTeleporterCoordinatesMenu()
        {
            Menus.Locations.XyzTeleporters.Coordinates = new Menu(MenuText.Location.XyzTeleporter.Coordinates.I00_TITLE);
            MenuItems.Location.XyzTeleporter.Coordinates.X = AddMenuItem(Menus.Locations.XyzTeleporters.Coordinates, MenuText.Location.XyzTeleporter.Coordinates.I01_X, false, false, null, Feature.Location.XyzTeleporter.Coordinates.SetX);
            MenuItems.Location.XyzTeleporter.Coordinates.X.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Coordinates.X.LeftPressed += Feature.Location.XyzTeleporter.Coordinates.DecX;
            MenuItems.Location.XyzTeleporter.Coordinates.X.RightPressed += Feature.Location.XyzTeleporter.Coordinates.IncX;
            MenuItems.Location.XyzTeleporter.Coordinates.Y = AddMenuItem(Menus.Locations.XyzTeleporters.Coordinates, MenuText.Location.XyzTeleporter.Coordinates.I02_Y, false, false, null, Feature.Location.XyzTeleporter.Coordinates.SetY);
            MenuItems.Location.XyzTeleporter.Coordinates.Y.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Coordinates.Y.LeftPressed += Feature.Location.XyzTeleporter.Coordinates.DecY;
            MenuItems.Location.XyzTeleporter.Coordinates.Y.RightPressed += Feature.Location.XyzTeleporter.Coordinates.IncY;
            MenuItems.Location.XyzTeleporter.Coordinates.Z = AddMenuItem(Menus.Locations.XyzTeleporters.Coordinates, MenuText.Location.XyzTeleporter.Coordinates.I03_Z, false, false, null, Feature.Location.XyzTeleporter.Coordinates.SetZ);
            MenuItems.Location.XyzTeleporter.Coordinates.Z.ShowLeftRightAdjustableSign = true;
            MenuItems.Location.XyzTeleporter.Coordinates.Z.LeftPressed += Feature.Location.XyzTeleporter.Coordinates.DecZ;
            MenuItems.Location.XyzTeleporter.Coordinates.Z.RightPressed += Feature.Location.XyzTeleporter.Coordinates.IncZ;
            AddMenuItem(Menus.Locations.XyzTeleporters.Coordinates, MenuText.Location.XyzTeleporter.Coordinates.I04_RESET, false, false, null, Feature.Location.XyzTeleporter.Coordinates.Reset);
            AddMenuItem(Menus.Locations.XyzTeleporters.Coordinates, MenuText.Location.XyzTeleporter.Coordinates.I05_TELEPORT, false, false, null, Feature.Location.XyzTeleporter.Coordinates.Teleport);
            Feature.Location.XyzTeleporter.Coordinates.UpdateXMenuText();
            Feature.Location.XyzTeleporter.Coordinates.UpdateYMenuText();
            Feature.Location.XyzTeleporter.Coordinates.UpdateZMenuText();
        }

        /// <summary>
        /// Initialize vehicle menu
        /// </summary>
        private static void InitVehicleMenu()
        {
            Menus.Vehicle = new Menu(MenuText.Vehicle.I00_TITLE);
            InitVehicleSpawnMenu();
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I01_SPAWN, false, false, Menus.Vehicles.SpawnVehicle);
            InitVehicleCustomMenu();
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I02_CUSTOM, false, false, Menus.Vehicles.CustomVehicle, null, Feature.Vehicle.Custom.PreEnterMenu);
            InitVehiclePaintMenu();
            MenuItem miPaint = AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I03_PAINT, false, false, Menus.Vehicles.Paint, null, Feature.Vehicle.Paint.PreEnterPaintMenu);
            InitVehicleModMenu();
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I04_MODS, false, false, Menus.Vehicles.Mod, null, Feature.Vehicle.Mod.PreEnterModMenu);
            InitVehicleDoorMenu();
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I05_DOORS, false, false, Menus.Vehicles.Doors);
            InitVehicleSpeedMeterMenu();
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I06_SPEED_METER, false, false, Menus.Vehicles.SpeedMeter);
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I07_REPAIR, false, false, null, Feature.Vehicle.Repair);
            AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I08_CLEAN, false, false, null, Feature.Vehicle.Clean);
            MenuItems.Vehicle.Invincible = AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I09_INVINCIBLE, true, Feature.Vehicle.Invincible, null, Feature.Vehicle.SetInvincible);
            MenuItems.Vehicle.SeatBelt = AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I10_SEAT_BELT, true, Feature.Vehicle.SeatBelt, null, Feature.Vehicle.SetSeatBelt);
            MenuItems.Vehicle.SpawnIntoVehicle = AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I11_SPAWN_INTO, true, Feature.Vehicle.SpawnIntoVehicle, null, Feature.Vehicle.SetSpawnIntoVehicle);
            MenuItems.Vehicle.Boost = AddMenuItem(Menus.Vehicle, MenuText.Vehicle.I12_BOOST, true, Feature.Vehicle.Boost, null, Feature.Vehicle.SetBoost);
        }

        /// <summary>
        /// Initializes door menu
        /// </summary>
        private static void InitVehicleDoorMenu()
        {
            Menus.Vehicles.Doors = new Menu(MenuText.Vehicle.Door.I00_TITLE);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I01_INSTANT_OPEN_CLOSE, true, Feature.Vehicle.Door.InstantOpenClose, null, Feature.Vehicle.Door.SetInstantOpenClose);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I02_FRONT_RIGHT, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I03_FRONT_LEFT, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I04_REAR_RIGHT, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I05_REAR_LEFT, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I06_HOOD, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I07_TRUNK, false, false, null, Feature.Vehicle.Door.ToggleDoor);
            AddMenuItem(Menus.Vehicles.Doors, MenuText.Vehicle.Door.I08_TRUNK2, false, false, null, Feature.Vehicle.Door.ToggleDoor);
        }

        /// <summary>
        /// Initialize custom vehicle menu
        /// </summary>
        private static void InitVehicleCustomMenu()
        {
            Menus.Vehicles.CustomVehicle = new Menu(MenuText.Vehicle.CustomVehicle.I00_TITLE);
            Menus.Vehicles.CustomVehicle.Width = 600;
            Menus.Vehicles.CustomVehicle.HasSubmenuSignOffset = new System.Drawing.Point(570, 5);
            Menus.Vehicles.CustomVehicle.PageTextOffset = new System.Drawing.Point(535, 5);
            MenuItems.Vehicle.CustomVehicle.SaveCurrent = AddMenuItem(Menus.Vehicles.CustomVehicle, MenuText.Vehicle.CustomVehicle.I01_SAVE, false, false, null, Feature.Vehicle.Custom.SaveCurrent);
            Menus.Vehicles.CustomVehicles.Item = new Menu(null);
            Menus.Vehicles.CustomVehicles.Item.Width = 700;
            Menus.Vehicles.CustomVehicles.Item.HasSubmenuSignOffset = new System.Drawing.Point(670, 5);
            MenuItems.Vehicle.CustomVehicle.Item.Spawn = AddMenuItem(Menus.Vehicles.CustomVehicles.Item, MenuText.Vehicle.CustomVehicle.Item.I01_SPAWN, false, false, null, Feature.Vehicle.Custom.Spawn);
            MenuItems.Vehicle.CustomVehicle.Item.Rename = AddMenuItem(Menus.Vehicles.CustomVehicles.Item, MenuText.Vehicle.CustomVehicle.Item.I02_RENAME, false, false, null, Feature.Vehicle.Custom.Rename);
            MenuItems.Vehicle.CustomVehicle.Item.Overwrite = AddMenuItem(Menus.Vehicles.CustomVehicles.Item, MenuText.Vehicle.CustomVehicle.Item.I03_OVERWRITE, false, false, null, Feature.Vehicle.Custom.Overwrite);
            MenuItems.Vehicle.CustomVehicle.Item.Delete = AddMenuItem(Menus.Vehicles.CustomVehicles.Item, MenuText.Vehicle.CustomVehicle.Item.I04_DELETE, false, false, null, Feature.Vehicle.Custom.Delete);
        }

        /// <summary>
        /// Initialize vehicle paint menu
        /// </summary>
        private static void InitVehiclePaintMenu()
        {
            Menus.Vehicles.Paint = new Menu(MenuText.Vehicle.I03_PAINT);
            InitPrimaryColorMenu();
            MenuItems.Vehicle.Paint.PrimaryColor = AddMenuItem(Menus.Vehicles.Paint, MenuText.Vehicle.Paint.I01_PRIMARY, false, false, Menus.Vehicles.Paints.PrimaryColor, Feature.Vehicle.Paint.EnterPrimaryMenu);
            InitSecondaryColorMenu();
            MenuItems.Vehicle.Paint.SecondaryColor = AddMenuItem(Menus.Vehicles.Paint, MenuText.Vehicle.Paint.I02_SECONDARY, false, false, Menus.Vehicles.Paints.SecondaryColor, Feature.Vehicle.Paint.EnterSecondaryMenu);
            InitPearlTopcoatMenu();
            MenuItems.Vehicle.Paint.PearlTopcoat = AddMenuItem(Menus.Vehicles.Paint, MenuText.Vehicle.Paint.I03_PEARL_TOPCOAT, false, false, Menus.Vehicles.Paints.PearlTopcoat, null, Feature.Vehicle.Paint.PreEnterPearlTopcoatMenu);
            InitWheelsMenu();
            MenuItems.Vehicle.Paint.Wheels = AddMenuItem(Menus.Vehicles.Paint, MenuText.Vehicle.Paint.I04_WHEELS, false, false, Menus.Vehicles.Paints.Wheels, null, Feature.Vehicle.Paint.PreEnterWheelsMenu);
            Menus.Vehicles.Paints.Livery = new Menu(MenuText.Vehicle.Paint.Livery.I00_TITLE);
            MenuItems.Vehicle.Paint.Livery = AddMenuItem(Menus.Vehicles.Paint, MenuText.Vehicle.Paint.I05_LIVERY, false, false, Menus.Vehicles.Paints.Livery, Feature.Vehicle.Paint.EnterLiveryMenu);
        }

        /// <summary>
        /// Initializes vehicle mod menu
        /// </summary>
        private static void InitVehicleModMenu()
        {
            Menus.Vehicles.Mod = new Menu(MenuText.Vehicle.Mod.I00_TITLE);
            MenuItems.Vehicle.Mod.AllPerformance = AddMenuItem(Menus.Vehicles.Mod, MenuText.Vehicle.Mod.I01_ALL_PERFORMANCE, false, false, null, Feature.Vehicle.Mod.AllPerformance);
            MenuItems.Vehicle.Mod.AllArmor = AddMenuItem(Menus.Vehicles.Mod, MenuText.Vehicle.Mod.I02_ALL_ARMOR, false, false, null, Feature.Vehicle.Mod.AllArmor);
            MenuItems.Vehicle.Mod.RemoveAll = AddMenuItem(Menus.Vehicles.Mod, MenuText.Vehicle.Mod.I03_REMOVE_ALL, false, false, null, Feature.Vehicle.Mod.RemoveAll);
            Menus.Vehicles.Mods.ModItem = new Menu(null);
        }

        /// <summary>
        /// Initialize primary color menu
        /// </summary>
        private static void InitPrimaryColorMenu()
        {
            Menus.Vehicles.Paints.PrimaryColor = new Menu(MenuText.Vehicle.Paint.CHOOSE_PAINT_TYPE);
            for (int i = 0; i < PaintStorage.PAINT_TYPES.Length; i++)
            {
                Menu subMenu = new Menu(PaintStorage.PAINT_TYPES[i]);
                for (int j = 0; j < PaintStorage.PAINTS[i].Length; j++)
                {
                    MenuItem mi = AddMenuItem(subMenu, PaintStorage.PAINTS[i][j].Name, false, false, null, null, null, Feature.Vehicle.Paint.ApplyColor, PaintStorage.PAINTS[i][j]);
                }
                MenuItem m = AddMenuItem(Menus.Vehicles.Paints.PrimaryColor, PaintStorage.PAINT_TYPES[i], false, false, subMenu, null, Feature.Vehicle.Paint.PreEnterPaintTypeMenu, Feature.Vehicle.Paint.SelectPaintType, i);
            }
        }

        /// <summary>
        /// Initialize Secondary color menu
        /// </summary>
        private static void InitSecondaryColorMenu()
        {
            Menus.Vehicles.Paints.SecondaryColor = new Menu(MenuText.Vehicle.Paint.CHOOSE_PAINT_TYPE);
            for (int i = 0; i < PaintStorage.PAINT_TYPES.Length; i++)
            {
                Menu subMenu = new Menu(PaintStorage.PAINT_TYPES[i]);
                for (int j = 0; j < PaintStorage.PAINTS[i].Length; j++)
                {
                    MenuItem mi = AddMenuItem(subMenu, PaintStorage.PAINTS[i][j].Name);
                    mi.Data = PaintStorage.PAINTS[i][j];
                    mi.Highlighted += Feature.Vehicle.Paint.ApplyColor;
                }
                MenuItem m = AddMenuItem(Menus.Vehicles.Paints.SecondaryColor, PaintStorage.PAINT_TYPES[i], false, false, subMenu, null, Feature.Vehicle.Paint.PreEnterPaintTypeMenu, Feature.Vehicle.Paint.SelectPaintType, i);
            }
        }

        /// <summary>
        /// Initialize pearl topcoat menu
        /// </summary>
        private static void InitPearlTopcoatMenu()
        {
            Menus.Vehicles.Paints.PearlTopcoat = new Menu(MenuText.Vehicle.Paint.CHOOSE_COLOR);
            for (int i = 0; i < PaintStorage.PEARL_TOPCOAT_PAINTS.Length; i++)
            {
                MenuItem mi = AddMenuItem(Menus.Vehicles.Paints.PearlTopcoat, PaintStorage.PEARL_TOPCOAT_PAINTS[i].Name, false, false, null, null, null, Feature.Vehicle.Paint.ApplyColor, PaintStorage.PEARL_TOPCOAT_PAINTS[i]);
            }
        }

        /// <summary>
        /// Initialize wheels menu
        /// </summary>
        private static void InitWheelsMenu()
        {
            Menus.Vehicles.Paints.Wheels = new Menu(MenuText.Vehicle.Paint.CHOOSE_COLOR);
            for (int i = 0; i < PaintStorage.WHEELS_PAINTS.Length; i++)
            {
                MenuItem mi = AddMenuItem(Menus.Vehicles.Paints.Wheels, PaintStorage.WHEELS_PAINTS[i].Name, false, false, null, null, null, Feature.Vehicle.Paint.ApplyColor, PaintStorage.WHEELS_PAINTS[i]);
            }
        }

        /// <summary>
        /// Initialize vehicle speed meter menu
        /// </summary>
        private static void InitVehicleSpeedMeterMenu()
        {
            Menus.Vehicles.SpeedMeter = new Menu(MenuText.Vehicle.SpeedMeter.I00_TITLE);
            MenuItems.Vehicle.SpeedMeter.Show = AddMenuItem(Menus.Vehicles.SpeedMeter, MenuText.Vehicle.SpeedMeter.I01_SHOW, true, Feature.Vehicle.SpeedMeter.Show, null, Feature.Vehicle.SpeedMeter.SetShow);
            MenuItems.Vehicle.SpeedMeter.ShowInMetric = AddMenuItem(Menus.Vehicles.SpeedMeter, MenuText.Vehicle.SpeedMeter.I02_SHOW_IN_METRIC, true, Feature.Vehicle.SpeedMeter.ShowInMetric, null, Feature.Vehicle.SpeedMeter.SetShowInMetric);
            MenuItems.Vehicle.SpeedMeter.ShowWithoutVehicle = AddMenuItem(Menus.Vehicles.SpeedMeter, MenuText.Vehicle.SpeedMeter.I03_SHOW_WITHOUT_VEHICLE, true, Feature.Vehicle.SpeedMeter.ShowWithoutVehicle, null, Feature.Vehicle.SpeedMeter.SetShowWithoutVehicle);
        }

        /// <summary>
        /// Initialize vehicle spawn menu
        /// </summary>
        private static void InitVehicleSpawnMenu()
        {
            Menus.Vehicles.SpawnVehicle = new Menu(MenuText.Vehicle.Spawn.I00_TITLE);
            for (int i = 0; i < VehicleStorage.MAIN_CATEGORIES.Length; i++)
            {
                MenuItem mi = AddMenuItem(Menus.Vehicles.SpawnVehicle, VehicleStorage.MAIN_CATEGORIES[i]);
                Menu subMenu = new Menu(VehicleStorage.MAIN_CATEGORIES[i]);
                if (i < VehicleStorage.SUB_CATEGORY_COUNT)
                {
                    for (int j = 0; j < VehicleStorage.SUB_CATEGORIES[i].Length; j++)
                    {
                        MenuItem miSub = AddMenuItem(subMenu, VehicleStorage.SUB_CATEGORIES[i][j]);
                        Menu menu = new Menu(VehicleStorage.SUB_CATEGORIES[i][j]);
                        for (int k = 0; k < VehicleStorage.VEHICLES[i][j].Length; k++)
                        {
                            MenuItem miVehicle = AddMenuItem(menu, VehicleStorage.VEHICLES[i][j][k].Name, false, false, null, Feature.Vehicle.SpawnVehicle, null, null, VehicleStorage.VEHICLES[i][j][k]);
                        }
                        miSub.SubMenu = menu;
                    }
                }
                else
                {
                    for (int j = 0; j < VehicleStorage.VEHICLES[i][0].Length; j++)
                    {
                        MenuItem miVehicle = AddMenuItem(subMenu, VehicleStorage.VEHICLES[i][0][j].Name, false, false, null, Feature.Vehicle.SpawnVehicle, null, null, VehicleStorage.VEHICLES[i][0][j]);
                    }
                }
                mi.SubMenu = subMenu;
            }
        }

        /// <summary>
        /// Initialize configuration menu
        /// </summary>
        private static void InitConfigurationMenu()
        {
            Menus.Configuration = new Menu(MenuText.Configuration.I00_TITLE);
            AddMenuItem(Menus.Configuration, MenuText.Configuration.I01_SAVE, false, false, null, Feature.Config.Save);
            AddMenuItem(Menus.Configuration, MenuText.Configuration.I02_LOAD, false, false, null, Feature.Config.Load);
            AddMenuItem(Menus.Configuration, MenuText.Configuration.I03_AUTO_SAVE, true, Feature.Config.AutoSave, null, Feature.Config.SetAutoSave);
        }

        /// <summary>
        /// Initialize language menu
        /// </summary>
        private static void InitLanguageMenu()
        {
            Menus.Language = new Menu(MenuText.Language.I00_TITLE);
            AddMenuItem(Menus.Language, MenuText.Language.I01_ENGLISH, false, false, null, Language.SetToEnglish);
            AddMenuItem(Menus.Language, MenuText.Language.I02_CHINESE_TRADITIONAL, false, false, null, Language.SetToChineseTraditional);
        }

        /// <summary>
        /// Initialize main menu
        /// </summary>
        private static void InitMainMenu()
        {
            Menus.Main = new Menu(MenuText.Main.I00_TITLE);
            AddMenuItem(Menus.Main, MenuText.Main.I01_PLAYER, false, false, Menus.Player);
            AddMenuItem(Menus.Main, MenuText.Main.I02_LOCATION, false, false, Menus.Location);
            AddMenuItem(Menus.Main, MenuText.Main.I03_VEHICLE, false, false, Menus.Vehicle);
            AddMenuItem(Menus.Main, MenuText.Main.I04_WEAPON, false, false, Menus.Weapon);
            AddMenuItem(Menus.Main, MenuText.Main.I05_DATE_TIME_SPEED, false, false, Menus.DateTimeSpeed);
            AddMenuItem(Menus.Main, MenuText.Main.I06_WORLD, false, false, Menus.World);
            AddMenuItem(Menus.Main, MenuText.Main.I07_WEATHER, false, false, Menus.Weather);
            AddMenuItem(Menus.Main, MenuText.Main.I08_MISC, false, false, Menus.Misc);
            AddMenuItem(Menus.Main, MenuText.Main.I09_CONFIGURATION, false, false, Menus.Configuration);
            AddMenuItem(Menus.Main, MenuText.Main.I10_LANGUAGE, false, false, Menus.Language);

            EnterMenu(Menus.Main);
        }

        /// <summary>
        /// Adds a menu item into menu
        /// </summary>
        /// <param name="parent">Parent menu</param>
        /// <param name="text">Text</param>
        /// <param name="toggle">Is toggle</param>
        /// <param name="on">Is on</param>
        /// <param name="subMenu">Sub menu</param>
        /// <param name="activateEventHandler">Activated event handler</param>
        /// <param name="highlightedEventHandler">Highlighted event handler</param>
        /// <param name="preActivateEventHandler">Pre-activated event handler</param>
        public static MenuItem AddMenuItem(Menu parent, MLString text, bool toggle = false, bool on = false, Menu subMenu = null, MenuItemEventHandler activateEventHandler = null, MenuItemEventHandler preActivateEventHandler = null, MenuItemEventHandler highlightedEventHandler = null, object data = null)
        {
            MenuItem mi = new MenuItem()
            {
                Text = text,
                IsToggle = toggle,
                On = on,
                SubMenu = subMenu
            };
            if (activateEventHandler != null) mi.Activated += activateEventHandler;
            if (preActivateEventHandler != null) mi.PreActivated += preActivateEventHandler;
            if (highlightedEventHandler != null) mi.Highlighted += highlightedEventHandler;
            mi.Data = data;
            parent.Add(mi);

            return mi;
        }

        /// <summary>
        /// Adds teleport targets into menu
        /// </summary>
        /// <param name="parent">Parent menu</param>
        /// <param name="targets">Teleport targets</param>
        private static void AddTeleportTargetsToMenu(Menu parent, TeleportTarget[] targets)
        {
            foreach (TeleportTarget tt in targets)
            {
                MenuItem mi = AddMenuItem(parent, tt.Name, false, false, null, Feature.Location.LocationTeleporter.Target, null, null, tt);
            }
        }
    }
}
