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

namespace GTAVBETrainerDotNet.Menu
{
    /// <summary>
    /// Menu text
    /// </summary>
    public static class MenuText
    {
        /// <summary>
        /// Main menu
        /// </summary>
        public static class Main
        {
            public const string I00_TITLE = "BE Trainer.NET " + GlobalConst.TRAINER_VERSION;
            public const string I01_PLAYER = "Player";
            public const string I02_LOCATION = "Location";
            public const string I03_VEHICLE = "Vehicle";
            public const string I04_WEAPON = "Weapon";
            public const string I05_DATE_TIME_SPEED = "Date & Time & Speed";
            public const string I06_WORLD = "World";
            public const string I07_WEATHER = "Weather";
            public const string I08_MISC = "Misc";
            public const string I09_CONFIGURATION = "Configuration";
        }

        /// <summary>
        /// Player menu
        /// </summary>
        public static class Player
        {
            public const string I00_TITLE = "Player Options";
            public const string I01_MODEL_SKIN_PROPS = "Model & Skin & Props";
            public const string I02_WANTED = "Wanted";
            public const string I03_CASH = "Cash {0}${1:#,0}";
            public const string I04_HEAL = "Quick Heal";
            public const string I05_INVINCIBLE = "Invincible";
            public const string I06_INFINITE_ABILITY = "Infinite Ability";
            public const string I07_FAST_RUN = "Fast Run";
            public const string I08_FAST_SWIM = "Fast Swim";
            public const string I09_SUPER_JUMP = "Super Jump";
            public const string I10_NOISELESS = "Noiseless";

            /// <summary>
            /// Wanted menu
            /// </summary>
            public static class Wanted
            {
                public const string I00_TITLE = "Wanted Options";
                public const string I01_NEVER_WANTED = "Never Wanted";
                public const string I02_POLICE_IGNORED = "Police Ignores Me";
                public const string I03_EVERYONE_IGNORED = "Everyone Ignores Me";
                public const string I04_WANTED_UP = "Wanted Level Up";
                public const string I05_WANTED_DOWN = "Wanted Level Down";
            }

            /// <summary>
            /// Model & Skin & Props menu
            /// </summary>
            public static class ModelSkinProps
            {
                public const string I00_TITLE = "Model & Skin & Props";
                public const string I01_CUSTOM_SETS = "Custom Sets";
                public const string I02_SET_MODEL = "Set Model";
                public const string I03_SET_SKIN = "Set Skin";
                public const string I04_SET_PROPS = "Set Props";
                public const string I05_RANDOM_MODEL = "Random Model";
                public const string I06_RANDOM_SKIN = "Random Skin";
                public const string I07_RANDOM_PROPS = "Random Props";
                public const string I08_RESET_SKIN = "Reset Skin";
                public const string I09_CLEAR_PROPS = "Clear Props";

                /// <summary>
                /// Custom sets menu
                /// </summary>
                public static class CustomSet
                {
                    public const string I00_TITLE = "Custom Sets";
                    public const string I01_CREATE = "Create New Set";

                    /// <summary>
                    /// Item menu
                    /// </summary>
                    public static class Item
                    {
                        public const string I01_APPLY = "Apply";
                        public const string I02_RENAME = "Rename";
                        public const string I03_OVERWRITE = "Overwrite with Current";
                        public const string I04_DELETE = "Delete";
                    }
                }

                /// <summary>
                /// Model selector menu
                /// </summary>
                public static class ModelSelector
                {
                    public const string I00_TITLE = "Model Selector";
                    public const string I01_MICHAEL = "Michael";
                    public const string I02_FRANKLIN = "Franklin";
                    public const string I03_TREVOR = "Trevor";
                    public const string I04_ANIMALS = "Animals";
                    public const string I05_NPCS = "NPCs";
                    public const string I06_RANDOM = "Random";

                    /// <summary>
                    /// Model selector animals menu
                    /// </summary>
                    public static class Animals
                    {
                        public const string I00_TITLE = "Model Selector - Animals";
                    }

                    /// <summary>
                    /// Model selector NPCs menu
                    /// </summary>
                    public static class NPCs
                    {
                        public const string I00_TITLE = "Model Selector - NPCs";
                    }
                }

                /// <summary>
                /// Skin categories menu
                /// </summary>
                public static class SkinCategories
                {
                    public const string I00_TITLE = "Skin Categories";
                    public const string I01_SLOT = "Slot {0}: {1} ({2})";
                    public const string I02_NO_AVAILABLE_SLOT = "No Available Slot";

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class DrawableSelector
                    {
                        public const string I00_TITLE = "Drawable Selector";
                        public const string I01_DRAWABLE = "Drawable #{0} ({1})";

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public const string I00_TITLE = "Texture Selector";
                            public const string I01_TEXTURE = "Texture #{0}";
                        }
                    }
                }

                /// <summary>
                /// Props categories menu
                /// </summary>
                public static class PropCategories
                {
                    public const string I00_TITLE = "Prop Categories";
                    public const string I01_SLOT = "Slot {0}: {1} ({2})";
                    public const string I02_NO_AVAILABLE_SLOT = "No Available Slot";

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class PropsSelector
                    {
                        public const string I00_TITLE = "Prop Selector";
                        public const string I01_NOTHING = "Nothing";
                        public const string I02_PROP = "Prop #{0} ({1})";

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public const string I00_TITLE = "Texture Selector";
                            public const string I01_TEXTURE = "Texture #{0}";
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Location menu
        /// </summary>
        public static class Location
        {
            public const string I00_TITLE = "Location Options";
            public const string I01_LOCATION_TELEPORTER = "Location Teleporter";
            public const string I02_CUSTOM_LOCATION_TELEPORTER = "Custom Location Teleporter";
            public const string I03_XYZ_TELEPORTER = "XYZ Teleporter";
            public const string I04_SHOW_COORDINATE = "Show Coordinates";

            /// <summary>
            /// Location teleporter menu
            /// </summary>
            public static class LocationTeleporter
            {
                public const string I00_TITLE = "Location Teleporter";
                public const string I01_MAP_MARKER = "Map Marker";
                public const string I02_SAFEHOUSES = "Safehouses";
                public const string I03_LANDMARKS = "Landmarks";
                public const string I04_ROOF_HIGH = "Roof & High Places";
                public const string I05_UNDERWATER = "Underwater Places";
                public const string I06_INTERIORS = "Interiors";
                public const string I07_SPECIALS = "Special Places";
                public const string I08_STUNT_JUMPS = "Stunt Jumps";
                public const string I09_SPACESHIP_PARTS = "Spaceship Parts";
                public const string I10_LETTER_SCRAPS = "Letter Scraps";
            }

            /// <summary>
            /// Custom location teleporter menu
            /// </summary>
            public static class CustomLocationTeleporter
            {
                public const string I00_TITLE = "Custom Location Teleporter";
                public const string I01_SAVE = "Save Current Location";

                /// <summary>
                /// Custom loactoin teleporter item menu
                /// </summary>
                public static class Item
                {
                    public const string I01_TELEPORT = "Teleport";
                    public const string I02_RENAME = "Rename";
                    public const string I03_OVERWRITE = "Overwrite With Current Location";
                    public const string I04_DELETE = "Delete";
                }
            }

            /// <summary>
            /// XYZ teleporter menu
            /// </summary>
            public static class XyzTeleporter
            {
                public const string I00_TITLE = "XYZ Teleporter";
                public const string I01_OFFSET = "Teleport by Offsets";
                public const string I02_COORDINATES = "Teleport to Coordinates";
                public const string I03_RANDOM = "Teleport to Random Location";

                /// <summary>
                /// Teleport by Offsets menu
                /// </summary>
                public static class Offset
                {
                    public const string I00_TITLE = "Teleport by Offsets";
                    public const string I01_X = "X: {0:#0.000000}";
                    public const string I02_Y = "Y: {0:#0.000000}";
                    public const string I03_Z = "Z: {0:#0.000000}";
                    public const string I04_RESET = "Reset";
                    public const string I05_TELEPORT = "Teleport";
                }

                /// <summary>
                /// Teleport to coordinates menu
                /// </summary>
                public static class Coordinates
                {
                    public const string I00_TITLE = "Ttleport to Coordinates";
                    public const string I01_X = "X: {0:#0.000000}";
                    public const string I02_Y = "Y: {0:#0.000000}";
                    public const string I03_Z = "Z: {0:#0.000000}";
                    public const string I04_RESET = "Reset to Current Location";
                    public const string I05_TELEPORT = "Teleport";
                }
            }
        }

        /// <summary>
        /// Vehicle menu
        /// </summary>
        public static class Vehicle
        {
            public const string I00_TITLE = "Vehicle Options";
            public const string I01_SPAWN = "Spawn Vehicle";
            public const string I02_CUSTOM = "Custom Vehicles";
            public const string I03_PAINT = "Paints";
            public const string I04_MODS = "Modifications";
            public const string I05_DOORS = "Door Control";
            public const string I06_SPEED_METER = "Speed Meter";
            public const string I07_REPAIR = "Repair Vehicle";
            public const string I08_CLEAN = "Clean Vehicle";
            public const string I09_INVINCIBLE = "Invincible";
            public const string I10_SEAT_BELT = "Seat Belt";
            public const string I11_SPAWN_INTO = "Spawn into Vehicle";
            public const string I12_BOOST = "Speed Boost";

            /// <summary>
            /// Spawn menu
            /// </summary>
            public static class Spawn
            {
                public const string I00_TITLE = "Spawn Vehicle";
            }

            /// <summary>
            /// Custom vehicle menu
            /// </summary>
            public static class CustomVehicle
            {
                public const string I00_TITLE = "Custom Vehicle Options";
                public const string I01_SAVE = "Save Current Vehicle";
                public const string I02_ITEM = "[{0}]";

                /// <summary>
                /// Item menu
                /// </summary>
                public static class Item
                {
                    public const string I00_TITLE = "[{0}]";
                    public const string I01_SPAWN = "Spawn";
                    public const string I02_RENAME = "Rename";
                    public const string I03_OVERWRITE = "Overwrite With Current Vehicle";
                    public const string I04_DELETE = "Delete";
                }
            }

            /// <summary>
            /// Paint menu
            /// </summary>
            public static class Paint
            {
                public const string I00_TITLE = "Choose a Part to Paint";
                public const string I01_PRIMARY = "Primary Color";
                public const string I02_SECONDARY = "Secondary Color";
                public const string I03_PEARL_TOPCOAT = "Pearl Topcoat";
                public const string I04_WHEELS = "Wheels";
                public const string I05_LIVERY = "Liveries ({0})";

                public const string CHOOSE_PAINT_TYPE = "Choose Paint Type";
                public const string CHOOSE_COLOR = "Choose Color";

                /// <summary>
                /// Livery menu
                /// </summary>
                public static class Livery
                {
                    public const string I00_TITLE = "Choose Livery";
                    public const string I01_ITEM = "Livery #{0}";
                }
            }

            /// <summary>
            /// Mod menu
            /// </summary>
            public static class Mod
            {
                public const string I00_TITLE = "Vehicle Mod Options";
                public const string I01_ALL_PERFORMANCE = "Applies All Performance Upgrades";
                public const string I02_ALL_ARMOR = "Applies All Armor Upgrades";
                public const string I03_REMOVE_ALL = "Removes All Upgrades";

                public const string FORMAT_MOD_CATEGORY = "{0} ({1})";
                public const string TURBO_TUNING = "Turbo Tuning";
                public const string TURBO_XEON_LIGHTS = "Turbo Xeon Lights";
                public const string BULLETPROOF_TYRES = "Bulletproof Tyres";
                public const string CUSTOM_TYRES = "Custom Tyres";
                public const string EXTRA = "Extra #{0}";
                public const string SET_PLATE_TEXT = "Set Plate Text";
                public const string NO_AVAILABLE_MOD = "No Available Mod for this Vehicle";
                public const string DEFAULT_WHEEL = "Set to Default Wheel";
                public const string DEFAULT = "Default";
                public const string MOD_ITEM = "{0} Item #{1}";
            }

            /// <summary>
            /// Speed meter menu
            /// </summary>
            public static class SpeedMeter
            {
                public const string I00_TITLE = "Speed Meter Options";
                public const string I01_SHOW = "Show Speed Meter";
                public const string I02_SHOW_IN_METRIC = "Show in Metric";
                public const string I03_SHOW_WITHOUT_VEHICLE = "Show Without Vehicle";
            }

            /// <summary>
            /// Door menu
            /// </summary>
            public static class Door
            {
                public const string I00_TITLE = "Door Control";
                public const string I01_INSTANT_OPEN_CLOSE = "Instant Open/Close";
                public const string I02_FRONT_RIGHT = "Front Right";
                public const string I03_FRONT_LEFT = "Front Left";
                public const string I04_REAR_RIGHT = "Rear Right";
                public const string I05_REAR_LEFT = "Rear Left";
                public const string I06_HOOD = "Hood";
                public const string I07_TRUNK = "Trunk";
                public const string I08_TRUNK2 = "Trunk 2";
            }
        }

        /// <summary>
        /// Weapon menu
        /// </summary>
        public static class Weapon
        {
            public const string I00_TITLE = "Weapon Options";
            public const string I01_GET_ALL_WEAPONS = "Get All Weapons";
            public const string I02_GET_SPECIFIC_WEAPON = "Get Specific Weapon";
            public const string I03_INFINITE_AMMO = "Infinite Ammo";
            public const string I04_PERMANENT_PARACHUTE = "Permanent Parachute";
            public const string I05_NO_RELOAD = "No Reload";
            public const string I06_FIRE_AMMO = "Fire Ammo";
            public const string I07_EXPLOSIVE_AMMO = "Explosive Ammo";
            public const string I08_EXPLOSIVE_MELEE = "Explosive Melee";
            public const string I09_VEHICLE_ROCKETS = "Vehicle Rockets";

            /// <summary>
            /// Specific weapon menu
            /// </summary>
            public static class SpecificWeapon
            {
                public const string I00_TITLE = "Select Weapon Category";

                public const string HAS = "Has this Weapon";
                public const string FILL_AMMO_CLIP = "Fill Ammo & Clip";
                public const string TINT = "Weapon Tint";
                public const string SELECT_TINT = "Select Tint";
            }
        }

        /// <summary>
        /// Time menu
        /// </summary>
        public static class DateTimeSpeed
        {
            public const string I00_TITLE = "Date & Time & Speed Options";
            public const string I01_SET_DATETIME = "Set Date & Time";
            public const string I02_SET_GAME_SPEED = "Set Game Speed";
            public const string I03_SET_AIMING_SPEED = "Set Aiming Speed";
            public const string I04_HOUR_FORWARD = "Hour Forward";
            public const string I05_HOUR_BACKWARD = "Hour Backward";
            public const string I06_DAY_FORWARD = "Day Forward";
            public const string I07_DAY_BACKWARD = "Day Backward";
            public const string I08_SHOW_TIME = "Show Time";
            public const string I09_TIME_PAUSED = "Time Paused";
            public const string I10_SYNC_WITH_SYSTEM = "Sync with System";

            /// <summary>
            /// Set date time menu
            /// </summary>
            public static class SetDateTime
            {
                public const string I00_TITLE = "Set Date & Time";
                public const string I01_YEAR = "Year: {0:0000}";
                public const string I02_MONTH = "Month: {0:00}";
                public const string I03_DAY = "Day: {0:00}";
                public const string I04_HOUR = "Hour: {0:00}";
                public const string I05_MINUTE = "Minute: {0:00}";
                public const string I06_SECOND = "Second: {0:00}";
                public const string I07_SET_TO_CURRENT = "Set to Current";
                public const string I08_SET_TO_SYSTEM = "Set to System";
            }

            /// <summary>
            /// Set game speed menu
            /// </summary>
            public static class SetGameSpeed
            {
                public const string I00_TITLE = "Change Game Speed";
                public const string I01_SPEED = "Speed: {0:#0%}";
                public const string I02_SET_TO_100 = "Set to 100%";
                public const string I03_SET_TO_75 = "Set to 75%";
                public const string I04_SET_TO_50 = "Set to 50%";
                public const string I05_SET_TO_25 = "Set to 25%";
                public const string I06_SET_TO_10 = "Set to 10%";
                public const string I07_SET_TO_0 = "Set to 0%";
            }

            /// <summary>
            /// Set aiming speed menu
            /// </summary>
            public static class SetAimingSpeed
            {
                public const string I00_TITLE = "Change Aiming Speed";
                public const string I01_SPEED = "Speed: {0:#0%}";
                public const string I02_SET_TO_100 = "Set to 100%";
                public const string I03_SET_TO_75 = "Set to 75%";
                public const string I04_SET_TO_50 = "Set to 50%";
                public const string I05_SET_TO_25 = "Set to 25%";
                public const string I06_SET_TO_10 = "Set to 10%";
                public const string I07_SET_TO_0 = "Set to 0%";
            }

        }

        /// <summary>
        /// World menu
        /// </summary>
        public static class World
        {
            public const string I00_TITLE = "World Options";
            public const string I01_MOON_GRAVITY = "Moon Gravity";
            public const string I02_RANDOM_COPS = "Random Cops";
            public const string I03_RANDOM_TRAINS = "Random Trains";
            public const string I04_RANDOM_BOATS = "Random Boats";
            public const string I05_GARBAGE_TRUCKS = "Garbage Trucks";
            public const string I06_RESTRICTED_ZONES = "Restricted Zones";
        }

        /// <summary>
        /// Weather menu
        /// </summary>
        public static class Weather
        {
            public const string I00_TITLE = "Weather Options";
            public const string I01_WIND = "Wind";
            public const string I02_FREEZE_WEATHER = "Freeze Weather";
        }

        /// <summary>
        /// Misc menu
        /// </summary>
        public static class Misc
        {
            public const string I00_TITLE = "Misc Options";
            public const string I01_PORTABLE_RADIO = "Portable Radio";
            public const string I02_HIDE_HUD = "Hide HUD";
            public const string I03_NEXT_RADIO_TRACK = "Next Radio Track";
        }

        /// <summary>
        /// Configuration menu
        /// </summary>
        public static class Configuration
        {
            public const string I00_TITLE = "Configuration Options";
            public const string I01_SAVE = "Save";
            public const string I02_LOAD = "Load";
            public const string I03_AUTO_SAVE = "Auto Save";
        }
    }
}
