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
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BEGroup.Utility;
using GTAVBETrainerDotNet.Config;
using GTAVBETrainerDotNet.SkinProps;
using GTAVBETrainerDotNet.Teleport;
using GTAVBETrainerDotNet.Vehicle;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Configurations
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Input key configurations
        /// </summary>
        public static class InputKey
        {
            /// <summary>
            /// Key to toggle trainer menu
            /// </summary>
            public static Keys ToggleMenu = Keys.F4;

            /// <summary>
            /// Key to move menu cursor up
            /// </summary>
            public static Keys MenuUp = Keys.NumPad8;

            /// <summary>
            /// Key to move menu cursor down
            /// </summary>
            public static Keys MenuDown = Keys.NumPad2;

            /// <summary>
            /// Key to move menu cursor left
            /// </summary>
            public static Keys MenuLeft = Keys.NumPad4;

            /// <summary>
            /// Key to move menu cursor right
            /// </summary>
            public static Keys MenuRight = Keys.NumPad6;

            /// <summary>
            /// Key to select current menu item
            /// </summary>
            public static Keys MenuSelect = Keys.NumPad5;

            /// <summary>
            /// Key to return to previous menu
            /// </summary>
            public static Keys MenuBack = Keys.NumPad0;

            /// <summary>
            /// Key to boost vehicle
            /// </summary>
            public static Keys BoostVehicle = Keys.NumPad9;

            /// <summary>
            /// Key to stop vehicle
            /// </summary>
            public static Keys StopVehicle = Keys.NumPad7;

            /// <summary>
            /// Key to launch vehicle rockets
            /// </summary>
            public static Keys VehicleRocket = Keys.Add;
        }

        // Configuration file
        private const string CONFIG_FILE = ".\\scripts\\BETrainer.ini";

        // Configuration sections & keys below:
        private const string CONFIG_TRAINER = "Trainer";
        private const string CONFIG_TRAINER_AUTO_SAVE = "AutoSave";

        private const string CONFIG_KEYS = "Keys";
        private const string CONFIG_KEYS_TOGGLE_MENU = "ToggleMenu";
        private const string CONFIG_KEYS_MENU_UP = "MenuUp";
        private const string CONFIG_KEYS_MENU_DOWN = "MenuDown";
        private const string CONFIG_KEYS_MENU_LEFT = "MenuLeft";
        private const string CONFIG_KEYS_MENU_RIGHT = "MenuRight";
        private const string CONFIG_KEYS_MENU_SELECT = "MenuSelect";
        private const string CONFIG_KEYS_MENU_BACK = "MenuBack";
        private const string CONFIG_KEYS_BOOST_VEHICLE = "BoostVehicle";
        private const string CONFIG_KEYS_STOP_VEHICLE = "StopVehicle";
        private const string CONFIG_KEYS_VEHICLE_ROCKET = "VehicleRocket";

        private const string CONFIG_PLAYER = "Player";
        private const string CONFIG_PLAYER_INVINCIBLE = "Invincible";
        private const string CONFIG_PLAYER_INFINITE_ABILITY = "InfiniteAbility";
        private const string CONFIG_PLAYER_FAST_RUN = "FastRun";
        private const string CONFIG_PLAYER_FAST_SWIM = "FastSwim";
        private const string CONFIG_PLAYER_SUPER_JUMP = "SuperJump";
        private const string CONFIG_PLAYER_NOISELESS = "Noiseless";
        private const string CONFIG_PLAYER_NEVER_WANTED = "NeverWanted";
        private const string CONFIG_PLAYER_POLICE_IGNORED = "PoliceIgnored";
        private const string CONFIG_PLAYER_EVERYONE_IGNORED = "EveryoneIgnored";

        private const string CONFIG_LOCATION = "Location";
        private const string CONFIG_LOCATION_SHOW_COORDINATES = "ShowCoordinates";

        private const string CONFIG_VEHICLE = "Vehicle";
        private const string CONFIG_VEHICLE_INVINCIBLE = "Invincible";
        private const string CONFIG_VEHICLE_SEATBELT = "SeatBelt";
        private const string CONFIG_VEHICLE_SPAWN_INTO = "SpawnIntoVehicle";
        private const string CONFIG_VEHICLE_BOOST = "SpeedBoost";
        private const string CONFIG_VEHICLE_SPEEDMETER_SHOW = "SpeedMeterShow";
        private const string CONFIG_VEHICLE_SPEEDMETER_SHOW_IN_METRIC = "SpeedMeterShowInMetric";
        private const string CONFIG_VEHICLE_SPEEDMETER_SHOW_WITHOUT_VEHICLE = "SpeedMeterShowWithoutVehicle";
        private const string CONFIG_VEHICLE_DOOR_INSTANT = "DoorInstantOpenClose";

        private const string CONFIG_WEAPON = "Weapon";
        private const string CONFIG_WEAPON_INFINITE_AMMO = "InfiniteAmmo";
        private const string CONFIG_WEAPON_PERMANENT_PARACHUTE = "PermanentParachute";
        private const string CONFIG_WEAPON_NO_RELOAD = "NoReload";
        private const string CONFIG_WEAPON_FIRE_AMMO = "FireAmmo";
        private const string CONFIG_WEAPON_EXPLOSIVE_AMMO = "ExplosiveAmmo";
        private const string CONFIG_WEAPON_EXPLOSIVE_MELEE = "ExplosiveMelee";
        private const string CONFIG_WEAPON_VEHICLE_ROCKETS = "VehicleRockets";

        private const string CONFIG_TIME = "Time";
        private const string CONFIG_TIME_SHOW_TIME = "ShowTime";
        private const string CONFIG_TIME_BULLET_TIME = "BulletTime";
        private const string CONFIG_TIME_PAUSED = "Paused";
        private const string CONFIG_TIME_SYNC_WITH_SYSTEM = "Sync With System";

        /// <summary>
        /// Load configurations
        /// </summary>
        public static void Load()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                Utils.ShowNotificationAboveMap(GlobalConst.Message.CONFIGURATION_CREATING);
                Save();
                return;
            }

            try
            {
                IniFile ini = new IniFile(CONFIG_FILE);

                // Trainer
                Feature.Config.AutoSave = Utils.ParseBoolStr(ini.GetValue(CONFIG_TRAINER, CONFIG_TRAINER_AUTO_SAVE));

                // Keys
                InputKey.ToggleMenu = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_TOGGLE_MENU));
                InputKey.MenuUp = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_UP));
                InputKey.MenuDown = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_DOWN));
                InputKey.MenuLeft = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_LEFT));
                InputKey.MenuRight = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_RIGHT));
                InputKey.MenuSelect = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_SELECT));
                InputKey.MenuBack = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_BACK));
                InputKey.BoostVehicle = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_BOOST_VEHICLE));
                InputKey.StopVehicle = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_STOP_VEHICLE));
                InputKey.VehicleRocket = Utils.ParseKey(ini.GetValue(CONFIG_KEYS, CONFIG_KEYS_VEHICLE_ROCKET));

                // Player
                Feature.Player.Invincible = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_INVINCIBLE)); 
                Feature.Player.InfiniteAbility = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_INFINITE_ABILITY)); 
                Feature.Player.FastRun = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_FAST_RUN)); 
                Feature.Player.FastSwim = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_FAST_SWIM)); 
                Feature.Player.SuperJump = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_SUPER_JUMP)); 
                Feature.Player.Noiseless = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_NOISELESS)); 
                Feature.Player.Wanted.NeverWanted = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_NEVER_WANTED)); 
                Feature.Player.Wanted.PoliceIgnored = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_POLICE_IGNORED)); 
                Feature.Player.Wanted.EveryoneIgnored = Utils.ParseBoolStr(ini.GetValue(CONFIG_PLAYER, CONFIG_PLAYER_EVERYONE_IGNORED)); 

                // Player MSP Custom Sets
                MSPCustomSets.LoadMSPCustomSets();

                // Location
                Feature.Location.ShowCoordinates = Utils.ParseBoolStr(ini.GetValue(CONFIG_LOCATION, CONFIG_LOCATION_SHOW_COORDINATES)); 
                Location.LoadCustomLocations();

                // Vehicle
                Feature.Vehicle.Boost = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_BOOST)); 
                Feature.Vehicle.Invincible = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_INVINCIBLE)); 
                Feature.Vehicle.SeatBelt = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SEATBELT)); 
                Feature.Vehicle.SpawnIntoVehicle = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPAWN_INTO)); 
                Feature.Vehicle.SpeedMeter.Show = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW)); 
                Feature.Vehicle.SpeedMeter.ShowInMetric = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW_IN_METRIC)); 
                Feature.Vehicle.SpeedMeter.ShowWithoutVehicle = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW_WITHOUT_VEHICLE)); 
                Feature.Vehicle.Door.InstantOpenClose = Utils.ParseBoolStr(ini.GetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_DOOR_INSTANT)); 
                Vehicle.LoadCustomVehicles();

                // Weapon
                Feature.Weapon.ExplosiveAmmo = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_EXPLOSIVE_AMMO));
                Feature.Weapon.ExplosiveMelee = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_EXPLOSIVE_MELEE));
                Feature.Weapon.FireAmmo = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_FIRE_AMMO));
                Feature.Weapon.InfiniteAmmo = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_INFINITE_AMMO));
                Feature.Weapon.NoReload = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_NO_RELOAD));
                Feature.Weapon.PermanentParachute = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_PERMANENT_PARACHUTE));
                Feature.Weapon.VehicleRocket = Utils.ParseBoolStr(ini.GetValue(CONFIG_WEAPON, CONFIG_WEAPON_VEHICLE_ROCKETS));

                // Time
                Feature.DateTimeSpeed.ShowTime = Utils.ParseBoolStr(ini.GetValue(CONFIG_TIME, CONFIG_TIME_SHOW_TIME));
                Feature.DateTimeSpeed.Paused = Utils.ParseBoolStr(ini.GetValue(CONFIG_TIME, CONFIG_TIME_PAUSED));
                Feature.DateTimeSpeed.SyncWithSystem = Utils.ParseBoolStr(ini.GetValue(CONFIG_TIME, CONFIG_TIME_SYNC_WITH_SYSTEM));

                Utils.ShowNotificationAboveMap(GlobalConst.Message.CONFIGURATION_LOADED);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Save configurations
        /// </summary> 
        public static void Save(bool showNotification = true)
        {
            if (File.Exists(CONFIG_FILE))
            {
                File.Delete(CONFIG_FILE);
            }

            try
            {
                IniFile ini = new IniFile(CONFIG_FILE);

                // Trainer
                ini.SetValue(CONFIG_TRAINER, CONFIG_TRAINER_AUTO_SAVE, Feature.Config.AutoSave.ToString());

                // Keys
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_STOP_VEHICLE, Enum.GetName(typeof(Keys), InputKey.StopVehicle));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_BOOST_VEHICLE, Enum.GetName(typeof(Keys), InputKey.BoostVehicle));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_BACK, Enum.GetName(typeof(Keys), InputKey.MenuBack));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_DOWN, Enum.GetName(typeof(Keys), InputKey.MenuDown));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_LEFT, Enum.GetName(typeof(Keys), InputKey.MenuLeft));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_RIGHT, Enum.GetName(typeof(Keys), InputKey.MenuRight));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_SELECT, Enum.GetName(typeof(Keys), InputKey.MenuSelect));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_MENU_UP, Enum.GetName(typeof(Keys), InputKey.MenuUp));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_TOGGLE_MENU, Enum.GetName(typeof(Keys), InputKey.ToggleMenu));
                ini.SetValue(CONFIG_KEYS, CONFIG_KEYS_VEHICLE_ROCKET, Enum.GetName(typeof(Keys), InputKey.VehicleRocket));

                // Player
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_INVINCIBLE, Feature.Player.Invincible.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_INFINITE_ABILITY, Feature.Player.InfiniteAbility.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_FAST_RUN, Feature.Player.FastRun.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_FAST_SWIM, Feature.Player.FastSwim.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_SUPER_JUMP, Feature.Player.SuperJump.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_NOISELESS, Feature.Player.Noiseless.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_NEVER_WANTED, Feature.Player.Wanted.NeverWanted.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_POLICE_IGNORED, Feature.Player.Wanted.PoliceIgnored.ToString());
                ini.SetValue(CONFIG_PLAYER, CONFIG_PLAYER_EVERYONE_IGNORED, Feature.Player.Wanted.EveryoneIgnored.ToString());

                // Location
                ini.SetValue(CONFIG_LOCATION, CONFIG_LOCATION_SHOW_COORDINATES, Feature.Location.ShowCoordinates.ToString());

                // Vehicle
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_BOOST, Feature.Vehicle.Boost.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_INVINCIBLE, Feature.Vehicle.Invincible.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SEATBELT, Feature.Vehicle.SeatBelt.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPAWN_INTO, Feature.Vehicle.SpawnIntoVehicle.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW, Feature.Vehicle.SpeedMeter.Show.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW_IN_METRIC, Feature.Vehicle.SpeedMeter.ShowInMetric.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_SPEEDMETER_SHOW_WITHOUT_VEHICLE, Feature.Vehicle.SpeedMeter.ShowWithoutVehicle.ToString());
                ini.SetValue(CONFIG_VEHICLE, CONFIG_VEHICLE_DOOR_INSTANT, Feature.Vehicle.Door.InstantOpenClose.ToString());

                // Weapon
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_EXPLOSIVE_AMMO, Feature.Weapon.ExplosiveAmmo.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_EXPLOSIVE_MELEE, Feature.Weapon.ExplosiveMelee.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_FIRE_AMMO, Feature.Weapon.FireAmmo.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_INFINITE_AMMO, Feature.Weapon.InfiniteAmmo.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_NO_RELOAD, Feature.Weapon.NoReload.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_PERMANENT_PARACHUTE, Feature.Weapon.PermanentParachute.ToString());
                ini.SetValue(CONFIG_WEAPON, CONFIG_WEAPON_VEHICLE_ROCKETS, Feature.Weapon.VehicleRocket.ToString());

                // Time
                ini.SetValue(CONFIG_TIME, CONFIG_TIME_SHOW_TIME, Feature.DateTimeSpeed.ShowTime.ToString());
                ini.SetValue(CONFIG_TIME, CONFIG_TIME_PAUSED, Feature.DateTimeSpeed.Paused.ToString());
                ini.SetValue(CONFIG_TIME, CONFIG_TIME_SYNC_WITH_SYSTEM, Feature.DateTimeSpeed.Paused.ToString());

                ini.Save();

                if (showNotification) Utils.ShowNotificationAboveMap(GlobalConst.Message.CONFIGURATION_SAVED);
            }
            catch
            {
            }
        }

        /// <summary>
        /// MSP custom set configurations
        /// </summary>
        public static class MSPCustomSets
        {
            private const string CONFIG_FILE_MSPCS = ".\\scripts\\BETrainer_MSPCustomSets.ini";

            private const string CONFIG_MSPCS = "MSPCustomSets";
            private const string CONFIG_MSPCS_COUNT = "Count";
            private const string CONFIG_MSPCS_ENTRY = "{0:000}";

            /// <summary>
            /// Player Model &amp; Skin &amp; Props custom sets
            /// </summary>
            public static List<MSPCustomSet> Items = null;

            /// <summary>
            /// Loads player model &amp; skin &amp; props custom sets
            /// </summary>
            public static void LoadMSPCustomSets()
            {
                Items = new List<MSPCustomSet>();
                if (!File.Exists(CONFIG_FILE_MSPCS)) return;

                IniFile ini = new IniFile(CONFIG_FILE_MSPCS);

                int count = 0; if (!int.TryParse(ini.GetValue(CONFIG_MSPCS, CONFIG_MSPCS_COUNT), out count)) count = 0;
                if (count == 0) return;

                Items.Capacity = count;

                for (int i = 1; i <= count; i++)
                {
                    MSPCustomSet set = MSPCustomSet.Deserialize(ini.GetValue(CONFIG_MSPCS, string.Format(CONFIG_MSPCS_ENTRY, i)));
                    if (set != null) Items.Add(set);
                }

                Items.Sort();
            }

            /// <summary>
            /// Saves player model &amp; skin &amp; props custom sets
            /// </summary>
            public static void SaveMSPCustomSets()
            {
                if (File.Exists(CONFIG_FILE_MSPCS)) File.Delete(CONFIG_FILE_MSPCS);
                if (Items == null || Items.Count == 0) return;

                IniFile ini = new IniFile(CONFIG_FILE_MSPCS);

                ini.SetValue(CONFIG_MSPCS, CONFIG_MSPCS_COUNT, Items.Count.ToString());
                for (int i = 1; i <= Items.Count; i++)
                {
                    MSPCustomSet set = Items[i - 1];
                    ini.SetValue(CONFIG_MSPCS, string.Format(CONFIG_MSPCS_ENTRY, i), set.Serialize());
                }

                ini.Save();
            }
        }
    
        /// <summary>
        /// Location configurations
        /// </summary>
        public static class Location
        {
            private const string CONFIG_FILE_CUSTOM_LOCATIONS = ".\\scripts\\BETrainer_CustomLocations.ini";

            private const string CONFIG_CL = "CustomLocations";
            private const string CONFIG_CL_COUNT = "Count";
            private const string CONFIG_CL_ENTRY = "{0:000}";

            /// <summary>
            /// Custom locations
            /// </summary>
            public static List<SimpleTeleportTarget> Targets = null;

            /// <summary>
            /// Saves custom locations
            /// </summary>
            public static void SaveCustomLocations()
            {
                if (File.Exists(CONFIG_FILE_CUSTOM_LOCATIONS)) File.Delete(CONFIG_FILE_CUSTOM_LOCATIONS);
                if (Targets == null || Targets.Count == 0) return;

                IniFile ini = new IniFile(CONFIG_FILE_CUSTOM_LOCATIONS);

                ini.SetValue(CONFIG_CL, CONFIG_CL_COUNT, Targets.Count.ToString());
                for (int i = 0; i < Targets.Count; i++)
                {
                    ini.SetValue(CONFIG_CL, string.Format(CONFIG_CL_ENTRY, i + 1), Targets[i].Serialize());
                }

                ini.Save();
            }

            /// <summary>
            /// Loads all custom locations
            /// </summary>
            public static void LoadCustomLocations()
            {
                Targets = new List<SimpleTeleportTarget>();
                if (!File.Exists(CONFIG_FILE_CUSTOM_LOCATIONS)) return;

                IniFile ini = new IniFile(CONFIG_FILE_CUSTOM_LOCATIONS);

                int count = Utils.ParseInt(ini.GetValue(CONFIG_CL, CONFIG_CL_COUNT));
                if (count <= 0) return;

                Targets.Capacity = count;

                for (int i = 0; i < count; i++)
                {
                    SimpleTeleportTarget target = SimpleTeleportTarget.Deserialize(ini.GetValue(CONFIG_CL, string.Format(CONFIG_CL_ENTRY, i + 1)));
                    if (target != null) Targets.Add(target);
                }
                Targets.Sort();
            }
        }

        /// <summary>
        /// Vehicle configurations
        /// </summary>
        public static class Vehicle
        {
            private const string CONFIG_FILE_CUSTOM_VEHICLES = ".\\scripts\\BETrainer_CustomVehicles.ini";
            private const string CONFIG_CV = "CustomVehicles";
            private const string CONFIG_CV_COUNT = "Count";
            private const string CONFIG_CV_ITEM = "{0:000}";

            public static List<CustomVehicle> CustomVehicles = null;

            /// <summary>
            /// Loads all custom vehicles
            /// </summary>
            public static void LoadCustomVehicles()
            {
                CustomVehicles = new List<CustomVehicle>();
                if (!File.Exists(CONFIG_FILE_CUSTOM_VEHICLES)) return;

                IniFile ini = new IniFile(CONFIG_FILE_CUSTOM_VEHICLES);
                int count = 0; if (!int.TryParse(ini.GetValue(CONFIG_CV, CONFIG_CV_COUNT), out count)) count = 0;
                if (count <= 0) return;

                CustomVehicles.Capacity = count;

                for (int i = 0; i < count; i++)
                {
                    string data = ini.GetValue(CONFIG_CV, string.Format(CONFIG_CV_ITEM, i + 1));
                    CustomVehicle cv = CustomVehicle.Deserialize(data);
                    if (cv != null)
                    {
                        CustomVehicles.Add(cv);
                    }
                }

                CustomVehicles.Sort();
            }

            /// <summary>
            /// Saves all custom vehicles
            /// </summary>
            public static void SaveCustomVehicles()
            {
                if (File.Exists(CONFIG_FILE_CUSTOM_VEHICLES)) File.Delete(CONFIG_FILE_CUSTOM_VEHICLES);
                if (CustomVehicles == null || CustomVehicles.Count == 0) return;

                IniFile ini = new IniFile(CONFIG_FILE_CUSTOM_VEHICLES);

                ini.SetValue(CONFIG_CV, CONFIG_CV_COUNT, CustomVehicles.Count.ToString());
                for (int i = 0; i < CustomVehicles.Count; i++)
                {
                    ini.SetValue(CONFIG_CV, string.Format(CONFIG_CV_ITEM, i + 1), CustomVehicles[i].Serialize());
                }
                ini.Save();
            }
        }
    }
}
