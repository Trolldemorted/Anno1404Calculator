using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator
{
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
            var handle = PInvoke.OpenProcess(anno, ProcessAccessFlags.VirtualMemoryRead);

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

            // production
            // var productionBase0 = ReadU32(handle, 0x012D2BFC); //"Addon.exe" + 0x00Ed2BFC
            // var productionBase1 = ReadU32(handle, productionBase0 + 0x5B0);
            // var productionBase2 = ReadU32(handle, productionBase1 + 0x5A4);
            // var carpetWorkshops = ReadU32(handle, productionBase2 + 0x7DC);
            //  var roesterei = ReadU32(handle, productionBase2 + 0x7DC - 0x318);

            PInvoke.CloseHandle(handle);
            return new AnnoStatus
            {
                Player1 = new AnnoPlayerStatus()
                {
                    Beggars = player1Beggars,
                    Peasants = player1Peasants,
                    Patricians = player1Patricians,
                    Citizens = player1Citizens,
                    Noblemen = player1Noblemen,
                    Nomads = player1Nomads,
                    Envoys = player1Emmis
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
        }

        uint ReadU32(IntPtr handle, uint address)
        {
            var buffer = new byte[4];
            PInvoke.ReadProcessMemory(handle, new IntPtr(address), buffer, 4, out IntPtr read);
            if (read.ToInt32() != 4)
                throw new InvalidOperationException();
            return BitConverter.ToUInt32(buffer, 0);
        }
    }
}
