using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation.Collections;

namespace Anno1404Calculator.DesktopExtension
{
    static class AnnoStatusSerializationExtensions
    {
        public static ValueSet Serialize(this AnnoStatus status)
        {
            return new ValueSet
            {
                { "player1"+nameof(status.Player1.Nomads), status.Player1.Nomads },
                { "player1"+nameof(status.Player1.Envoys), status.Player1.Envoys },
                { "player1"+nameof(status.Player1.Beggars), status.Player1.Beggars },
                { "player1"+nameof(status.Player1.Peasants), status.Player1.Peasants },
                { "player1"+nameof(status.Player1.Citizens), status.Player1.Citizens },
                { "player1"+nameof(status.Player1.Patricians), status.Player1.Patricians },
                { "player1"+nameof(status.Player1.Noblemen), status.Player1.Noblemen },
                { "player2"+nameof(status.Player2.Nomads), status.Player2.Nomads },
                { "player2"+nameof(status.Player2.Envoys), status.Player2.Envoys },
                { "player2"+nameof(status.Player2.Beggars), status.Player2.Beggars },
                { "player2"+nameof(status.Player2.Peasants), status.Player2.Peasants },
                { "player2"+nameof(status.Player2.Citizens), status.Player2.Citizens },
                { "player2"+nameof(status.Player2.Patricians), status.Player2.Patricians },
                { "player2"+nameof(status.Player2.Noblemen), status.Player2.Noblemen },
                { "player3"+nameof(status.Player3.Nomads), status.Player3.Nomads },
                { "player3"+nameof(status.Player3.Envoys), status.Player3.Envoys },
                { "player3"+nameof(status.Player3.Beggars), status.Player3.Beggars },
                { "player3"+nameof(status.Player3.Peasants), status.Player3.Peasants },
                { "player3"+nameof(status.Player3.Citizens), status.Player3.Citizens },
                { "player3"+nameof(status.Player3.Patricians), status.Player3.Patricians },
                { "player3"+nameof(status.Player3.Noblemen), status.Player3.Noblemen },
                { "player4"+nameof(status.Player4.Nomads), status.Player4.Nomads },
                { "player4"+nameof(status.Player4.Envoys), status.Player4.Envoys },
                { "player4"+nameof(status.Player4.Beggars), status.Player4.Beggars },
                { "player4"+nameof(status.Player4.Peasants), status.Player4.Peasants },
                { "player4"+nameof(status.Player4.Citizens), status.Player4.Citizens },
                { "player4"+nameof(status.Player4.Patricians), status.Player4.Patricians },
                { "player4"+nameof(status.Player4.Noblemen), status.Player4.Noblemen }
            };
        }
    }
}
