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
    /// Vehicle storage
    /// </summary>
    public static class VehicleStorage
    {
        /// <summary>
        /// Sub category item count
        /// </summary>
        public const int SUB_CATEGORY_COUNT = 2;

        /// <summary>
        /// Names of main categories
        /// </summary>
        public static readonly MLString[] MAIN_CATEGORIES =
        {
            Utils.CSML("Cars", "家用"),
            Utils.CSML("Industrial", "商用"),
            Utils.CSML("Emergency and Military", "特种车辆与军车"),
            Utils.CSML("Motorcycles", "摩托车"),
            Utils.CSML("Planes", "飞机"),
            Utils.CSML("Helicopters", "直升机"),
            Utils.CSML("Boats", "船只"),
            Utils.CSML("Bicycles", "自行车"),
        };

        /// <summary>
        /// Name of sub categories
        /// </summary>
        public static readonly MLString[][] SUB_CATEGORIES =
        {
            new MLString[]
            {
                Utils.CSML("Supercars", "超级跑车"),
                Utils.CSML("Sports", "跑车"),
                Utils.CSML("Sport Classics", "经典跑车"),
                Utils.CSML("Coupes", "房车"),
                Utils.CSML("Muscle", "肌肉车"),
                Utils.CSML("Offroad", "越野车") ,
                Utils.CSML("SUVs", "SUV"),
                Utils.CSML("Sedans", "轿车"),
                Utils.CSML("Compacts", "紧凑型车"),
            },
            new MLString[]
            {
                Utils.CSML("Pickups", "皮卡"),
                Utils.CSML("Vans", "厢式货车"),
                Utils.CSML("Trucks", "卡车"),
                Utils.CSML("Service/Utility", "服务车/工具车"),
                Utils.CSML("Trailers", "拖车"),
                Utils.CSML("Trains (Undriveable)" , "火车(不可驾驶)"),
            },
        };

        /// <summary>
        /// Vehicles' data
        /// </summary>
        public static readonly VehicleData[][][] VEHICLES =
        {
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Coil Voltic", "VOLTIC"), new VehicleData("Grotti Cheetah", "CHEETAH"), new VehicleData("Grotti Turismo R", "TURISMOR"), new VehicleData("Overflod Entity XF", "ENTITYXF"), new VehicleData("Pegassi Infernus", "INFERNUS"), new VehicleData("Pegassi Osiris", "OSIRIS"), new VehicleData("Pegassi Vacca", "VACCA"), new VehicleData("Pegassi Zentorno", "ZENTORNO"), new VehicleData("Truffade Adder", "ADDER"), new VehicleData("Vapid Bullet", "BULLET"), },
                new VehicleData[] { new VehicleData("Albany Alpha", "ALPHA"), new VehicleData("Annis Elegy RH8", "ELEGY2"), new VehicleData("Benefactor Feltzer", "FELTZER2"), new VehicleData("Benefactor Schwartzer", "SCHWARZER"), new VehicleData("Benefactor Surano", "SURANO"), new VehicleData("Bravado Banshee", "BANSHEE"), new VehicleData("Bravado Buffalo", "BUFFALO"), new VehicleData("Bravado Buffalo S", "BUFFALO2"), new VehicleData("Bravado Buffalo S (Race)", "BUFFALO3"), new VehicleData("Dewbauchee Massacro", "MASSACRO"), new VehicleData("Dewbauchee Massacro (Race)", "MASSACRO2"), new VehicleData("Dewbauchee Rapid GT", "RAPIDGT"), new VehicleData("Dewbauchee Rapid GT Cabrio", "RAPIDGT2"), new VehicleData("Dinka Blista Compact", "BLISTA2"), new VehicleData("Dinka Blista Compact (Go Go Monkey Race)", "BLISTA3"), new VehicleData("Dinka Jester", "JESTER"), new VehicleData("Dinka Jester (Race)", "JESTER2"), new VehicleData("Grotti Carbonizzare", "CARBONIZZARE"), new VehicleData("Hijak Khamelion", "KHAMELION"), new VehicleData("Invetero Coquette", "COQUETTE"), new VehicleData("Karin Futo", "FUTO"), new VehicleData("Karin Kuruma", "KURUMA"), new VehicleData("Karin Kuruma (Armoured)", "KURUMA2"), new VehicleData("Karin Sultan", "SULTAN"), new VehicleData("Lampadati Furore GT", "FUROREGT"), new VehicleData("Maibatsu Penumbra", "PENUMBRA"), new VehicleData("Obey 9F", "NINEF"), new VehicleData("Obey 9F Cabrio", "NINEF2"), new VehicleData("Phister Comet", "COMET2"), new VehicleData("Schyster Fusilade", "FUSILADE"), },
                new VehicleData[] { new VehicleData("Albany Manana", "MANANA"), new VehicleData("Albany Roosevelt", "BTYPE"), new VehicleData("Benefactor Stirling GT", "FELTZER3"), new VehicleData("Declasse Tornado", "TORNADO"), new VehicleData("Declasse Tornado (Rusty)", "TORNADO3"), new VehicleData("Declasse Tornado Cabrio", "TORNADO2"), new VehicleData("Declasse Tornado Cabrio (Rusty)", "TORNADO4"), new VehicleData("Dewbauchee JB 700", "JB700"), new VehicleData("Grotti Stinger", "STINGER"), new VehicleData("Grotti Stinger GT", "STINGERGT"), new VehicleData("Invetero Coquette Classic", "COQUETTE2"), new VehicleData("Lampadati Casco", "CASCO"), new VehicleData("Lampadati Pigalle", "PIGALLE"), new VehicleData("Pegassi Monroe", "MONROE"), new VehicleData("Truffade Z-Type", "ZTYPE"), new VehicleData("Vapid Peyote", "PEYOTE"), },
                new VehicleData[] { new VehicleData("Dewbauchee Exemplar", "EXEMPLAR"), new VehicleData("Enus Cognoscenti Cabrio", "COGCABRIO"), new VehicleData("Enus Windsor", "WINDSOR"), new VehicleData("Lampadati Felon", "FELON"), new VehicleData("Lampadati Felon GT", "FELON2"), new VehicleData("Ocelot F620", "F620"), new VehicleData("Ocelot Jackal", "JACKAL"), new VehicleData("Ubermacht Sentinel", "SENTINEL2"), new VehicleData("Ubermacht Sentinel XS", "SENTINEL"), new VehicleData("Ubermacht Zion", "ZION"), new VehicleData("Ubermacht Zion Cabrio", "ZION2"), },
                new VehicleData[] { new VehicleData("Albany Buccaneer", "BUCCANEER"), new VehicleData("Albany Virgo", "VIRGO"), new VehicleData("Bravado Gauntlet", "GAUNTLET"), new VehicleData("Bravado Gauntlet (Race)", "GAUNTLET2"), new VehicleData("Cheval Picador", "PICADOR"), new VehicleData("Declasse Sabre Turbo", "SABREGT"), new VehicleData("Declasse Stallion", "STALION"), new VehicleData("Declasse Stallion (Race)", "STALION2"), new VehicleData("Declasse Vigero", "VIGERO"), new VehicleData("Declasse Voodoo", "VOODOO2"), new VehicleData("Imponte Duke O' Death", "DUKES2"), new VehicleData("Imponte Dukes", "DUKES"), new VehicleData("Imponte Phoenix", "PHOENIX"), new VehicleData("Imponte Ruiner", "RUINER"), new VehicleData("Vapid Blade", "BLADE"), new VehicleData("Vapid Dominator", "DOMINATOR"), new VehicleData("Vapid Dominator (Race)", "DOMINATOR2"), new VehicleData("Vapid Hotknife", "HOTKNIFE"), new VehicleData("Vapid Slamvan", "SLAMVAN"), new VehicleData("Vapid Slamvan (Lost MC)", "SLAMVAN2"), },
                new VehicleData[] { new VehicleData("Benefactor Dubsta 6x6", "DUBSTA3"), new VehicleData("BF Bifta", "BIFTA"), new VehicleData("BF Injection", "BFINJECTION"), new VehicleData("Bravado Dune", "DUNE"), new VehicleData("Bravado Duneloader", "DLOADER"), new VehicleData("Bravado Space Docker", "DUNE2"), new VehicleData("Canis Bodhi", "BODHI2"), new VehicleData("Canis Kalahari", "KALAHARI"), new VehicleData("Canis Mesa (Off-Road)", "MESA3"), new VehicleData("Cheval Marshall", "MARSHALL"), new VehicleData("Declasse Rancher XL", "RANCHERXL"), new VehicleData("Declasse Rancher XL (Snow)", "RANCHERXL2"), new VehicleData("Insurgent", "INSURGENT2"), new VehicleData("Insurgent (Gun Mount)", "INSURGENT"), new VehicleData("Karin Rebel", "REBEL2"), new VehicleData("Karin Rebel (Rusty)", "REBEL"), new VehicleData("Karin Technical", "TECHNICAL"), new VehicleData("Nagasaki Blazer", "BLAZER"), new VehicleData("Nagasaki Blazer (Hot Rod)", "BLAZER3"), new VehicleData("Nagasaki Blazer (Lifeguard)", "BLAZER2"), new VehicleData("Vapid Guardian", "GUARDIAN"), new VehicleData("Vapid Sandking", "SANDKING2"), new VehicleData("Vapid Sandking XL", "SANDKING"), new VehicleData("Vapid The Liberator", "MONSTER"), },
                new VehicleData[] { new VehicleData("Albany Cavalcade", "CAVALCADE"), new VehicleData("Albany Cavalcade Mk2", "CAVALCADE2"), new VehicleData("Benefactor Dubsta", "DUBSTA"), new VehicleData("Benefactor Dubsta (Flat Black)", "DUBSTA2"), new VehicleData("Benefactor Serrano", "SERRANO"), new VehicleData("Bravado Gresley", "GRESLEY"), new VehicleData("Canis Mesa", "MESA"), new VehicleData("Canis Mesa (Snow)", "MESA2"), new VehicleData("Canis Seminole", "SEMINOLE"), new VehicleData("Declasse Granger", "GRANGER"), new VehicleData("Dundreary Landstalker", "LANDSTALKER"), new VehicleData("Emperor Habanero", "HABANERO"), new VehicleData("Enus Huntley S", "HUNTLEY"), new VehicleData("Fathom FQ 2", "FQ2"), new VehicleData("Gallivanter Baller (Large)", "BALLER"), new VehicleData("Gallivanter Baller (Small)", "BALLER2"), new VehicleData("Karin BeeJay XL", "BJXL"), new VehicleData("Mammoth Patriot", "PATRIOT"), new VehicleData("Obey Rocoto", "ROCOTO"), new VehicleData("Vapid Radius", "RADI"), },
                new VehicleData[] { new VehicleData("Albany Emperor", "EMPEROR"), new VehicleData("Albany Emperor (Rusty)", "EMPEROR2"), new VehicleData("Albany Emperor (Snow)", "EMPEROR3"), new VehicleData("Albany Primo", "PRIMO"), new VehicleData("Albany Washington", "WASHINGTON"), new VehicleData("Benefactor Glendale", "GLENDALE"), new VehicleData("Benefactor Schafter", "SCHAFTER2"), new VehicleData("Chariot Romero Hearse", "ROMERO"), new VehicleData("Cheval Fugitive", "FUGITIVE"), new VehicleData("Cheval Surge", "SURGE"), new VehicleData("Declasse Asea", "ASEA"), new VehicleData("Declasse Asea (Snow)", "ASEA2"), new VehicleData("Declasse Premier", "PREMIER"), new VehicleData("Dundreary Regina", "REGINA"), new VehicleData("Dundreary Stretch", "STRETCH"), new VehicleData("Enus Super Diamond", "SUPERD"), new VehicleData("Karin Asterope", "ASTEROPE"), new VehicleData("Karin Intruder", "INTRUDER"), new VehicleData("Obey Tailgater", "TAILGATER"), new VehicleData("Ubermacht Oracle", "ORACLE"), new VehicleData("Ubermacht Oracle Mk2", "ORACLE2"), new VehicleData("Vapid Stanier", "STANIER"), new VehicleData("Vapid Stanier (Taxi)", "TAXI"), new VehicleData("Vulcan Ingot", "INGOT"), new VehicleData("Vulcar Warrener", "WARRENER"), new VehicleData("Zirconium Stratum", "STRATUM"), },
                new VehicleData[] { new VehicleData("Benefactor Panto", "PANTO"), new VehicleData("Bollokan Prairie", "PRAIRIE"), new VehicleData("Declasse Rhapsody", "RHAPSODY"), new VehicleData("Dinka Blista", "BLISTA"), new VehicleData("Karin Dilettante", "DILETTANTE"), new VehicleData("Karin Dilettante (FlyUS)", "DILETTANTE2"), new VehicleData("Weeny Issi", "ISSI2"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Bravado Bison", "BISON"), new VehicleData("Bravado Bison (Backrack)", "BISON3"), new VehicleData("Bravado Bison (Construction)", "BISON2"), new VehicleData("Bravado Ratloader", "RATLOADER2"), new VehicleData("Bravado Ratloader (Rusty)", "RATLOADER"), new VehicleData("Vapid Bobcat", "BOBCATXL"), new VehicleData("Vapid Sadler", "SADLER"), new VehicleData("Vapid Sadler (Snow)", "SADLER2"), },
                new VehicleData[] { new VehicleData("BF Surfer", "SURFER"), new VehicleData("BF Surfer (Rusty)", "SURFER2"), new VehicleData("Bravado Paradise", "PARADISE"), new VehicleData("Bravado Rumpo (Deludamol)", "RUMPO2"), new VehicleData("Bravado Rumpo (Weazel News)", "RUMPO"), new VehicleData("Bravado Youga", "YOUGA"), new VehicleData("Brute Camper", "CAMPER"), new VehicleData("Brute Pony (Business)", "PONY"), new VehicleData("Brute Pony (Cannibus Shop)", "PONY2"), new VehicleData("Brute Taco Van", "TACO"), new VehicleData("Declasse Burrito", "BURRITO3"), new VehicleData("Declasse Burrito (Bug Stars)", "BURRITO2"), new VehicleData("Declasse Burrito (Construction)", "BURRITO4"), new VehicleData("Declasse Burrito (Gang)", "GBURRITO2"), new VehicleData("Declasse Burrito (Graphics)", "BURRITO"), new VehicleData("Declasse Burrito (Snow)", "BURRITO5"), new VehicleData("Declasse Burrito (The Lost)", "GBURRITO"), new VehicleData("Vapid Minivan", "MINIVAN"), new VehicleData("Vapid Speedo", "SPEEDO"), new VehicleData("Vapid Speedo (Clown)", "SPEEDO2"), new VehicleData("Zirconium Journey", "JOURNEY"), },
                new VehicleData[] { new VehicleData("Brute Boxville (Go Postal)", "BOXVILLE2"), new VehicleData("Brute Boxville (Humane Labs)", "BOXVILLE3"), new VehicleData("Brute Boxville (Post OP)", "BOXVILLE4"), new VehicleData("Brute Boxville (Water & Power)", "BOXVILLE"), new VehicleData("Brute Stockade", "STOCKADE"), new VehicleData("Brute Stockade (Snow)", "STOCKADE3"), new VehicleData("Brute Tipper (2 Axle)", "TIPTRUCK"), new VehicleData("Brute Tipper (3 Axle)", "TIPTRUCK2"), new VehicleData("Cutter", "CUTTER"), new VehicleData("Dock Handler", "HANDLER"), new VehicleData("Dock Tug", "DOCKTUG"), new VehicleData("Dump Truck", "DUMP"), new VehicleData("HVY Biff", "BIFF"), new VehicleData("Jobuilt Hauler", "HAULER"), new VehicleData("Jobuilt Phantom", "PHANTOM"), new VehicleData("Jobuilt Rubble", "RUBBLE"), new VehicleData("Maibatsu Mule (Graphics 1)", "MULE"), new VehicleData("Maibatsu Mule (Graphics 2)", "MULE2"), new VehicleData("Maibatsu Mule (Plain)", "MULE3"), new VehicleData("Mixer", "MIXER"), new VehicleData("Mixer (Support Wheel)", "MIXER2"), new VehicleData("MTL Flatbed Truck", "FLATBED"), new VehicleData("MTL Packer", "PACKER"), new VehicleData("MTL Pounder", "POUNDER"), new VehicleData("Vapid Benson", "BENSON"), new VehicleData("Vapid Scrap Truck", "SCRAP"), new VehicleData("Vapid Tow Truck", "TOWTRUCK"), new VehicleData("Vapid Tow Truck (Old)", "TOWTRUCK2"), },
                new VehicleData[] { new VehicleData("Airtug", "AIRTUG"), new VehicleData("Brute Airport Bus", "AIRBUS"), new VehicleData("Brute Bus (City Bus)", "BUS"), new VehicleData("Brute Rental Shuttle Bus", "RENTALBUS"), new VehicleData("Brute Tourbus", "TOURBUS"), new VehicleData("Cable Car (Mt. Chilliad)", "CABLECAR"), new VehicleData("Dashound Dashound Coach", "COACH"), new VehicleData("Dozer", "BULLDOZER"), new VehicleData("Forklift", "FORKLIFT"), new VehicleData("Jobuilt Trashmaster", "TRASH2"), new VehicleData("Jobuilt Trashmaster (Rusty)", "TRASH"), new VehicleData("Nagasaki Caddy", "CADDY2"), new VehicleData("Nagasaki Caddy (Golf)", "CADDY"), new VehicleData("Ripley (Airport Tug)", "RIPLEY"), new VehicleData("Stanley Fieldmaster Tractor", "TRACTOR2"), new VehicleData("Stanley Fieldmaster Tractor (Snow)", "TRACTOR3"), new VehicleData("Stanley Lawn Mower", "MOWER"), new VehicleData("Stanley Tractor (Rusty)", "TRACTOR"), new VehicleData("Vapid Pickup Utility", "UTILLITRUCK3"), new VehicleData("Vapid Plumbing Utility", "UTILLITRUCK2"), new VehicleData("Vapid Telephone Utility", "UTILLITRUCK"), },
                new VehicleData[] { new VehicleData("Army Flatbed Trailer (Empty)", "ARMYTRAILER"), new VehicleData("Army Flatbed Trailer (With Drill)", "ARMYTRAILER2"), new VehicleData("Army Fuel Tanker", "ARMYTANKER"), new VehicleData("Boat Trailer", "BOATTRAILER"), new VehicleData("Boat Trailer", "TR3"), new VehicleData("Car Transport Trailer", "TR4"), new VehicleData("Car Transport Trailer (Empty)", "TR2"), new VehicleData("Commercial Trailer (Graphics 1)", "TRAILERS2"), new VehicleData("Commercial Trailer (Graphics 2)", "TRAILERS3"), new VehicleData("Container Trailer", "DOCKTRAILER"), new VehicleData("Fame or Shame Trailer", "TVTRAILER"), new VehicleData("Flatbed Trailer", "FREIGHTTRAILER"), new VehicleData("Flatbed Trailer", "TRFLAT"), new VehicleData("Grain Trailer", "GRAINTRAILER"), new VehicleData("Hay Bale Trailer", "BALETRAILER"), new VehicleData("Logging Trailer", "TRAILERLOGS"), new VehicleData("Meth Lab Trailer", "PROPTRAILER"), new VehicleData("Petrol Tanker Trailer (Plain)", "TANKER2"), new VehicleData("Petrol Tanker Trailer (RON)", "TANKER"), new VehicleData("Plain Trailer", "TRAILERS"), new VehicleData("Rake Trailer", "RAKETRAILER"), new VehicleData("Small Trailer", "TRAILERSMALL"), },
                new VehicleData[] { new VehicleData("Container Car 1", "FREIGHTCONT1"), new VehicleData("Container Car 2", "FREIGHTCONT2"), new VehicleData("Flatbed Car", "FREIGHTCAR"), new VehicleData("Freight Train Cab", "FREIGHT"), new VehicleData("Grain Car", "FREIGHTGRAIN"), new VehicleData("Metro Train (Half)", "METROTRAIN"), new VehicleData("Oil Tanker Car", "TANKERCAR"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Albany Police Roadcruiser (Snow)", "POLICEOLD2"), new VehicleData("Ambulance", "AMBULANCE"), new VehicleData("Army Barracks Truck", "BARRACKS"), new VehicleData("Army Truck Cab", "BARRACKS2"), new VehicleData("Bravado Buffalo (FIB)", "FBI"), new VehicleData("Brute Police Riot Van", "RIOT"), new VehicleData("Canis Crusader (Army Mesa)", "CRUSADER"), new VehicleData("Declasse Granger (FIB)", "FBI2"), new VehicleData("Declasse Lifeguard", "LGUARD"), new VehicleData("Declasse Park Ranger", "PRANGER"), new VehicleData("Declasse Police Rancher (Snow)", "POLICEOLD1"), new VehicleData("Declasse Police Transporter", "POLICET"), new VehicleData("Declasse Sheriff SUV", "SHERIFF2"), new VehicleData("Firetruck", "FIRETRUK"), new VehicleData("Prison Bus", "PBUS"), new VehicleData("Rhino Tank", "RHINO"), new VehicleData("Vapid Police Buffalo", "POLICE2"), new VehicleData("Vapid Police Cruiser", "POLICE"), new VehicleData("Vapid Police Interceptor", "POLICE3"), new VehicleData("Vapid Sheriff Cruiser", "SHERIFF"), new VehicleData("Vapid Unmarked Police Cruiser", "POLICE4"), new VehicleData("Western Police Bike", "POLICEB"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Dinka Akuma", "AKUMA"), new VehicleData("Dinka Double-T", "DOUBLE"), new VehicleData("Dinka Enduro", "ENDURO"), new VehicleData("Dinka Thrust", "THRUST"), new VehicleData("LCC Hexer", "HEXER"), new VehicleData("LCC Innovation", "INNOVATION"), new VehicleData("Maibatsu Sanchez", "SANCHEZ2"), new VehicleData("Maibatsu Sanchez (Graphics)", "SANCHEZ"), new VehicleData("Nagasaki Carbon RS", "CARBONRS"), new VehicleData("Pegassi Bati", "BATI"), new VehicleData("Pegassi Bati (Race)", "BATI2"), new VehicleData("Pegassi Ruffian", "RUFFIAN"), new VehicleData("Principe Faggio", "FAGGIO2"), new VehicleData("Principe Lectro", "LECTRO"), new VehicleData("Principe Nemesis", "NEMESIS"), new VehicleData("Shitzu Hakuchou", "HAKUCHOU"), new VehicleData("Shitzu PCJ 600", "PCJ"), new VehicleData("Shitzu Vader", "VADER"), new VehicleData("Western Bagger", "BAGGER"), new VehicleData("Western Daemon", "DAEMON"), new VehicleData("Western Sovereign", "SOVEREIGN"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Buckingham Cargo Plane (An-225)", "CARGOPLANE"), new VehicleData("Buckingham Jet (B747)", "JET"), new VehicleData("Buckingham Luxor", "LUXOR"), new VehicleData("Buckingham Luxor Deluxe", "LUXOR2"), new VehicleData("Buckingham Miljet", "MILJET"), new VehicleData("Buckingham Shamal", "SHAMAL"), new VehicleData("Buckingham Vestra", "VESTRA"), new VehicleData("Jobuilt Mammatus", "MAMMATUS"), new VehicleData("Jobuilt P-996 Lazer", "LAZER"), new VehicleData("Jobuilt Velum (4 Seater)", "VELUM"), new VehicleData("Jobuilt Velum (5 Seater)", "VELUM2"), new VehicleData("Mammoth Dodo", "DODO"), new VehicleData("Mammoth Hydra", "HYDRA"), new VehicleData("Mammoth Titan", "TITAN"), new VehicleData("Western Besra", "BESRA"), new VehicleData("Western Cuban 800", "CUBAN800"), new VehicleData("Western Duster", "DUSTER"), new VehicleData("Western Mallard Stunt Plane", "STUNT"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Blimp (Atomic)", "BLIMP"), new VehicleData("Blimp (Xero Gas)", "BLIMP2"), new VehicleData("Buckingham Savage", "SAVAGE"), new VehicleData("Buckingham Swift", "SWIFT"), new VehicleData("Buckingham Swift Deluxe", "SWIFT2"), new VehicleData("Buckingham Valkyrie", "VALKYRIE"), new VehicleData("HVY Skylift", "SKYLIFT"), new VehicleData("Maibatsu Frogger", "FROGGER"), new VehicleData("Maibatsu Frogger (TPE/FIB)", "FROGGER2"), new VehicleData("Nagasaki Buzzard (Unarmed)", "BUZZARD2"), new VehicleData("Nagasaki Buzzard Attack Chopper", "BUZZARD"), new VehicleData("Western Annihilator", "ANNIHILATOR"), new VehicleData("Western Cargobob (Desert Camo)", "CARGOBOB"), new VehicleData("Western Cargobob (Jetsam)", "CARGOBOB2"), new VehicleData("Western Cargobob (TPE)", "CARGOBOB3"), new VehicleData("Western Maverick", "MAVERICK"), new VehicleData("Western Maverick (Police)", "POLMAV"), },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("Dinka Marquis", "MARQUIS"), new VehicleData("Kraken Sub", "SUBMERSIBLE2"), new VehicleData("Nagasaki Dinghy (2 Seater)", "DINGHY2"), new VehicleData("Nagasaki Dinghy (4 Seater, Black)", "DINGHY3"), new VehicleData("Nagasaki Dinghy (4 Seater, Red)", "DINGHY"), new VehicleData("Pegassi Speeder", "SPEEDER"), new VehicleData("Shitzu Jetmax", "JETMAX"), new VehicleData("Shitzu Predator (Police)", "PREDATOR"), new VehicleData("Shitzu Squalo", "SQUALO"), new VehicleData("Shitzu Suntrap", "SUNTRAP"), new VehicleData("Shitzu Tropic", "TROPIC"), new VehicleData("Speedophile Seashark", "SEASHARK"), new VehicleData("Speedophile Seashark (Lifeguard)", "SEASHARK2"), new VehicleData("Submersible", "SUBMERSIBLE"), new VehicleData("Tug", "TUG") },
            },
            new VehicleData[][] {
                new VehicleData[] { new VehicleData("BMX", "BMX"), new VehicleData("Cruiser", "CRUISER"), new VehicleData("Endurex Race", "TRIBIKE2"), new VehicleData("Fixter", "FIXTER"), new VehicleData("Scorcher", "SCORCHER"), new VehicleData("Tri-Cycles Race", "TRIBIKE3"), new VehicleData("Whippet Race", "TRIBIKE"), },
            },
        };
    }
}
