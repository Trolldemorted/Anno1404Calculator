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
                { nameof(status.Nomads), status.Nomads },
                { nameof(status.Envoys), status.Envoys },
                { nameof(status.Beggars), status.Beggars },
                { nameof(status.Peasants), status.Peasants },
                { nameof(status.Citizens), status.Citizens },
                { nameof(status.Patricians), status.Patricians },
                { nameof(status.Noblemen), status.Noblemen }
            };
        }
    }
}
