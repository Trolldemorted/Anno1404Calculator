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
        static readonly uint NomadsOffset       = 0x7D18;
        static readonly uint EmmisOffset        = 0x7D38;
        static readonly uint BeggarsOffset      = 0x7CD8;
        static readonly uint PeasantsOffset     = 0x7D78;
        static readonly uint CitizensOffset     = 0x7D98;
        static readonly uint PatriciansOffset   = 0x7DB8;
        static readonly uint NoblemenOffset     = 0x7DD8;

        public AnnoStatus Read()
        {
            var anno = Process.GetProcessesByName("Addon")[0];
            var handle = PInvoke.OpenProcess(anno, ProcessAccessFlags.VirtualMemoryRead);

            // inhabitants
            var inhabitantsBase = ReadU32(handle, 0x012D5A90);
            var beggars = ReadU32(handle, inhabitantsBase + BeggarsOffset);
            var peasants = ReadU32(handle, inhabitantsBase + PeasantsOffset);
            var citizens = ReadU32(handle, inhabitantsBase + CitizensOffset);
            var patricians = ReadU32(handle, inhabitantsBase + PatriciansOffset);
            var noblemen = ReadU32(handle, inhabitantsBase + NoblemenOffset);
            var nomads = ReadU32(handle, inhabitantsBase + NomadsOffset);
            var emmis = ReadU32(handle, inhabitantsBase + EmmisOffset);

            // production
            var productionBase0 = ReadU32(handle, 0x012D2BFC); //"Addon.exe" + 0x00Ed2BFC
            var productionBase1 = ReadU32(handle, productionBase0 + 0x5B0);
            var productionBase2 = ReadU32(handle, productionBase1 + 0x5A4);
            var carpetWorkshops = ReadU32(handle, productionBase2 + 0x7DC);
            var roesterei = ReadU32(handle, productionBase2 + 0x7DC - 0x318);

            PInvoke.CloseHandle(handle);
            return new AnnoStatus()
            {
                Beggars = beggars,
                Peasants = peasants,
                Patricians = patricians,
                Citizens = citizens,
                Noblemen = noblemen,
                Nomads = nomads,
                Envoys = emmis
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
