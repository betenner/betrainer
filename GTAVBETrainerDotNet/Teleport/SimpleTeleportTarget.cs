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

namespace GTAVBETrainerDotNet.Teleport
{
    /// <summary>
    /// A simple teleport target which does not require any IPL operation
    /// </summary>
    public class SimpleTeleportTarget : IComparable<SimpleTeleportTarget>
    {
        /// <summary>
        /// Name of the target
        /// </summary>
        public MLString Name = null;

        /// <summary>
        /// Coordinates of the target
        /// </summary>
        public GTA.Math.Vector3 Coords;

        /// <summary>
        /// Index in list, just for reference
        /// </summary>
        public int Index = 0;

        /// <summary>
        /// Creates a simple teleport target
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        public SimpleTeleportTarget(MLString name, float x, float y, float z)
        {
            Name = name;
            Coords = new GTA.Math.Vector3(x, y, z);
        }

        public int CompareTo(SimpleTeleportTarget other)
        {
            return this.Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Serializes this target
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name.Replace(GlobalConst.SERIALIZATION_COMMA, GlobalConst.SERIALIZATION_COMMA_REPLACEMENT)); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(Coords.X); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(Coords.Y); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(Coords.Z); sb.Append(GlobalConst.SERIALIZATION_COMMA);

            return sb.ToString();
        }

        /// <summary>
        /// Deserializes this target
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static SimpleTeleportTarget Deserialize(string data)
        {
            try
            {
                string[] items = data.Split(new string[] { GlobalConst.SERIALIZATION_COMMA }, StringSplitOptions.RemoveEmptyEntries);
                return new SimpleTeleportTarget(items[0].Replace(GlobalConst.SERIALIZATION_COMMA_REPLACEMENT, GlobalConst.SERIALIZATION_COMMA), Utils.ParseFloat(items[1]), Utils.ParseFloat(items[2]), Utils.ParseFloat(items[3]));
            }
            catch
            {
                return null;
            }
        }
    }
}
