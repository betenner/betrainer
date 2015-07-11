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

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Global constants & enumerations
    /// </summary>
    public static class GlobalConst
    {
        /// <summary>
        /// Trainer version
        /// </summary>
        public const string TRAINER_VERSION = "v1.00";

        /// <summary>
        /// Default screen width
        /// </summary>
        public const int DEFAULT_SCREEN_WIDTH = 1920;

        /// <summary>
        /// Default screen height
        /// </summary>
        public const int DEFAULT_SCREEN_HEIGHT = 1080;

        /// <summary>
        /// Comma replacement in serialization
        /// </summary>
        public const string SERIALIZATION_COMMA_REPLACEMENT = "#_C_#";

        /// <summary>
        /// Comma in serializtion
        /// </summary>
        public const string SERIALIZATION_COMMA = ",";

        /// <summary>
        /// Horizontal alignment
        /// </summary>
        public enum HAlign
        {
            Left,
            Center,
            Right,
        }

        /// <summary>
        /// Message text
        /// </summary>
        public static class Message
        {
            public const string PLAYER_HEALED = "Player healed.";
            public const string PLAYER_RESET_SKIN = "Skin reset to default.";
            public const string PLAYER_MODEL_SET = "Model set to {0}.";
            public const string PLAYER_RANDOM_SKIN = "Skin ranomized.";
            public const string PLAYER_RANDOM_PROPS = "Props ranomized.";
            public const string PLAYER_INVALID_NAME = "Invalid name.";
            public const string PLAYER_MSPCS_APPLIED = "MSP custom set applied."; 
            public const string PLAYER_MSPCS_CREATED = "MSP custom set created.";
            public const string PLAYER_MSPCS_DELETED = "MSP custom set deleted.";
            public const string PLAYER_MSPCS_RENAMED = "MSP custom set renamed.";
            public const string PLAYER_MSPCS_OVERWRITTEN = "MSP custom set overwritten.";
            
            public const string TP_NO_MAP_MARKER_FOUND = "No map marker found.";
            public const string TP_MAP_MARKER = "Teleported to map marker.";
            public const string TP_TARGET = "Teleported to target location.";
            public const string TP_SCENERY_LOADED = "Scenery loaded.";
            public const string TP_SCENERY_UNLOADED = "Scenery unloaded.";

            public const string CL_SAVED = "Custom location saved.";
            public const string CL_TELEPORTED = "Teleported to custom location.";
            public const string CL_RENAMED = "Custom location renamed.";
            public const string CL_OVERWRITTEN = "Custom location overwritten.";
            public const string CL_DELETED = "Custom location deleted.";

            public const string XYZ_TELEPORTED = "Teleported.";
            public const string XYZ_RANDOM_TELEPORTED = "Teleported to a random location.";

            public const string VEHICLE_NOT_IN_VEHICLE = "Player isn't in a vehicle.";
            public const string VEHICLE_SPAWNED = "{0} spawned.";
            public const string VEHICLE_REPAIRED = "Vehicle repaired.";
            public const string VEHICLE_CLEANED = "Vehicle cleaned.";

            public const string VP_NO_PEARL = "Pearl topcoat can't be applied to current paint type.";
            public const string VP_NO_WHEEL = "Can't change the color of the default wheel.";

            public const string VM_ALL_PERFORMANCE = "Applied all performance upgrades.";
            public const string VM_ALL_ARMOR = "Applied all armor upgrades.";
            public const string VM_REMOVE_ALL = "Removed all upgrades.";
            public const string VM_APPLIED = "{0} applied.";
            public const string VM_WINDOW_TINT_CHANGED = "Window tint changed.";
            public const string VM_LICENSE_PLATE_CHANGED = "License plate changed.";
            public const string VM_WHEEL_CATEGORY_CHANGED = "Wheel category changed.";
            public const string VM_WHEELS_CHANGED = "Wheels changed.";
            public const string VM_TYRES_CHANGED = "Tyres changed.";

            public const string CV_SPAWN = "Custom vehicle spawned.";
            public const string CV_SAVED = "Custom vehicle saved.";
            public const string CV_RENAMED = "Custom vehicle renamed.";
            public const string CV_OVERWRITTEN = "Custom vehicle overwritten.";
            public const string CV_DELETED = "Custom vehicle deleted.";
            public const string CV_CV = "Custom vehicle";
            public const string CV_SPAWN_FAILED = "Custom vehicle spawn failed.";

            public const string WEAPON_ALL = "All weapons acquired.";

            public const string WEATHER_SET = "Weather set to {0}.";

            public const string TRAINER_INITIALIZING = "BE Trainer.NET " + TRAINER_VERSION + " initializing...";
            public const string TRAINER_INITIALIZED = "BE Trainer.NET " + TRAINER_VERSION + " initialized.";
            
            public const string CONFIGURATION_CREATING = "Configuration not found, creating a new one...";
            public const string CONFIGURATION_SAVED = "Configuration saved.";
            public const string CONFIGURATION_LOADED = "Configuration loaded.";
            public const string CONFIGURATION_MSPCS_SAVED = "MSP custom sets saved.";
            
        }
    }
}
