using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    internal class Almondplantation : IProductionBuilding
    {
        public override double ProductionFactor => throw new NotImplementedException();

        public override ImmutableDictionary<Type, double> SuccessorBuildings => throw new NotImplementedException();

        public Almondplantation(uint count) : base(count)
        {
        }
    }
}
