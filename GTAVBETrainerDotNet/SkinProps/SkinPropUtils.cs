//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015-2020
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVBETrainerDotNet.SkinProps
{
    /// <summary>
    /// Skin utilities
    /// </summary>
    public static class SkinPropUtils
    {
        /// <summary>
        /// Total count of skin categories.
        /// </summary>
        public const int SKIN_CATEGORY_COUNT = 12;

        /// <summary>
        /// Total count of prop categories.
        /// </summary>
        public const int PROP_CATEGORY_COUNT = 10;

        /// <summary>
        /// Max drawable count for each skin category.
        /// </summary>
        public const int SKIN_CATEGORY_DRAWABLE_MAX_COUNT = 50;

        /// <summary>
        /// Max drawable count for each prop category.
        /// </summary>
        public const int PROP_CATEGORY_DRAWABLE_MAX_COUNT = 50;

        /// <summary>
        /// Default skin drawable index
        /// </summary>
        public const int DEFAULT_SKIN_DRAWABLE = 0;

        /// <summary>
        /// Default prop drawable index
        /// </summary>
        public const int DEFAULT_PROP_DRAWABLE = -1;

        /// <summary>
        /// Gets the description of a skin category
        /// </summary>
        /// <param name="skinCategoryIndex">Skin category index</param>
        /// <returns></returns>
        public static string GetSkinCategoryDesc(int skinCategoryIndex)
        {
           	switch (skinCategoryIndex)
	        {
	            case 0:
		            return "Head/Face";
	            case 1:
		            return "Beard/Mask";
	            case 2:
		            return "Hair/Hat";
	            case 3:
		            return "Top";
	            case 4:
		            return "Legs";
	            case 5:
		            return "Accessory/Gloves";
	            case 6:
		            return "Accessory/Shoes";
	            case 7:
                    return "Accessory";
	            case 8:
                    return "Accessory";
	            case 9:
		            return "Accessory";
	            case 10:
		            return "Badges";
	            case 11:
		            return "Shirt/Jacket";
	            default:
		            return skinCategoryIndex.ToString();
	        }
        }

        /// <summary>
        /// Gets the description of a prop category
        /// </summary>
        /// <param name="propCategoryIndex">Prop category index</param>
        /// <returns></returns>
        public static string GetPropCategoryDesc(int propCategoryIndex)
        {
            switch (propCategoryIndex)
            {
                case 0:
                    return "Hats/Masks/Helmets";
                case 1:
                    return "Glasses";
                case 2:
                    return "Earrings";
                default:
                    return "??? " + propCategoryIndex.ToString();
            }
        }
    }
}
