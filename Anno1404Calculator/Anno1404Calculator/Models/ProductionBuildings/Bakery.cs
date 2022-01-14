using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    internal class Bakery : IProductionBuilding
    {
        public override double ProductionFactor => 2;

        public override ImmutableDictionary<Type, double> SuccessorBuildings { get; } = new Dictionary<Type, double>()
        {
            { typeof(Mill), 2.0 }
        }.ToImmutableDictionary();

        public Bakery(uint count) : base(count)
        {
        }
    }
}
