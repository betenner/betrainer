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

namespace GTAVBETrainerDotNet.Weapon
{
    /// <summary>
    /// Weapon storage
    /// </summary>
    public static class WeaponStorage
    {
        /// <summary>
        /// Weapon tints
        /// </summary>
        public enum WeaponTint
        {
            Normal = 0,
            Green = 1,
            Gold = 2,
            Pink = 3,
            Army = 4,
            LSPD = 5,
            Orange = 6,
            Platinum = 7,
        }

        /// <summary>
        /// Weapon categories
        /// </summary>
        public enum WeaponCategory
        {
            Melee = 0,
            Handguns = 1,
            SubmachineGuns = 2,
            AssaultRifles = 3,
            Shotguns = 4,
            SniperRifles = 5,
            HeavyWeapons = 6,
            ThrownWeapons = 7,
        }

        public const int PARACHUTE_HASH = -72657034;
        public const int WEAPON_CATEGORY_COUNT = 8;
        public const int TOTAL_WEAPONS_COUNT = 54;
        public const int TOTAL_WEAPONS_SLOTS = 57;
        public const int MAX_ATTACHMENT_SLOTS = 15;
        public const string WEAPON_UNARMED = "WEAPON_UNARMED";

        public static readonly MLString[] WEAPON_CATEGORY_NAMES = 
        { 
            Utils.CTML("Melee", "近戰武器"), 
            Utils.CTML("Handguns", "手槍"), 
            Utils.CTML("Submachine Guns", "機關槍"), 
            Utils.CTML("Assault Rifles", "衝鋒槍"), 
            Utils.CTML("Shotguns", "散彈槍"), 
            Utils.CTML("Sniper Rifles", "阻擊槍"), 
            Utils.CTML("Heavy Weapons", "重型武器"), 
            Utils.CTML("Thrown Weapons", "投擲武器"), 
        };

        public static readonly WeaponData[][] WEAPONS = 
        {
            // Melee
            new WeaponData[]
            {
                new WeaponData("Knife", "WEAPON_KNIFE", false),
                new WeaponData("Nightstick", "WEAPON_NIGHTSTICK", false),
                new WeaponData("Hammer", "WEAPON_HAMMER", false),
                new WeaponData("Baseball Bat", "WEAPON_BAT", false),
                new WeaponData("Golf Club", "WEAPON_GOLFCLUB", false),
                new WeaponData("Crowbar", "WEAPON_CROWBAR", false),
                new WeaponData("Bottle", "WEAPON_BOTTLE", false),
                new WeaponData("Antique Dagger", "WEAPON_DAGGER", false),
                new WeaponData("Hatchet", "WEAPON_HATCHET", false),
            },

            // Handguns
            new WeaponData[]
            {
                new WeaponData("Pistol", "WEAPON_PISTOL", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_PISTOL_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_PISTOL_VARMOD_LUXE")),
                new WeaponData("Combat Pistol", "WEAPON_COMBATPISTOL", true, 
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_COMBATPISTOL_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH")),
                new WeaponData("AP Pistol", "WEAPON_APPISTOL", true, 
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_APPISTOL_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH"),
                    new WeaponAttachmentData("Gilded Gun Metal Finish", "COMPONENT_APPISTOL_VARMOD_LUXE")),
                new WeaponData("Pistol .50", "WEAPON_PISTOL50", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_PISTOL50_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH"),
                    new WeaponAttachmentData("Platinum Pearl Deluxe Finish", "COMPONENT_PISTOL50_VARMOD_LUXE")),
                new WeaponData("SNS Pistol", "WEAPON_SNSPISTOL", true, 
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_SNSPISTOL_CLIP_02")),
                new WeaponData("Heavy Pistol", "WEAPON_HEAVYPISTOL", true, 
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_HEAVYPISTOL_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH"),
                    new WeaponAttachmentData("Etched Wood Grip Finish", "COMPONENT_HEAVYPISTOL_VARMOD_LUXE")),
                new WeaponData("Vintage Pistol", "WEAPON_VINTAGEPISTOL", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_VINTAGEPISTOL_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP")),
                new WeaponData("Stun Gun", "WEAPON_STUNGUN"),
                new WeaponData("Flare Gun", "WEAPON_FLAREGUN"),
            },

            // Submachine Guns
            new WeaponData[]
            {
                new WeaponData("Micro SMG", "WEAPON_MICROSMG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_MICROSMG_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MACRO"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_PI_FLSH"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_MICROSMG_VARMOD_LUXE")),
                new WeaponData("SMG", "WEAPON_SMG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_SMG_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MACRO_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_PI_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_SMG_VARMOD_LUXE")),
                new WeaponData("Assault SMG", "WEAPON_ASSAULTSMG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_ASSAULTSMG_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MACRO"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH")),
                new WeaponData("MG", "WEAPON_MG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_MG_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_SMALL_02")),
                new WeaponData("Combat MG", "WEAPON_COMBATMG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_COMBATMG_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MEDIUM"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
                new WeaponData("Gusenberg Sweeper", "WEAPON_GUSENBERG", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_GUSENBERG_CLIP_02")),
                new WeaponData("Combat PDW", "WEAPON_COMBATPDW", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_COMBATPDW_CLIP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_SMALL"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
            },

            // Assault Rifles
            new WeaponData[]
            {
                new WeaponData("Assault Rifle", "WEAPON_ASSAULTRIFLE", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_ASSAULTRIFLE_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MACRO"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_ASSAULTRIFLE_VARMOD_LUXE")),
                new WeaponData("Carbine Rifle", "WEAPON_CARBINERIFLE", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_CARBINERIFLE_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MEDIUM"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_CARBINERIFLE_VARMOD_LUXE")),
                new WeaponData("Advanced Rifle", "WEAPON_ADVANCEDRIFLE", true, 
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_ADVANCEDRIFLE_CLIP_02"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_SMALL"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Gilded Gun Metal Finish", "COMPONENT_ADVANCEDRIFLE_VARMOD_LUXE")),
                new WeaponData("Special Carbine", "WEAPON_SPECIALCARBINE", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_SPECIALCARBINE_CLIP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_MEDIUM"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
                new WeaponData("Bullpup Rifle", "WEAPON_BULLPUPRIFLE", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_BULLPUPRIFLE_CLIP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_SMALL"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
            },

            // Shotguns
            new WeaponData[]
            {
                new WeaponData("Pump Shotgun", "WEAPON_PUMPSHOTGUN", true,
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_SR_SUPP"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH")),
                new WeaponData("Sawed-Off Shotgun", "WEAPON_SAWNOFFSHOTGUN", true,
                    new WeaponAttachmentData("Gilded Gun Metal Finish", "COMPONENT_SAWNOFFSHOTGUN_VARMOD_LUXE")),
                new WeaponData("Bullpup Shotgun", "WEAPON_BULLPUPSHOTGUN", true,
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
                new WeaponData("Assault Shotgun", "WEAPON_ASSAULTSHOTGUN", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_ASSAULTSHOTGUN_CLIP_02"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
                new WeaponData("Musket", "WEAPON_MUSKET"),
                new WeaponData("Heavy Shotgun", "WEAPON_HEAVYSHOTGUN", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_HEAVYSHOTGUN_CLIP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
            },

            // Sniper Rifles
            new WeaponData[]
            {
                new WeaponData("Sniper Rifle", "WEAPON_SNIPERRIFLE", true,
                    new WeaponAttachmentData("Advanced Scope", "COMPONENT_AT_SCOPE_MAX"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP_02"),
                    new WeaponAttachmentData("Etched Wood Grip Finish", "COMPONENT_SNIPERRIFLE_VARMOD_LUXE")),
                new WeaponData("Heavy Sniper", "WEAPON_HEAVYSNIPER", true,
                    new WeaponAttachmentData("Normal Scope", "COMPONENT_AT_SCOPE_LARGE")),
                new WeaponData("Marksman Rifle", "WEAPON_MARKSMANRIFLE", true,
                    new WeaponAttachmentData("Extended Magazine", "COMPONENT_MARKSMANRIFLE_CLIP_02"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Suppressor", "COMPONENT_AT_AR_SUPP"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP"),
                    new WeaponAttachmentData("Yusuf Amir Luxury Finish", "COMPONENT_MARKSMANRIFLE_VARMOD_LUXE")),
            },

            // Heavy Weapons
            new WeaponData[]
            {
                new WeaponData("Grenade Launcher", "WEAPON_GRENADELAUNCHER", true,
                    new WeaponAttachmentData("Scope", "COMPONENT_AT_SCOPE_SMALL"),
                    new WeaponAttachmentData("Flashlight", "COMPONENT_AT_AR_FLSH"),
                    new WeaponAttachmentData("Grip", "COMPONENT_AT_AR_AFGRIP")),
                new WeaponData("RPG", "WEAPON_RPG"),
                new WeaponData("Minigun", "WEAPON_MINIGUN"),
                new WeaponData("Fireworks Launcher", "WEAPON_FIREWORK"),
                new WeaponData("Railgun", "WEAPON_RAILGUN"),
                new WeaponData("Homing Launcher", "WEAPON_HOMINGLAUNCHER"),
            },

            // Thrown Weapons
            new WeaponData[]
            {
                new WeaponData("Grenade", "WEAPON_GRENADE", false),
                new WeaponData("Sticky Bomb", "WEAPON_STICKYBOMB", false),
                new WeaponData("Proximity Mine", "WEAPON_PROXMINE", false),
                new WeaponData("Teargas", "WEAPON_SMOKEGRENADE", false),
                new WeaponData("Molotov", "WEAPON_MOLOTOV", false),
                new WeaponData("Fire Extinguisher", "WEAPON_FIREEXTINGUISHER", false),
                new WeaponData("Jerry Can", "WEAPON_PETROLCAN", false),
                new WeaponData("Snowball", "WEAPON_SNOWBALL", false),
                new WeaponData("Flare", "WEAPON_FLARE", false),
            },
        };
    }
}
