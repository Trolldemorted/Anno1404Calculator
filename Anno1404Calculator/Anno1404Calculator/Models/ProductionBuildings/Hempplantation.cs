using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    public class Hempplantation : IProductionBuilding
    {
        public override double ProductionFactor => throw new NotImplementedException();

        public override ImmutableDictionary<Type, double> SuccessorBuildings { get; } = new Dictionary<Type, double>()
        {
            { typeof(Weavershut), 2.0 }
        }.ToImmutableDictionary();

        public Hempplantation(uint count) : base(count)
        {
        }

        public override double GetCitizenConsumption(AnnoPlayerStatus status)
        {
            return 0.0
        }
    }
}
