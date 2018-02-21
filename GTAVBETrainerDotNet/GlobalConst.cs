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

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Global constants & enumerations
    /// </summary>
    public static class GlobalConst
    {
        /// <summary>
        /// Trainer name
        /// </summary>
        public const string TRAINER_NAME = "BE Trainer.NET";

        /// <summary>
        /// Trainer version
        /// </summary>
        public const string TRAINER_VERSION = "v1.03";

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
            public static readonly MLString PLAYER_HEALED = Utils.CTML("Player healed.", "玩家已被治癒。");
            public static readonly MLString PLAYER_RESET_SKIN = Utils.CTML("Skin reset to default.", "皮膚已重置為默認。");
            public static readonly MLString PLAYER_MODEL_SET = Utils.CTML("Model set to {0}.", "模型更改為“{0}”。");
            public static readonly MLString PLAYER_RANDOM_SKIN = Utils.CTML("Skin ranomized.", "皮膚已隨機。");
            public static readonly MLString PLAYER_RANDOM_PROPS = Utils.CTML("Props ranomized.", "飾品已隨機。");
            public static readonly MLString PLAYER_INVALID_NAME = Utils.CTML("Invalid name.", "非法名稱。");
            public static readonly MLString PLAYER_MSPCS_APPLIED = Utils.CTML("MSP custom set applied.", "外觀方案已應用。"); 
            public static readonly MLString PLAYER_MSPCS_CREATED = Utils.CTML("MSP custom set created.", "外觀方案已創建。");
            public static readonly MLString PLAYER_MSPCS_DELETED = Utils.CTML("MSP custom set deleted.", "外觀方案已刪除。");
            public static readonly MLString PLAYER_MSPCS_RENAMED = Utils.CTML("MSP custom set renamed.", "外觀方案已重命名。");
            public static readonly MLString PLAYER_MSPCS_OVERWRITTEN = Utils.CTML("MSP custom set overwritten.", "外觀方案已覆蓋。");
            
            public static readonly MLString TP_NO_MAP_MARKER_FOUND = Utils.CTML("No map marker found.", "未找到地圖標記。");
            public static readonly MLString TP_MAP_MARKER = Utils.CTML("Teleported to map marker.", "已傳送到地圖標記。");
            public static readonly MLString TP_TARGET = Utils.CTML("Teleported to target location.", "已傳送到目標地點。");
            public static readonly MLString TP_SCENERY_LOADED = Utils.CTML("Scenery loaded.", "場景已加載。");
            public static readonly MLString TP_SCENERY_UNLOADED = Utils.CTML("Scenery unloaded.", "場景已卸載。");

            public static readonly MLString CL_SAVED = Utils.CTML("Custom location saved.", "自定義地點已保存。");
            public static readonly MLString CL_TELEPORTED = Utils.CTML("Teleported to custom location.", "已傳送到自定義地點。");
            public static readonly MLString CL_RENAMED = Utils.CTML("Custom location renamed.", "自定義地點已重命名。");
            public static readonly MLString CL_OVERWRITTEN = Utils.CTML("Custom location overwritten.", "自定義地點已覆蓋。");
            public static readonly MLString CL_DELETED = Utils.CTML("Custom location deleted.", "自定義地點已刪除。");

            public static readonly MLString XYZ_TELEPORTED = Utils.CTML("Teleported.", "已傳送。");
            public static readonly MLString XYZ_RANDOM_TELEPORTED = Utils.CTML("Teleported to a random location.", "已傳送到隨機地點。");

            public static readonly MLString VEHICLE_NOT_IN_VEHICLE = Utils.CTML("Player isn't in a vehicle.", "玩家沒有在載具內。");
            public static readonly MLString VEHICLE_SPAWNED = Utils.CTML("{0} spawned.", "“{0}”已生成。");
            public static readonly MLString VEHICLE_REPAIRED = Utils.CTML("Vehicle repaired.", "載具已修復。");
            public static readonly MLString VEHICLE_CLEANED = Utils.CTML("Vehicle cleaned.", "載具已清潔。");

            public static readonly MLString VP_NO_PEARL = Utils.CTML("Pearl topcoat can't be applied to current paint type.", "當前噴漆種類無法應用高亮層");
            public static readonly MLString VP_NO_WHEEL = Utils.CTML("Can't change the color of the default wheel.", "默認輪胎無法更改顏色。");

            public static readonly MLString VM_ALL_PERFORMANCE = Utils.CTML("Applied all performance upgrades.", "所有性能項目已升級。");
            public static readonly MLString VM_ALL_ARMOR = Utils.CTML("Applied all armor upgrades.", "所有護甲項目已升級。");
            public static readonly MLString VM_REMOVE_ALL = Utils.CTML("Removed all upgrades.", "已移除所有升級項目。");
            public static readonly MLString VM_APPLIED = Utils.CTML("{0} applied.", "“{0}”已應用。");
            public static readonly MLString VM_WINDOW_TINT_CHANGED = Utils.CTML("Window tint changed.", "窗戶貼膜顏色已更改。");
            public static readonly MLString VM_LICENSE_PLATE_CHANGED = Utils.CTML("License plate changed.", "車牌號已更改。");
            public static readonly MLString VM_WHEEL_CATEGORY_CHANGED = Utils.CTML("Wheel category changed.", "輪子種類已更改。");
            public static readonly MLString VM_WHEELS_CHANGED = Utils.CTML("Wheels changed.", "輪子已更改。");
            public static readonly MLString VM_TYRES_CHANGED = Utils.CTML("Tyres changed.", "輪胎已更改。");

            public static readonly MLString CV_SPAWN = Utils.CTML("Custom vehicle spawned.", "自定義載具已生成。");
            public static readonly MLString CV_SAVED = Utils.CTML("Custom vehicle saved.", "自定義載具已保存。");
            public static readonly MLString CV_RENAMED = Utils.CTML("Custom vehicle renamed.", "自定義載具已重命名。");
            public static readonly MLString CV_OVERWRITTEN = Utils.CTML("Custom vehicle overwritten.", "自定義載具已覆蓋。");
            public static readonly MLString CV_DELETED = Utils.CTML("Custom vehicle deleted.", "自定義載具已刪除。");
            public static readonly MLString CV_CV = Utils.CTML("Custom vehicle", "自定義載具");
            public static readonly MLString CV_SPAWN_FAILED = Utils.CTML("Custom vehicle spawn failed.", "生成自定義載具失敗。");

            public static readonly MLString WEAPON_ALL = Utils.CTML("All weapons acquired.", "已獲得所有武器。");

            public static readonly MLString WEATHER_SET = Utils.CTML("Weather set to {0}.", "天氣已更改為“{0}”。");

            public static readonly MLString TRAINER_INITIALIZING = Utils.CTML(TRAINER_NAME + " " + TRAINER_VERSION + " initializing...", TRAINER_NAME + " " + TRAINER_VERSION + " 初始化中...");
            public static readonly MLString TRAINER_INITIALIZED = Utils.CTML(TRAINER_NAME + " " + TRAINER_VERSION + " initializing...", TRAINER_NAME + " " + TRAINER_VERSION + " 初始化完成。");
            
            public static readonly MLString CONFIGURATION_CREATING = Utils.CTML("Configuration not found, creating a new one...", "未發現配置文件，生成中...");
            public static readonly MLString CONFIGURATION_SAVED = Utils.CTML("Configuration saved.", "配置文件已保存。");
            public static readonly MLString CONFIGURATION_LOADED = Utils.CTML("Configuration loaded.", "配置文件已加載。");
            public static readonly MLString CONFIGURATION_MSPCS_SAVED = Utils.CTML("MSP custom sets saved.", "外觀方案已保存。");
            
        }
    }
}
