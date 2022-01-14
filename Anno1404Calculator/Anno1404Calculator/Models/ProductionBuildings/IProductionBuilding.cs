using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anno1404Calculator.Models.ProductionBuildings
{
    public abstract class IProductionBuilding
    {
        public abstract double ProductionFactor { get; }
        public abstract ImmutableDictionary<Type, double> SuccessorBuildings { get; }
        public abstract double GetCitizenConsumption(AnnoPlayerStatus status);
        public uint Count { get; }

        /// <summary>
        /// Calculates the total consumption of the output product,
        /// i.e. the sum of the consumptions by citizens and by successor buildings.
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public double GetConsumption(AnnoPlayerStatus status)
        {
            double consumption = GetCitizenConsumption(status);
            foreach ((var type, var successorBuildings) in SuccessorBuildings)
            {
                var building = status.ProductionBuildings[type];
                consumption += building.Count * building.ProductionFactor * successorBuildings;
            }

            return consumption;
        }

        public IProductionBuilding(uint count)
        {
            Count = count;
        }
    }
}
