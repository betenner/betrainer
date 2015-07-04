using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GTAVBETrainerDotNet.Vehicle
{
    /// <summary>
    /// Custom vehicle
    /// </summary>
    public class CustomVehicle : IComparable<CustomVehicle>
    {
        public const int MOD_COLOR_1_SLOTS = 3;
        public const int MOD_COLOR_2_SLOTS = 2;
        public const int EXTRA_COUNT = 10;
        public const int MOD_COUNT = 25;
        public const int TOGGLE_BEGIN = 17;
        public const int TOGGLE_END = 22;

        /// <summary>
        /// Index in list, just for reference
        /// </summary>
        public int Index = 0;

        /// <summary>
        /// Name of this custom vehicle
        /// </summary>
        public string Name = null;

        /// <summary>
        /// Model hash
        /// </summary>
        public int Model = 0;

        /// <summary>
        /// Primary color
        /// </summary>
        public int PrimaryColor = 0;

        /// <summary>
        /// Secondary color
        /// </summary>
        public int SecondaryColor = 0;

        /// <summary>
        /// Pearl topcoat color
        /// </summary>
        public int PearlTopcoatColor = 0;

        /// <summary>
        /// Wheel color
        /// </summary>
        public int WheelColor = 0;

        /// <summary>
        /// Mod color 1
        /// </summary>
        public int[] ModColor1 = new int[MOD_COLOR_1_SLOTS];

        /// <summary>
        /// Mod color 2
        /// </summary>
        public int[] ModColor2 = new int[MOD_COLOR_2_SLOTS];

        /// <summary>
        /// Custom primary color
        /// </summary>
        public Color CustomPrimaryColor = Color.Black;

        /// <summary>
        /// Custom secondary color
        /// </summary>
        public Color CustomSecondaryColor = Color.Black;

        /// <summary>
        /// Livery
        /// </summary>
        public int Livery = 0;

        /// <summary>
        /// License plate text
        /// </summary>
        public string LicensePlateText = null;

        /// <summary>
        /// Index of license plate
        /// </summary>
        public int LicensePlateIndex = 0;

        /// <summary>
        /// Wheel type
        /// </summary>
        public int WheelType = 0;

        /// <summary>
        /// Window tint
        /// </summary>
        public int WindowTint = 0;

        /// <summary>
        /// Bulletproof tyre
        /// </summary>
        public bool BulletproofTyre = false;

        /// <summary>
        /// Custom tyre
        /// </summary>
        public bool CustomTyre = false;

        /// <summary>
        /// Extras
        /// </summary>
        public bool?[] ExtraEnbled = new bool?[EXTRA_COUNT];

        /// <summary>
        /// Non-toggle mods
        /// </summary>
        public int[] Mods = new int[MOD_COUNT - (TOGGLE_END - TOGGLE_BEGIN) - 1];

        /// <summary>
        /// Toggle mods
        /// </summary>
        public bool[] Toggles = new bool[TOGGLE_END - TOGGLE_BEGIN + 1];

        /// <summary>
        /// Serializes this custom vehicle
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            StringBuilder sb = new StringBuilder(300);

            sb.Append(this.Name.Replace(GlobalConst.SERIALIZATION_COMMA, GlobalConst.SERIALIZATION_COMMA_REPLACEMENT)); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.Model); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.PrimaryColor); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.SecondaryColor); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.PearlTopcoatColor); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.WheelColor); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            for (int i = 0; i < MOD_COLOR_1_SLOTS; i++)
            {
                sb.Append(this.ModColor1[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            }
            for (int i = 0; i < MOD_COLOR_2_SLOTS; i++)
            {
                sb.Append(this.ModColor2[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            }
            sb.Append(this.CustomPrimaryColor.R); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomPrimaryColor.G); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomPrimaryColor.B); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomSecondaryColor.R); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomSecondaryColor.G); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomSecondaryColor.B); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.Livery); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.LicensePlateText.Replace(GlobalConst.SERIALIZATION_COMMA, GlobalConst.SERIALIZATION_COMMA_REPLACEMENT)); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.LicensePlateIndex); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.WheelType); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.WindowTint); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.BulletproofTyre ? '1' : '0'); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(this.CustomTyre ? '1' : '0'); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            for (int i = 0; i < EXTRA_COUNT; i++)
            {
                sb.Append(this.ExtraEnbled[i].HasValue ? (this.ExtraEnbled[i].Value ? "1" : "0") : "-1"); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            }
            int modIndex = 0;
            int toggleIndex = 0;
            for (int i = 0; i < MOD_COUNT; i++)
            {
                if (i >= TOGGLE_BEGIN && i <= TOGGLE_END)
                {
                    sb.Append(this.Toggles[toggleIndex++] ? '1' : '0'); sb.Append(GlobalConst.SERIALIZATION_COMMA);
                }
                else
                {
                    sb.Append(this.Mods[modIndex++]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Deserializes a custom vehicle data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static CustomVehicle Deserialize(string data)
        {
            try
            {
                CustomVehicle cv = new CustomVehicle();

                string[] items = data.Split(new string[] { GlobalConst.SERIALIZATION_COMMA }, StringSplitOptions.RemoveEmptyEntries);

                int index = 0;
                cv.Name = items[index++].Replace(GlobalConst.SERIALIZATION_COMMA_REPLACEMENT, GlobalConst.SERIALIZATION_COMMA);
                cv.Model = Utils.ParseInt(items[index++]);
                cv.PrimaryColor = Utils.ParseInt(items[index++]);
                cv.SecondaryColor = Utils.ParseInt(items[index++]);
                cv.PearlTopcoatColor = Utils.ParseInt(items[index++]);
                cv.WheelColor = Utils.ParseInt(items[index++]);
                for (int i = 0; i < MOD_COLOR_1_SLOTS; i++)
                {
                    cv.ModColor1[i] = Utils.ParseInt(items[index++]);
                }
                for (int i = 0; i < MOD_COLOR_2_SLOTS; i++)
                {
                    cv.ModColor2[i] = Utils.ParseInt(items[index++]);
                }
                int r = 0, g = 0, b = 0;
                r = Utils.ParseInt(items[index++]);
                g = Utils.ParseInt(items[index++]);
                b = Utils.ParseInt(items[index++]);
                cv.CustomPrimaryColor = Color.FromArgb(r, g, b);
                r = Utils.ParseInt(items[index++]);
                g = Utils.ParseInt(items[index++]);
                b = Utils.ParseInt(items[index++]);
                cv.CustomSecondaryColor = Color.FromArgb(r, g, b);
                cv.Livery = Utils.ParseInt(items[index++]);
                cv.LicensePlateText = items[index++].Replace(GlobalConst.SERIALIZATION_COMMA_REPLACEMENT, GlobalConst.SERIALIZATION_COMMA);
                cv.LicensePlateIndex = Utils.ParseInt(items[index++]);
                cv.WheelType = Utils.ParseInt(items[index++]);
                cv.WindowTint = Utils.ParseInt(items[index++]);
                cv.BulletproofTyre = Utils.ParseBool(items[index++]);
                cv.CustomTyre = Utils.ParseBool(items[index++]);
                for (int i = 0; i < EXTRA_COUNT; i++)
                {
                    cv.ExtraEnbled[i] = Utils.ParseNullableBool(items[index++]);
                }
                int modIndex = 0;
                int toggleIndex = 0;
                for (int i = 0; i < MOD_COUNT; i++)
                {
                    if (i >= TOGGLE_BEGIN && i <= TOGGLE_END)
                    {
                        cv.Toggles[toggleIndex++] = Utils.ParseBool(items[index++]);
                    }
                    else
                    {
                        cv.Mods[modIndex++] = Utils.ParseInt(items[index++]);
                    }
                }

                return cv;
            }
            catch
            {
                return null;
            }
        }

        public int CompareTo(CustomVehicle other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
