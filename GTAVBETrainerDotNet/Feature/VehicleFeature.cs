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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTAVBETrainerDotNet.Menu;
using GTAVBETrainerDotNet.Vehicle;
using GTA;
using GTA.Native;

namespace GTAVBETrainerDotNet
{
    public static partial class Feature
    {
        /// <summary>
        /// Vehicle features
        /// </summary>
        public static class Vehicle
        {
            public const float FULL_HEALTH = 2000f;
            public const int DOOR_COUNT = 6;
            public const int PED_FLAG_THROUGH_WINDSCREEN = 32;
            public const float BOOST_BASE_SPEED = 10f;
            public const float BOOST_MULTIPLIER = 1.02f;
            public const float MAX_SPEED = 628f;    // 2 mach XD
            public const float SPAWN_X_OFFSET = 0f;
            public const float SPAWN_Y_OFFSET = 5f;
            public const float SPAWN_Z_OFFSET = 0f;
            public const int SPAWN_WAIT = 100;
            public const int VEHICLE_MENU_DEPTH = 2;

            public static bool Invincible = false;
            public static bool SeatBelt = false;
            public static bool SpawnIntoVehicle = false;
            public static bool Boost = false;

            /// <summary>
            /// Checks whether the player is in a vehicle.
            /// </summary>
            /// <param name="showNotification">If player isn't in a vehicle, whether showing a notification</param>
            /// <returns>true if player is in a vehicle; otherwise false</returns>
            private static bool CheckInVehicle(bool showNotification = true)
            {
                if (Game.Player.Character.IsInVehicle()) return true;
                if (showNotification) Utils.ShowNotificationAboveMap(GlobalConst.Message.VEHICLE_NOT_IN_VEHICLE);
                return false;
            }

            /// <summary>
            /// Updates vehicle features
            /// </summary>
            public static void UpdateFeatures()
            {
                if (Game.Player.Character.IsInVehicle())
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;

                    // Invincible
                    if (Invincible)
                    {
                        Function.Call(Hash.SET_ENTITY_INVINCIBLE, vehicle, true);
                        Function.Call(Hash.SET_ENTITY_PROOFS, vehicle, true, true, true, true, true, true, true, true);
                        Function.Call(Hash.SET_VEHICLE_TYRES_CAN_BURST, vehicle, false);
                        Function.Call(Hash.SET_VEHICLE_WHEELS_CAN_BREAK, vehicle, false);
                        Function.Call(Hash.SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED, vehicle, false);
                        Function.Call(Hash.SET_ENTITY_ONLY_DAMAGED_BY_PLAYER, vehicle, false);
                        Function.Call(Hash.SET_ENTITY_CAN_BE_DAMAGED, vehicle, false);
                        if (Function.Call<bool>(Hash._IS_VEHICLE_DAMAGED, vehicle))
                        {
                            Function.Call(Hash.SET_VEHICLE_FIXED, vehicle);
                        }
                        Function.Call(Hash.SET_ENTITY_HEALTH, vehicle, FULL_HEALTH);
                        Function.Call(Hash.SET_VEHICLE_ENGINE_HEALTH, vehicle, FULL_HEALTH);
                        Function.Call(Hash.SET_VEHICLE_PETROL_TANK_HEALTH, vehicle, FULL_HEALTH);
                        Function.Call(Hash.SET_VEHICLE_BODY_HEALTH, vehicle, FULL_HEALTH);
                        Function.Call(Hash.SET_VEHICLE_CAN_BREAK, vehicle, false);
                        for (int i = 0; i < DOOR_COUNT; i++)
                        {
                            Function.Call(Hash._SET_VEHICLE_DOOR_BREAKABLE, vehicle, i, false);
                        }
                    }
                    else
                    {
                        Function.Call(Hash.SET_ENTITY_INVINCIBLE, vehicle, false);
                        Function.Call(Hash.SET_ENTITY_PROOFS, vehicle, false, false, false, false, false, false, false, false);
                        Function.Call(Hash.SET_VEHICLE_TYRES_CAN_BURST, vehicle, true);
                        Function.Call(Hash.SET_VEHICLE_WHEELS_CAN_BREAK, vehicle, true);
                        Function.Call(Hash.SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED, vehicle, true);
                        for (int i = 0; i < DOOR_COUNT; i++)
                        {
                            Function.Call(Hash._SET_VEHICLE_DOOR_BREAKABLE, vehicle, i, true);
                        }
                    }

                    // Seat belt
                    if (SeatBelt)
                    {
                        Function.Call(Hash.SET_PED_CONFIG_FLAG, PED_FLAG_THROUGH_WINDSCREEN, false);
                        Function.Call(Hash.SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE, Game.Player.Character.Handle, 1);
                    }
                    else
                    {
                        Function.Call(Hash.SET_PED_CONFIG_FLAG, PED_FLAG_THROUGH_WINDSCREEN, true);
                        Function.Call(Hash.SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE, Game.Player.Character.Handle, 0);
                    }
                }
                else
                {
                    ReturnToVehicleMenu();
                }

                // Boost
                UpdateBoostVehicle();

                // Speed meter
                SpeedMeter.UpdateSpeedMeter();
            }

            /// <summary>
            /// Returns to the vehicle menu
            /// </summary>
            public static void ReturnToVehicleMenu()
            {
                if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paint) ||
                    MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Mod) ||
                    MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Doors))
                {
                    MenuStorage.ReturnToMenuByDepth(VEHICLE_MENU_DEPTH);
                }
            }

            /// <summary>
            /// Initializes vehicle features
            /// </summary>
            public static void InitFeatures()
            {
                SetInvincible(MenuStorage.MenuItems.Vehicle.Invincible);
                SetSeatBelt(MenuStorage.MenuItems.Vehicle.SeatBelt);
                SetSpawnIntoVehicle(MenuStorage.MenuItems.Vehicle.SpawnIntoVehicle);
                SetBoost(MenuStorage.MenuItems.Vehicle.Boost);

                SpeedMeter.SetShow(MenuStorage.MenuItems.Vehicle.SpeedMeter.Show);
                SpeedMeter.SetShowInMetric(MenuStorage.MenuItems.Vehicle.SpeedMeter.ShowInMetric);
                SpeedMeter.SetShowWithoutVehicle(MenuStorage.MenuItems.Vehicle.SpeedMeter.ShowWithoutVehicle);
            }

            /// <summary>
            /// Update boosts vehicle
            /// </summary>
            public static void UpdateBoostVehicle()
            {
                if (!Boost || !Game.IsKeyPressed(Configuration.InputKey.BoostVehicle) || !CheckInVehicle()) return;

                int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                float speed = Function.Call<float>(Hash.GET_ENTITY_SPEED, vehicle);
                if (speed < BOOST_BASE_SPEED) speed = BOOST_BASE_SPEED;
                Function.Call(Hash.SET_ENTITY_MAX_SPEED, vehicle, MAX_SPEED);
                speed *= BOOST_MULTIPLIER;
                Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, vehicle, speed);
            }

            /// <summary>
            /// Stops current vehicle
            /// </summary>
            public static void StopVehicle()
            {
                if (!CheckInVehicle()) return;

                int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, vehicle, 0f);
            }

            /// <summary>
            /// Sets invincible
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetInvincible(MenuItem sender)
            {
                Invincible = sender.On;
                Config.DoAutoSave();
            }

            /// <summary>
            /// Sets seat belt feature
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetSeatBelt(MenuItem sender)
            {
                SeatBelt = sender.On;
                Config.DoAutoSave();
            }

            /// <summary>
            /// Sets spawn into vehicle
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetSpawnIntoVehicle(MenuItem sender)
            {
                SpawnIntoVehicle = sender.On;
                Config.DoAutoSave();
            }

            /// <summary>
            /// Sets speed boost
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SetBoost(MenuItem sender)
            {
                Boost = sender.On;
                Config.DoAutoSave();
            }

            /// <summary>
            /// Repairs current vehicle
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void Repair(MenuItem sender)
            {
                if (!CheckInVehicle()) return;

                int vehicle = Game.Player.Character.CurrentVehicle.Handle;

                Function.Call(Hash.SET_VEHICLE_FIXED, vehicle);
                Function.Call(Hash.SET_VEHICLE_DEFORMATION_FIXED, vehicle);
                Function.Call(Hash.SET_VEHICLE_NEEDS_TO_BE_HOTWIRED, false);
                Function.Call(Hash.SET_VEHICLE_ENGINE_HEALTH, vehicle, FULL_HEALTH);
                Function.Call(Hash.SET_VEHICLE_PETROL_TANK_HEALTH, vehicle, FULL_HEALTH);
                Function.Call(Hash.SET_VEHICLE_BODY_HEALTH, vehicle, FULL_HEALTH);
                Function.Call(Hash.SET_VEHICLE_UNDRIVEABLE, vehicle, false);
                Function.Call(Hash.SET_VEHICLE_ENGINE_CAN_DEGRADE, vehicle, false);
                Function.Call(Hash.SET_VEHICLE_ENGINE_ON, vehicle, true);

                Utils.ShowNotificationAboveMap(GlobalConst.Message.VEHICLE_REPAIRED);
            }

            /// <summary>
            /// Cleans current vehicle
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void Clean(MenuItem sender)
            {
                if (!CheckInVehicle()) return;

                Function.Call(Hash.SET_VEHICLE_DIRT_LEVEL, Game.Player.Character.CurrentVehicle.Handle, 0);

                Utils.ShowNotificationAboveMap(GlobalConst.Message.VEHICLE_CLEANED);
            }

            /// <summary>
            /// Spawns the specified vehicle
            /// </summary>
            /// <param name="sender">Source menu item</param>
            public static void SpawnVehicle(MenuItem sender)
            {
                SpawnVehicle(sender.Data as VehicleData, true);
            }

            /// <summary>
            /// Spawns the specified vehicle
            /// </summary>
            /// <param name="data">Vehicle data</param>
            /// <param name="cleanUp">Whether mark the spawned vehicle as no longer needed</param>
            /// <returns>Vehicle handle</returns>
            private static int SpawnVehicle(VehicleData data, bool cleanUp)
            {
                return SpawnVehicle(Function.Call<int>(Hash.GET_HASH_KEY, data.InternalValue), data.Name, cleanUp);
            }

            /// <summary>
            /// Spawns the specified vehicle
            /// </summary>
            /// <param name="hash">Vehicle model hash</param>
            /// <param name="name">Name of the vehicle</param>
            /// <param name="cleanUp">Whether mark the spawned vehicle as no longer needed</param>
            /// <returns>Vehicle handle</returns>
            private static unsafe int SpawnVehicle(int hash, string name, bool cleanUp)
            {
                int model = hash;

                if (Function.Call<bool>(Hash.IS_MODEL_IN_CDIMAGE, model) && Function.Call<bool>(Hash.IS_MODEL_A_VEHICLE, model))
                {
                    Function.Call(Hash.REQUEST_MODEL, model);
                    while (!Function.Call<bool>(Hash.HAS_MODEL_LOADED, model)) Script.Wait(0);
                    float direction = Function.Call<float>(Hash.GET_ENTITY_HEADING, Game.Player.Character.Handle);
                    GTA.Math.Vector3 coord = Function.Call<GTA.Math.Vector3>(Hash.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS, Game.Player.Character.Handle, SPAWN_X_OFFSET, SPAWN_Y_OFFSET, SPAWN_Z_OFFSET);
                    int vehicle = Function.Call<int>(Hash.CREATE_VEHICLE, model, coord.X, coord.Y, coord.Z, direction, 1, 0);

                    if (SpawnIntoVehicle)
                    {
                        Function.Call(Hash.SET_PED_INTO_VEHICLE, Game.Player.Character.Handle, vehicle, -1);
                        if (Function.Call<bool>(Hash.IS_THIS_MODEL_A_HELI, Function.Call<int>(Hash.GET_ENTITY_MODEL, vehicle)) || Function.Call<bool>(Hash.IS_THIS_MODEL_A_PLANE, Function.Call<int>(Hash.GET_ENTITY_MODEL, vehicle)))
                        {
                            Function.Call(Hash.SET_HELI_BLADES_FULL_SPEED, Game.Player.Character.CurrentVehicle.Handle);
                        }
                    }

                    Script.Wait(SPAWN_WAIT);
                    Function.Call(Hash.SET_MODEL_AS_NO_LONGER_NEEDED, model);
                    if (cleanUp) Function.Call(Hash.SET_VEHICLE_AS_NO_LONGER_NEEDED, &vehicle);
                    Utils.ShowNotificationAboveMap(string.Format(GlobalConst.Message.VEHICLE_SPAWNED, name));
                    return vehicle;
                }

                return -1;
            }

            /// <summary>
            /// Door features
            /// </summary>
            public static class Door
            {
                public static bool InstantOpenClose = false;

                /// <summary>
                /// Sets instant open/close
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetInstantOpenClose(MenuItem sender)
                {
                    InstantOpenClose = sender.On;
                    Config.DoAutoSave();
                }

                /// <summary>
                /// Toggles door
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void ToggleDoor(MenuItem sender)
                {
                    if (!Vehicle.CheckInVehicle()) return;
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    int index = sender.Parent.SelectedIndex - 1;
                    float angle = Function.Call<float>(Hash.GET_VEHICLE_DOOR_ANGLE_RATIO, vehicle, index);
                    if (angle < 0.01f)
                    {
                        Function.Call(Hash.SET_VEHICLE_DOOR_OPEN, vehicle, index, false, InstantOpenClose);
                    }
                    else
                    {
                        Function.Call(Hash.SET_VEHICLE_DOOR_SHUT, vehicle, index, InstantOpenClose);
                    }
                }
            }

            /// <summary>
            /// Custom vehicle features
            /// </summary>
            public static class Custom
            {
                private const int MAX_INPUT_LENGTH = 40;
                private const string DEFAULT_NAME = "Custom Vehicle {0}";

                /// <summary>
                /// Pre-enters custom vehicle menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterMenu(MenuItem sender)
                {
                    GenerateCustomVehicleList();
                }

                /// <summary>
                /// Generates custom vehicle list
                /// </summary>
                private static void GenerateCustomVehicleList()
                {
                    MenuStorage.Menus.Vehicles.CustomVehicle.Clear();
                    MenuStorage.Menus.Vehicles.CustomVehicle.Add(MenuStorage.MenuItems.Vehicle.CustomVehicle.SaveCurrent);
                    for (int i = 0; i < Configuration.Vehicle.CustomVehicles.Count; i++)
                    {
                        CustomVehicle cv = Configuration.Vehicle.CustomVehicles[i];
                        cv.Index = i;
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.CustomVehicle, string.Format(MenuText.Vehicle.CustomVehicle.I02_ITEM, cv.Name), false, false, MenuStorage.Menus.Vehicles.CustomVehicles.Item, null, PreEnterItemMenu, null, cv);
                    }
                }

                /// <summary>
                /// Pre-enters item menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterItemMenu(MenuItem sender)
                {
                    CustomVehicle cv = (sender.Data as CustomVehicle);
                    MenuStorage.Menus.Vehicles.CustomVehicles.Item.Title = string.Format(MenuText.Vehicle.CustomVehicle.Item.I00_TITLE, cv.Name);
                    MenuStorage.MenuItems.Vehicle.CustomVehicle.Item.Delete.Data = cv;
                    MenuStorage.MenuItems.Vehicle.CustomVehicle.Item.Overwrite.Data = cv;
                    MenuStorage.MenuItems.Vehicle.CustomVehicle.Item.Rename.Data = cv;
                    MenuStorage.MenuItems.Vehicle.CustomVehicle.Item.Spawn.Data = cv;
                    MenuStorage.Menus.Vehicles.CustomVehicles.Item.SelectedIndex = 0;
                }

                /// <summary>
                /// Saves the current vehicle
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SaveCurrent(MenuItem sender)
                {
                    if (!Vehicle.CheckInVehicle()) return;

                    string name = Utils.ShowInGameKeyboard(null, string.Format(DEFAULT_NAME, Configuration.Vehicle.CustomVehicles.Count + 1), MAX_INPUT_LENGTH);
                    if (string.IsNullOrEmpty(name)) return;

                    CustomVehicle cv = GetCurrentVehicleData();
                    cv.Name = name;
                    Configuration.Vehicle.CustomVehicles.Add(cv);
                    Configuration.Vehicle.CustomVehicles.Sort();
                    Configuration.Vehicle.SaveCustomVehicles();
                    Utils.ShowNotificationAboveMap(GlobalConst.Message.CV_SAVED);
                    GenerateCustomVehicleList();
                }

                /// <summary>
                /// Gets current vehicle data
                /// </summary>
                /// <returns></returns>
                private static unsafe CustomVehicle GetCurrentVehicleData()
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    CustomVehicle cv = new CustomVehicle();

                    cv.Model = Function.Call<int>(Hash.GET_ENTITY_MODEL, vehicle);

                    int primaryColor = 0, secondaryColor = 0;
                    Function.Call(Hash.GET_VEHICLE_COLOURS, vehicle, &primaryColor, &secondaryColor);
                    cv.PrimaryColor = primaryColor;
                    cv.SecondaryColor = secondaryColor;

                    int pearlColor = 0, wheelColor = 0;
                    Function.Call(Hash.GET_VEHICLE_EXTRA_COLOURS, vehicle, &pearlColor, &wheelColor);
                    cv.PearlTopcoatColor = pearlColor;
                    cv.WheelColor = wheelColor;

                    int mod1a = 0, mod1b = 0, mod1c = 0;
                    Function.Call(Hash.GET_VEHICLE_MOD_COLOR_1, vehicle, &mod1a, &mod1b, &mod1c);
                    cv.ModColor1[0] = mod1a;
                    cv.ModColor1[1] = mod1b;
                    cv.ModColor1[2] = mod1c;

                    int mod2a = 0, mod2b = 0;
                    Function.Call(Hash.GET_VEHICLE_MOD_COLOR_2, vehicle, &mod2a, &mod2b);
                    cv.ModColor2[0] = mod2a;
                    cv.ModColor2[1] = mod2b;

                    int cp1r = 0, cp1g = 0, cp1b = 0;
                    Function.Call(Hash.GET_VEHICLE_CUSTOM_PRIMARY_COLOUR, vehicle, &cp1r, &cp1g, &cp1b);
                    cv.CustomPrimaryColor = Color.FromArgb(cp1r, cp1g, cp1b);

                    int cp2r = 0, cp2g = 0, cp2b = 0;
                    Function.Call(Hash.GET_VEHICLE_CUSTOM_SECONDARY_COLOUR, vehicle, &cp2r, &cp2g, &cp2b);
                    cv.CustomSecondaryColor = Color.FromArgb(cp2r, cp2g, cp2b);

                    cv.Livery = Function.Call<int>(Hash.GET_VEHICLE_LIVERY, vehicle);

                    cv.LicensePlateText = Function.Call<string>(Hash.GET_VEHICLE_NUMBER_PLATE_TEXT, vehicle);

                    cv.LicensePlateIndex = Function.Call<int>(Hash.GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, vehicle);

                    cv.WheelType = Function.Call<int>(Hash.GET_VEHICLE_WHEEL_TYPE, vehicle);

                    cv.WindowTint = Function.Call<int>(Hash.GET_VEHICLE_WINDOW_TINT, vehicle);

                    cv.BulletproofTyre = !Function.Call<bool>(Hash.GET_VEHICLE_TYRES_CAN_BURST, vehicle);

                    cv.CustomTyre = Function.Call<bool>(Hash.GET_VEHICLE_MOD_VARIATION, vehicle, Vehicle.Mod.MOD_INDEX_CUSTOM_TYRES);

                    for (int i = 0; i < CustomVehicle.EXTRA_COUNT; i++)
                    {
                        if (!Function.Call<bool>(Hash.DOES_EXTRA_EXIST, vehicle, i))
                        {
                            cv.ExtraEnbled[i] = null;
                        }
                        else
                        {
                            cv.ExtraEnbled[i] = Function.Call<bool>(Hash.IS_VEHICLE_EXTRA_TURNED_ON, vehicle, i);
                        }
                    }

                    int toggleIndex = 0;
                    int modIndex = 0;
                    for (int i = 0; i < CustomVehicle.MOD_COUNT; i++)
                    {
                        if (i >= CustomVehicle.TOGGLE_BEGIN && i <= CustomVehicle.TOGGLE_END)
                        {
                            cv.Toggles[toggleIndex++] = Function.Call<bool>(Hash.IS_TOGGLE_MOD_ON, vehicle, i);
                        }
                        else
                        {
                            cv.Mods[modIndex++] = Function.Call<int>(Hash.GET_VEHICLE_MOD, vehicle, i);
                        }
                    }

                    return cv;
                }

                /// <summary>
                /// Spawns the selected custom vehicle
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void Spawn(MenuItem sender)
                {
                    CustomVehicle cv = (sender.Data as CustomVehicle);

                    int vehicle = Vehicle.SpawnVehicle(cv.Model, GlobalConst.Message.CV_CV, false);
                    if (vehicle == -1)
                    {
                        Utils.ShowNotificationAboveMap(GlobalConst.Message.CV_SPAWN_FAILED);
                        return;
                    }

                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                    Function.Call(Hash.SET_VEHICLE_TYRE_BURST, vehicle, !cv.BulletproofTyre);
                    Function.Call(Hash.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, vehicle, cv.LicensePlateIndex);
                    Function.Call(Hash.SET_VEHICLE_NUMBER_PLATE_TEXT, vehicle, cv.LicensePlateText);
                    Function.Call(Hash.SET_VEHICLE_WINDOW_TINT, vehicle, cv.WindowTint);
                    Function.Call(Hash.SET_VEHICLE_WHEEL_TYPE, vehicle, cv.WheelType);
                    for (int i = 0; i < CustomVehicle.EXTRA_COUNT; i++)
                    {
                        bool? extraEnabled = cv.ExtraEnbled[i];
                        if (extraEnabled.HasValue)
                        {
                            Function.Call(Hash.SET_VEHICLE_EXTRA, vehicle, i, extraEnabled.Value);
                        }
                    }
                    int toggleIndex = 0;
                    int modIndex = 0;
                    for (int i = 0; i < CustomVehicle.MOD_COUNT; i++)
                    {
                        if (i >= CustomVehicle.TOGGLE_BEGIN && i <= CustomVehicle.TOGGLE_END)
                        {
                            Function.Call(Hash.TOGGLE_VEHICLE_MOD, vehicle, i, cv.Toggles[toggleIndex++]);
                        }
                        else
                        {
                            Function.Call(Hash.SET_VEHICLE_MOD, vehicle, i, cv.Mods[modIndex++]);
                        }
                    }
                    int cmod = Function.Call<int>(Hash.GET_VEHICLE_MOD, vehicle, Mod.MOD_INDEX_CUSTOM_TYRES);
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, Mod.MOD_INDEX_CUSTOM_TYRES, cmod, cv.CustomTyre);
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, Mod.MOD_INDEX_CUSTOM_TYRES + 1, cmod, cv.CustomTyre);
                    if (cv.Livery != -1)
                    {
                        Function.Call(Hash.SET_VEHICLE_LIVERY, vehicle, cv.Livery);
                    }
                    Function.Call(Hash.SET_VEHICLE_COLOURS, vehicle, cv.PrimaryColor, cv.SecondaryColor);
                    Function.Call(Hash.SET_VEHICLE_EXTRA_COLOURS, vehicle, cv.PearlTopcoatColor, cv.WheelColor);
                    Function.Call(Hash.SET_VEHICLE_MOD_COLOR_1, vehicle, cv.ModColor1[0], cv.ModColor1[1], cv.ModColor1[2]);
                    Function.Call(Hash.SET_VEHICLE_MOD_COLOR_2, vehicle, cv.ModColor2[0], cv.ModColor2[1]);
                    Function.Call(Hash.SET_VEHICLE_DIRT_LEVEL, vehicle, 0f);
                    unsafe
                    {
                        Function.Call(Hash.SET_VEHICLE_AS_NO_LONGER_NEEDED, &vehicle);
                    }
                }

                /// <summary>
                /// Renames the selected custom vehicle
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void Rename(MenuItem sender)
                {
                    CustomVehicle cv = (sender.Data as CustomVehicle);
                    string name = Utils.ShowInGameKeyboard(null, cv.Name, MAX_INPUT_LENGTH);
                    if (!string.IsNullOrEmpty(name) && name != cv.Name)
                    {
                        cv.Name = name;
                        sender.Parent.Title = name;
                        Configuration.Vehicle.CustomVehicles.Sort();
                        Configuration.Vehicle.SaveCustomVehicles();
                        GenerateCustomVehicleList();
                        Utils.ShowNotificationAboveMap(GlobalConst.Message.CV_RENAMED);
                    }
                }

                /// <summary>
                /// Overwrites with the current vehicle
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void Overwrite(MenuItem sender)
                {
                    if (!CheckInVehicle()) return;

                    CustomVehicle old = (sender.Data as CustomVehicle);
                    CustomVehicle cv = GetCurrentVehicleData();
                    cv.Name = old.Name;
                    cv.Index = old.Index;
                    Configuration.Vehicle.CustomVehicles[old.Index] = cv;
                    Configuration.Vehicle.SaveCustomVehicles();
                    Utils.ShowNotificationAboveMap(GlobalConst.Message.CV_OVERWRITTEN);
                }

                /// <summary>
                /// Deletes the selected custom vehicle
                /// </summary>
                /// <param name="sender"></param>
                public static void Delete(MenuItem sender)
                {
                    MenuStorage.ReturnToPrevMenu();
                    Configuration.Vehicle.CustomVehicles.RemoveAt((sender.Data as CustomVehicle).Index);
                    Configuration.Vehicle.SaveCustomVehicles();
                    GenerateCustomVehicleList();
                    Utils.ShowNotificationAboveMap(GlobalConst.Message.CV_DELETED);
                }
            }

            /// <summary>
            /// Modification features
            /// </summary>
            public static class Mod
            {
                private const int MOD_INDEX_ENGINE = 11;
                private const int MOD_INDEX_BRAKES = 12;
                private const int MOD_INDEX_TRANSMISSION = 13;
                private const int MOD_INDEX_ARMOR = 16;
                private const int MOD_INDEX_TURBO_TUNING = 18;
                private const int MOD_INDEX_XEON_LIGHTS = 22;
                public const int MOD_INDEX_CUSTOM_TYRES = 23;
                private const int MOD_INDEX_BIKE_RARE_WHEEL = 24;
                private const int MOD_COUNT = 25;
                private const int EXTRA_COUNT = 10;
                private const int TOGGLE_WAIT = 100;
                private const int PLATE_TEXT_MAX_LENGTH = 8;

                private static int _lastSelectedMod = 0;

                /// <summary>
                /// Pre-enters mod menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterModMenu(MenuItem sender)
                {
                    if (!CheckInVehicle())
                    {
                        sender.PreventsEnteringSubMenuOnce = true;
                        return;
                    }

                    GenerateModMenu();
                }

                /// <summary>
                /// Generates mod menu for current vehicle
                /// </summary>
                private static void GenerateModMenu()
                {
                    MenuStorage.Menus.Vehicles.Mod.Clear();

                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);

                    int model = Function.Call<int>(Hash.GET_ENTITY_MODEL, vehicle);

                    bool isBike = Function.Call<bool>(Hash.IS_THIS_MODEL_A_BIKE, model);
                    bool isAircraft = Function.Call<bool>(Hash.IS_THIS_MODEL_A_HELI, model) || Function.Call<bool>(Hash.IS_THIS_MODEL_A_PLANE, model);
                    bool isSpecial = Function.Call<bool>(Hash.IS_THIS_MODEL_A_TRAIN, model) || Function.Call<bool>(Hash.IS_THIS_MODEL_A_BICYCLE, model) || Function.Call<bool>(Hash.IS_THIS_MODEL_A_BOAT, model);

                    if (!isSpecial && !isAircraft)
                    {
                        MenuStorage.Menus.Vehicles.Mod.Add(MenuStorage.MenuItems.Vehicle.Mod.AllPerformance);
                        MenuStorage.Menus.Vehicles.Mod.Add(MenuStorage.MenuItems.Vehicle.Mod.AllArmor);
                        MenuStorage.Menus.Vehicles.Mod.Add(MenuStorage.MenuItems.Vehicle.Mod.RemoveAll);

                        for (int i = 0; i < 30; i++)
                        {
                            if (i == 21 || i == 23 || i == 24)
                            {
                                continue;
                            }

                            int mods = Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, i);
                            if (mods > 0)
                            {
                                MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod,
                                    string.Format(MenuText.Vehicle.Mod.FORMAT_MOD_CATEGORY, ModStorage.GetModCategoryName(i), mods + 1),
                                    false, false, MenuStorage.Menus.Vehicles.Mods.ModItem, null, PreEnterModItem, null, i);
                            }
                        }

                        int tintCount = Function.Call<int>(Hash.GET_NUM_VEHICLE_WINDOW_TINTS);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod,
                            string.Format(MenuText.Vehicle.Mod.FORMAT_MOD_CATEGORY, ModStorage.GetModCategoryName(ModStorage.SPECIAL_ID_FOR_WINDOW_TINT), tintCount),
                            false, false, MenuStorage.Menus.Vehicles.Mods.ModItem, null, PreEnterModItem, null, ModStorage.SPECIAL_ID_FOR_WINDOW_TINT);

                        int plateCount = Function.Call<int>(Hash.GET_NUMBER_OF_VEHICLE_NUMBER_PLATES);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod,
                            string.Format(MenuText.Vehicle.Mod.FORMAT_MOD_CATEGORY, ModStorage.GetModCategoryName(ModStorage.SPECIAL_ID_FOR_LICENSE_PLATES), plateCount),
                            false, false, MenuStorage.Menus.Vehicles.Mods.ModItem, null, PreEnterModItem, null, ModStorage.SPECIAL_ID_FOR_LICENSE_PLATES);

                        if (!isBike)
                        {
                            MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod,
                                string.Format(MenuText.Vehicle.Mod.FORMAT_MOD_CATEGORY, ModStorage.GetModCategoryName(ModStorage.SPECIAL_ID_FOR_WHEEL_CATEGORY), ModStorage.WHEEL_CATEGORY_COUNT),
                                false, false, MenuStorage.Menus.Vehicles.Mods.ModItem, null, PreEnterModItem, null, ModStorage.SPECIAL_ID_FOR_WHEEL_CATEGORY);
                        }

                        int wheelCount = 0;
                        int wheelType = Function.Call<int>(Hash.GET_VEHICLE_WHEEL_TYPE, vehicle);
                        if (wheelType == 6)
                        {
                            wheelCount = ModStorage.WHEEL_CATEGORY_COUNT_BIKE;
                        }
                        else if (wheelType == 7)
                        {
                            wheelCount = ModStorage.WHEEL_CATEGORY_COUNTS[6];
                        }
                        else
                        {
                            wheelCount = ModStorage.WHEEL_CATEGORY_COUNTS[wheelType];
                        }
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod,
                            string.Format(MenuText.Vehicle.Mod.FORMAT_MOD_CATEGORY, ModStorage.GetModCategoryName(ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION), wheelCount),
                            false, false, MenuStorage.Menus.Vehicles.Mods.ModItem, null, PreEnterModItem, null, ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.TURBO_TUNING, true, GetTurboTuning(), null, SetTurboTuning);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.TURBO_XEON_LIGHTS, true, GetXeonLight(), null, SetXeonLight);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.BULLETPROOF_TYRES, true, GetBulletproofTyres(), null, SetBulletproofTyres);
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.CUSTOM_TYRES, true, GetCustomTyres(), null, SetCustomTyres);
                    }

                    int extraIndex = 1;
                    for (int i = 0; i < EXTRA_COUNT; i++)
                    {
                        if (!Function.Call<bool>(Hash.DOES_EXTRA_EXIST, vehicle, i)) continue;
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, string.Format(MenuText.Vehicle.Mod.EXTRA, extraIndex++), true, GetExtra(i), null, SetExtra, null, null, i);
                    }

                    if (!isSpecial && !isAircraft)
                    {
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.SET_PLATE_TEXT, false, false, null, SetPlateText);
                    }

                    if (MenuStorage.Menus.Vehicles.Mod.ItemCount == 0)
                    {
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mod, MenuText.Vehicle.Mod.NO_AVAILABLE_MOD);
                    }
                }

                /// <summary>
                /// Adds all performance upgrades
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void AllPerformance(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);

                    // Engine
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_ENGINE, Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, MOD_INDEX_ENGINE) - 1, true);

                    // Brakes
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_BRAKES, Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, MOD_INDEX_BRAKES) - 1, true);

                    // Transmission
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_TRANSMISSION, Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, MOD_INDEX_TRANSMISSION) - 1, true);

                    // Turbo tuning
                    Function.Call(Hash.TOGGLE_VEHICLE_MOD, vehicle, MOD_INDEX_TURBO_TUNING, true);

                    Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_ALL_PERFORMANCE);
                }

                /// <summary>
                /// Adds all armor upgrades
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void AllArmor(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);

                    // Armor
                    Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_ARMOR, Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, MOD_INDEX_ARMOR) - 1, true);

                    // Bulletproof tyres
                    Function.Call(Hash.SET_VEHICLE_TYRES_CAN_BURST, vehicle, false);

                    Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_ALL_ARMOR);
                }

                /// <summary>
                /// Removes all upgrades
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void RemoveAll(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    for (int i = 0; i < MOD_COUNT; i++)
                    {
                        Function.Call(Hash.REMOVE_VEHICLE_MOD, vehicle, i);
                    }
                    Function.Call(Hash.SET_VEHICLE_WINDOW_TINT, vehicle, 0);
                    Function.Call(Hash.SET_VEHICLE_TYRES_CAN_BURST, vehicle, true);
                    Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_REMOVE_ALL);
                }

                /// <summary>
                /// Pre-enters mod item
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterModItem(MenuItem sender)
                {
                    MenuStorage.Menus.Vehicles.Mods.ModItem.Title = sender.Text;
                    MenuStorage.Menus.Vehicles.Mods.ModItem.Clear();

                    int category = (int)sender.Data;
                    _lastSelectedMod = category;
                    int actualCategory = category;
                    if (category == ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION)
                    {
                        actualCategory = 23;
                    }
                    else if (category > ModStorage.SPECIAL_ID_START)
                    {
                        ProcessSpecialMod(sender);
                        return;
                    }

                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    int count = 0;
                    if (category == ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION)
                    {
                        int wheelType = Function.Call<int>(Hash.GET_VEHICLE_WHEEL_TYPE, vehicle);
                        if (wheelType == 6)
                        {
                            count = ModStorage.WHEEL_CATEGORY_COUNT_BIKE;
                        }
                        else if (wheelType == 7)
                        {
                            count = ModStorage.WHEEL_CATEGORY_COUNTS[6];
                        }
                        else
                        {
                            count = ModStorage.WHEEL_CATEGORY_COUNTS[wheelType];
                        }
                    }
                    else
                    {
                        count = Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle, actualCategory);
                    }

                    if (category == ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION)
                    {
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mods.ModItem, MenuText.Vehicle.Mod.DEFAULT_WHEEL, false, false, null, ApplyMod, null, null, -1);
                    }
                    else
                    {
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mods.ModItem, ModStorage.GetNormalItemTitle(vehicle, category, -1, _lastSelectedMod), false, false, null, ApplyMod, null, null, -1);
                    }

                    for (int i = 0; i < count; i++)
                    {
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mods.ModItem, ModStorage.GetNormalItemTitle(vehicle, actualCategory, i, _lastSelectedMod), false, false, null, ApplyMod, null, null, i);
                    }

                    MenuStorage.Menus.Vehicles.Mods.ModItem.SelectedIndex = GetMenuIndex(category, actualCategory, vehicle);
                }

                /// <summary>
                /// Gets the menu index
                /// </summary>
                /// <param name="category">Category</param>
                /// <param name="actualCategory">Actual category</param>
                /// <param name="vehicle">Vehicle handle</param>
                /// <returns></returns>
                private static int GetMenuIndex(int category, int actualCategory, int vehicle)
                {
                    int menuIndex = 0;

                    if (category == ModStorage.SPECIAL_ID_FOR_WHEEL_CATEGORY)
                    {
                        menuIndex = Function.Call<int>(Hash.GET_VEHICLE_WHEEL_TYPE, vehicle);
                        if (menuIndex > 6)
                        {
                            menuIndex--;
                        }
                    }
                    else if (category == ModStorage.SPECIAL_ID_FOR_LICENSE_PLATES)
                    {
                        menuIndex = Function.Call<int>(Hash.GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, vehicle);
                    }
                    else if (category == ModStorage.SPECIAL_ID_FOR_WINDOW_TINT)
                    {
                        menuIndex = Function.Call<int>(Hash.GET_VEHICLE_WINDOW_TINT, vehicle);
                    }
                    else
                    {
                        menuIndex = Function.Call<int>(Hash.GET_VEHICLE_MOD, vehicle, actualCategory);
                        menuIndex++;
                    }
                    return menuIndex;
                }

                /// <summary>
                /// Processing special mods
                /// </summary>
                /// <param name="sender">Source menu item</param>
                private static void ProcessSpecialMod(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    int category = (int)sender.Data;
                    List<int> values = new List<int>();

                    switch (category)
                    {
                        case ModStorage.SPECIAL_ID_FOR_LICENSE_PLATES:
                            int plateCount = Function.Call<int>(Hash.GET_NUMBER_OF_VEHICLE_NUMBER_PLATES, vehicle);
                            for (int i = 0; i < plateCount; i++)
                            {
                                values.Add(i);
                            }
                            break;

                        case ModStorage.SPECIAL_ID_FOR_WHEEL_CATEGORY:
                            for (int i = 0; i < ModStorage.WHEEL_CATEGORY_COUNT; i++)
                            {
                                int j = i;
                                if (j >= 6) j++;
                                values.Add(j);
                            }
                            break;

                        case ModStorage.SPECIAL_ID_FOR_WINDOW_TINT:
                            int tintCount = Function.Call<int>(Hash.GET_NUM_VEHICLE_WINDOW_TINTS);
                            for (int i = 0; i < tintCount; i++)
                            {
                                values.Add(i);
                            }
                            break;

                        default:
                            return;
                    }

                    for (int i = 0; i < values.Count; i++)
                    {
                        string name = ModStorage.GetSpecialItemTitle(category, i);
                        if (name != null)
                        {
                        }
                        else if (i == 0 && values[i] == -1)
                        {
                            name = MenuText.Vehicle.Mod.DEFAULT;
                        }
                        else
                        {
                            name = string.Format(MenuText.Vehicle.Mod.MOD_ITEM, ModStorage.GetModCategoryName(category), i);
                        }
                        MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Mods.ModItem, name, false, false, null, ApplyMod, null, null, values[i]);
                    }

                    int menuIndex = GetMenuIndex(category, category, vehicle);
                    MenuStorage.Menus.Vehicles.Mods.ModItem.SelectedIndex = menuIndex;
                }

                /// <summary>
                /// Applies selected mod
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void ApplyMod(MenuItem sender)
                {
                    int value = (int)sender.Data;
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;

                    if ((_lastSelectedMod >= 0 && _lastSelectedMod <= 8) ||
                        (_lastSelectedMod >= 10 && _lastSelectedMod <= 16) ||
                        (_lastSelectedMod >= 21 && _lastSelectedMod <= 24))
                    {
                        Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                        Function.Call(Hash.SET_VEHICLE_MOD, vehicle, _lastSelectedMod, value, 1);
                        Utils.ShowNotificationAboveMap(string.Format(GlobalConst.Message.VM_APPLIED, ModStorage.GetNormalItemTitle(vehicle, _lastSelectedMod, value, _lastSelectedMod)));
                    }
                    else
                    {
                        switch (_lastSelectedMod)
                        {
                            case ModStorage.SPECIAL_ID_FOR_WINDOW_TINT:
                                Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                                Function.Call(Hash.SET_VEHICLE_WINDOW_TINT, vehicle, value);
                                Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_WINDOW_TINT_CHANGED);
                                break;

                            case ModStorage.SPECIAL_ID_FOR_LICENSE_PLATES:
                                int plateCount = Function.Call<int>(Hash.GET_NUMBER_OF_VEHICLE_NUMBER_PLATES, vehicle);
                                Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                                Function.Call(Hash.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, vehicle, value);
                                Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_LICENSE_PLATE_CHANGED);
                                break;

                            case ModStorage.SPECIAL_ID_FOR_WHEEL_CATEGORY:
                                Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                                Function.Call(Hash.SET_VEHICLE_WHEEL_TYPE, vehicle, value);
                                Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_CUSTOM_TYRES, 0, 0);
                                Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_WHEEL_CATEGORY_CHANGED);
                                break;

                            case ModStorage.SPECIAL_ID_FOR_WHEEL_SELECTION:
                                Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                                Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_CUSTOM_TYRES, value, 0);
                                Function.Call(Hash.SET_VEHICLE_MOD, vehicle, MOD_INDEX_BIKE_RARE_WHEEL, value, 0);
                                Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_WHEELS_CHANGED);
                                break;
                        }
                    }
                }

                /// <summary>
                /// Sets turbo tuning
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetTurboTuning(MenuItem sender)
                {
                    Function.Call(Hash.TOGGLE_VEHICLE_MOD, Game.Player.Character.CurrentVehicle.Handle, MOD_INDEX_TURBO_TUNING, sender.On);
                    Script.Wait(TOGGLE_WAIT);
                    sender.On = GetTurboTuning();
                }

                /// <summary>
                /// Gets turbo tuning
                /// </summary>
                /// <returns></returns>
                private static bool GetTurboTuning()
                {
                    return Function.Call<bool>(Hash.IS_TOGGLE_MOD_ON, Game.Player.Character.CurrentVehicle.Handle, MOD_INDEX_TURBO_TUNING);
                }

                /// <summary>
                /// Sets xeon light
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetXeonLight(MenuItem sender)
                {
                    Function.Call(Hash.TOGGLE_VEHICLE_MOD, Game.Player.Character.CurrentVehicle.Handle, MOD_INDEX_XEON_LIGHTS, sender.On);
                    Script.Wait(TOGGLE_WAIT);
                    sender.On = GetXeonLight();
                }

                /// <summary>
                /// Gets xeon light
                /// </summary>
                /// <returns></returns>
                private static bool GetXeonLight()
                {
                    return Function.Call<bool>(Hash.IS_TOGGLE_MOD_ON, Game.Player.Character.CurrentVehicle.Handle, MOD_INDEX_XEON_LIGHTS);
                }

                /// <summary>
                /// Sets bulletproof tyres
                /// </summary>
                /// <param name="sender"></param>
                public static void SetBulletproofTyres(MenuItem sender)
                {
                    Function.Call(Hash.SET_VEHICLE_TYRES_CAN_BURST, Game.Player.Character.CurrentVehicle.Handle, !sender.On);
                    Script.Wait(TOGGLE_WAIT);
                    sender.On = GetBulletproofTyres();
                }

                /// <summary>
                /// Gets bulletproof tyres
                /// </summary>
                /// <returns></returns>
                private static bool GetBulletproofTyres()
                {
                    return !Function.Call<bool>(Hash.GET_VEHICLE_TYRES_CAN_BURST, Game.Player.Character.CurrentVehicle.Handle);
                }

                /// <summary>
                /// Sets custom tyres
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetCustomTyres(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                    int mod = Function.Call<int>(Hash.GET_VEHICLE_MOD, vehicle, MOD_INDEX_CUSTOM_TYRES);
                    Function.Call(Hash.SET_VEHICLE_MOD, MOD_INDEX_CUSTOM_TYRES, mod, sender.On);
                    Function.Call(Hash.SET_VEHICLE_MOD, MOD_INDEX_BIKE_RARE_WHEEL, mod, sender.On);
                    Utils.ShowNotificationAboveMap(GlobalConst.Message.VM_TYRES_CHANGED);
                }

                /// <summary>
                /// Gets custom tyres
                /// </summary>
                /// <returns></returns>
                private static bool GetCustomTyres()
                {
                    return (Function.Call<int>(Hash.GET_VEHICLE_MOD_VARIATION, Game.Player.Character.CurrentVehicle.Handle, MOD_INDEX_CUSTOM_TYRES) > 0);
                }

                /// <summary>
                /// Sets extra
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetExtra(MenuItem sender)
                {
                    Function.Call(Hash.SET_VEHICLE_EXTRA, Game.Player.Character.CurrentVehicle.Handle, (int)sender.Data, sender.On ? 0 : -1);
                }

                /// <summary>
                /// Gets extra
                /// </summary>
                /// <param name="extra">Extra index</param>
                /// <returns></returns>
                private static bool GetExtra(int extra)
                {
                    return (Function.Call<bool>(Hash.IS_VEHICLE_EXTRA_TURNED_ON, Game.Player.Character.CurrentVehicle.Handle, extra));
                }

                /// <summary>
                /// Sets plate text
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetPlateText(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    string text = Function.Call<string>(Hash.GET_VEHICLE_NUMBER_PLATE_TEXT, vehicle);
                    text = Utils.ShowInGameKeyboard(null, text, PLATE_TEXT_MAX_LENGTH);
                    if (!string.IsNullOrEmpty(text))
                    {
                        Function.Call(Hash.SET_VEHICLE_NUMBER_PLATE_TEXT, vehicle, text);
                    }
                }
            }

            /// <summary>
            /// Paint features
            /// </summary>
            public static class Paint
            {
                private const int PRIMARY_NO_PEARL_TYPE_1 = 3;
                private const int PRIMARY_NO_PEARL_TYPE_2 = 4;
                private const int PRIMARY_NO_PEARL_TYPE_3 = 5;
                private const int WHEEL_MOD_INDEX = 23;
                private const int WHEEL_INDEX_DEFAULT = -1;

                private static int _type = 0;

                /// <summary>
                /// Enters paint menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterPaintMenu(MenuItem sender)
                {
                    if (!CheckInVehicle())
                    {
                        sender.PreventsEnteringSubMenuOnce = true;
                        return;
                    }

                    MenuStorage.Menus.Vehicles.Paint.Remove(MenuStorage.MenuItems.Vehicle.Paint.Livery);

                    int liveryCount = Function.Call<int>(Hash.GET_VEHICLE_LIVERY_COUNT, Game.Player.Character.CurrentVehicle.Handle);
                    if (liveryCount > 0)
                    {
                        MenuStorage.MenuItems.Vehicle.Paint.Livery.Text = string.Format(MenuText.Vehicle.Paint.I05_LIVERY, liveryCount);
                        MenuStorage.Menus.Vehicles.Paint.Add(MenuStorage.MenuItems.Vehicle.Paint.Livery);
                    }
                }

                /// <summary>
                /// Enters livery menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void EnterLiveryMenu(MenuItem sender)
                {
                    MenuStorage.Menus.Vehicles.Paints.Livery.Clear();
                    int count = Function.Call<int>(Hash.GET_VEHICLE_LIVERY_COUNT, Game.Player.Character.CurrentVehicle.Handle);
                    for (int i = 0; i < count; i++)
                    {
                        MenuItem mi = MenuStorage.AddMenuItem(MenuStorage.Menus.Vehicles.Paints.Livery, string.Format(MenuText.Vehicle.Paint.Livery.I01_ITEM, i + 1));
                        mi.Data = i;
                        mi.Highlighted += ApplyLivery;
                    }
                    int livery = Function.Call<int>(Hash.GET_VEHICLE_LIVERY, Game.Player.Character.CurrentVehicle.Handle);
                    MenuStorage.Menus.Vehicles.Paints.Livery.SelectedIndex = livery;
                }

                /// <summary>
                /// Applies livery
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void ApplyLivery(MenuItem sender)
                {
                    Function.Call(Hash.SET_VEHICLE_LIVERY, Game.Player.Character.CurrentVehicle.Handle, (int)sender.Data);
                }

                /// <summary>
                /// Enters primary color menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void EnterPrimaryMenu(MenuItem sender)
                {
                    int p1 = 0, p2 = 0, p3 = 0;
                    unsafe
                    {
                        Function.Call(Hash.GET_VEHICLE_MOD_COLOR_1, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2, &p3);
                    }
                    int index = p1;
                    if (index == 2) index = 0;
                    else if (index > 2) index--;
                    MenuStorage.Menus.Vehicles.Paints.PrimaryColor.SelectedIndex = index;
                }

                /// <summary>
                /// Enters secondary color menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void EnterSecondaryMenu(MenuItem sender)
                {
                    int p1 = 0, p2 = 0;
                    unsafe
                    {
                        Function.Call(Hash.GET_VEHICLE_MOD_COLOR_2, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2);
                    }
                    int index = p1;
                    if (index > 1) index--;
                    MenuStorage.Menus.Vehicles.Paints.SecondaryColor.SelectedIndex = index;
                }

                /// <summary>
                /// Enters pearl topcoat menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterPearlTopcoatMenu(MenuItem sender)
                {
                    int p1 = 0, p2 = 0, p3 = 0;
                    unsafe
                    {
                        Function.Call(Hash.GET_VEHICLE_MOD_COLOR_1, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2, &p3);
                    }
                    if (p1 == PRIMARY_NO_PEARL_TYPE_1 || p1 == PRIMARY_NO_PEARL_TYPE_2 || p1 == PRIMARY_NO_PEARL_TYPE_3)
                    {
                        Utils.ShowNotificationAboveMap(GlobalConst.Message.VP_NO_PEARL);
                        sender.PreventsEnteringSubMenuOnce = true;
                        return;
                    }

                    int index = p3;
                    if (index > -1) index++;
                    sender.SubMenu.SelectedIndex = index;
                }

                /// <summary>
                /// Pre enters wheels menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterWheelsMenu(MenuItem sender)
                {
                    int wheel = Function.Call<int>(Hash.GET_VEHICLE_MOD, Game.Player.Character.CurrentVehicle.Handle, WHEEL_MOD_INDEX);
                    if (wheel == WHEEL_INDEX_DEFAULT)
                    {
                        Utils.ShowNotificationAboveMap(GlobalConst.Message.VP_NO_WHEEL);
                        sender.PreventsEnteringSubMenuOnce = true;
                        return;
                    }

                    int p1 = 0, p2 = 0;
                    unsafe
                    {
                        Function.Call(Hash.GET_VEHICLE_EXTRA_COLOURS, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2);
                    }
                    sender.SubMenu.SelectedIndex = PaintStorage.FindWheelPaintByValue(p2);
                }

                /// <summary>
                /// Enters paint type menu
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void PreEnterPaintTypeMenu(MenuItem sender)
                {
                    int p1 = 0, p2 = 0, p3 = 0;
                    unsafe
                    {
                        if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paints.PrimaryColor))
                        {
                            Function.Call(Hash.GET_VEHICLE_MOD_COLOR_1, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2, &p3);
                            sender.SubMenu.SelectedIndex = p2;
                        }
                        else
                        {
                            Function.Call(Hash.GET_VEHICLE_MOD_COLOR_2, Game.Player.Character.CurrentVehicle.Handle, &p1, &p2);
                            sender.SubMenu.SelectedIndex = p2;
                        }
                    }
                }

                /// <summary>
                /// Select paint type
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SelectPaintType(MenuItem sender)
                {
                    _type = (int)sender.Data;
                    if (_type > 1) _type++;
                }

                /// <summary>
                /// Applies selected color
                /// </summary>
                /// <param name="sender"></param>
                public static void ApplyColor(MenuItem sender)
                {
                    int vehicle = Game.Player.Character.CurrentVehicle.Handle;
                    Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
                    PaintData pd = (sender.Data as PaintData);

                    int paint = pd.InternalValue;
                    int p1 = 0, p2 = 0, p3 = 0;

                    unsafe
                    {
                        // Primary color
                        if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paints.PrimaryColor))
                        {
                            Function.Call(Hash.SET_VEHICLE_MOD_COLOR_1, vehicle, _type, paint, -1);
                        }

                        // Secondary color
                        else if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paints.SecondaryColor))
                        {
                            Function.Call(Hash.SET_VEHICLE_MOD_COLOR_2, vehicle, _type, paint);
                        }

                        // Pearl topcoat
                        else if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paints.PearlTopcoat))
                        {
                            Function.Call(Hash.GET_VEHICLE_MOD_COLOR_1, vehicle, &p1, &p2, &p3);
                            Function.Call(Hash.SET_VEHICLE_MOD_COLOR_1, vehicle, 2, p2, paint - 1);
                        }

                        // Wheel
                        else if (MenuStorage.IsMenuInStack(MenuStorage.Menus.Vehicles.Paints.Wheels))
                        {
                            Function.Call(Hash.GET_VEHICLE_EXTRA_COLOURS, vehicle, &p1, &p2);
                            Function.Call(Hash.SET_VEHICLE_EXTRA_COLOURS, vehicle, p1, paint);
                        }
                    }
                }
            }

            /// <summary>
            /// Speed meter features
            /// </summary>
            public static class SpeedMeter
            {
                private static readonly Point SPEEDMETER_POS = new Point(960, 945);
                private const float SPEEDMETER_X_SCALE = 0.45f;
                private const float SPEEDMETER_Y_SCALE = 0.45f;
                private static readonly Color SPEEDMETER_TEXT_COLOR = Color.White;
                private static readonly Color SPEEDMETER_SHADOW_COLOR = Color.Black;
                private static readonly Point SPEEDMETER_SHADOW_OFFSET = new Point(2, 3);
                private const GlobalConst.HAlign SPEEDMETER_ALIGN = GlobalConst.HAlign.Center;
                private const string SPEEDMETER_FORMAT_MPH = "{0:#0} mph";
                private const string SPEEDMETER_FORMAT_KPH = "{0:#0} km/h";
                private const GTA.Font SPEEDMETER_FONT = GTA.Font.ChaletLondon;
                private const float SPEEDMETER_SPEED_FACTOR_KPH = 3.6f;
                private const float SPEEDMETER_SPEED_FACTOR_MPH = 3.6f / 1.609344f;

                public static bool Show = false;
                public static bool ShowInMetric = false;
                public static bool ShowWithoutVehicle = false;

                /// <summary>
                /// Sets show
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetShow(MenuItem sender)
                {
                    Show = sender.On;
                    Config.DoAutoSave();
                }

                /// <summary>
                /// Sets show in metric
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetShowInMetric(MenuItem sender)
                {
                    ShowInMetric = sender.On;
                    Config.DoAutoSave();
                }

                /// <summary>
                /// Sets show without vehicle
                /// </summary>
                /// <param name="sender">Source menu item</param>
                public static void SetShowWithoutVehicle(MenuItem sender)
                {
                    ShowWithoutVehicle = sender.On;
                    Config.DoAutoSave();
                }

                /// <summary>
                /// Updates and show speed meter
                /// </summary>
                public static void UpdateSpeedMeter()
                {
                    if (Show && (Game.Player.Character.IsInVehicle() || ShowWithoutVehicle))
                    {
                        int handle = Game.Player.Character.Handle;
                        if (Game.Player.Character.IsInVehicle()) handle = Game.Player.Character.CurrentVehicle.Handle;

                        float speed = Function.Call<float>(Hash.GET_ENTITY_SPEED, handle);
                        speed *= (ShowInMetric ? SPEEDMETER_SPEED_FACTOR_KPH : SPEEDMETER_SPEED_FACTOR_MPH);

                        Utils.DrawText(string.Format((ShowInMetric ? SPEEDMETER_FORMAT_KPH : SPEEDMETER_FORMAT_MPH), speed),
                            SPEEDMETER_POS.X + SPEEDMETER_SHADOW_OFFSET.X, SPEEDMETER_POS.Y + SPEEDMETER_SHADOW_OFFSET.Y,
                            SPEEDMETER_ALIGN, SPEEDMETER_SHADOW_COLOR, SPEEDMETER_X_SCALE, SPEEDMETER_Y_SCALE, SPEEDMETER_FONT);
                        Utils.DrawText(string.Format((ShowInMetric ? SPEEDMETER_FORMAT_KPH : SPEEDMETER_FORMAT_MPH), speed),
                            SPEEDMETER_POS.X, SPEEDMETER_POS.Y, SPEEDMETER_ALIGN, SPEEDMETER_TEXT_COLOR, SPEEDMETER_X_SCALE, SPEEDMETER_Y_SCALE, SPEEDMETER_FONT);
                    }
                }
            }
        }
    }
}
