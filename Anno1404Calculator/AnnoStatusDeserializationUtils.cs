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
                Player1 = new AnnoPlayerStatus()
                {
                    Nomads = (uint)set["player1"+nameof(AnnoPlayerStatus.Nomads)],
                    Envoys = (uint)set["player1" + nameof(AnnoPlayerStatus.Envoys)],
                    Beggars = (uint)set["player1" + nameof(AnnoPlayerStatus.Beggars)],
                    Peasants = (uint)set["player1" + nameof(AnnoPlayerStatus.Peasants)],
                    Citizens = (uint)set["player1" + nameof(AnnoPlayerStatus.Citizens)],
                    Patricians = (uint)set["player1" + nameof(AnnoPlayerStatus.Patricians)],
                    Noblemen = (uint)set["player1" + nameof(AnnoPlayerStatus.Noblemen)]
                },
                Player2 = new AnnoPlayerStatus()
                {
                    Nomads = (uint)set["player2" + nameof(AnnoPlayerStatus.Nomads)],
                    Envoys = (uint)set["player2" + nameof(AnnoPlayerStatus.Envoys)],
                    Beggars = (uint)set["player2" + nameof(AnnoPlayerStatus.Beggars)],
                    Peasants = (uint)set["player2" + nameof(AnnoPlayerStatus.Peasants)],
                    Citizens = (uint)set["player2" + nameof(AnnoPlayerStatus.Citizens)],
                    Patricians = (uint)set["player2" + nameof(AnnoPlayerStatus.Patricians)],
                    Noblemen = (uint)set["player2" + nameof(AnnoPlayerStatus.Noblemen)]
                },
                Player3 = new AnnoPlayerStatus()
                {
                    Nomads = (uint)set["player3" + nameof(AnnoPlayerStatus.Nomads)],
                    Envoys = (uint)set["player3" + nameof(AnnoPlayerStatus.Envoys)],
                    Beggars = (uint)set["player3" + nameof(AnnoPlayerStatus.Beggars)],
                    Peasants = (uint)set["player3" + nameof(AnnoPlayerStatus.Peasants)],
                    Citizens = (uint)set["player3" + nameof(AnnoPlayerStatus.Citizens)],
                    Patricians = (uint)set["player3" + nameof(AnnoPlayerStatus.Patricians)],
                    Noblemen = (uint)set["player3" + nameof(AnnoPlayerStatus.Noblemen)]
                },
                Player4 = new AnnoPlayerStatus()
                {
                    Nomads = (uint)set["player4" + nameof(AnnoPlayerStatus.Nomads)],
                    Envoys = (uint)set["player4" + nameof(AnnoPlayerStatus.Envoys)],
                    Beggars = (uint)set["player4" + nameof(AnnoPlayerStatus.Beggars)],
                    Peasants = (uint)set["player4" + nameof(AnnoPlayerStatus.Peasants)],
                    Citizens = (uint)set["player4" + nameof(AnnoPlayerStatus.Citizens)],
                    Patricians = (uint)set["player4" + nameof(AnnoPlayerStatus.Patricians)],
                    Noblemen = (uint)set["player4" + nameof(AnnoPlayerStatus.Noblemen)]
                },
            };
        }
    }
}
