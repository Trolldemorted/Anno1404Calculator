namespace Anno1404Calculator; 

using Anno1404Calculator.Models;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;

public class AnnoApi
{
    static readonly uint Player1BeggarsOffset       = 0x7CD8;
    static readonly uint Player2BeggarsOffset       = 0x7CDC;
    static readonly uint Player3BeggarsOffset       = 0x7CE0;
    static readonly uint Player4BeggarsOffset       = 0x7CE4;
    static readonly uint Player1NomadsOffset        = 0x7D18;
    static readonly uint Player2NomadsOffset        = 0x7D1C;
    static readonly uint Player3NomadsOffset        = 0x7D20;
    static readonly uint Player4NomadsOffset        = 0x7D24;
    static readonly uint Player1EmmisOffset         = 0x7D38;
    static readonly uint Player2EmmisOffset         = 0x7D3C;
    static readonly uint Player3EmmisOffset         = 0x7D40;
    static readonly uint Player4EmmisOffset         = 0x7D44;
    static readonly uint Player1PeasantsOffset      = 0x7D78;
    static readonly uint Player2PeasantsOffset      = 0x7D7C;
    static readonly uint Player3PeasantsOffset      = 0x7D80;
    static readonly uint Player4PeasantsOffset      = 0x7D84;
    static readonly uint Player1CitizensOffset      = 0x7D98;
    static readonly uint Player2CitizensOffset      = 0x7D9C;
    static readonly uint Player3CitizensOffset      = 0x7DA0;
    static readonly uint Player4CitizensOffset      = 0x7DA4;
    static readonly uint Player1PatriciansOffset    = 0x7DB8;
    static readonly uint Player2PatriciansOffset    = 0x7DBC;
    static readonly uint Player3PatriciansOffset    = 0x7DC0;
    static readonly uint Player4PatriciansOffset    = 0x7DC4;
    static readonly uint Player1NoblemenOffset      = 0x7DD8;
    static readonly uint Player2NoblemenOffset      = 0x7DDC;
    static readonly uint Player3NoblemenOffset      = 0x7DE0;
    static readonly uint Player4NoblemenOffset      = 0x7DE4;

    public AnnoStatus Read()
    {
        var anno = Process.GetProcessesByName("Addon")[0];
        var handle = Windows.Win32.PInvoke.OpenProcess_SafeHandle(Windows.Win32.System.Threading.PROCESS_ACCESS_RIGHTS.PROCESS_VM_READ, false, (uint)anno.Id);

        // inhabitants
        var inhabitantsBase = ReadU32(handle, 0x012D5A90); // 0x400000 + 0xED5A90
        var player1Beggars = ReadU32(handle, inhabitantsBase + Player1BeggarsOffset);
        var player1Peasants = ReadU32(handle, inhabitantsBase + Player1PeasantsOffset);
        var player1Citizens = ReadU32(handle, inhabitantsBase + Player1CitizensOffset);
        var player1Patricians = ReadU32(handle, inhabitantsBase + Player1PatriciansOffset);
        var player1Noblemen = ReadU32(handle, inhabitantsBase + Player1NoblemenOffset);
        var player1Nomads = ReadU32(handle, inhabitantsBase + Player1NomadsOffset);
        var player1Emmis = ReadU32(handle, inhabitantsBase + Player1EmmisOffset);
        var player2Beggars = ReadU32(handle, inhabitantsBase + Player2BeggarsOffset);
        var player2Peasants = ReadU32(handle, inhabitantsBase + Player2PeasantsOffset);
        var player2Citizens = ReadU32(handle, inhabitantsBase + Player2CitizensOffset);
        var player2Patricians = ReadU32(handle, inhabitantsBase + Player2PatriciansOffset);
        var player2Noblemen = ReadU32(handle, inhabitantsBase + Player2NoblemenOffset);
        var player2Nomads = ReadU32(handle, inhabitantsBase + Player2NomadsOffset);
        var player2Emmis = ReadU32(handle, inhabitantsBase + Player2EmmisOffset);
        var player3Beggars = ReadU32(handle, inhabitantsBase + Player3BeggarsOffset);
        var player3Peasants = ReadU32(handle, inhabitantsBase + Player3PeasantsOffset);
        var player3Citizens = ReadU32(handle, inhabitantsBase + Player3CitizensOffset);
        var player3Patricians = ReadU32(handle, inhabitantsBase + Player3PatriciansOffset);
        var player3Noblemen = ReadU32(handle, inhabitantsBase + Player3NoblemenOffset);
        var player3Nomads = ReadU32(handle, inhabitantsBase + Player3NomadsOffset);
        var player3Emmis = ReadU32(handle, inhabitantsBase + Player3EmmisOffset);
        var player4Beggars = ReadU32(handle, inhabitantsBase + Player4BeggarsOffset);
        var player4Peasants = ReadU32(handle, inhabitantsBase + Player4PeasantsOffset);
        var player4Citizens = ReadU32(handle, inhabitantsBase + Player4CitizensOffset);
        var player4Patricians = ReadU32(handle, inhabitantsBase + Player4PatriciansOffset);
        var player4Noblemen = ReadU32(handle, inhabitantsBase + Player4NoblemenOffset);
        var player4Nomads = ReadU32(handle, inhabitantsBase + Player4NomadsOffset);
        var player4Emmis = ReadU32(handle, inhabitantsBase + Player4EmmisOffset);

        var status = new AnnoStatus
        {
            Player1 = new AnnoPlayerStatus()
            {
                Beggars = player1Beggars,
                Peasants = player1Peasants,
                Patricians = player1Patricians,
                Citizens = player1Citizens,
                Noblemen = player1Noblemen,
                Nomads = player1Nomads,
                Envoys = player1Emmis,
                // Intermediate buildings
                Lumberjackshuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Lumberjackshut),
                Indigofarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Indigofarm),
                Papermills = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Papermill),
                Quartzquarries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Quartzquarry),
                Almondplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Almondplantation),
                Cattlefarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Cattlefarm),
                Apiaries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Apiary),
                Candlemakersworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Candlemakersworkshop),
                Coalmines = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Coalmine),
                Coffeeplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Coffeeplantation),
                Coppermines = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Coppermine),
                Coppersmelters = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Coppersmelter),
                Cropfarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Cropfarm),
                Goldsmelters = 0, // ReadBuildingCount(handle, Anno1404IntermediateBuilding.Goldsmelter),
                Hempplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Hempplantation),
                Mills = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Mill),
                Monasterygardens = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Monasterygarden),
                Pigfarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Pigfarm),
                Rosenurseries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Rosenursery),
                Saltmines = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Saltmine),
                Saltworks = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Saltworks),
                Silkplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Silkplantation),
                Sugarcaneplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Sugarcaneplantation),
                Sugarmills = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Sugarmill),
                Trapperslodges = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Trapperslodge),
                Barrelcooperages = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Barrelcooperage),
                Goldmines = 0, // ReadBuildingCount(handle, Anno1404IntermediateBuilding.Goldmine),
                Ironmines = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Ironmine),
                Ironsmelters = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Ironsmelter),
                Pearlfishershuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Pearlfishershut),
                Vineyards = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Vineyard),
                Claypits = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Claypit),
                // Final buildings
                Bakeries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Bakery),
                Butchersshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Butchersshop),
                Carpetworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Carpetworkshop),
                Ciderfarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Ciderfarm),
                Confectionersworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Confectionersworkshop),
                Dateplantations = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Dateplantation),
                Fishermanshuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Fishermanshut),
                Furriersworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Furriersworkshop),
                Goatfarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Goatfarm),
                Monasterybreweries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Monasterybrewery),
                Opticiansworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Opticiansworkshop),
                Perfumeries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Perfumery),
                Pearlworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Pearlworkshop),
                Printinghouses = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Printinghouse),
                Redsmithsworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Redsmithsworkshop),
                Roastinghouses = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Roastinghouse),
                Tanneries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Tannery),
                Winepresses = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Winepress),
                Spicefarms = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Spicefarm),
                Silkweavingmills = 0, // ReadBuildingCount(handle, Anno1404Building.Silkweavingmill),
                Weavershuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Weavershut),
                Charcoalburnershuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Charcoalburnershut),
                Forestglassworks = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Forestglassworks),
                // Misc buildings
                Mosaicworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Mosaicworkshop),
                Weaponsmithies = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Weaponsmithy),
                Toolmakersworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Toolmakersworkshop),
                Stonemasonshuts = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Stonemasonshut),
                Cannonfoundries = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Cannonfoundry),
                Ropeyards = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Ropeyard),
                Warmachinesworkshops = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Warmachinesworkshop),
                Glasssmelters = ReadBuildingCount(handle, 0, ProductionBuildingEnum.Glasssmelter),
            },
            Player2 = new AnnoPlayerStatus()
            {
                Beggars = player2Beggars,
                Peasants = player2Peasants,
                Patricians = player2Patricians,
                Citizens = player2Citizens,
                Noblemen = player2Noblemen,
                Nomads = player2Nomads,
                Envoys = player2Emmis,
                // Intermediate buildings
                Lumberjackshuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Lumberjackshut),
                Indigofarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Indigofarm),
                Papermills = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Papermill),
                Quartzquarries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Quartzquarry),
                Almondplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Almondplantation),
                Cattlefarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Cattlefarm),
                Apiaries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Apiary),
                Candlemakersworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Candlemakersworkshop),
                Coalmines = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Coalmine),
                Coffeeplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Coffeeplantation),
                Coppermines = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Coppermine),
                Coppersmelters = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Coppersmelter),
                Cropfarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Cropfarm),
                Goldsmelters = 0, // ReadBuildingCount(handle, Anno1414IntermediateBuilding.Goldsmelter),
                Hempplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Hempplantation),
                Mills = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Mill),
                Monasterygardens = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Monasterygarden),
                Pigfarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Pigfarm),
                Rosenurseries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Rosenursery),
                Saltmines = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Saltmine),
                Saltworks = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Saltworks),
                Silkplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Silkplantation),
                Sugarcaneplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Sugarcaneplantation),
                Sugarmills = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Sugarmill),
                Trapperslodges = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Trapperslodge),
                Barrelcooperages = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Barrelcooperage),
                Goldmines = 0, // ReadBuildingCount(handle, Anno1414IntermediateBuilding.Goldmine),
                Ironmines = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Ironmine),
                Ironsmelters = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Ironsmelter),
                Pearlfishershuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Pearlfishershut),
                Vineyards = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Vineyard),
                Claypits = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Claypit),
                // Final buildings
                Bakeries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Bakery),
                Butchersshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Butchersshop),
                Carpetworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Carpetworkshop),
                Ciderfarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Ciderfarm),
                Confectionersworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Confectionersworkshop),
                Dateplantations = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Dateplantation),
                Fishermanshuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Fishermanshut),
                Furriersworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Furriersworkshop),
                Goatfarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Goatfarm),
                Monasterybreweries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Monasterybrewery),
                Opticiansworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Opticiansworkshop),
                Perfumeries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Perfumery),
                Pearlworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Pearlworkshop),
                Printinghouses = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Printinghouse),
                Redsmithsworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Redsmithsworkshop),
                Roastinghouses = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Roastinghouse),
                Tanneries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Tannery),
                Winepresses = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Winepress),
                Spicefarms = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Spicefarm),
                Silkweavingmills = 0, // ReadBuildingCount(handle, Anno1414Building.Silkweavingmill),
                Weavershuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Weavershut),
                Charcoalburnershuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Charcoalburnershut),
                Forestglassworks = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Forestglassworks),
                // Misc buildings
                Mosaicworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Mosaicworkshop),
                Weaponsmithies = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Weaponsmithy),
                Toolmakersworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Toolmakersworkshop),
                Stonemasonshuts = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Stonemasonshut),
                Cannonfoundries = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Cannonfoundry),
                Ropeyards = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Ropeyard),
                Warmachinesworkshops = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Warmachinesworkshop),
                Glasssmelters = ReadBuildingCount(handle, 1, ProductionBuildingEnum.Glasssmelter),
            },
            Player3 = new AnnoPlayerStatus()
            {
                Beggars = player3Beggars,
                Peasants = player3Peasants,
                Patricians = player3Patricians,
                Citizens = player3Citizens,
                Noblemen = player3Noblemen,
                Nomads = player3Nomads,
                Envoys = player3Emmis,
                // Intermediate buildings
                Lumberjackshuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Lumberjackshut),
                Indigofarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Indigofarm),
                Papermills = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Papermill),
                Quartzquarries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Quartzquarry),
                Almondplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Almondplantation),
                Cattlefarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Cattlefarm),
                Apiaries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Apiary),
                Candlemakersworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Candlemakersworkshop),
                Coalmines = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Coalmine),
                Coffeeplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Coffeeplantation),
                Coppermines = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Coppermine),
                Coppersmelters = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Coppersmelter),
                Cropfarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Cropfarm),
                Goldsmelters = 0, // ReadBuildingCount(handle, Anno2424IntermediateBuilding.Goldsmelter),
                Hempplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Hempplantation),
                Mills = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Mill),
                Monasterygardens = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Monasterygarden),
                Pigfarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Pigfarm),
                Rosenurseries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Rosenursery),
                Saltmines = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Saltmine),
                Saltworks = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Saltworks),
                Silkplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Silkplantation),
                Sugarcaneplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Sugarcaneplantation),
                Sugarmills = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Sugarmill),
                Trapperslodges = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Trapperslodge),
                Barrelcooperages = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Barrelcooperage),
                Goldmines = 0, // ReadBuildingCount(handle, Anno2424IntermediateBuilding.Goldmine),
                Ironmines = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Ironmine),
                Ironsmelters = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Ironsmelter),
                Pearlfishershuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Pearlfishershut),
                Vineyards = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Vineyard),
                Claypits = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Claypit),
                // Final buildings
                Bakeries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Bakery),
                Butchersshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Butchersshop),
                Carpetworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Carpetworkshop),
                Ciderfarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Ciderfarm),
                Confectionersworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Confectionersworkshop),
                Dateplantations = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Dateplantation),
                Fishermanshuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Fishermanshut),
                Furriersworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Furriersworkshop),
                Goatfarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Goatfarm),
                Monasterybreweries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Monasterybrewery),
                Opticiansworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Opticiansworkshop),
                Perfumeries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Perfumery),
                Pearlworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Pearlworkshop),
                Printinghouses = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Printinghouse),
                Redsmithsworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Redsmithsworkshop),
                Roastinghouses = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Roastinghouse),
                Tanneries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Tannery),
                Winepresses = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Winepress),
                Spicefarms = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Spicefarm),
                Silkweavingmills = 0, // ReadBuildingCount(handle, Anno2424Building.Silkweavingmill),
                Weavershuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Weavershut),
                Charcoalburnershuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Charcoalburnershut),
                Forestglassworks = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Forestglassworks),
                // Misc buildings
                Mosaicworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Mosaicworkshop),
                Weaponsmithies = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Weaponsmithy),
                Toolmakersworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Toolmakersworkshop),
                Stonemasonshuts = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Stonemasonshut),
                Cannonfoundries = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Cannonfoundry),
                Ropeyards = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Ropeyard),
                Warmachinesworkshops = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Warmachinesworkshop),
                Glasssmelters = ReadBuildingCount(handle, 2, ProductionBuildingEnum.Glasssmelter),
            },
            Player4 = new AnnoPlayerStatus()
            {
                Beggars = player4Beggars,
                Peasants = player4Peasants,
                Patricians = player4Patricians,
                Citizens = player4Citizens,
                Noblemen = player4Noblemen,
                Nomads = player4Nomads,
                Envoys = player4Emmis,
                // Intermediate buildings
                Lumberjackshuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Lumberjackshut),
                Indigofarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Indigofarm),
                Papermills = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Papermill),
                Quartzquarries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Quartzquarry),
                Almondplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Almondplantation),
                Cattlefarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Cattlefarm),
                Apiaries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Apiary),
                Candlemakersworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Candlemakersworkshop),
                Coalmines = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Coalmine),
                Coffeeplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Coffeeplantation),
                Coppermines = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Coppermine),
                Coppersmelters = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Coppersmelter),
                Cropfarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Cropfarm),
                Goldsmelters = 0, // ReadBuildingCount(handle, Anno3434IntermediateBuilding.Goldsmelter),
                Hempplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Hempplantation),
                Mills = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Mill),
                Monasterygardens = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Monasterygarden),
                Pigfarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Pigfarm),
                Rosenurseries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Rosenursery),
                Saltmines = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Saltmine),
                Saltworks = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Saltworks),
                Silkplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Silkplantation),
                Sugarcaneplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Sugarcaneplantation),
                Sugarmills = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Sugarmill),
                Trapperslodges = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Trapperslodge),
                Barrelcooperages = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Barrelcooperage),
                Goldmines = 0, // ReadBuildingCount(handle, Anno3434IntermediateBuilding.Goldmine),
                Ironmines = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Ironmine),
                Ironsmelters = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Ironsmelter),
                Pearlfishershuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Pearlfishershut),
                Vineyards = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Vineyard),
                Claypits = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Claypit),
                // Final buildings
                Bakeries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Bakery),
                Butchersshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Butchersshop),
                Carpetworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Carpetworkshop),
                Ciderfarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Ciderfarm),
                Confectionersworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Confectionersworkshop),
                Dateplantations = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Dateplantation),
                Fishermanshuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Fishermanshut),
                Furriersworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Furriersworkshop),
                Goatfarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Goatfarm),
                Monasterybreweries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Monasterybrewery),
                Opticiansworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Opticiansworkshop),
                Perfumeries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Perfumery),
                Pearlworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Pearlworkshop),
                Printinghouses = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Printinghouse),
                Redsmithsworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Redsmithsworkshop),
                Roastinghouses = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Roastinghouse),
                Tanneries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Tannery),
                Winepresses = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Winepress),
                Spicefarms = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Spicefarm),
                Silkweavingmills = 0, // ReadBuildingCount(handle, Anno3434Building.Silkweavingmill),
                Weavershuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Weavershut),
                Charcoalburnershuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Charcoalburnershut),
                Forestglassworks = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Forestglassworks),
                // Misc buildings
                Mosaicworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Mosaicworkshop),
                Weaponsmithies = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Weaponsmithy),
                Toolmakersworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Toolmakersworkshop),
                Stonemasonshuts = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Stonemasonshut),
                Cannonfoundries = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Cannonfoundry),
                Ropeyards = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Ropeyard),
                Warmachinesworkshops = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Warmachinesworkshop),
                Glasssmelters = ReadBuildingCount(handle, 3, ProductionBuildingEnum.Glasssmelter),
            }
        };

        handle.Close();
        return status;
    }

    private uint ReadBuildingCount(Microsoft.Win32.SafeHandles.SafeFileHandle handle, uint playerId, ProductionBuildingEnum building)
    {
        uint buildingId = building.GetBuildingId();
        uint hugeTablePtr = ReadU32(handle, 0x012D92D8);
        uint firstPtr = hugeTablePtr + 0x79A4 + playerId * 0x18;
        uint nextPtr = ReadU32(handle, firstPtr + 0x4);

        for (int i = 0; i < 20; i++)
        {
            uint nextId = ReadU32(handle, nextPtr + 0x10);
            if (nextId == buildingId)
            {
                return ReadU32(handle, nextPtr + 0x14);
            }
            else if (nextId < buildingId)
            {
                nextPtr = ReadU32(handle, nextPtr + 0xC);
            }
            else
            {
                nextPtr = ReadU32(handle, nextPtr + 0x8);
            }
        }

        return 0;
    }

    private unsafe uint ReadU32(Microsoft.Win32.SafeHandles.SafeFileHandle handle, uint address)
    {
        Span<byte> buffer = stackalloc byte[4];
        uint read = 0;
        fixed (byte* bufferPtr = buffer)
        {
            Windows.Win32.PInvoke.ReadProcessMemory(handle, (void*)address, bufferPtr, 4, (nuint*)&read);
        }
        
        if (read != 4)
        {
            // throw new InvalidOperationException();
        }

        return BinaryPrimitives.ReadUInt32LittleEndian(buffer);
    }
}
