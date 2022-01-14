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
                Lumberjackshuts = ReadBuildingCount(handle, ProductionBuildingEnum.Lumberjackshut),
                Indigofarms = ReadBuildingCount(handle, ProductionBuildingEnum.Indigofarm),
                Papermills = ReadBuildingCount(handle, ProductionBuildingEnum.Papermill),
                Quartzquarries = ReadBuildingCount(handle, ProductionBuildingEnum.Quartzquarry),
                Almondplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Almondplantation),
                Cattlefarms = ReadBuildingCount(handle, ProductionBuildingEnum.Cattlefarm),
                Apiaries = ReadBuildingCount(handle, ProductionBuildingEnum.Apiary),
                Candlemakersworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Candlemakersworkshop),
                Coalmines = ReadBuildingCount(handle, ProductionBuildingEnum.Coalmine),
                Coffeeplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Coffeeplantation),
                Coppermines = ReadBuildingCount(handle, ProductionBuildingEnum.Coppermine),
                Coppersmelters = ReadBuildingCount(handle, ProductionBuildingEnum.Coppersmelter),
                Cropfarms = ReadBuildingCount(handle, ProductionBuildingEnum.Cropfarm),
                Goldsmelters = 0, // ReadBuildingCount(handle, Anno1404IntermediateBuilding.Goldsmelter),
                Hempplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Hempplantation),
                Mills = ReadBuildingCount(handle, ProductionBuildingEnum.Mill),
                Monasterygardens = ReadBuildingCount(handle, ProductionBuildingEnum.Monasterygarden),
                Pigfarms = ReadBuildingCount(handle, ProductionBuildingEnum.Pigfarm),
                Rosenurseries = ReadBuildingCount(handle, ProductionBuildingEnum.Rosenursery),
                Saltmines = ReadBuildingCount(handle, ProductionBuildingEnum.Saltmine),
                Saltworks = ReadBuildingCount(handle, ProductionBuildingEnum.Saltworks),
                Silkplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Silkplantation),
                Sugarcaneplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Sugarcaneplantation),
                Sugarmills = ReadBuildingCount(handle, ProductionBuildingEnum.Sugarmill),
                Trapperslodges = ReadBuildingCount(handle, ProductionBuildingEnum.Trapperslodge),
                Barrelcooperages = ReadBuildingCount(handle, ProductionBuildingEnum.Barrelcooperage),
                Goldmines = 0, // ReadBuildingCount(handle, Anno1404IntermediateBuilding.Goldmine),
                Ironmines = ReadBuildingCount(handle, ProductionBuildingEnum.Ironmine),
                Ironsmelters = ReadBuildingCount(handle, ProductionBuildingEnum.Ironsmelter),
                Pearlfishershuts = ReadBuildingCount(handle, ProductionBuildingEnum.Pearlfishershut),
                Vineyards = ReadBuildingCount(handle, ProductionBuildingEnum.Vineyard),
                Claypits = ReadBuildingCount(handle, ProductionBuildingEnum.Claypit),
                // Final buildings
                Bakeries = ReadBuildingCount(handle, ProductionBuildingEnum.Bakery),
                Butchersshops = ReadBuildingCount(handle, ProductionBuildingEnum.Butchersshop),
                Carpetworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Carpetworkshop),
                Ciderfarms = ReadBuildingCount(handle, ProductionBuildingEnum.Ciderfarm),
                Confectionersworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Confectionersworkshop),
                Dateplantations = ReadBuildingCount(handle, ProductionBuildingEnum.Dateplantation),
                Fishermanshuts = ReadBuildingCount(handle, ProductionBuildingEnum.Fishermanshut),
                Furriersworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Furriersworkshop),
                Goatfarms = ReadBuildingCount(handle, ProductionBuildingEnum.Goatfarm),
                Monasterybreweries = ReadBuildingCount(handle, ProductionBuildingEnum.Monasterybrewery),
                Opticiansworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Opticiansworkshop),
                Perfumeries = ReadBuildingCount(handle, ProductionBuildingEnum.Perfumery),
                Pearlworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Pearlworkshop),
                Printinghouses = ReadBuildingCount(handle, ProductionBuildingEnum.Printinghouse),
                Redsmithsworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Redsmithsworkshop),
                Roastinghouses = ReadBuildingCount(handle, ProductionBuildingEnum.Roastinghouse),
                Tanneries = ReadBuildingCount(handle, ProductionBuildingEnum.Tannery),
                Winepresses = ReadBuildingCount(handle, ProductionBuildingEnum.Winepress),
                Spicefarms = ReadBuildingCount(handle, ProductionBuildingEnum.Spicefarm),
                Silkweavingmills = 0, // ReadBuildingCount(handle, Anno1404Building.Silkweavingmill),
                Weavershuts = ReadBuildingCount(handle, ProductionBuildingEnum.Weavershut),
                Charcoalburnershuts = ReadBuildingCount(handle, ProductionBuildingEnum.Charcoalburnershut),
                Forestglassworks = ReadBuildingCount(handle, ProductionBuildingEnum.Forestglassworks),
                // Misc buildings
                Mosaicworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Mosaicworkshop),
                Weaponsmithies = ReadBuildingCount(handle, ProductionBuildingEnum.Weaponsmithy),
                Toolmakersworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Toolmakersworkshop),
                Stonemasonshuts = ReadBuildingCount(handle, ProductionBuildingEnum.Stonemasonshut),
                Cannonfoundries = ReadBuildingCount(handle, ProductionBuildingEnum.Cannonfoundry),
                Ropeyards = ReadBuildingCount(handle, ProductionBuildingEnum.Ropeyard),
                Warmachinesworkshops = ReadBuildingCount(handle, ProductionBuildingEnum.Warmachinesworkshop),
                Glasssmelters = ReadBuildingCount(handle, ProductionBuildingEnum.Glasssmelter),
            },
            Player2 = new AnnoPlayerStatus()
            {
                Beggars = player2Beggars,
                Peasants = player2Peasants,
                Patricians = player2Patricians,
                Citizens = player2Citizens,
                Noblemen = player2Noblemen,
                Nomads = player2Nomads,
                Envoys = player2Emmis
            },
            Player3 = new AnnoPlayerStatus()
            {
                Beggars = player3Beggars,
                Peasants = player3Peasants,
                Patricians = player3Patricians,
                Citizens = player3Citizens,
                Noblemen = player3Noblemen,
                Nomads = player3Nomads,
                Envoys = player3Emmis
            },
            Player4 = new AnnoPlayerStatus()
            {
                Beggars = player4Beggars,
                Peasants = player4Peasants,
                Patricians = player4Patricians,
                Citizens = player4Citizens,
                Noblemen = player4Noblemen,
                Nomads = player4Nomads,
                Envoys = player4Emmis
            }
        };

        handle.Close();
        return status;
    }

    private uint ReadBuildingCount(Microsoft.Win32.SafeHandles.SafeFileHandle handle, ProductionBuildingEnum building)
    {
        uint buildingId = building.GetBuildingId();
        uint hugeTablePtr = ReadU32(handle, 0x012D92D8);
        uint firstPtr = hugeTablePtr + 0x79A4;
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
