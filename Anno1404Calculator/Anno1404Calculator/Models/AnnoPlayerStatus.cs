namespace Anno1404Calculator.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record AnnoPlayerStatus
{
    public uint Nomads { get; set; }
    public uint Envoys { get; set; }
    public uint Beggars { get; set; }
    public uint Peasants { get; set; }
    public uint Citizens { get; set; }
    public uint Patricians { get; set; }
    public uint Noblemen { get; set; }
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
    public uint Indigofarms { get; set; }
    public uint Lumberjackshuts { get; set; }
    public uint Cattlefarms { get; set; }
    public uint Trapperslodges { get; set; }
    public uint Goldmines { get; set; }
    public uint Vineyards { get; set; }
    public uint Barrelcooperages { get; set; }
    public uint Ironmines { get; set; }
    public uint Ironsmelters { get; set; }
    public uint Pearlfishershuts { get; set; }
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
    public uint Pearlworkshops { get; set; }
    public uint Roastinghouses { get; set; }
    public uint Carpetworkshops { get; set; }
    public uint Dateplantations { get; set; }
    public uint Goatfarms { get; set; }
    public uint Silkweavingmills { get; set; }
    public uint Charcoalburnershuts { get; set; }
    // Misc buildings
    public uint Toolmakersworkshops { get; set; }
    public uint Stonemasonshuts { get; set; }
    public uint Ropeyards { get; set; }
    public uint Weaponsmithies { get; set; }
    public uint Mosaicworkshops { get; set; }
    public uint Warmachinesworkshops { get; set; }
    public uint Cannonfoundries { get; set; }
    public uint Glasssmelters { get; set; }
    public uint Forestglassworks { get; set; }

    public uint GetBuildingCount(ProductionBuildingEnum building) =>
        building switch
        {
            ProductionBuildingEnum.Sugarcaneplantation => this.Sugarcaneplantations,
            ProductionBuildingEnum.Sugarmill => this.Sugarmills,
            ProductionBuildingEnum.Silkplantation => this.Silkplantations,
            ProductionBuildingEnum.Rosenursery => this.Rosenurseries,
            ProductionBuildingEnum.Hempplantation => this.Hempplantations,
            ProductionBuildingEnum.Goldsmelter => this.Goldsmelters,
            ProductionBuildingEnum.Goldmine => this.Goldmines,
            ProductionBuildingEnum.Coppersmelter => this.Coppersmelters,
            ProductionBuildingEnum.Coppermine => this.Coppermines,
            ProductionBuildingEnum.Coffeeplantation => this.Coffeeplantations,
            ProductionBuildingEnum.Candlemakersworkshop => this.Candlemakersworkshops,
            ProductionBuildingEnum.Apiary => this.Apiaries,
            ProductionBuildingEnum.Almondplantation => this.Almondplantations,
            ProductionBuildingEnum.Cropfarm => this.Cropfarms,
            ProductionBuildingEnum.Mill => this.Mills,
            ProductionBuildingEnum.Monasterygarden => this.Monasterygardens,
            ProductionBuildingEnum.Coalmine => this.Coalmines,
            ProductionBuildingEnum.Saltmine => this.Saltmines,
            ProductionBuildingEnum.Saltworks => this.Saltworks,
            ProductionBuildingEnum.Pigfarm => this.Pigfarms,
            ProductionBuildingEnum.Papermill => this.Papermills,
            ProductionBuildingEnum.Indigofarm => this.Indigofarms,
            ProductionBuildingEnum.Lumberjackshut => this.Lumberjackshuts,
            ProductionBuildingEnum.Cattlefarm => this.Cattlefarms,
            ProductionBuildingEnum.Trapperslodge => this.Trapperslodges,
            ProductionBuildingEnum.Vineyard => this.Vineyards,
            ProductionBuildingEnum.Barrelcooperage => this.Barrelcooperages,
            ProductionBuildingEnum.Claypit => this.Claypits,
            ProductionBuildingEnum.Quartzquarry => this.Quartzquarries,
            ProductionBuildingEnum.Ironmine => this.Ironmines,
            ProductionBuildingEnum.Ironsmelter => this.Ironsmelters,
            ProductionBuildingEnum.Pearlfishershut => this.Pearlfishershuts,
            ProductionBuildingEnum.Fishermanshut => this.Fishermanshuts,
            ProductionBuildingEnum.Ciderfarm => this.Ciderfarms,
            ProductionBuildingEnum.Weavershut => this.Weavershuts,
            ProductionBuildingEnum.Bakery => this.Bakeries,
            ProductionBuildingEnum.Monasterybrewery => this.Monasterybreweries,
            ProductionBuildingEnum.Tannery => this.Tanneries,
            ProductionBuildingEnum.Printinghouse => this.Printinghouses,
            ProductionBuildingEnum.Butchersshop => this.Butchersshops,
            ProductionBuildingEnum.Furriersworkshop => this.Furriersworkshops,
            ProductionBuildingEnum.Winepress => this.Winepresses,
            ProductionBuildingEnum.Redsmithsworkshop => this.Redsmithsworkshops,
            ProductionBuildingEnum.Opticiansworkshop => this.Opticiansworkshops,
            ProductionBuildingEnum.Confectionersworkshop => this.Confectionersworkshops,
            ProductionBuildingEnum.Perfumery => this.Perfumeries,
            ProductionBuildingEnum.Pearlworkshop => this.Pearlworkshops,
            ProductionBuildingEnum.Roastinghouse => this.Roastinghouses,
            ProductionBuildingEnum.Carpetworkshop => this.Carpetworkshops,
            ProductionBuildingEnum.Dateplantation => this.Dateplantations,
            ProductionBuildingEnum.Goatfarm => this.Goatfarms,
            ProductionBuildingEnum.Silkweavingmill => this.Silkweavingmills,
            ProductionBuildingEnum.Spicefarm => this.Spicefarms,
            ProductionBuildingEnum.Charcoalburnershut => this.Charcoalburnershuts,
            ProductionBuildingEnum.Forestglassworks => this.Forestglassworks,
            ProductionBuildingEnum.Toolmakersworkshop => this.Toolmakersworkshops,
            ProductionBuildingEnum.Stonemasonshut => this.Stonemasonshuts,
            ProductionBuildingEnum.Ropeyard => this.Ropeyards,
            ProductionBuildingEnum.Weaponsmithy => this.Weaponsmithies,
            ProductionBuildingEnum.Mosaicworkshop => this.Mosaicworkshops,
            ProductionBuildingEnum.Warmachinesworkshop => this.Warmachinesworkshops,
            ProductionBuildingEnum.Cannonfoundry => this.Cannonfoundries,
            ProductionBuildingEnum.Glasssmelter => this.Glasssmelters,
            _ => throw new NotImplementedException(),
        };
}
