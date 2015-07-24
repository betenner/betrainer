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
using System.Drawing;
using GTA;

namespace GTAVBETrainerDotNet
{
    public class Trainer : Script
    {
        /// <summary>
        /// Is the trainer initializing
        /// </summary>
        public static bool IsInitializing = false;

        /// <summary>
        /// Frame counter
        /// </summary>
        public static int FrameCounter = 0;

        /// <summary>
        /// Whether showing the trainer menu
        /// </summary>
        public static bool ShowingTrainerMenu = false;

        /// <summary>
        /// Language code
        /// </summary>
        public static int LanguageCode = Language.CODE_ENGLISH;

        public Trainer()
        {
            IsInitializing = true;

            // Show trainer info
            Utils.ShowNotificationAboveMap(GlobalConst.Message.TRAINER_INITIALIZING);

            // Load configurations
            Configuration.Load();

            // Initialization
            Menu.MenuStorage.InitMenus();

            // Init toggle features
            Feature.InitFeatures();

            // Key handling
            this.KeyDown += Trainer_KeyDown;
            this.Tick += Trainer_Tick;

            Utils.ShowNotificationAboveMap(GlobalConst.Message.TRAINER_INITIALIZED);

            IsInitializing = false;
        }

        void Trainer_Tick(object sender, EventArgs e)
        {
            if (Game.IsPaused) return;
            
            FrameCounter++;

            Update();
            Draw();
        }

        void Trainer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Game.IsPaused) return;

            if (e.KeyCode == Configuration.InputKey.StopVehicle)
            {
                Feature.Vehicle.StopVehicle();
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuBack)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.MenuStorage.ReturnToPrevMenu();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuDown)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                    if (menu != null) menu.MoveDown();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuLeft)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                    if (menu != null) menu.MoveLeft();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuRight)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                    if (menu != null) menu.MoveRight();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuSelect)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                    if (menu != null) menu.Activate();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.MenuUp)
            {
                if (ShowingTrainerMenu)
                {
                    Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                    if (menu != null) menu.MoveUp();
                }
            }
            
            else if (e.KeyCode == Configuration.InputKey.ToggleMenu)
            {
                ShowingTrainerMenu = !ShowingTrainerMenu;
                Menu.MenuStorage.PlayMenuBeep();
            }

        }

        void Draw()
        {
            if (ShowingTrainerMenu)
            {
                Menu.Menu menu = Menu.MenuStorage.GetCurrentMenu();
                if (menu != null) menu.Draw();
            }

            Feature.Location.DrawCoordinate();
        }

        void Update()
        {
            Feature.UpdateFeatures();
        }
    }
}
