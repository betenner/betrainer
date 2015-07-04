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
using GTA.Native;

namespace GTAVBETrainerDotNet.Vehicle
{
    /// <summary>
    /// Storage for modifications
    /// </summary>
    public static class ModStorage
    {
        public const int CUSTOM_TYRE_COUNT = 1;

        public const int WHEEL_CATEGORY_COUNT = 7;

        public static readonly string[] WHEEL_CATEGORY_NAMES = { "Sports", "Muscle", "Lowrider", "SUV", "Offroad", "Tuner", "High End" };

        public static readonly int[] WHEEL_CATEGORY_COUNTS = { 25, 18, 15, 19, 10, 24, 20 };

        public const int WHEEL_CATEGORY_COUNT_BIKE = 13;

        public static readonly string[] TINT_NAMES = { "No Tint", "Dark", "Medium", "Light", "Very Light", "Safety Value" };

        public static readonly string[] PLATE_NAMES = { "Blue on White", "Yellow/Black", "Gold/Blue", "Blue/White SA Caps", "Blue/White SA Exempt", "Blue/White Yankton" };

        public static readonly string[] BRAKES_AND_TRANS_PREFIXES = { "Street", "Sports", "Race" };

        public static readonly string[] SUSP_PREFIXES = { "Lowered", "Street", "Sports", "Competition" };

        public const int SPECIAL_ID_START = 90;

        public const int SPECIAL_ID_FOR_WHEEL_CATEGORY = 91;

        public const int SPECIAL_ID_FOR_WHEEL_SELECTION = 92;

        public const int SPECIAL_ID_FOR_WINDOW_TINT = 93;

        public const int SPECIAL_ID_FOR_LICENSE_PLATES = 94;

        public const int SPECIAL_ID_FOR_TOGGLE_VARIATIONS = 95;

        public const int SPECIAL_ID_FOR_PLATE_TEXT = 96;

        /// <summary>
        /// Gets the category name for mod
        /// </summary>
        /// <param name="index">Index of the mod</param>
        /// <returns></returns>
        public static string GetModCategoryName(int index)
        {
            switch (index)
            {
                case 0:
                    return "Spoiler";
                case 1:
                    return "Front Bumper";
                case 2:
                    return "Rear Bumper";
                case 3:
                    return "Side Skirts";
                case 4:
                    return "Exhaust";
                case 5:
                    return "Rollcage";
                case 6:
                    return "Grille";
                case 7:
                    return "Bonnet";
                case 8:
                    return "Fenders/Arches";
                case 10:
                    return "Roof";
                case 11:
                    return "Engine";
                case 12:
                    return "Brakes";
                case 13:
                    return "Transmission";
                case 14:
                    return "Horn";
                case 15:
                    return "Suspension";
                case 16:
                    return "Armor";
                case 22:
                    return "Headlights";
                case SPECIAL_ID_FOR_WHEEL_CATEGORY:
                    return "Wheel Category";
                case SPECIAL_ID_FOR_WHEEL_SELECTION:
                    return "Wheel Choice";
                case SPECIAL_ID_FOR_WINDOW_TINT:
                    return "Window Tint";
                case SPECIAL_ID_FOR_LICENSE_PLATES:
                    return "License Plates";
                default:
                    return index.ToString();
            }
        }

        /// <summary>
        /// Gets the title of special item
        /// </summary>
        /// <param name="category">Category index</param>
        /// <param name="index">Item index</param>
        /// <returns></returns>
        public static string GetSpecialItemTitle(int category, int index)
        {
            switch (category)
            {
                case SPECIAL_ID_FOR_LICENSE_PLATES:
                    return PLATE_NAMES[index];

                case SPECIAL_ID_FOR_WHEEL_CATEGORY:
                    return WHEEL_CATEGORY_NAMES[index];

                case SPECIAL_ID_FOR_WINDOW_TINT:
                    return TINT_NAMES[index];
            }
            return null;
        }

        /// <summary>
        /// Gets title of horn
        /// </summary>
        /// <param name="index">Horn index</param>
        /// <returns></returns>
        public static string GetHornTitle(int index)
        {
            if (index == 0)
            {
                return "Truck Horn";
            }
            else if (index == 1)
            {
                return "Cop Horn";
            }
            else if (index == 2)
            {
                return "Clown Horn";
            }
            else if (index >= 3 && index <= 7)
            {
                return "Musical Horn " + (index - 2).ToString();
            }
            else if (index == 8)
            {
                return "Sad Trombone";
            }
            else if (index >= 9 && index <= 15)
            {
                return "Classical Horn " + (index - 8).ToString();
            }
            else if (index >= 16 && index <= 23)
            {
                string suffix = null;
                switch (index)
                {
                    case 16:
                        suffix = "Do";
                        break;
                    case 17:
                        suffix = "Re";
                        break;
                    case 18:
                        suffix = "Mi";
                        break;
                    case 19:
                        suffix = "Fa";
                        break;
                    case 20:
                        suffix = "Sol";
                        break;
                    case 21:
                        suffix = "La";
                        break;
                    case 22:
                        suffix = "Ti";
                        break;
                    case 23:
                        suffix = "Do (High)";
                        break;
                }
                return "Scale - " + suffix;
            }
            else if (index >= 24 && index <= 26)
            {
                return "Jazz Horn " + (index - 23).ToString();
            }
            else if (index == 27)
            {
                return "Jazz Horn Loop";
            }
            else if (index >= 28)
            {
                return "Star spangled Banner " + (index - 27).ToString();
            }
            return "Unknown Horn";
        }

        /// <summary>
        /// Gets the title of a normal item
        /// </summary>
        /// <param name="vehicle">Vehicle handle</param>
        /// <param name="category">Category index</param>
        /// <param name="index">Item index</param>
        /// <param name="lastSelectedModValue">Last selected mod value</param>
        /// <returns></returns>
        public static string GetNormalItemTitle(int vehicle, int category, int index, int lastSelectedModValue)
        {
            // Engine stuff is EMS Upgrade, Level 1-4
            // Brakes/trans are stock, street, sports, race
            // Susp is stock,lowered,street,sport,competition
            // Armor is none, 20, 40, 60, 80, 100%

            string modItemNameStr = null;

            if (index == -1)
            {
                if (category == 16)
                {
                    modItemNameStr = "No Armor";
                }
                else
                {
                    modItemNameStr = "Stock " + GetModCategoryName(lastSelectedModValue);
                }
            }
            else if (category == 11) //Engine
            {
                modItemNameStr = "EMS Upgrade, Level " + (index + 1).ToString();
            }
            else if (category == 12 || category == 13) //brakes, trans
            {
                if (category == 12)
                {
                    modItemNameStr = " Brakes";
                }
                else
                {
                    modItemNameStr = " Transmission";
                }
            }
            else if (category == 14) //suspension
            {
                modItemNameStr = GetHornTitle(index);
            }
            else if (category == 15) //suspension
            {
                modItemNameStr = SUSP_PREFIXES[index] + " Suspension";
            }
            else if (category == 16) //Armor
            {
                modItemNameStr = ((index + 1) * 20).ToString() + "% Armor";
            }
            else
            {
                string modItemNameChr = Function.Call<string>(Hash.GET_MOD_TEXT_LABEL, vehicle, category, index);
                bool foundName = false;
                if (!string.IsNullOrEmpty(modItemNameChr))
                {
                    string modItemNameTxt = Function.Call<string>(Hash._GET_LABEL_TEXT, modItemNameChr);
                    if (modItemNameTxt != null)
                    {
                        modItemNameStr = modItemNameTxt;
                        foundName = true;
                    }
                }

                if (!foundName)
                {
                    modItemNameStr = GetModCategoryName(lastSelectedModValue) + " Item " + (index + 1).ToString();
                }
            }

            return modItemNameStr;
        }
    }
}
