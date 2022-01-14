using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    public class Weavershut : IProductionBuilding
    {
        public Weavershut(uint count) : base(count)
        {
        }

        public override double ProductionFactor => throw new NotImplementedException();

        public override ImmutableDictionary<Type, double> SuccessorBuildings { get; } = new Dictionary<Type, double>()
        {
            { typeof(Hempplantation), 2.0 }
        }.ToImmutableDictionary();

        public override double GetCitizenConsumption(AnnoPlayerStatus status)
        {
            return status.Citizens * 0.0042 + status.Patricians * 0.0019 + status.Noblemen * 0.0008;
        }
    }
}
