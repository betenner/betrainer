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
            public static readonly MLString I00_TITLE = GlobalConst.TRAINER_NAME + " " + GlobalConst.TRAINER_VERSION;
            public static readonly MLString I01_PLAYER = Utils.CTML("Player", "玩家");
            public static readonly MLString I02_LOCATION = Utils.CTML("Location", "地點");
            public static readonly MLString I03_VEHICLE = Utils.CTML("Vehicle", "載具");
            public static readonly MLString I04_WEAPON = Utils.CTML("Weapon", "武器");
            public static readonly MLString I05_DATE_TIME_SPEED = Utils.CTML("Date & Time & Speed", "日期時間與速度");
            public static readonly MLString I06_WORLD = Utils.CTML("World", "世界");
            public static readonly MLString I07_WEATHER = Utils.CTML("Weather", "天氣");
            public static readonly MLString I08_MISC = Utils.CTML("Misc", "其他");
            public static readonly MLString I09_CONFIGURATION = Utils.CTML("Configuration", "配置");
            public static readonly MLString I10_LANGUAGE = "Language / 語言";
        }

        /// <summary>
        /// Player menu
        /// </summary>
        public static class Player
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Player Options", "玩家選項");
            public static readonly MLString I01_MODEL_SKIN_PROPS = Utils.CTML("Model & Skin & Props", "外觀");
            public static readonly MLString I02_WANTED = Utils.CTML("Wanted", "通緝");
            public static readonly MLString I03_CASH = Utils.CTML("Cash {0}${1:#,0}", "現金 {0}${1:#,0}");
            public static readonly MLString I04_HEAL = Utils.CTML("Quick Heal", "快速治癒");
            public static readonly MLString I05_INVINCIBLE = Utils.CTML("Invincible", "無敵");
            public static readonly MLString I06_INFINITE_ABILITY = Utils.CTML("Infinite Ability", "無限能力");
            public static readonly MLString I07_FAST_RUN = Utils.CTML("Fast Run", "快速移動");
            public static readonly MLString I08_FAST_SWIM = Utils.CTML("Fast Swim", "快速游泳");
            public static readonly MLString I09_SUPER_JUMP = Utils.CTML("Super Jump", "超級跳");
            public static readonly MLString I10_NOISELESS = Utils.CTML("Noiseless", "無聲模式");

            /// <summary>
            /// Wanted menu
            /// </summary>
            public static class Wanted
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Wanted Options", "通緝選項");
                public static readonly MLString I01_NEVER_WANTED = Utils.CTML("Never Wanted", "永不通緝");
                public static readonly MLString I02_POLICE_IGNORED = Utils.CTML("Police Ignores Me", "被警察忽略");
                public static readonly MLString I03_EVERYONE_IGNORED = Utils.CTML("Everyone Ignores Me", "被所有人忽略");
                public static readonly MLString I04_WANTED_UP = Utils.CTML("Wanted Level Up", "提高通緝等級");
                public static readonly MLString I05_WANTED_DOWN = Utils.CTML("Wanted Level Down", "降低通緝等級");
            }

            /// <summary>
            /// Model & Skin & Props menu
            /// </summary>
            public static class ModelSkinProps
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Model & Skin & Props", "外觀設置");
                public static readonly MLString I01_CUSTOM_SETS = Utils.CTML("Custom Sets", "自定義方案");
                public static readonly MLString I02_SET_MODEL = Utils.CTML("Set Model", "設置模型");
                public static readonly MLString I03_SET_SKIN = Utils.CTML("Set Skin", "設置皮膚");
                public static readonly MLString I04_SET_PROPS = Utils.CTML("Set Props", "設置飾品");
                public static readonly MLString I05_RANDOM_MODEL = Utils.CTML("Random Model", "隨機模型");
                public static readonly MLString I06_RANDOM_SKIN = Utils.CTML("Random Skin", "隨機皮膚");
                public static readonly MLString I07_RANDOM_PROPS = Utils.CTML("Random Props", "隨機飾品");
                public static readonly MLString I08_RESET_SKIN = Utils.CTML("Reset Skin", "重置皮膚");
                public static readonly MLString I09_CLEAR_PROPS = Utils.CTML("Clear Props", "清除飾品");

                /// <summary>
                /// Custom sets menu
                /// </summary>
                public static class CustomSet
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Custom Sets", "自定義方案");
                    public static readonly MLString I01_CREATE = Utils.CTML("Create New Set", "創建新方案");

                    /// <summary>
                    /// Item menu
                    /// </summary>
                    public static class Item
                    {
                        public static readonly MLString I01_APPLY = Utils.CTML("Apply", "應用");
                        public static readonly MLString I02_RENAME = Utils.CTML("Rename", "重命名");
                        public static readonly MLString I03_OVERWRITE = Utils.CTML("Overwrite with Current", "用當前外觀覆蓋");
                        public static readonly MLString I04_DELETE = Utils.CTML("Delete", "刪除");
                    }
                }

                /// <summary>
                /// Model selector menu
                /// </summary>
                public static class ModelSelector
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Model Selector", "模型選擇");
                    public static readonly MLString I01_MICHAEL = Utils.CTML("Michael", "麥可");
                    public static readonly MLString I02_FRANKLIN = Utils.CTML("Franklin", "富蘭克林");
                    public static readonly MLString I03_TREVOR = Utils.CTML("Trevor", "崔佛");
                    public static readonly MLString I04_ANIMALS = Utils.CTML("Animals", "動物");
                    public static readonly MLString I05_NPCS = Utils.CTML("NPCs", "人物");
                    public static readonly MLString I06_RANDOM = Utils.CTML("Random", "隨機");

                    /// <summary>
                    /// Model selector animals menu
                    /// </summary>
                    public static class Animals
                    {
                        public static readonly MLString I00_TITLE = Utils.CTML("Model Selector - Animals", "模型選擇 - 動物");
                    }

                    /// <summary>
                    /// Model selector NPCs menu
                    /// </summary>
                    public static class NPCs
                    {
                        public static readonly MLString I00_TITLE = Utils.CTML("Model Selector - NPCs", "模型選擇 - 人物");
                    }
                }

                /// <summary>
                /// Skin categories menu
                /// </summary>
                public static class SkinCategories
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Skin Categories", "皮膚類別");
                    public static readonly MLString I01_SLOT = Utils.CTML("Slot {0}: {1} ({2})", "位置 {0}: {1} ({2})");
                    public static readonly MLString I02_NO_AVAILABLE_SLOT = Utils.CTML("No Available Slot", "沒有可用的位置");

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class DrawableSelector
                    {
                        public static readonly MLString I00_TITLE = Utils.CTML("Drawable Selector", "樣式選擇");
                        public static readonly MLString I01_DRAWABLE = Utils.CTML("Drawable #{0} ({1})", "樣式 #{0} ({1})");

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public static readonly MLString I00_TITLE = Utils.CTML("Texture Selector", "紋理選擇");
                            public static readonly MLString I01_TEXTURE = Utils.CTML("Texture #{0}", "紋理 #{0}");
                        }
                    }
                }

                /// <summary>
                /// Props categories menu
                /// </summary>
                public static class PropCategories
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Prop Categories", "飾品類別");
                    public static readonly MLString I01_SLOT = Utils.CTML("Slot {0}: {1} ({2})", "位置 {0}: {1} ({2})");
                    public static readonly MLString I02_NO_AVAILABLE_SLOT = Utils.CTML("No Available Slot", "沒有可用的位置");

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class PropsSelector
                    {
                        public static readonly MLString I00_TITLE = Utils.CTML("Prop Selector", "飾品選擇");
                        public static readonly MLString I01_NOTHING = Utils.CTML("Nothing", "無");
                        public static readonly MLString I02_PROP = Utils.CTML("Prop #{0} ({1})", "飾品 #{0} ({1})");

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public static readonly MLString I00_TITLE = Utils.CTML("Texture Selector", "紋理選擇");
                            public static readonly MLString I01_TEXTURE = Utils.CTML("Texture #{0}", "紋理 #{0}");
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
            public static readonly MLString I00_TITLE = Utils.CTML("Location Options", "地點選項");
            public static readonly MLString I01_LOCATION_TELEPORTER = Utils.CTML("Location Teleporter", "預設地點傳送");
            public static readonly MLString I02_CUSTOM_LOCATION_TELEPORTER = Utils.CTML("Custom Location Teleporter", "自定義地點傳送");
            public static readonly MLString I03_XYZ_TELEPORTER = Utils.CTML("XYZ Teleporter", "座標傳送");
            public static readonly MLString I04_SHOW_COORDINATE = Utils.CTML("Show Coordinates", "顯示座標");

            /// <summary>
            /// Location teleporter menu
            /// </summary>
            public static class LocationTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Location Teleporter", "預設地點傳送");
                public static readonly MLString I01_MAP_MARKER = Utils.CTML("Map Marker", "地圖標記");
                public static readonly MLString I02_SAFEHOUSES = Utils.CTML("Safehouses", "主角的家");
                public static readonly MLString I03_LANDMARKS = Utils.CTML("Landmarks", "地標建築");
                public static readonly MLString I04_ROOF_HIGH = Utils.CTML("Roof & High Places", "至高點");
                public static readonly MLString I05_UNDERWATER = Utils.CTML("Underwater Places", "水下");
                public static readonly MLString I06_INTERIORS = Utils.CTML("Interiors", "室內");
                public static readonly MLString I07_SPECIALS = Utils.CTML("Special Places", "特殊地點");
                public static readonly MLString I08_STUNT_JUMPS = Utils.CTML("Stunt Jumps", "飛車跳躍點");
                public static readonly MLString I09_SPACESHIP_PARTS = Utils.CTML("Spaceship Parts", "外星飛船碎片");
                public static readonly MLString I10_LETTER_SCRAPS = Utils.CTML("Letter Scraps", "信件碎片");
            }

            /// <summary>
            /// Custom location teleporter menu
            /// </summary>
            public static class CustomLocationTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Custom Location Teleporter", "自定義地點傳送");
                public static readonly MLString I01_SAVE = Utils.CTML("Save Current Location", "保存當前地點");

                /// <summary>
                /// Custom loactoin teleporter item menu
                /// </summary>
                public static class Item
                {
                    public static readonly MLString I01_TELEPORT = Utils.CTML("Teleport", "傳送");
                    public static readonly MLString I02_RENAME = Utils.CTML("Rename", "重命名");
                    public static readonly MLString I03_OVERWRITE = Utils.CTML("Overwrite With Current Location", "使用當前地點覆蓋");
                    public static readonly MLString I04_DELETE = Utils.CTML("Delete", "刪除");
                }
            }

            /// <summary>
            /// XYZ teleporter menu
            /// </summary>
            public static class XyzTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CTML("XYZ Teleporter", "座標傳送");
                public static readonly MLString I01_OFFSET = Utils.CTML("Teleport by Offsets", "偏移量傳送");
                public static readonly MLString I02_COORDINATES = Utils.CTML("Teleport to Coordinates", "傳送到指定座標");
                public static readonly MLString I03_RANDOM = Utils.CTML("Teleport to Random Location", "傳送到隨機地點");

                /// <summary>
                /// Teleport by Offsets menu
                /// </summary>
                public static class Offset
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Teleport by Offsets", "偏移量傳送");
                    public static readonly MLString I01_X = "X: {0:#0.000000}";
                    public static readonly MLString I02_Y = "Y: {0:#0.000000}";
                    public static readonly MLString I03_Z = "Z: {0:#0.000000}";
                    public static readonly MLString I04_RESET = Utils.CTML("Reset", "重置");
                    public static readonly MLString I05_TELEPORT = Utils.CTML("Teleport", "傳送");
                }

                /// <summary>
                /// Teleport to coordinates menu
                /// </summary>
                public static class Coordinates
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Ttleport to Coordinates", "傳送到指定座標");
                    public static readonly MLString I01_X = "X: {0:#0.000000}";
                    public static readonly MLString I02_Y = "Y: {0:#0.000000}";
                    public static readonly MLString I03_Z = "Z: {0:#0.000000}";
                    public static readonly MLString I04_RESET = Utils.CTML("Reset to Current Location", "重置為當前座標");
                    public static readonly MLString I05_TELEPORT = Utils.CTML("Teleport", "傳送");
                }
            }
        }

        /// <summary>
        /// Vehicle menu
        /// </summary>
        public static class Vehicle
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Vehicle Options", "載具選項");
            public static readonly MLString I01_SPAWN = Utils.CTML("Spawn Vehicle", "生成載具");
            public static readonly MLString I02_CUSTOM = Utils.CTML("Custom Vehicles", "自定義載具");
            public static readonly MLString I03_PAINT = Utils.CTML("Paints", "噴漆");
            public static readonly MLString I04_MODS = Utils.CTML("Modifications", "改裝");
            public static readonly MLString I05_DOORS = Utils.CTML("Door Control", "門控制");
            public static readonly MLString I06_SPEED_METER = Utils.CTML("Speed Meter", "速度表");
            public static readonly MLString I07_REPAIR = Utils.CTML("Repair Vehicle", "修理載具");
            public static readonly MLString I08_CLEAN = Utils.CTML("Clean Vehicle", "清潔載具");
            public static readonly MLString I09_INVINCIBLE = Utils.CTML("Invincible", "無敵");
            public static readonly MLString I10_SEAT_BELT = Utils.CTML("Seat Belt", "安全帶");
            public static readonly MLString I11_SPAWN_INTO = Utils.CTML("Spawn into Vehicle", "生成載具時直接駕駛");
            public static readonly MLString I12_VEHICLE_BOOST = Utils.CTML("Vehicle Boost", "載具加速");

            /// <summary>
            /// Vehicle boost menu
            /// </summary>
            public static class VehicleBoost
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Vehicle Boost", "載具加速");
                public static readonly MLString I01_BOOST_PROGRESSIVE = Utils.CTML("Progressive Boost", "漸進加速");
                public static readonly MLString I02_BOOST_PROGRESSIVE_SPEED_INC = Utils.CTML("Progressive Boost Speed Increment: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)", "漸進加速倍率: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)");
                public static readonly MLString I03_BOOST_INSTANT = Utils.CTML("Instant Boost", "瞬間加速");
                public static readonly MLString I04_BOOST_INSTANT_SPEED = Utils.CTML("Instant Boost Speed: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)", "瞬間加速速度: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)");
            }

            /// <summary>
            /// Spawn menu
            /// </summary>
            public static class Spawn
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Spawn Vehicle", "生成載具");
            }

            /// <summary>
            /// Custom vehicle menu
            /// </summary>
            public static class CustomVehicle
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Custom Vehicle Options", "自定義載具");
                public static readonly MLString I01_SAVE = Utils.CTML("Save Current Vehicle", "保存當前載具");
                public static readonly MLString I02_ITEM = "[{0}]";

                /// <summary>
                /// Item menu
                /// </summary>
                public static class Item
                {
                    public static readonly MLString I00_TITLE = "[{0}]";
                    public static readonly MLString I01_SPAWN = Utils.CTML("Spawn", "生成");
                    public static readonly MLString I02_RENAME = Utils.CTML("Rename", "重命名");
                    public static readonly MLString I03_OVERWRITE = Utils.CTML("Overwrite With Current Vehicle", "使用當前載具覆蓋");
                    public static readonly MLString I04_DELETE = Utils.CTML("Delete", "刪除");
                }
            }

            /// <summary>
            /// Paint menu
            /// </summary>
            public static class Paint
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Choose a Part to Paint", "選擇要噴漆的部位");
                public static readonly MLString I01_PRIMARY = Utils.CTML("Primary Color", "主顏色");
                public static readonly MLString I02_SECONDARY = Utils.CTML("Secondary Color", "副顏色");
                public static readonly MLString I03_PEARL_TOPCOAT = Utils.CTML("Pearl Topcoat", "高亮層");
                public static readonly MLString I04_WHEELS = Utils.CTML("Wheels", "輪子");
                public static readonly MLString I05_LIVERY = Utils.CTML("Liveries ({0})", "車身圖案 ({0})");

                public static readonly MLString CHOOSE_PAINT_TYPE = Utils.CTML("Choose Paint Type", "選擇噴漆類型");
                public static readonly MLString CHOOSE_COLOR = Utils.CTML("Choose Color", "選擇顏色");

                /// <summary>
                /// Livery menu
                /// </summary>
                public static class Livery
                {
                    public static readonly MLString I00_TITLE = Utils.CTML("Choose Livery", "選擇圖案");
                    public static readonly MLString I01_ITEM = Utils.CTML("Livery #{0}", "圖案 #{0}");
                }
            }

            /// <summary>
            /// Mod menu
            /// </summary>
            public static class Mod
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Vehicle Mod Options", "載具改裝選項");
                public static readonly MLString I01_ALL_PERFORMANCE = Utils.CTML("Applies All Performance Upgrades", "升級所有性能改裝");
                public static readonly MLString I02_ALL_ARMOR = Utils.CTML("Applies All Armor Upgrades", "升級所有護甲改裝");
                public static readonly MLString I03_REMOVE_ALL = Utils.CTML("Removes All Upgrades", "移除所有升級改裝");

                public static readonly MLString FORMAT_MOD_CATEGORY = "{0} ({1})";
                public static readonly MLString TURBO_TUNING = Utils.CTML("Turbo Tuning", "渦輪調教");
                public static readonly MLString TURBO_XEON_LIGHTS = Utils.CTML("Turbo Xeon Lights", "高亮氙燈");
                public static readonly MLString BULLETPROOF_TYRES = Utils.CTML("Bulletproof Tyres", "防彈輪胎");
                public static readonly MLString CUSTOM_TYRES = Utils.CTML("Custom Tyres", "自定義輪胎");
                public static readonly MLString EXTRA = Utils.CTML("Extra #{0}", "配件 #{0}");
                public static readonly MLString SET_PLATE_TEXT = Utils.CTML("Set Plate Text", "設置車牌號");
                public static readonly MLString NO_AVAILABLE_MOD = Utils.CTML("No Available Mod for this Vehicle", "該載具沒有可用的改裝");
                public static readonly MLString DEFAULT_WHEEL = Utils.CTML("Set to Default Wheel", "設為默認輪胎");
                public static readonly MLString DEFAULT = Utils.CTML("Default", "默認");
                public static readonly MLString MOD_ITEM = Utils.CTML("{0} Item #{1}", "{0} 物品 #{1}");
            }

            /// <summary>
            /// Speed meter menu
            /// </summary>
            public static class SpeedMeter
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Speed Meter Options", "速度表選項");
                public static readonly MLString I01_SHOW = Utils.CTML("Show Speed Meter", "顯示速度表");
                public static readonly MLString I02_SHOW_IN_METRIC = Utils.CTML("Show in Metric", "使用公制顯示");
                public static readonly MLString I03_SHOW_WITHOUT_VEHICLE = Utils.CTML("Show Without Vehicle", "不在載具內時顯示");
            }

            /// <summary>
            /// Door menu
            /// </summary>
            public static class Door
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Door Control", "門控制");
                public static readonly MLString I01_INSTANT_OPEN_CLOSE = Utils.CTML("Instant Open/Close", "瞬間打開/關閉");
                public static readonly MLString I02_FRONT_RIGHT = Utils.CTML("Front Right", "右前門");
                public static readonly MLString I03_FRONT_LEFT = Utils.CTML("Front Left", "左前門");
                public static readonly MLString I04_REAR_RIGHT = Utils.CTML("Rear Right", "右後門");
                public static readonly MLString I05_REAR_LEFT = Utils.CTML("Rear Left", "左後門");
                public static readonly MLString I06_HOOD = Utils.CTML("Hood", "引擎蓋");
                public static readonly MLString I07_TRUNK = Utils.CTML("Trunk", "後備箱");
                public static readonly MLString I08_TRUNK2 = Utils.CTML("Trunk 2", "後備箱2");
            }
        }

        /// <summary>
        /// Weapon menu
        /// </summary>
        public static class Weapon
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Weapon Options", "武器選項");
            public static readonly MLString I01_GET_ALL_WEAPONS = Utils.CTML("Get All Weapons", "獲取所有武器");
            public static readonly MLString I02_GET_SPECIFIC_WEAPON = Utils.CTML("Get Specific Weapon", "獲取指定武器");
            public static readonly MLString I03_INFINITE_AMMO = Utils.CTML("Infinite Ammo", "無限彈藥");
            public static readonly MLString I04_PERMANENT_PARACHUTE = Utils.CTML("Permanent Parachute", "永久降落傘");
            public static readonly MLString I05_NO_RELOAD = Utils.CTML("No Reload", "無需裝彈");
            public static readonly MLString I06_FIRE_AMMO = Utils.CTML("Fire Ammo", "火焰子彈");
            public static readonly MLString I07_EXPLOSIVE_AMMO = Utils.CTML("Explosive Ammo", "爆炸子彈");
            public static readonly MLString I08_EXPLOSIVE_MELEE = Utils.CTML("Explosive Melee", "爆炸近戰");
            public static readonly MLString I09_VEHICLE_ROCKETS = Utils.CTML("Vehicle Rockets", "載具火箭彈");

            /// <summary>
            /// Specific weapon menu
            /// </summary>
            public static class SpecificWeapon
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Select Weapon Category", "選擇武器類別");

                public static readonly MLString HAS = Utils.CTML("Has this Weapon", "擁有此武器");
                public static readonly MLString FILL_AMMO_CLIP = Utils.CTML("Fill Ammo & Clip", "填充彈藥");
                public static readonly MLString TINT = Utils.CTML("Weapon Tint", "武器顏色");
                public static readonly MLString SELECT_TINT = Utils.CTML("Select Tint", "選擇顏色");
            }
        }

        /// <summary>
        /// Time menu
        /// </summary>
        public static class DateTimeSpeed
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Date & Time & Speed Options", "日期時間與速度選項");
            public static readonly MLString I01_SET_DATETIME = Utils.CTML("Set Date & Time", "設置日期與時間");
            public static readonly MLString I02_SET_GAME_SPEED = Utils.CTML("Set Game Speed", "設置遊戲速度");
            public static readonly MLString I03_SET_AIMING_SPEED = Utils.CTML("Set Aiming Speed", "設置瞄準時遊戲速度");
            public static readonly MLString I04_HOUR_FORWARD = Utils.CTML("Hour Forward", "快進一小時");
            public static readonly MLString I05_HOUR_BACKWARD = Utils.CTML("Hour Backward", "倒退一小時");
            public static readonly MLString I06_DAY_FORWARD = Utils.CTML("Day Forward", "快進一天");
            public static readonly MLString I07_DAY_BACKWARD = Utils.CTML("Day Backward", "倒退一天");
            public static readonly MLString I08_SHOW_TIME = Utils.CTML("Show Time", "顯示時間");
            public static readonly MLString I09_TIME_PAUSED = Utils.CTML("Time Paused", "時間暫停");
            public static readonly MLString I10_SYNC_WITH_SYSTEM = Utils.CTML("Sync with System", "與系統時間同步");

            /// <summary>
            /// Set date time menu
            /// </summary>
            public static class SetDateTime
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Set Date & Time", "設置日期與時間");
                public static readonly MLString I01_YEAR = Utils.CTML("Year: {0:0000}", "年：{0:0000}");
                public static readonly MLString I02_MONTH = Utils.CTML("Month: {0:00}", "月：{0:00}");
                public static readonly MLString I03_DAY = Utils.CTML("Day: {0:00}", "日：{0:00}");
                public static readonly MLString I04_HOUR = Utils.CTML("Hour: {0:00}", "時：{0:00}");
                public static readonly MLString I05_MINUTE = Utils.CTML("Minute: {0:00}", "分：{0:00}");
                public static readonly MLString I06_SECOND = Utils.CTML("Second: {0:00}", "秒：{0:00}");
                public static readonly MLString I07_SET_TO_CURRENT = Utils.CTML("Set to Current", "設置為當前時間");
                public static readonly MLString I08_SET_TO_SYSTEM = Utils.CTML("Set to System", "設置為系統時間");
            }

            /// <summary>
            /// Set game speed menu
            /// </summary>
            public static class SetGameSpeed
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Change Game Speed", "更改遊戲速度");
                public static readonly MLString I01_SPEED = Utils.CTML("Speed: {0:#0%}", "速度：{0:#0%}");
                public static readonly MLString I02_SET_TO_100 = Utils.CTML("Set to 100%", "設置為100%");
                public static readonly MLString I03_SET_TO_75 = Utils.CTML("Set to 75%", "設置為75%");
                public static readonly MLString I04_SET_TO_50 = Utils.CTML("Set to 50%", "設置為50%");
                public static readonly MLString I05_SET_TO_25 = Utils.CTML("Set to 25%", "設置為25%");
                public static readonly MLString I06_SET_TO_10 = Utils.CTML("Set to 10%", "設置為10%");
                public static readonly MLString I07_SET_TO_0 = Utils.CTML("Set to 0%", "設置為0%");
            }

            /// <summary>
            /// Set aiming speed menu
            /// </summary>
            public static class SetAimingSpeed
            {
                public static readonly MLString I00_TITLE = Utils.CTML("Change Aiming Speed", "更改瞄準時遊戲速度");
                public static readonly MLString I01_SPEED = Utils.CTML("Speed: {0:#0%}", "速度：{0:#0%}");
                public static readonly MLString I02_SET_TO_100 = Utils.CTML("Set to 100%", "設置為100%");
                public static readonly MLString I03_SET_TO_75 = Utils.CTML("Set to 75%", "設置為75%");
                public static readonly MLString I04_SET_TO_50 = Utils.CTML("Set to 50%", "設置為50%");
                public static readonly MLString I05_SET_TO_25 = Utils.CTML("Set to 25%", "設置為25%");
                public static readonly MLString I06_SET_TO_10 = Utils.CTML("Set to 10%", "設置為10%");
                public static readonly MLString I07_SET_TO_0 = Utils.CTML("Set to 0%", "設置為0%");
            }

        }

        /// <summary>
        /// World menu
        /// </summary>
        public static class World
        {
            public static readonly MLString I00_TITLE = Utils.CTML("World Options", "世界選項");
            public static readonly MLString I01_MOON_GRAVITY = Utils.CTML("Moon Gravity", "月球重力");
            public static readonly MLString I02_RANDOM_COPS = Utils.CTML("Random Cops", "隨機警察");
            public static readonly MLString I03_RANDOM_TRAINS = Utils.CTML("Random Trains", "隨機火車");
            public static readonly MLString I04_RANDOM_BOATS = Utils.CTML("Random Boats", "隨機船隻");
            public static readonly MLString I05_GARBAGE_TRUCKS = Utils.CTML("Garbage Trucks", "隨機垃圾車");
            public static readonly MLString I06_RESTRICTED_ZONES = Utils.CTML("Restricted Zones", "禁區");
        }

        /// <summary>
        /// Weather menu
        /// </summary>
        public static class Weather
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Weather Options", "天氣選項");
            public static readonly MLString I01_WIND = Utils.CTML("Wind", "風");
            public static readonly MLString I02_FREEZE_WEATHER = Utils.CTML("Freeze Weather", "凍結天氣");
        }

        /// <summary>
        /// Misc menu
        /// </summary>
        public static class Misc
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Misc Options", "其他選項");
            public static readonly MLString I01_PORTABLE_RADIO = Utils.CTML("Portable Radio", "隨身廣播");
            public static readonly MLString I02_HIDE_HUD = Utils.CTML("Hide HUD", "隱藏介面");
            public static readonly MLString I03_NEXT_RADIO_TRACK = Utils.CTML("Next Radio Track", "下一廣播");
        }

        /// <summary>
        /// Configuration menu
        /// </summary>
        public static class Configuration
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Configuration Options", "配置");
            public static readonly MLString I01_SAVE = Utils.CTML("Save", "保存");
            public static readonly MLString I02_LOAD = Utils.CTML("Load", "加載");
            public static readonly MLString I03_AUTO_SAVE = Utils.CTML("Auto Save", "自動保存");
        }

        /// <summary>
        /// Language menu
        /// </summary>
        public static class Language
        {
            public static readonly MLString I00_TITLE = Utils.CTML("Choose Language", "選擇語言");
            public static readonly MLString I01_ENGLISH = "English";
            public static readonly MLString I02_CHINESE_TRADITIONAL = "繁體中文 (Chinese Traditional)";
        }
    }
}
