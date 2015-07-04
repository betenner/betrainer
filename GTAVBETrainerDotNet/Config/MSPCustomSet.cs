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
using GTAVBETrainerDotNet.SkinProps;

namespace GTAVBETrainerDotNet.Config
{
    /// <summary>
    /// Player Model & Skin & Props custom set
    /// </summary>
    public class MSPCustomSet : IComparable<MSPCustomSet>
    {
        /// <summary>
        /// Name of the set
        /// </summary>
        public string Name = null;

        /// <summary>
        /// Model hash
        /// </summary>
        public int ModelHash = 0;

        /// <summary>
        /// Index in list, just for reference
        /// </summary>
        public int Index = 0;

        /// <summary>
        /// Skin drawables for each category
        /// </summary>
        public int[] SkinDrawables = null;

        /// <summary>
        /// Skin textures for each drawable
        /// </summary>
        public int[] SkinTextures = null;

        /// <summary>
        /// Prop drawables for each category
        /// </summary>
        public int[] PropDrawables = null;

        /// <summary>
        /// Prop textures for each drawable
        /// </summary>
        public int[] PropTextures = null;

        public int CompareTo(MSPCustomSet other)
        {
            return this.Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Serializes this object
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name.Replace(GlobalConst.SERIALIZATION_COMMA, GlobalConst.SERIALIZATION_COMMA_REPLACEMENT)); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            sb.Append(ModelHash); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            for (int i = 0; i < SkinPropUtils.SKIN_CATEGORY_COUNT; i++)
            {
                sb.Append(SkinDrawables[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
                sb.Append(SkinTextures[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            }
            for (int i = 0; i < SkinPropUtils.PROP_CATEGORY_COUNT; i++)
            {
                sb.Append(PropDrawables[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
                sb.Append(PropTextures[i]); sb.Append(GlobalConst.SERIALIZATION_COMMA);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Deserializes a MSPCustomSet object
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static MSPCustomSet Deserialize(string data)
        {
            MSPCustomSet set = new MSPCustomSet();

            string[] items = data.Split(new string[] { GlobalConst.SERIALIZATION_COMMA }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                int index = 0;
                set.Name = items[index++].Replace(GlobalConst.SERIALIZATION_COMMA_REPLACEMENT, GlobalConst.SERIALIZATION_COMMA);
                set.ModelHash = Utils.ParseInt(items[index++]);
                set.SkinDrawables = new int[SkinPropUtils.SKIN_CATEGORY_COUNT];
                set.SkinTextures = new int[SkinPropUtils.SKIN_CATEGORY_COUNT];
                set.PropDrawables = new int[SkinPropUtils.PROP_CATEGORY_COUNT];
                set.PropTextures = new int[SkinPropUtils.PROP_CATEGORY_COUNT];
                for (int i = 0; i < SkinPropUtils.SKIN_CATEGORY_COUNT; i++)
                {
                    set.SkinDrawables[i] = Utils.ParseInt(items[index++]);
                    set.SkinTextures[i] = Utils.ParseInt(items[index++]);
                }
                for (int i = 0; i < SkinPropUtils.PROP_CATEGORY_COUNT; i++)
                {
                    set.PropDrawables[i] = Utils.ParseInt(items[index++]);
                    set.PropTextures[i] = Utils.ParseInt(items[index++]);
                }
            }
            catch
            {
                return null;
            }

            return set;
        }
    }
}
