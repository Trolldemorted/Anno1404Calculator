namespace Anno1404Calculator.Models;

using Anno1404Calculator.Models.ProductionBuildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AnnoPlayerStatus
{
    public uint Nomads { get; set; }
    public uint Envoys { get; set; }
    public uint Beggars { get; set; }
    public uint Peasants { get; set; }
    public uint Citizens { get; set; }
    public uint Patricians { get; set; }
    public uint Noblemen { get; set; }
    public Dictionary<Type, IProductionBuilding> ProductionBuildings { get; set; }
    // Intermediate buildings
    public uint Sugarcaneplantations { get; set; }
    public uint Sugarmills { get; set; }
    public uint Silkplantations { get; set; }
    public uint Rosenurseries { get; set; }
    public uint Hempplantations { get; set; }
    public uint Goldsmelters { get; set; }
    public uint Coppersmelters { get; set; }
    public uint Coppermines { get; set; }
    public uint Coffeeplantations { get; set; }
    public uint Candlemakersworkshops { get; set; }
    public uint Quartzquarries { get; set; }
    public uint Claypits { get; set; }
    public uint Apiaries { get; set; }
    public uint Almondplantations { get; set; }
    public uint Cropfarms { get; set; }
    public uint Mills { get; set; }
    public uint Monasterygardens { get; set; }
    public uint Coalmines { get; set; }
    public uint Saltmines { get; set; }
    public uint Saltworks { get; set; }
    public uint Pigfarms { get; set; }
    public uint Papermills { get; set; }
    public uint Indigoplantations { get; set; }
    public uint Lumberjackshuts { get; set; }
    public uint Cattlefarms { get; set; }
    public uint Trapperslodges { get; set; }
    public uint Goldmines { get; set; }
    public uint Vineyards { get; set; }
    public uint Barrelcooperage { get; set; }
    public uint Ironmine { get; set; }
    public uint Ironsmelter { get; set; }
    public uint Pearlfishershut { get; set; }
    // Final buildings
    public uint Fishermanshuts { get; set; }
    public uint Spicefarms { get; set; }
    public uint Ciderfarms { get; set; }
    public uint Weavershuts { get; set; }
    public uint Bakeries { get; set; }
    public uint Monasterybreweries { get; set; }
    public uint Tanneries { get; set; }
    public uint Printinghouses { get; set; }
    public uint Butchersshops { get; set; }
    public uint Furriersworkshops { get; set; }
    public uint Winepresses { get; set; }
    public uint Redsmithsworkshops { get; set; }
    public uint Opticiansworkshops { get; set; }
    public uint Confectionersworkshops { get; set; }
    public uint Perfumeries { get; set; }
    public uint Perlworkshops { get; set; }
    public uint Roastinghouses { get; set; }
    public uint Carpetworkshops { get; set; }
    public uint Dateplantations { get; set; }
    public uint Goatfarms { get; set; }
    public uint Silkweavingmills { get; set; }
    // Misc buildings
    public uint Toolmakersworkshops { get; set; }
    public uint Stonemasonshuts { get; set; }
    public uint Ropeyards { get; set; }
    public uint Weaponsmithies { get; set; }
    public uint Mosaicworkshops { get; set; }
    public uint Warmachinesworkshops { get; set; }
    public uint Cannonfoundries { get; set; }

    /*
    public double GetConsumption(ProductionBuilding building) =>
        building switch
        {
            ProductionBuilding.Sugarcaneplantation => throw new NotImplementedException(),
            ProductionBuilding.Sugarmill => throw new NotImplementedException(),
            ProductionBuilding.Silkplantation => throw new NotImplementedException(),
            ProductionBuilding.Rosenursery => Envoys * 0.0008,
            ProductionBuilding.Hempplantation => (Weavershuts * 2 + Ropeyards + Candlemakersworkshops) * ProductionBuilding.Hempplantation.GetProductionPerMinuteFactor(),
            ProductionBuilding.Goldsmelter => throw new NotImplementedException(),
            ProductionBuilding.Goldmine => throw new NotImplementedException(),
            ProductionBuilding.Coppersmelter => throw new NotImplementedException(),
            ProductionBuilding.Coppermine => throw new NotImplementedException(),
            ProductionBuilding.Coffeeplantation => throw new NotImplementedException(),
            ProductionBuilding.Candlemakersworkshop => throw new NotImplementedException(),
            ProductionBuilding.Apiary => throw new NotImplementedException(),
            ProductionBuilding.Almondplantation => throw new NotImplementedException(),
            ProductionBuilding.Cropfarm => throw new NotImplementedException(),
            ProductionBuilding.Mill => throw new NotImplementedException(),
            ProductionBuilding.Monasterygarden => throw new NotImplementedException(),
            ProductionBuilding.Coalmine => throw new NotImplementedException(),
            ProductionBuilding.Saltmine => throw new NotImplementedException(),
            ProductionBuilding.Saltworks => throw new NotImplementedException(),
            ProductionBuilding.Pigfarm => throw new NotImplementedException(),
            ProductionBuilding.Papermill => throw new NotImplementedException(),
            ProductionBuilding.Indigofarm => throw new NotImplementedException(),
            ProductionBuilding.Lumberjackshut => throw new NotImplementedException(),
            ProductionBuilding.Cattlefarm => throw new NotImplementedException(),
            ProductionBuilding.Trapperslodge => throw new NotImplementedException(),
            ProductionBuilding.Vineyard => throw new NotImplementedException(),
            ProductionBuilding.Barrelcooperage => throw new NotImplementedException(),
            ProductionBuilding.Claypit => throw new NotImplementedException(),
            ProductionBuilding.Quartzquarry => throw new NotImplementedException(),
            ProductionBuilding.Ironmine => throw new NotImplementedException(),
            ProductionBuilding.Ironsmelter => throw new NotImplementedException(),
            ProductionBuilding.Pearlfishershut => throw new NotImplementedException(),
            ProductionBuilding.Fishermanshut => Beggars * 0.007 + Peasants * 0.01 + Citizens * 0.004 + Patricians * 0.0022 + Noblemen * 0.0016,
            ProductionBuilding.Ciderfarm => Beggars * 0.003 + Peasants * 0.0044 + Citizens * 0.0044 + Patricians * 0.0023 + Noblemen * 0.0013,
            ProductionBuilding.Weavershut => Citizens * 0.0042 + Patricians * 0.0019 + Noblemen * 0.0008,
            ProductionBuilding.Bakery => Patricians * 0.0055 + Noblemen * 0.0039,
            ProductionBuilding.Monasterybrewery => Patricians * 0.0024 + Noblemen * 0.0014,
            ProductionBuilding.Tannery => Patricians * 0.0028 + Noblemen * 0.0016,
            ProductionBuilding.Printinghouse => Patricians * 0.0016 + Noblemen * 0.0009,
            ProductionBuilding.Butchersshop => Noblemen * 0.0022,
            ProductionBuilding.Furriersworkshop => Noblemen * 0.0016,
            ProductionBuilding.Winepress => Noblemen * 0.002,
            ProductionBuilding.Redsmithsworkshop => Patricians * 0.0008 + Noblemen * 0.0006,
            ProductionBuilding.Opticiansworkshop => throw new NotImplementedException(),
            ProductionBuilding.Confectionersworkshop => Envoys * 0.00163,
            ProductionBuilding.Perfumery => throw new NotImplementedException(),
            ProductionBuilding.Pearlworkshop => Envoys * 0.00133,
            ProductionBuilding.Roastinghouse => Envoys * 0.001,
            ProductionBuilding.Carpetworkshop => Nomads * 0.00165 + Envoys * 0.001,
            ProductionBuilding.Dateplantation => Nomads * 0.00666 + Envoys * 0.005,
            ProductionBuilding.Goatfarm => Nomads * 0.00344 + Envoys * 0.00225,
            ProductionBuilding.Silkweavingmill => Noblemen * 0.00142,
            ProductionBuilding.Spicefarm => Citizens * 0.0044 + Patricians * 0.0022 + Noblemen * 0.0016,
            ProductionBuilding.Charcoalburnershut => throw new NotImplementedException(),
            ProductionBuilding.Forestglassworks => throw new NotImplementedException(),
            ProductionBuilding.Toolmakersworkshop => throw new NotImplementedException(),
            ProductionBuilding.Stonemasonshut => throw new NotImplementedException(),
            ProductionBuilding.Ropeyard => throw new NotImplementedException(),
            ProductionBuilding.Weaponsmithy => throw new NotImplementedException(),
            ProductionBuilding.Mosaicworkshop => throw new NotImplementedException(),
            ProductionBuilding.Warmachinesworkshop => throw new NotImplementedException(),
            ProductionBuilding.Cannonfoundry => throw new NotImplementedException(),
            ProductionBuilding.Glasssmelter => Noblemen * 0.00117,
            _ => throw new NotImplementedException(),
        };
    */
}
