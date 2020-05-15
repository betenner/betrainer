//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015-2020
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

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
            public static readonly MLString I01_PLAYER = Utils.CSML("Player", "玩家");
            public static readonly MLString I02_LOCATION = Utils.CSML("Location", "地点");
            public static readonly MLString I03_VEHICLE = Utils.CSML("Vehicle", "载具");
            public static readonly MLString I04_WEAPON = Utils.CSML("Weapon", "武器");
            public static readonly MLString I05_DATE_TIME_SPEED = Utils.CSML("Date & Time & Speed", "日期时间与速度");
            public static readonly MLString I06_WORLD = Utils.CSML("World", "世界");
            public static readonly MLString I07_WEATHER = Utils.CSML("Weather", "天气");
            public static readonly MLString I08_MISC = Utils.CSML("Misc", "其他");
            public static readonly MLString I09_CONFIGURATION = Utils.CSML("Configuration", "配置");
            public static readonly MLString I10_LANGUAGE = "Language / 语言";
        }

        /// <summary>
        /// Player menu
        /// </summary>
        public static class Player
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Player Options", "玩家选项");
            public static readonly MLString I01_MODEL_SKIN_PROPS = Utils.CSML("Model & Skin & Props", "外观");
            public static readonly MLString I02_WANTED = Utils.CSML("Wanted", "通缉");
            public static readonly MLString I03_CASH = Utils.CSML("Cash {0}${1:#,0}", "现金 {0}${1:#,0}");
            public static readonly MLString I04_HEAL = Utils.CSML("Quick Heal", "快速治愈");
            public static readonly MLString I05_INVINCIBLE = Utils.CSML("Invincible", "无敌");
            public static readonly MLString I06_INFINITE_ABILITY = Utils.CSML("Infinite Ability", "无限能力");
            public static readonly MLString I07_FAST_RUN = Utils.CSML("Fast Run", "快速移动");
            public static readonly MLString I08_FAST_SWIM = Utils.CSML("Fast Swim", "快速游泳");
            public static readonly MLString I09_SUPER_JUMP = Utils.CSML("Super Jump", "超级跳");
            public static readonly MLString I10_NOISELESS = Utils.CSML("Noiseless", "无声模式");

            /// <summary>
            /// Wanted menu
            /// </summary>
            public static class Wanted
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Wanted Options", "通缉选项");
                public static readonly MLString I01_NEVER_WANTED = Utils.CSML("Never Wanted", "永不通缉");
                public static readonly MLString I02_POLICE_IGNORED = Utils.CSML("Police Ignores Me", "被警察忽略");
                public static readonly MLString I03_EVERYONE_IGNORED = Utils.CSML("Everyone Ignores Me", "被所有人忽略");
                public static readonly MLString I04_WANTED_UP = Utils.CSML("Wanted Level Up", "提高通缉等级");
                public static readonly MLString I05_WANTED_DOWN = Utils.CSML("Wanted Level Down", "降低通缉等级");
            }

            /// <summary>
            /// Model & Skin & Props menu
            /// </summary>
            public static class ModelSkinProps
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Model & Skin & Props", "外观设置");
                public static readonly MLString I01_CUSTOM_SETS = Utils.CSML("Custom Sets", "自定义方案");
                public static readonly MLString I02_SET_MODEL = Utils.CSML("Set Model", "设置模型");
                public static readonly MLString I03_SET_SKIN = Utils.CSML("Set Skin", "设置皮肤");
                public static readonly MLString I04_SET_PROPS = Utils.CSML("Set Props", "设置饰品");
                public static readonly MLString I05_RANDOM_MODEL = Utils.CSML("Random Model", "随机模型");
                public static readonly MLString I06_RANDOM_SKIN = Utils.CSML("Random Skin", "随机皮肤");
                public static readonly MLString I07_RANDOM_PROPS = Utils.CSML("Random Props", "随机饰品");
                public static readonly MLString I08_RESET_SKIN = Utils.CSML("Reset Skin", "重置皮肤");
                public static readonly MLString I09_CLEAR_PROPS = Utils.CSML("Clear Props", "清除饰品");

                /// <summary>
                /// Custom sets menu
                /// </summary>
                public static class CustomSet
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Custom Sets", "自定义方案");
                    public static readonly MLString I01_CREATE = Utils.CSML("Create New Set", "创建新方案");

                    /// <summary>
                    /// Item menu
                    /// </summary>
                    public static class Item
                    {
                        public static readonly MLString I01_APPLY = Utils.CSML("Apply", "应用");
                        public static readonly MLString I02_RENAME = Utils.CSML("Rename", "重命名");
                        public static readonly MLString I03_OVERWRITE = Utils.CSML("Overwrite with Current", "用当前外观覆盖");
                        public static readonly MLString I04_DELETE = Utils.CSML("Delete", "删除");
                    }
                }

                /// <summary>
                /// Model selector menu
                /// </summary>
                public static class ModelSelector
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Model Selector", "模型选择");
                    public static readonly MLString I01_MICHAEL = Utils.CSML("Michael", "麦可");
                    public static readonly MLString I02_FRANKLIN = Utils.CSML("Franklin", "富兰克林");
                    public static readonly MLString I03_TREVOR = Utils.CSML("Trevor", "崔佛");
                    public static readonly MLString I04_ANIMALS = Utils.CSML("Animals", "动物");
                    public static readonly MLString I05_NPCS = Utils.CSML("NPCs", "人物");
                    public static readonly MLString I06_RANDOM = Utils.CSML("Random", "随机");

                    /// <summary>
                    /// Model selector animals menu
                    /// </summary>
                    public static class Animals
                    {
                        public static readonly MLString I00_TITLE = Utils.CSML("Model Selector - Animals", "模型选择 - 动物");
                    }

                    /// <summary>
                    /// Model selector NPCs menu
                    /// </summary>
                    public static class NPCs
                    {
                        public static readonly MLString I00_TITLE = Utils.CSML("Model Selector - NPCs", "模型选择 - 人物");
                    }
                }

                /// <summary>
                /// Skin categories menu
                /// </summary>
                public static class SkinCategories
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Skin Categories", "皮肤类别");
                    public static readonly MLString I01_SLOT = Utils.CSML("Slot {0}: {1} ({2})", "位置 {0}: {1} ({2})");
                    public static readonly MLString I02_NO_AVAILABLE_SLOT = Utils.CSML("No Available Slot", "没有可用的位置");

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class DrawableSelector
                    {
                        public static readonly MLString I00_TITLE = Utils.CSML("Drawable Selector", "样式选择");
                        public static readonly MLString I01_DRAWABLE = Utils.CSML("Drawable #{0} ({1})", "样式 #{0} ({1})");

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public static readonly MLString I00_TITLE = Utils.CSML("Texture Selector", "纹理选择");
                            public static readonly MLString I01_TEXTURE = Utils.CSML("Texture #{0}", "纹理 #{0}");
                        }
                    }
                }

                /// <summary>
                /// Props categories menu
                /// </summary>
                public static class PropCategories
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Prop Categories", "饰品类别");
                    public static readonly MLString I01_SLOT = Utils.CSML("Slot {0}: {1} ({2})", "位置 {0}: {1} ({2})");
                    public static readonly MLString I02_NO_AVAILABLE_SLOT = Utils.CSML("No Available Slot", "没有可用的位置");

                    /// <summary>
                    /// Drawable selector menu
                    /// </summary>
                    public static class PropsSelector
                    {
                        public static readonly MLString I00_TITLE = Utils.CSML("Prop Selector", "饰品选择");
                        public static readonly MLString I01_NOTHING = Utils.CSML("Nothing", "无");
                        public static readonly MLString I02_PROP = Utils.CSML("Prop #{0} ({1})", "饰品 #{0} ({1})");

                        /// <summary>
                        /// Texture selector menu
                        /// </summary>
                        public static class TextureSelector
                        {
                            public static readonly MLString I00_TITLE = Utils.CSML("Texture Selector", "纹理选择");
                            public static readonly MLString I01_TEXTURE = Utils.CSML("Texture #{0}", "纹理 #{0}");
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
            public static readonly MLString I00_TITLE = Utils.CSML("Location Options", "地点选项");
            public static readonly MLString I01_LOCATION_TELEPORTER = Utils.CSML("Location Teleporter", "预设地点传送");
            public static readonly MLString I02_CUSTOM_LOCATION_TELEPORTER = Utils.CSML("Custom Location Teleporter", "自定义地点传送");
            public static readonly MLString I03_XYZ_TELEPORTER = Utils.CSML("XYZ Teleporter", "坐标传送");
            public static readonly MLString I04_SHOW_COORDINATE = Utils.CSML("Show Coordinates", "显示坐标");

            /// <summary>
            /// Location teleporter menu
            /// </summary>
            public static class LocationTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Location Teleporter", "预设地点传送");
                public static readonly MLString I01_MAP_MARKER = Utils.CSML("Map Marker", "地图标记");
                public static readonly MLString I02_SAFEHOUSES = Utils.CSML("Safehouses", "主角的家");
                public static readonly MLString I03_LANDMARKS = Utils.CSML("Landmarks", "地标建筑");
                public static readonly MLString I04_ROOF_HIGH = Utils.CSML("Roof & High Places", "至高点");
                public static readonly MLString I05_UNDERWATER = Utils.CSML("Underwater Places", "水下");
                public static readonly MLString I06_INTERIORS = Utils.CSML("Interiors", "室内");
                public static readonly MLString I07_SPECIALS = Utils.CSML("Special Places", "特殊地点");
                public static readonly MLString I08_STUNT_JUMPS = Utils.CSML("Stunt Jumps", "飞车跳跃点");
                public static readonly MLString I09_SPACESHIP_PARTS = Utils.CSML("Spaceship Parts", "外星飞船碎片");
                public static readonly MLString I10_LETTER_SCRAPS = Utils.CSML("Letter Scraps", "信件碎片");
            }

            /// <summary>
            /// Custom location teleporter menu
            /// </summary>
            public static class CustomLocationTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Custom Location Teleporter", "自定义地点传送");
                public static readonly MLString I01_SAVE = Utils.CSML("Save Current Location", "保存当前地点");

                /// <summary>
                /// Custom loactoin teleporter item menu
                /// </summary>
                public static class Item
                {
                    public static readonly MLString I01_TELEPORT = Utils.CSML("Teleport", "传送");
                    public static readonly MLString I02_RENAME = Utils.CSML("Rename", "重命名");
                    public static readonly MLString I03_OVERWRITE = Utils.CSML("Overwrite With Current Location", "使用当前地点覆盖");
                    public static readonly MLString I04_DELETE = Utils.CSML("Delete", "删除");
                }
            }

            /// <summary>
            /// XYZ teleporter menu
            /// </summary>
            public static class XyzTeleporter
            {
                public static readonly MLString I00_TITLE = Utils.CSML("XYZ Teleporter", "坐标传送");
                public static readonly MLString I01_OFFSET = Utils.CSML("Teleport by Offsets", "偏移量传送");
                public static readonly MLString I02_COORDINATES = Utils.CSML("Teleport to Coordinates", "传送到指定坐标");
                public static readonly MLString I03_RANDOM = Utils.CSML("Teleport to Random Location", "传送到随机地点");

                /// <summary>
                /// Teleport by Offsets menu
                /// </summary>
                public static class Offset
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Teleport by Offsets", "偏移量传送");
                    public static readonly MLString I01_X = "X: {0:#0.000000}";
                    public static readonly MLString I02_Y = "Y: {0:#0.000000}";
                    public static readonly MLString I03_Z = "Z: {0:#0.000000}";
                    public static readonly MLString I04_RESET = Utils.CSML("Reset", "重置");
                    public static readonly MLString I05_TELEPORT = Utils.CSML("Teleport", "传送");
                }

                /// <summary>
                /// Teleport to coordinates menu
                /// </summary>
                public static class Coordinates
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Ttleport to Coordinates", "传送到指定坐标");
                    public static readonly MLString I01_X = "X: {0:#0.000000}";
                    public static readonly MLString I02_Y = "Y: {0:#0.000000}";
                    public static readonly MLString I03_Z = "Z: {0:#0.000000}";
                    public static readonly MLString I04_RESET = Utils.CSML("Reset to Current Location", "重置为当前坐标");
                    public static readonly MLString I05_TELEPORT = Utils.CSML("Teleport", "传送");
                }
            }
        }

        /// <summary>
        /// Vehicle menu
        /// </summary>
        public static class Vehicle
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Vehicle Options", "载具选项");
            public static readonly MLString I01_SPAWN = Utils.CSML("Spawn Vehicle", "生成载具");
            public static readonly MLString I02_CUSTOM = Utils.CSML("Custom Vehicles", "自定义载具");
            public static readonly MLString I03_PAINT = Utils.CSML("Paints", "喷漆");
            public static readonly MLString I04_MODS = Utils.CSML("Modifications", "改装");
            public static readonly MLString I05_DOORS = Utils.CSML("Door Control", "门控制");
            public static readonly MLString I06_SPEED_METER = Utils.CSML("Speed Meter", "速度表");
            public static readonly MLString I07_REPAIR = Utils.CSML("Repair Vehicle", "修理载具");
            public static readonly MLString I08_CLEAN = Utils.CSML("Clean Vehicle", "清洁载具");
            public static readonly MLString I09_INVINCIBLE = Utils.CSML("Invincible", "无敌");
            public static readonly MLString I10_SEAT_BELT = Utils.CSML("Seat Belt", "安全带");
            public static readonly MLString I11_SPAWN_INTO = Utils.CSML("Spawn into Vehicle", "生成载具时直接驾驶");
            public static readonly MLString I12_VEHICLE_BOOST = Utils.CSML("Vehicle Boost", "载具加速");

            /// <summary>
            /// Vehicle boost menu
            /// </summary>
            public static class VehicleBoost
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Vehicle Boost", "载具加速");
                public static readonly MLString I01_BOOST_PROGRESSIVE = Utils.CSML("Progressive Boost", "渐进加速");
                public static readonly MLString I02_BOOST_PROGRESSIVE_SPEED_INC = Utils.CSML("Progressive Boost Speed Increment: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)", "渐进加速倍率: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)");
                public static readonly MLString I03_BOOST_INSTANT = Utils.CSML("Instant Boost", "瞬间加速");
                public static readonly MLString I04_BOOST_INSTANT_SPEED = Utils.CSML("Instant Boost Speed: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)", "瞬间加速速度: {0:#0}m/s ({1:#0.0}km/h, {2:#0.0}mph)");
            }

            /// <summary>
            /// Spawn menu
            /// </summary>
            public static class Spawn
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Spawn Vehicle", "生成载具");
            }

            /// <summary>
            /// Custom vehicle menu
            /// </summary>
            public static class CustomVehicle
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Custom Vehicle Options", "自定义载具");
                public static readonly MLString I01_SAVE = Utils.CSML("Save Current Vehicle", "保存当前载具");
                public static readonly MLString I02_ITEM = "[{0}]";

                /// <summary>
                /// Item menu
                /// </summary>
                public static class Item
                {
                    public static readonly MLString I00_TITLE = "[{0}]";
                    public static readonly MLString I01_SPAWN = Utils.CSML("Spawn", "生成");
                    public static readonly MLString I02_RENAME = Utils.CSML("Rename", "重命名");
                    public static readonly MLString I03_OVERWRITE = Utils.CSML("Overwrite With Current Vehicle", "使用当前载具覆盖");
                    public static readonly MLString I04_DELETE = Utils.CSML("Delete", "删除");
                }
            }

            /// <summary>
            /// Paint menu
            /// </summary>
            public static class Paint
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Choose a Part to Paint", "选择要喷漆的部位");
                public static readonly MLString I01_PRIMARY = Utils.CSML("Primary Color", "主颜色");
                public static readonly MLString I02_SECONDARY = Utils.CSML("Secondary Color", "副颜色");
                public static readonly MLString I03_PEARL_TOPCOAT = Utils.CSML("Pearl Topcoat", "高亮层");
                public static readonly MLString I04_WHEELS = Utils.CSML("Wheels", "轮子");
                public static readonly MLString I05_LIVERY = Utils.CSML("Liveries ({0})", "车身图案 ({0})");

                public static readonly MLString CHOOSE_PAINT_TYPE = Utils.CSML("Choose Paint Type", "选择喷漆类型");
                public static readonly MLString CHOOSE_COLOR = Utils.CSML("Choose Color", "选择颜色");

                /// <summary>
                /// Livery menu
                /// </summary>
                public static class Livery
                {
                    public static readonly MLString I00_TITLE = Utils.CSML("Choose Livery", "选择图案");
                    public static readonly MLString I01_ITEM = Utils.CSML("Livery #{0}", "图案 #{0}");
                }
            }

            /// <summary>
            /// Mod menu
            /// </summary>
            public static class Mod
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Vehicle Mod Options", "载具改装选项");
                public static readonly MLString I01_ALL_PERFORMANCE = Utils.CSML("Applies All Performance Upgrades", "升级所有性能改装");
                public static readonly MLString I02_ALL_ARMOR = Utils.CSML("Applies All Armor Upgrades", "升级所有护甲改装");
                public static readonly MLString I03_REMOVE_ALL = Utils.CSML("Removes All Upgrades", "移除所有升级改装");

                public static readonly MLString FORMAT_MOD_CATEGORY = "{0} ({1})";
                public static readonly MLString TURBO_TUNING = Utils.CSML("Turbo Tuning", "涡轮调教");
                public static readonly MLString TURBO_XEON_LIGHTS = Utils.CSML("Turbo Xeon Lights", "高亮氙灯");
                public static readonly MLString BULLETPROOF_TYRES = Utils.CSML("Bulletproof Tyres", "防弹轮胎");
                public static readonly MLString CUSTOM_TYRES = Utils.CSML("Custom Tyres", "自定义轮胎");
                public static readonly MLString EXTRA = Utils.CSML("Extra #{0}", "配件 #{0}");
                public static readonly MLString SET_PLATE_TEXT = Utils.CSML("Set Plate Text", "设置车牌号");
                public static readonly MLString NO_AVAILABLE_MOD = Utils.CSML("No Available Mod for this Vehicle", "该载具没有可用的改装");
                public static readonly MLString DEFAULT_WHEEL = Utils.CSML("Set to Default Wheel", "设为默认轮胎");
                public static readonly MLString DEFAULT = Utils.CSML("Default", "默认");
                public static readonly MLString MOD_ITEM = Utils.CSML("{0} Item #{1}", "{0} 物品 #{1}");
            }

            /// <summary>
            /// Speed meter menu
            /// </summary>
            public static class SpeedMeter
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Speed Meter Options", "速度表选项");
                public static readonly MLString I01_SHOW = Utils.CSML("Show Speed Meter", "显示速度表");
                public static readonly MLString I02_SHOW_IN_METRIC = Utils.CSML("Show in Metric", "使用公制显示");
                public static readonly MLString I03_SHOW_WITHOUT_VEHICLE = Utils.CSML("Show Without Vehicle", "不在载具内时显示");
            }

            /// <summary>
            /// Door menu
            /// </summary>
            public static class Door
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Door Control", "门控制");
                public static readonly MLString I01_INSTANT_OPEN_CLOSE = Utils.CSML("Instant Open/Close", "瞬间打开/关闭");
                public static readonly MLString I02_FRONT_RIGHT = Utils.CSML("Front Right", "右前门");
                public static readonly MLString I03_FRONT_LEFT = Utils.CSML("Front Left", "左前门");
                public static readonly MLString I04_REAR_RIGHT = Utils.CSML("Rear Right", "右后门");
                public static readonly MLString I05_REAR_LEFT = Utils.CSML("Rear Left", "左后门");
                public static readonly MLString I06_HOOD = Utils.CSML("Hood", "引擎盖");
                public static readonly MLString I07_TRUNK = Utils.CSML("Trunk", "后备箱");
                public static readonly MLString I08_TRUNK2 = Utils.CSML("Trunk 2", "后备箱2");
            }
        }

        /// <summary>
        /// Weapon menu
        /// </summary>
        public static class Weapon
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Weapon Options", "武器选项");
            public static readonly MLString I01_GET_ALL_WEAPONS = Utils.CSML("Get All Weapons", "获取所有武器");
            public static readonly MLString I02_GET_SPECIFIC_WEAPON = Utils.CSML("Get Specific Weapon", "获取指定武器");
            public static readonly MLString I03_INFINITE_AMMO = Utils.CSML("Infinite Ammo", "无限弹药");
            public static readonly MLString I04_PERMANENT_PARACHUTE = Utils.CSML("Permanent Parachute", "永久降落伞");
            public static readonly MLString I05_NO_RELOAD = Utils.CSML("No Reload", "无需装弹");
            public static readonly MLString I06_FIRE_AMMO = Utils.CSML("Fire Ammo", "火焰子弹");
            public static readonly MLString I07_EXPLOSIVE_AMMO = Utils.CSML("Explosive Ammo", "爆炸子弹");
            public static readonly MLString I08_EXPLOSIVE_MELEE = Utils.CSML("Explosive Melee", "爆炸近战");
            public static readonly MLString I09_VEHICLE_ROCKETS = Utils.CSML("Vehicle Rockets", "载具火箭弹");

            /// <summary>
            /// Specific weapon menu
            /// </summary>
            public static class SpecificWeapon
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Select Weapon Category", "选择武器类别");

                public static readonly MLString HAS = Utils.CSML("Has this Weapon", "拥有此武器");
                public static readonly MLString FILL_AMMO_CLIP = Utils.CSML("Fill Ammo & Clip", "填充弹药");
                public static readonly MLString TINT = Utils.CSML("Weapon Tint", "武器颜色");
                public static readonly MLString SELECT_TINT = Utils.CSML("Select Tint", "选择颜色");
            }
        }

        /// <summary>
        /// Time menu
        /// </summary>
        public static class DateTimeSpeed
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Date & Time & Speed Options", "日期时间与速度选项");
            public static readonly MLString I01_SET_DATETIME = Utils.CSML("Set Date & Time", "设置日期与时间");
            public static readonly MLString I02_SET_GAME_SPEED = Utils.CSML("Set Game Speed", "设置游戏速度");
            public static readonly MLString I03_SET_AIMING_SPEED = Utils.CSML("Set Aiming Speed", "设置瞄准时游戏速度");
            public static readonly MLString I04_HOUR_FORWARD = Utils.CSML("Hour Forward", "快进一小时");
            public static readonly MLString I05_HOUR_BACKWARD = Utils.CSML("Hour Backward", "倒退一小时");
            public static readonly MLString I06_DAY_FORWARD = Utils.CSML("Day Forward", "快进一天");
            public static readonly MLString I07_DAY_BACKWARD = Utils.CSML("Day Backward", "倒退一天");
            public static readonly MLString I08_SHOW_TIME = Utils.CSML("Show Time", "显示时间");
            public static readonly MLString I09_TIME_PAUSED = Utils.CSML("Time Paused", "时间暂停");
            public static readonly MLString I10_SYNC_WITH_SYSTEM = Utils.CSML("Sync with System", "与系统时间同步");

            /// <summary>
            /// Set date time menu
            /// </summary>
            public static class SetDateTime
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Set Date & Time", "设置日期与时间");
                public static readonly MLString I01_YEAR = Utils.CSML("Year: {0:0000}", "年：{0:0000}");
                public static readonly MLString I02_MONTH = Utils.CSML("Month: {0:00}", "月：{0:00}");
                public static readonly MLString I03_DAY = Utils.CSML("Day: {0:00}", "日：{0:00}");
                public static readonly MLString I04_HOUR = Utils.CSML("Hour: {0:00}", "时：{0:00}");
                public static readonly MLString I05_MINUTE = Utils.CSML("Minute: {0:00}", "分：{0:00}");
                public static readonly MLString I06_SECOND = Utils.CSML("Second: {0:00}", "秒：{0:00}");
                public static readonly MLString I07_SET_TO_CURRENT = Utils.CSML("Set to Current", "设置为当前时间");
                public static readonly MLString I08_SET_TO_SYSTEM = Utils.CSML("Set to System", "设置为系统时间");
            }

            /// <summary>
            /// Set game speed menu
            /// </summary>
            public static class SetGameSpeed
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Change Game Speed", "更改游戏速度");
                public static readonly MLString I01_SPEED = Utils.CSML("Speed: {0:#0%}", "速度：{0:#0%}");
                public static readonly MLString I02_SET_TO_100 = Utils.CSML("Set to 100%", "设置为100%");
                public static readonly MLString I03_SET_TO_75 = Utils.CSML("Set to 75%", "设置为75%");
                public static readonly MLString I04_SET_TO_50 = Utils.CSML("Set to 50%", "设置为50%");
                public static readonly MLString I05_SET_TO_25 = Utils.CSML("Set to 25%", "设置为25%");
                public static readonly MLString I06_SET_TO_10 = Utils.CSML("Set to 10%", "设置为10%");
                public static readonly MLString I07_SET_TO_0 = Utils.CSML("Set to 0%", "设置为0%");
            }

            /// <summary>
            /// Set aiming speed menu
            /// </summary>
            public static class SetAimingSpeed
            {
                public static readonly MLString I00_TITLE = Utils.CSML("Change Aiming Speed", "更改瞄准时游戏速度");
                public static readonly MLString I01_SPEED = Utils.CSML("Speed: {0:#0%}", "速度：{0:#0%}");
                public static readonly MLString I02_SET_TO_100 = Utils.CSML("Set to 100%", "设置为100%");
                public static readonly MLString I03_SET_TO_75 = Utils.CSML("Set to 75%", "设置为75%");
                public static readonly MLString I04_SET_TO_50 = Utils.CSML("Set to 50%", "设置为50%");
                public static readonly MLString I05_SET_TO_25 = Utils.CSML("Set to 25%", "设置为25%");
                public static readonly MLString I06_SET_TO_10 = Utils.CSML("Set to 10%", "设置为10%");
                public static readonly MLString I07_SET_TO_0 = Utils.CSML("Set to 0%", "设置为0%");
            }

        }

        /// <summary>
        /// World menu
        /// </summary>
        public static class World
        {
            public static readonly MLString I00_TITLE = Utils.CSML("World Options", "世界选项");
            public static readonly MLString I01_MOON_GRAVITY = Utils.CSML("Moon Gravity", "月球重力");
            public static readonly MLString I02_RANDOM_COPS = Utils.CSML("Random Cops", "随机警察");
            public static readonly MLString I03_RANDOM_TRAINS = Utils.CSML("Random Trains", "随机火车");
            public static readonly MLString I04_RANDOM_BOATS = Utils.CSML("Random Boats", "随机船只");
            public static readonly MLString I05_GARBAGE_TRUCKS = Utils.CSML("Garbage Trucks", "随机垃圾车");
            public static readonly MLString I06_RESTRICTED_ZONES = Utils.CSML("Restricted Zones", "禁区");
        }

        /// <summary>
        /// Weather menu
        /// </summary>
        public static class Weather
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Weather Options", "天气选项");
            public static readonly MLString I01_WIND = Utils.CSML("Wind", "风");
            public static readonly MLString I02_FREEZE_WEATHER = Utils.CSML("Freeze Weather", "冻结天气");
        }

        /// <summary>
        /// Misc menu
        /// </summary>
        public static class Misc
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Misc Options", "其他选项");
            public static readonly MLString I01_PORTABLE_RADIO = Utils.CSML("Portable Radio", "随身广播");
            public static readonly MLString I02_HIDE_HUD = Utils.CSML("Hide HUD", "隐藏接口");
            public static readonly MLString I03_NEXT_RADIO_TRACK = Utils.CSML("Next Radio Track", "下一广播");
        }

        /// <summary>
        /// Configuration menu
        /// </summary>
        public static class Configuration
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Configuration Options", "配置");
            public static readonly MLString I01_SAVE = Utils.CSML("Save", "保存");
            public static readonly MLString I02_LOAD = Utils.CSML("Load", "加载");
            public static readonly MLString I03_AUTO_SAVE = Utils.CSML("Auto Save", "自动保存");
        }

        /// <summary>
        /// Language menu
        /// </summary>
        public static class Language
        {
            public static readonly MLString I00_TITLE = Utils.CSML("Choose Language", "选择语言");
            public static readonly MLString I01_ENGLISH = "English";
            public static readonly MLString I02_CHINESE_SIMPLIFIED = "简体中文 (Chinese Traditional)";
        }
    }
}
