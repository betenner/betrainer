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
    /// Skin/Prop detail info
    /// </summary>
    public struct SkinPropDetail
    {
        /// <summary>
        /// Count of available drawables
        /// </summary>
        public int DrawableCount;

        /// <summary>
        /// Count of available textures
        /// </summary>
        public int TextureCount;

        /// <summary>
        /// Category index
        /// </summary>
        public int Category;

        /// <summary>
        /// Drawable index
        /// </summary>
        public int Drawable;

        /// <summary>
        /// Texture index
        /// </summary>
        public int Texture;
    }
}
