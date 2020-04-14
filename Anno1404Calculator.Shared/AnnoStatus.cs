using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace Anno1404Calculator.Shared
{
    public class AnnoStatus
    {
        public uint Nomads { get; set; }
        public uint Envoys { get; set; }
        public uint Beggars { get; set; }
        public uint Peasants { get; set; }
        public uint Citizens { get; set; }
        public uint Patricians { get; set; }
        public uint Noblemen { get; set; }

        public ValueSet Serialize()
        {
            return new ValueSet
            {
                { nameof(Nomads), Nomads },
                { nameof(Envoys), Envoys },
                { nameof(Beggars), Beggars },
                { nameof(Peasants), Peasants },
                { nameof(Citizens), Citizens },
                { nameof(Patricians), Patricians },
                { nameof(Noblemen), Noblemen }
            };
        }

        public static AnnoStatus Deserialize(ValueSet set)
        {
            return new AnnoStatus()
            {
                Nomads = (uint)set[nameof(Nomads)],
                Envoys = (uint)set[nameof(Envoys)],
                Beggars = (uint)set[nameof(Beggars)],
                Peasants = (uint)set[nameof(Peasants)],
                Citizens = (uint)set[nameof(Citizens)],
                Patricians = (uint)set[nameof(Patricians)],
                Noblemen = (uint)set[nameof(Noblemen)]
            };
        }
    }
}
