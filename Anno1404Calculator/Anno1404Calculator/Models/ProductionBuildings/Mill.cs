using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    internal class Mill : IProductionBuilding
    {
        public override double ProductionFactor => 2;

        public override ImmutableDictionary<Type, double> SuccessorBuildings { get; } = new Dictionary<Type, double>()
        {
            { typeof(Cropfarm), 2.0 }
        }.ToImmutableDictionary();

        public Mill(uint count) : base(count)
        {
        }

        public override double GetCitizenConsumption(AnnoPlayerStatus status)
        {
            return status.ProductionBuildings[typeof(Bakery)].Count * 4.0;
        }
    }
}
