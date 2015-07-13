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
using GTAVBETrainerDotNet.Menu;

namespace GTAVBETrainerDotNet.Teleport
{
    /// <summary>
    /// Teleport targets storage
    /// </summary>
    public static class TeleportTargetStorage
    {
        /// <summary>
        /// Safehouses
        /// </summary>
        public static readonly TeleportTarget[] SAFEHOUSES =
        {
	        new TeleportTarget ( "Michael's Safehouse", -827.138f, 176.368f, 70.4999f ),
	        new TeleportTarget ( "Michael's Safehouse Inside", -813.603f, 179.474f, 72.1548f ),
	        new TeleportTarget ( "Franklin's Safehouse 1", -18.0355f, -1456.94f, 30.4548f ),
	        new TeleportTarget ( "Franklin's Safehouse 1 Inside", -14.3803f, -1438.51f, 31.1073f ),
	        new TeleportTarget ( "Franklin's Safehouse 2", 10.8766f, 545.654f, 175.419f ),
	        new TeleportTarget ( "Franklin's Safehouse 2 Inside", 7.11903f, 536.615f, 176.028f ),
	        new TeleportTarget ( "Trevor's Safehouse 1", 1982.13f, 3829.44f, 32.3662f ),
	        new TeleportTarget ( "Trevor's Safehouse 1 Inside", 1972.61f, 3817.04f, 33.4278f ),
	        new TeleportTarget ( "Trevor's Safehouse 2", -1157.05f, -1512.73f, 4.2127f ),
	        new TeleportTarget ( "Trevor's Safehouse 2 Inside", -1151.77f, -1518.14f, 10.6327f ),
	        new TeleportTarget ( "Trevor's Safehouse 3", 91.1407f, -1280.65f, 29.1353f ),
	        new TeleportTarget ( "Trevor's Safehouse 3 Inside", 96.1536f, -1290.73f, 29.2664f ),
        };

        /// <summary>
        /// Landmarks
        /// </summary>
        public static readonly TeleportTarget[] LANDMARKS =
        {
	        new TeleportTarget ( "Airport Entrance", -1034.6f, -2733.6f, 13.8f ),
	        new TeleportTarget ( "Airport Field", -1336.0f, -3044.0f, 13.9f ),
	        new TeleportTarget ( "Altruist Cult Camp", -1170.841f, 4926.646f, 224.295f ),
	        new TeleportTarget ( "Calafia Train Bridge", -517.869f, 4425.284f, 89.795f ),
	        new TeleportTarget ( "Cargo Ship", 899.678f, -2882.191f, 19.013f ),
	        new TeleportTarget ( "Chumash", -3192.6f, 1100.0f, 20.2f ),
	        new TeleportTarget ( "Chumash Historic Family Pier", -3426.683f, 967.738f, 8.347f ),
	        new TeleportTarget ( "Del Perro Pier", -1850.127f, -1231.751f, 13.017f ),
	        new TeleportTarget ( "Devin Weston's House", -2639.872f, 1866.812f, 160.135f ),
	        new TeleportTarget ( "El Burro Heights", 1384.0f, -2057.1f, 52.0f ),
	        new TeleportTarget ( "Elysian Island", 338.2f, -2715.9f, 38.5f ),
	        new TeleportTarget ( "Far North San Andreas", 24.775f, 7644.102f, 19.055f ),
	        new TeleportTarget ( "Ferris Wheel", -1670.7f, -1125.0f, 13.0f ),
	        new TeleportTarget ( "Fort Zancudo", -2047.4f, 3132.1f, 32.8f ),
	        new TeleportTarget ( "Fort Zancudo ATC Entrance", -2344.373f, 3267.498f, 32.811f ),
	        new TeleportTarget ( "Fort Zancudo ATC Top Floor", -2358.132f, 3249.754f, 101.451f ),
	        new TeleportTarget ( "God's Thumb", -1006.402f, 6272.383f, 1.503f ),
	        new TeleportTarget ( "Hippy Camp", 2476.712f, 3789.645f, 41.226f ),
	        new TeleportTarget ( "Jetsam", 760.4f, -2943.2f, 5.8f ),
	        new TeleportTarget ( "Jolene Cranley-Evans Ghost", 3059.620f, 5564.246f, 197.091f ),
	        new TeleportTarget ( "Kortz Center", -2243.810f, 264.048f, 174.615f ),
	        new TeleportTarget ( "Main LS Customs", -365.425f, -131.809f, 37.873f ),
	        new TeleportTarget ( "Marlowe Vineyards", -1868.971f, 2095.674f, 139.115f ),
	        new TeleportTarget ( "McKenzie Airfield", 2121.7f, 4796.3f, 41.1f ),
	        new TeleportTarget ( "Merryweather Dock", 486.417f, -3339.692f, 6.070f ),
	        new TeleportTarget ( "Mineshaft", -595.342f, 2086.008f, 131.412f ),
	        new TeleportTarget ( "Mt. Chiliad", 425.4f, 5614.3f, 766.5f ),
	        new TeleportTarget ( "Mt. Chiliad Summit", 450.718f, 5566.614f, 806.183f ),
	        new TeleportTarget ( "NOOSE Headquarters", 2535.243f, -383.799f, 92.993f ),
	        new TeleportTarget ( "Pacific Standard Bank", 235.046f, 216.434f, 106.287f ),
	        new TeleportTarget ( "Paleto Bay Pier", -275.522f, 6635.835f, 7.425f ),
	        new TeleportTarget ( "Playboy Mansion", -1475.234f, 167.088f, 55.841f ),
	        new TeleportTarget ( "Police Station", 436.491f, -982.172f, 30.699f ),
	        new TeleportTarget ( "Quarry", 2954.196f, 2783.410f, 41.004f ),
	        new TeleportTarget ( "Sandy Shores Airfield", 1747.0f, 3273.7f, 41.1f ),
	        new TeleportTarget ( "Satellite Dishes", 2062.123f, 2942.055f, 47.431f ),
	        new TeleportTarget ( "Sisyphus Theater Stage", 686.245f, 577.950f, 130.461f ),
	        new TeleportTarget ( "Trevor's Meth Lab", 1391.773f, 3608.716f, 38.942f ),
	        new TeleportTarget ( "Weed Farm", 2208.777f, 5578.235f, 53.735f ),
	        new TeleportTarget ( "Wind Farm", 2354.0f, 1830.3f, 101.1f )
        };

        /// <summary>
        /// Roof & high places
        /// </summary>
        public static readonly TeleportTarget[] HIGH_PLACES = 
        {
	        new TeleportTarget ( "Airplane Graveyard Airplane Tail ", 2395.096f, 3049.616f, 60.053f ),
	        new TeleportTarget ( "FIB Building Roof", 150.126f, -754.591f, 262.865f ),
	        new TeleportTarget ( "Galileo Observatory Roof", -438.804f, 1076.097f, 352.411f ),
	        new TeleportTarget ( "IAA Building Roof", 134.085f, -637.859f, 262.851f ),
	        new TeleportTarget ( "Maze Bank Arena Roof", -324.300f, -1968.545f, 67.002f ),
	        new TeleportTarget ( "Maze Bank Roof", -75.015f, -818.215f, 326.176f ),
	        new TeleportTarget ( "Palmer-Taylor Power Station Chimney", 2732.931f, 1577.540f, 83.671f ),
	        new TeleportTarget ( "Rebel Radio", 736.153f, 2583.143f, 79.634f ),
	        new TeleportTarget ( "Sandy Shores Building Site Crane", 1051.209f, 2280.452f, 89.727f ),
	        new TeleportTarget ( "Satellite Dish Antenna", 2034.988f, 2953.105f, 74.602f ),
	        new TeleportTarget ( "Stab City", 126.975f, 3714.419f, 46.827f ),
	        new TeleportTarget ( "Very High Up", -129.964f, 8130.873f, 6705.307f ),
	        new TeleportTarget ( "Windmill Top", 2026.677f, 1842.684f, 133.313f )
        };

        /// <summary>
        /// Underwater places
        /// </summary>
        public static readonly TeleportTarget[] UNDERWATER = 
        {
	        new TeleportTarget ( "Dead Sea Monster", -3373.726f, 504.714f, -24.656f ),
	        new TeleportTarget ( "Humane Labs Tunnel", 3838.47f, 3673.06f, -19.7281f, null, new string[]{"chemgrill_grp1"} ),
	        new TeleportTarget ( "Sunken Body", -3161.078f, 3001.998f, -37.974f ),
	        new TeleportTarget ( "Sunken Cargo Ship", 3199.748f, -379.018f, -22.500f ),
	        new TeleportTarget ( "Sunken Plane", -942.350f, 6608.752f, -20.912f ),
	        new TeleportTarget ( "Underwater Hatch", 4273.950f, 2975.714f, -170.746f ),
	        new TeleportTarget ( "Underwater UFO", 762.426f, 7380.371f, -111.377f ),
	        new TeleportTarget ( "Underwater WW2 Tank", 4201.633f, 3643.821f, -39.016f ),
        };

        /// <summary>
        /// Interiors
        /// </summary>
        public static readonly TeleportTarget[] INTERIORS = 
        {
	        new TeleportTarget ( "10 Car Garage Back Room", 223.193f, -967.322f, -99.000f ),
	        new TeleportTarget ( "10 Car Garage Bay", 228.135f, -995.350f, -99.000f ),
	        new TeleportTarget ( "Ammunation Gun Range", 22.153f, -1072.854f, 29.797f ),
	        new TeleportTarget ( "Ammunation Office", 12.494f, -1110.130f, 29.797f ),
	        //new TeleportTarget ( "Bahama Mamas West", -1387.08f, -588.4f, 30.3195f ),
	        new TeleportTarget ( "Blaine County Savings Bank", -109.299f, 6464.035f, 31.627f ),
	        new TeleportTarget ( "Clucking Bell Farms Warehouse", -70.0624f, 6263.53f, 31.0909f, new string[] { "CS1_02_cf_onmission1", "CS1_02_cf_onmission2", "CS1_02_cf_onmission3", "CS1_02_cf_onmission4" }, new string[] { "CS1_02_cf_offmission" } ),
	        //new TeleportTarget ( "Control Office", 1080.97f, -1976.0f, 31.4721f ),
	        //new TeleportTarget ( "Devin's Garage", 482.027f, -1317.96f, 29.2021f ),
	        new TeleportTarget ( "Eclipse Apartment 5", -762.762f, 322.634f, 175.401f ),
	        new TeleportTarget ( "Eclipse Apartment 9", -790.673f, 334.468f, 158.599f ),
	        new TeleportTarget ( "Eclipse Apartment 31", -762.762f, 322.634f, 221.855f ),
	        new TeleportTarget ( "Eclipse Apartment 40", -790.673f, 334.468f, 206.218f ),
	        new TeleportTarget ( "FIB Building Burnt", 159.553f, -738.851f, 246.152f ),
	        new TeleportTarget ( "FIB Building Floor 47", 134.573f, -766.486f, 234.152f ),
	        new TeleportTarget ( "FIB Building Floor 49", 134.635f, -765.831f, 242.152f ),
	        new TeleportTarget ( "FIB Building Lobby", 110.4f, -744.2f, 45.7f, new string[] { "FIBlobby" }, new string[] { "FIBlobbyfake" } ),
	        new TeleportTarget ( "FIB Building Top Floor", 135.733f, -749.216f, 258.152f ),
	        //new TeleportTarget ( "Garment Factory", 717.397f, -965.572f, 30.3955f ),
	        new TeleportTarget ( "Hospital (Destroyed)", 302.651f, -586.293f, 43.3129f, new string[] { "RC12B_Destroyed", "RC12B_HospitalInterior" }, new string[] { "RC12B_Default", "RC12B_Fixed" } ),
	        new TeleportTarget ( "Humane Labs Lower Level", 3525.495f, 3705.301f, 20.992f ),
	        new TeleportTarget ( "Humane Labs Upper Level", 3618.52f, 3755.76f, 28.6901f ),
	        new TeleportTarget ( "IAA Office", 117.220f, -620.938f, 206.047f ),
	        //new TeleportTarget ( "Ice Planet Jewelery", 243.516f, 364.099f, 105.738f ),
	        new TeleportTarget ( "Janitor's Apartment", -110.721f, -8.22095f, 70.5197f ),
	        new TeleportTarget ( "Jewel Store", -630.07f, -236.332f, 38.0571f, new string[] { "post_hiest_unload" }, new string[] { "jewel2fake", "bh1_16_refurb" } ),
	        new TeleportTarget ( "Lester's House", 1273.898f, -1719.304f, 54.771f ),
	        new TeleportTarget ( "Life Invader Office", -1049.13f, -231.779f, 39.0144f, new string[] { "facelobby" }, new string[] { "facelobbyfake" } ),
	        //new TeleportTarget ( "Maze Bank Arena", -254.918f, -2019.75f, 30.1456f ),
	        new TeleportTarget ( "Morgue", 275.446f, -1361.11f, 24.5378f, new string[] { "Coroner_Int_on" }, new string[] {"Coroner_Int_off"} ),
	        new TeleportTarget ( "O'Neil Farm", 2454.78f, 4971.92f, 46.8103f, new string[] { "farm", "farm_props", "farmint" }, new string[] { "farm_burnt", "farm_burnt_props", "farmint_cap" } ),
	        new TeleportTarget ( "Pacific Standard Bank Vault", 255.851f, 217.030f, 101.683f ),
	        //new TeleportTarget ( "Paleto Bay Sheriff", -446.135f, 6012.91f, 31.7164f ),
	        //new TeleportTarget ( "Raven Slaughterhouse", 967.357f, -2184.71f, 30.0613f ),
	        //new TeleportTarget ( "Rogers Salvage & Scrap", -609.962f, -1612.49f, 27.0105f ),
	        //new TeleportTarget ( "Sandy Shores Sheriff", 1853.18f, 3686.63f, 34.2671f ),
	        //new TeleportTarget ( "Simeon's Dealership", -56.4951f, -1095.8f, 26.4224f ),
	        //new TeleportTarget ( "Split Sides West Comedy Club", -564.261f, 278.232f, 83.1364f ),
	        new TeleportTarget ( "Stadium", -248.4916f, -2010.509f, 34.5743f, new string[] {"SP1_10_real_interior"}, new string[] {"SP1_10_fake_interior"} ),
	        new TeleportTarget ( "Strip Club DJ Booth", 126.135f, -1278.583f, 29.270f ),
	        new TeleportTarget ( "Torture Warehouse", 136.514f, -2203.15f, 7.30914f ),
        };

        // IPLs for carrier
        private static readonly string[] IPLS_CARRIER = 
        {
	        "hei_carrier",
	        "hei_carrier_DistantLights",
	        "hei_Carrier_int1",
	        "hei_Carrier_int2",
	        "hei_Carrier_int3",
	        "hei_Carrier_int4",
	        "hei_Carrier_int5",
	        "hei_Carrier_int6",
	        "hei_carrier_LODLights"
        };

        // IPLs for heist job & yacht
        private static readonly string[] IPLS_HEISTYACHT = 
        {
	        "hei_yacht_heist",
	        "hei_yacht_heist_Bar",
	        "hei_yacht_heist_Bedrm",
	        "hei_yacht_heist_Bridge",
	        "hei_yacht_heist_DistantLights",
	        "hei_yacht_heist_enginrm",
	        "hei_yacht_heist_LODLights",
	        "hei_yacht_heist_Lounge"
        };

        // IPLs for North Yankton
        private static readonly string[] IPLS_NORTH_YANKTON = 
        {
	        "plg_01",
	        "prologue01",
	        "prologue01_lod",
	        "prologue01c",
	        "prologue01c_lod",
	        "prologue01d",
	        "prologue01d_lod",
	        "prologue01e",
	        "prologue01e_lod",
	        "prologue01f",
	        "prologue01f_lod",
	        "prologue01g",
	        "prologue01h",
	        "prologue01h_lod",
	        "prologue01i",
	        "prologue01i_lod",
	        "prologue01j",
	        "prologue01j_lod",
	        "prologue01k",
	        "prologue01k_lod",
	        "prologue01z",
	        "prologue01z_lod",
	        "plg_02",
	        "prologue02",
	        "prologue02_lod",
	        "plg_03",
	        "prologue03",
	        "prologue03_lod",
	        "prologue03b",
	        "prologue03b_lod",
	        //the commented code disables the 'Prologue' grave and
	        //enables the 'Bury the Hatchet' grave
	        //"prologue03_grv_cov",
	        //"prologue03_grv_cov_lod",
	        "prologue03_grv_dug",
	        "prologue03_grv_dug_lod",
	        //"prologue03_grv_fun",
	        "prologue_grv_torch",
	        "plg_04",
	        "prologue04",
	        "prologue04_lod",
	        "prologue04b",
	        "prologue04b_lod",
	        "prologue04_cover",
	        "des_protree_end",
	        "des_protree_start",
	        "des_protree_start_lod",
	        "plg_05",
	        "prologue05",
	        "prologue05_lod",
	        "prologue05b",
	        "prologue05b_lod",
	        "plg_06",
	        "prologue06",
	        "prologue06_lod",
	        "prologue06b",
	        "prologue06b_lod",
	        "prologue06_int",
	        "prologue06_int_lod",
	        "prologue06_pannel",
	        "prologue06_pannel_lod",
	        //"prologue_m2_door",
	        //"prologue_m2_door_lod",
	        "plg_occl_00",
	        "prologue_occl",
	        "plg_rd",
	        "prologuerd",
	        "prologuerdb",
	        "prologuerd_lod"
        };

        /// <summary>
        /// Special places
        /// </summary>
        public static readonly TeleportTarget[] SPECIALS =
        {
	        //new TeleportTarget ( "Carrier", 3069.330f, -4632.4f, 15.043f, IPLS_CARRIER, null ),
	        new TeleportTarget ( "Fort Zancudo UFO", -2052.000f, 3237.000f, 1456.973f, new string[] { "ufo", "ufo_lod", "ufo_eye" }, null ),
	        //new TeleportTarget ( "Heist Yacht", -2043.974f, -1031.582f, 11.981f, IPLS_HEISTYACHT, null ),
	        new TeleportTarget ( "Max Renda Refit", -583.1606f, -282.3967f, 35.394f, new string[] {"refit_unload"}, new string[] {"bh1_16_doors_shut"} ),
	        new TeleportTarget ( "North Yankton", 3360.19f, -4849.67f, 111.8f, IPLS_NORTH_YANKTON, null ),
	        new TeleportTarget ( "North Yankton Bank", 5309.519f, -5212.375f, 83.522f, IPLS_NORTH_YANKTON, null ),
	        new TeleportTarget ( "Simeon's Showroom", -59.7936f, -1098.784f, 27.2612f, new string[] { "shr_int" }, new string[] { "fakeint" } ),
	        new TeleportTarget ( "SS Bulker (Intact)", -163.749f, -2377.94f, 9.3192f, new string[] { "cargoship" }, new string[] { "sunkcargoship" } ),
	        new TeleportTarget ( "SS Bulker (Sunk)", -162.8918f, -2365.769f, 0.0f, new string[] { "sunkcargoship" }, new string[] { "cargoship" } ),
	        new TeleportTarget ( "Train Crash Bridge", -532.1309f, 4526.187f, 88.7955f, new string[] { "canyonriver01_traincrash", "railing_end" }, new string[] { "railing_start", "canyonriver01" } ),
	        new TeleportTarget ( "Yacht", -2023.661f, -1038.038f, 5.577f, new string[] { "smboat", "smboat_lod" }, null ),
        };

        /// <summary>
        /// Unfinished places
        /// </summary>
        public static readonly TeleportTarget[] BROKENS =
        {
	        //new TeleportTarget ( "Carrier", 3069.330f, -4704.220f, 15.043f, IPLS_CARRIER, null ),
	        new TeleportTarget ( "des_farmhouse", 2447.9f, 4973.4f, 47.7f, null, null ),
	        new TeleportTarget ( "canyon", -1600.6194f, 4443.4565f, 0.725f, null, null ),
	        new TeleportTarget ( "vb_30_crimetape", -1150.0391f, -1521.761f, 9.6331f, null, null ),
	        new TeleportTarget ( "sheriff_cap", 1856.0288f, 3682.9983f, 33.2675f, null, null ),
	        new TeleportTarget ( "CS1_16_sheriff_Cap", -440.5073f, 6018.766f, 30.49f, null, null ),
	        new TeleportTarget ( "chemgrill_grp1", 3832.9f, 3665.5f, -23.4f, null, null ),
	        new TeleportTarget ( "Hospitaldoorsfixed", 0, 0, 0, null, null ),
	        new TeleportTarget ( "SP1_10_fake/real_interior", -248.4916f, -2010.509f, 34.5743f, null, null ),
	        new TeleportTarget ( "id2_14_pre_no_int etc", 716.84f, -962.05f, 31.59f, null, null ),
	        new TeleportTarget ( "burnt_switch_off", 716.84f, -962.05f, 31.59f, null, null ),
	        new TeleportTarget ( "des_farmhouse", 2447.9f, 4973.4f, 47.7f, null, null ),
	        new TeleportTarget ( "FINBANK (1)", 2.69689322f, -667.0166f, 16.1306286f, null, null ),
	        new TeleportTarget ( "FINBANK (2)", 6.194215f, -660.759338f, 33.4501877f, null, null ),
	        new TeleportTarget ( "DT1_03_Shutter", 23.9346f, -669.7552f, 30.8853f, null, null ),
	        new TeleportTarget ( "CS3_07_MPGates", -1601.424072265625f, 2808.212646484375f, 16.2598f, null, null ),
	        new TeleportTarget ( "PaperRCM", -1459.1273193359375f, 486.12811279296875f, 115.20159912109375f, null, null ),
	        new TeleportTarget ("KorizTempWalls", -2199.1376953125f, 223.4647979736328f, 181.11180114746094f, null, null ),
	        new TeleportTarget ("mic3_chopper_debris", -2242.78466796875f, 263.4779052734375f, 173.6154022216797f ),
	        new TeleportTarget ( "showroom", -59.79359817504883f, -1098.7840576171875f, 27.2612f ),
	        new TeleportTarget ("FBI_colPLUG, repair, rubble", 74.29f, -736.0499877929688f, 46.76f ),
	        new TeleportTarget ( "FBI heist", 136.00399780273438f, -749.2869873046875f, 153.302f )
	        //new TeleportTarget ( "Director Mod Trailer", -20.004f, -10.889f, 500.602f ),
        };

        /// <summary>
        /// Stunt jumps
        /// </summary>
        public static readonly TeleportTarget[] STUNT_JUMPS =
        {

        };

        /// <summary>
        /// Spaceship parts
        /// </summary>
        public static readonly TeleportTarget[] SPACESHIP_PARTS =
        {
            new TeleportTarget("#01", 428.9633f, 6468.706f, 28.7793f),
            new TeleportTarget("#02", -377.6008f, 6085.317f, 39.6054f),
            new TeleportTarget("#03", -511.4319f, 5665.392f, 47.18425f),
            new TeleportTarget("#04", 2196.858f, 5605.221f, 53.46579f),
            new TeleportTarget("#05", -1440.44f, 5408.934f, 24.91879f),
            new TeleportTarget("#06", 2426.09f, 4781.363f, 34.53447f),
            new TeleportTarget("#07", -1949.748f, 4579.819f, 48.60158f),
            new TeleportTarget("#08", 3830.587f, 4444.813f, 2.741449f),
            new TeleportTarget("#09", -523.1528f, 4437.72f, 31.19645f),
            new TeleportTarget("#10", 1493.419f, 3841.722f, 25.35632f),
            new TeleportTarget("#11", 2515.396f, 3783.656f, 53.00525f),
            new TeleportTarget("#12", -584.2244f, 3583.952f, 268.1571f),
            new TeleportTarget("#13", 1923.4f, 3466.915f, 51.53664f),
            new TeleportTarget("#14", 77.28337f, 3278.656f, 31.13165f),
            new TeleportTarget("#15", -387.5963f, 2956.099f, 20.28623f),
            new TeleportTarget("#16", 1964.487f, 2919.821f, 57.10085f),
            new TeleportTarget("#17", 891.7535f, 2861.718f, 56.29594f),
            new TeleportTarget("#18", 171.3739f, 2214.534f, 90.55803f),
            new TeleportTarget("#19", 3132.028f, 2205.297f, -5.922436f),
            new TeleportTarget("#20", 1371.199f, 2186.829f, 97.91506f),
            new TeleportTarget("#21", -1443.997f, 2136.469f, 30.47571f),
            new TeleportTarget("#22", -1939.431f, 1953.672f, 156.9697f),
            new TeleportTarget("#23", 796.1694f, 1841.498f, 123.736f),
            new TeleportTarget("#24", -2807.29f, 1451.316f, 100.8354f),
            new TeleportTarget("#25", -1903.989f, 1388.988f, 218.8167f),
            new TeleportTarget("#26", -411.1031f, 1100.412f, 332.5343f),
            new TeleportTarget("#27", -1533.125f, 869.5099f, 181.8977f),
            new TeleportTarget("#28", 85.95246f, 812.373f, 214.2908f),
            new TeleportTarget("#29", 2908.929f, 804.3307f, 2.923146f),
            new TeleportTarget("#30", 22.86215f, 639.6559f, 190.6649f),
            new TeleportTarget("#31", 1965.278f, 551.0641f, 161.405f),
            new TeleportTarget("#32", 1683.04f, 36.84582f, 156.6593f),
            new TeleportTarget("#33", -1175.974f, -63.66705f, 45.80711f),
            new TeleportTarget("#34", -416.1761f, -139.9122f, 64.41656f),
            new TeleportTarget("#35", -233.4292f, -244.759f, 49.90495f),
            new TeleportTarget("#36", -1182.393f, -521.6902f, 40.84121f),
            new TeleportTarget("#37", 161.4487f, -560.5097f, 21.99138f),
            new TeleportTarget("#38", 195.8474f, -566.9279f, 129.09f),
            new TeleportTarget("#39", 465.8565f, -730.8796f, 27.36073f),
            new TeleportTarget("#40", 1236.186f, -1105.222f, 35.68897f),
            new TeleportTarget("#41", -901.9235f, -1162.494f, 32.74917f),
            new TeleportTarget("#42", 14.27985f, -1214.412f, 29.35767f),
            new TeleportTarget("#43", 293.9202f, -1447.16f, 46.50953f),
            new TeleportTarget("#44", 1742.733f, -1626.818f, 112.4214f),
            new TeleportTarget("#45", 375.8281f, -2118.732f, 16.63311f),
            new TeleportTarget("#46", 1134.959f, -2612.322f, 15.01656f),
            new TeleportTarget("#47", 338.3029f, -2776.947f, 43.63181f),
            new TeleportTarget("#48", 1590.83f, -2808.073f, 4.886177f),
            new TeleportTarget("#49", 640.5842f, -3234.545f, -6.723347f),
            new TeleportTarget("#50", -1221.659f, -3500.85f, 13.94022f),
        };

        /// <summary>
        /// Letter scraps
        /// </summary>
        public static readonly TeleportTarget[] LETTER_SCRAPS =
        {

        };

        /// <summary>
        /// Teleport categories
        /// </summary>
        public static readonly TeleportCategory[] CATEGORIES =
        {
            new TeleportCategory(MenuText.Location.LocationTeleporter.I02_SAFEHOUSES, SAFEHOUSES),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I03_LANDMARKS, LANDMARKS),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I04_ROOF_HIGH, HIGH_PLACES),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I05_UNDERWATER, UNDERWATER),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I06_INTERIORS, INTERIORS),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I07_SPECIALS, SPECIALS),
            //new TeleportCategory(MenuText.Location.LocationTeleporter.I08_STUNT_JUMPS, STUNT_JUMPS),
            new TeleportCategory(MenuText.Location.LocationTeleporter.I09_SPACESHIP_PARTS, SPACESHIP_PARTS),
            //new TeleportCategory(MenuText.Location.LocationTeleporter.I10_LETTER_SCRAPS, LETTER_SCRAPS),
        };

    }
}
