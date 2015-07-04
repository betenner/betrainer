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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Windows API interfaces
    /// </summary>
    public static class WinAPI
    {
        [DllImport("user32.dll", EntryPoint = "GetKeyState")]
        private static extern int GetKeyState(int key);

        /// <summary>
        /// Is the specified is pressed down.
        /// </summary>
        /// <param name="key">Key code</param>
        /// <returns></returns>
        public static bool IsKeyDown(Keys key)
        {
            return ((GetKeyState((int)key) & 0x8000) != 0) ? true : false;
        }
    }
}
