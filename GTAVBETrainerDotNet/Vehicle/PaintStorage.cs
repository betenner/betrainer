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

namespace GTAVBETrainerDotNet.Vehicle
{
    /// <summary>
    /// Storage for paint data
    /// </summary>
    public static class PaintStorage
    {
        // Paint types
        public static readonly string[] PAINT_TYPES = {"Metallic", "Normal", "Matte", "Metal", "Chrome", };

        // Paints
        public static readonly PaintData[][] PAINTS =
        {
            new PaintData[] { new PaintData("Black", 0), new PaintData("Carbon Black", 1), new PaintData("Graphite Black", 2), new PaintData("Anthracite Black", 3), new PaintData("Black Steel", 4), new PaintData("Dark Steel", 5), new PaintData("Silver", 6), new PaintData("Bluish Silver", 7), new PaintData("Rolled Steel", 8), new PaintData("Shadow Silver", 9), new PaintData("Stone Silver", 10), new PaintData("Midnight Silver", 11), new PaintData("Cast Iron Silver", 12), new PaintData("Red", 13), new PaintData("Torino Red", 14), new PaintData("Formula Red", 15), new PaintData("Lava Red", 16), new PaintData("Blaze Red", 17), new PaintData("Grace Red", 18), new PaintData("Garnet Red", 19), new PaintData("Sunset Red", 20), new PaintData("Cabernet Red", 21), new PaintData("Wine Red", 22), new PaintData("Candy Red", 23), new PaintData("Hot Pink", 24), new PaintData("Pfister Pink", 25), new PaintData("Salmon Pink", 26), new PaintData("Sunrise Orange", 27), new PaintData("Orange", 28), new PaintData("Bright Orange", 29), new PaintData("Gold", 30), new PaintData("Bronze", 31), new PaintData("Yellow", 32), new PaintData("Race Yellow", 33), new PaintData("Dew Yellow", 34), new PaintData("Dark Green", 35), new PaintData("Racing Green", 36), new PaintData("Sea Green", 37), new PaintData("Olive Green", 38), new PaintData("Bright Green", 39), new PaintData("Gasoline Green", 40), new PaintData("Lime Green", 41), new PaintData("Midnight Blue", 42), new PaintData("Galaxy Blue", 43), new PaintData("Dark Blue", 44), new PaintData("Saxon Blue", 45), new PaintData("Blue", 46), new PaintData("Mariner Blue", 47), new PaintData("Harbor Blue", 48), new PaintData("Diamond Blue", 49), new PaintData("Surf Blue", 50), new PaintData("Nautical Blue", 51), new PaintData("Racing Blue", 52), new PaintData("Ultra Blue", 53), new PaintData("Light Blue", 54), new PaintData("Chocolate Brown", 55), new PaintData("Bison Brown", 56), new PaintData("Creek Brown", 57), new PaintData("Feltzer Brown", 58), new PaintData("Maple Brown", 59), new PaintData("Beechwood Brown", 60), new PaintData("Sienna Brown", 61), new PaintData("Saddle Brown", 62), new PaintData("Moss Brown", 63), new PaintData("Woodbeech Brown", 64), new PaintData("Straw Brown", 65), new PaintData("Sandy Brown", 66), new PaintData("Bleached Brown", 67), new PaintData("Schafter Purple", 68), new PaintData("Spinnaker Purple", 69), new PaintData("Midnight Purple", 70), new PaintData("Bright Purple", 71), new PaintData("Cream", 72), new PaintData("Ice White", 73), new PaintData("Frost White", 74), }, 
            new PaintData[] { new PaintData("Black", 0), new PaintData("Carbon Black", 1), new PaintData("Graphite Black", 2), new PaintData("Anthracite Black", 3), new PaintData("Black Steel", 4), new PaintData("Dark Steel", 5), new PaintData("Silver", 6), new PaintData("Bluish Silver", 7), new PaintData("Rolled Steel", 8), new PaintData("Shadow Silver", 9), new PaintData("Stone Silver", 10), new PaintData("Midnight Silver", 11), new PaintData("Cast Iron Silver", 12), new PaintData("Red", 13), new PaintData("Torino Red", 14), new PaintData("Formula Red", 15), new PaintData("Lava Red", 16), new PaintData("Blaze Red", 17), new PaintData("Grace Red", 18), new PaintData("Garnet Red", 19), new PaintData("Sunset Red", 20), new PaintData("Cabernet Red", 21), new PaintData("Wine Red", 22), new PaintData("Candy Red", 23), new PaintData("Hot Pink", 24), new PaintData("Pfister Pink", 25), new PaintData("Salmon Pink", 26), new PaintData("Sunrise Orange", 27), new PaintData("Orange", 28), new PaintData("Bright Orange", 29), new PaintData("Gold", 30), new PaintData("Bronze", 31), new PaintData("Yellow", 32), new PaintData("Race Yellow", 33), new PaintData("Dew Yellow", 34), new PaintData("Dark Green", 35), new PaintData("Racing Green", 36), new PaintData("Sea Green", 37), new PaintData("Olive Green", 38), new PaintData("Bright Green", 39), new PaintData("Gasoline Green", 40), new PaintData("Lime Green", 41), new PaintData("Midnight Blue", 42), new PaintData("Galaxy Blue", 43), new PaintData("Dark Blue", 44), new PaintData("Saxon Blue", 45), new PaintData("Blue", 46), new PaintData("Mariner Blue", 47), new PaintData("Harbor Blue", 48), new PaintData("Diamond Blue", 49), new PaintData("Surf Blue", 50), new PaintData("Nautical Blue", 51), new PaintData("Racing Blue", 52), new PaintData("Ultra Blue", 53), new PaintData("Light Blue", 54), new PaintData("Chocolate Brown", 55), new PaintData("Bison Brown", 56), new PaintData("Creek Brown", 57), new PaintData("Feltzer Brown", 58), new PaintData("Maple Brown", 59), new PaintData("Beechwood Brown", 60), new PaintData("Sienna Brown", 61), new PaintData("Saddle Brown", 62), new PaintData("Moss Brown", 63), new PaintData("Woodbeech Brown", 64), new PaintData("Straw Brown", 65), new PaintData("Sandy Brown", 66), new PaintData("Bleached Brown", 67), new PaintData("Schafter Purple", 68), new PaintData("Spinnaker Purple", 69), new PaintData("Midnight Purple", 70), new PaintData("Bright Purple", 71), new PaintData("Cream", 72), new PaintData("Ice White", 73), new PaintData("Frost White", 74), }, 
            new PaintData[] { new PaintData("Black", 0), new PaintData("Gray", 1), new PaintData("Light Gray", 2), new PaintData("Ice White", 3), new PaintData("Blue", 4), new PaintData("Dark Blue", 5), new PaintData("Midnight Blue", 6), new PaintData("Midnight Purple", 7), new PaintData("Schafter Purple", 8), new PaintData("Red", 9), new PaintData("Dark Red", 10), new PaintData("Orange", 11), new PaintData("Yellow", 12), new PaintData("Lime Green", 13), new PaintData("Green", 14), new PaintData("Forest Green", 15), new PaintData("Foliage Green", 16), new PaintData("Olive Drab", 17), new PaintData("Dark Earth", 18), new PaintData("Desert Tan", 19), }, 
            new PaintData[] { new PaintData("Brushed Steel", 0), new PaintData("Brushed Black Steel", 1), new PaintData("Brushed Aluminum", 2), new PaintData("Pure Gold", 3), new PaintData("Brushed Gold", 4), }, 
            new PaintData[] { new PaintData("Chrome", 0), }, 
        };

        /// <summary>
        /// Pearl topcoat paints
        /// </summary>
        public static readonly PaintData[] PEARL_TOPCOAT_PAINTS = { new PaintData("Black", 0), new PaintData("Carbon Black", 1), new PaintData("Graphite Black", 2), new PaintData("Anthracite Black", 3), new PaintData("Black Steel", 4), new PaintData("Dark Steel", 5), new PaintData("Silver", 6), new PaintData("Bluish Silver", 7), new PaintData("Rolled Steel", 8), new PaintData("Shadow Silver", 9), new PaintData("Stone Silver", 10), new PaintData("Midnight Silver", 11), new PaintData("Cast Iron Silver", 12), new PaintData("Red", 13), new PaintData("Torino Red", 14), new PaintData("Formula Red", 15), new PaintData("Lava Red", 16), new PaintData("Blaze Red", 17), new PaintData("Grace Red", 18), new PaintData("Garnet Red", 19), new PaintData("Sunset Red", 20), new PaintData("Cabernet Red", 21), new PaintData("Wine Red", 22), new PaintData("Candy Red", 23), new PaintData("Hot Pink", 24), new PaintData("Pfister Pink", 25), new PaintData("Salmon Pink", 26), new PaintData("Sunrise Orange", 27), new PaintData("Orange", 28), new PaintData("Bright Orange", 29), new PaintData("Gold", 30), new PaintData("Bronze", 31), new PaintData("Yellow", 32), new PaintData("Race Yellow", 33), new PaintData("Dew Yellow", 34), new PaintData("Dark Green", 35), new PaintData("Racing Green", 36), new PaintData("Sea Green", 37), new PaintData("Olive Green", 38), new PaintData("Bright Green", 39), new PaintData("Gasoline Green", 40), new PaintData("Lime Green", 41), new PaintData("Midnight Blue", 42), new PaintData("Galaxy Blue", 43), new PaintData("Dark Blue", 44), new PaintData("Saxon Blue", 45), new PaintData("Blue", 46), new PaintData("Mariner Blue", 47), new PaintData("Harbor Blue", 48), new PaintData("Diamond Blue", 49), new PaintData("Surf Blue", 50), new PaintData("Nautical Blue", 51), new PaintData("Racing Blue", 52), new PaintData("Ultra Blue", 53), new PaintData("Light Blue", 54), new PaintData("Chocolate Brown", 55), new PaintData("Bison Brown", 56), new PaintData("Creek Brown", 57), new PaintData("Feltzer Brown", 58), new PaintData("Maple Brown", 59), new PaintData("Beechwood Brown", 60), new PaintData("Sienna Brown", 61), new PaintData("Saddle Brown", 62), new PaintData("Moss Brown", 63), new PaintData("Woodbeech Brown", 64), new PaintData("Straw Brown", 65), new PaintData("Sandy Brown", 66), new PaintData("Bleached Brown", 67), new PaintData("Schafter Purple", 68), new PaintData("Spinnaker Purple", 69), new PaintData("Midnight Purple", 70), new PaintData("Bright Purple", 71), new PaintData("Cream", 72), new PaintData("Ice White", 73), new PaintData("Frost White", 74), };

        /// <summary>
        /// Wheels paints
        /// </summary>
        public static readonly PaintData[] WHEELS_PAINTS = { new PaintData("Bright Silver", 5), new PaintData("Aluminum", 119), new PaintData("Alloy", 156), new PaintData("Black", 0), new PaintData("Carbon Black", 1), new PaintData("Anthracite Black", 11), new PaintData("Black Steel", 2), new PaintData("Stone Silver", 8), new PaintData("Frost White", 122), new PaintData("Red", 27), new PaintData("Blaze Red", 30), new PaintData("Garnet Red", 45), new PaintData("Candy Red", 35), new PaintData("Sunset Red", 33), new PaintData("Salmon Pink", 136), new PaintData("Hot Pink", 135), new PaintData("Sunrise Orange", 36), new PaintData("Orange", 41), new PaintData("Bright Orange", 138), new PaintData("Gold", 37), new PaintData("Straw Brown", 99), new PaintData("Dark Copper", 90), new PaintData("Dark Ivory", 95), new PaintData("Dark Brown", 115), new PaintData("Bronze", 109), new PaintData("Dark Earth", 153), new PaintData("Desert Tan", 154), new PaintData("Yellow", 88), new PaintData("Race Yellow", 89), new PaintData("Yellow Bird", 91), new PaintData("Lime Green", 55), new PaintData("Pea Green", 125), new PaintData("Green", 53), new PaintData("Dark Green", 56), new PaintData("Olive Green", 151), new PaintData("Midnight Blue", 82), new PaintData("Royal Blue", 64), new PaintData("Baby Blue", 87), new PaintData("Bright Blue", 70), new PaintData("Flourescent Blue", 140), new PaintData("Slate Blue", 81), new PaintData("Schafter Purple", 145), new PaintData("Midnight Purple", 142), };

        /// <summary>
        /// Finds the index of the wheel paint by internal value
        /// </summary>
        /// <param name="value">Internal value of the wheel paint</param>
        /// <returns></returns>
        public static int FindWheelPaintByValue(int value)
        {
            for (int i = 0; i < WHEELS_PAINTS.Length; i++)
            {
                if (WHEELS_PAINTS[i].InternalValue == value) return i;
            }

            return 0;
        }
    }
}
