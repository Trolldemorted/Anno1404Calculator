using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace Anno1404Calculator
{
    class AnnoStatusDeserializationUtils
    {
        public static AnnoStatus Deserialize(ValueSet set)
        {
            return new AnnoStatus()
            {
                Nomads = (uint)set[nameof(AnnoStatus.Nomads)],
                Envoys = (uint)set[nameof(AnnoStatus.Envoys)],
                Beggars = (uint)set[nameof(AnnoStatus.Beggars)],
                Peasants = (uint)set[nameof(AnnoStatus.Peasants)],
                Citizens = (uint)set[nameof(AnnoStatus.Citizens)],
                Patricians = (uint)set[nameof(AnnoStatus.Patricians)],
                Noblemen = (uint)set[nameof(AnnoStatus.Noblemen)]
            };
        }
    }
}
