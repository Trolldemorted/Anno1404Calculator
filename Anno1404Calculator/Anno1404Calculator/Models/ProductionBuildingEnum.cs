namespace Anno1404Calculator.Models;

using System;
using System.Collections.Generic;
using System.Text;

public enum ProductionBuildingEnum
{
    // Intermediate buildings
    Sugarcaneplantation,
    Sugarmill,
    Silkplantation,
    Rosenursery,
    Hempplantation,
    Goldsmelter,
    Goldmine,
    Coppersmelter,
    Coppermine,
    Coffeeplantation,
    Candlemakersworkshop,
    Apiary,
    Almondplantation,
    Cropfarm,
    Mill,
    Monasterygarden,
    Coalmine,
    Saltmine,
    Saltworks,
    Pigfarm,
    Papermill,
    Indigofarm,
    Lumberjackshut,
    Cattlefarm,
    Trapperslodge,
    Vineyard,
    Barrelcooperage,
    Claypit,
    Quartzquarry,
    Ironmine,
    Ironsmelter,
    Pearlfishershut,
    // final buildings
    Fishermanshut,
    Ciderfarm,
    Weavershut,
    Bakery,
    Monasterybrewery,
    Tannery,
    Printinghouse,
    Butchersshop,
    Furriersworkshop,
    Winepress,
    Redsmithsworkshop,
    Opticiansworkshop,
    Confectionersworkshop,
    Perfumery,
    Pearlworkshop,
    Roastinghouse,
    Carpetworkshop,
    Dateplantation,
    Goatfarm,
    Silkweavingmill,
    Spicefarm,
    Charcoalburnershut,
    Forestglassworks,
    // Misc buildings (tools, stone, mosaic, weapons, cannons, ropes, war machines, glas)
    Toolmakersworkshop,
    Stonemasonshut,
    Ropeyard,
    Weaponsmithy,
    Mosaicworkshop,
    Warmachinesworkshop,
    Cannonfoundry,
    Glasssmelter,
}

public static class Anno1404IntermediateBuildingExtensions
{
    public static uint GetBuildingId(this ProductionBuildingEnum ib) =>
        ib switch
        {
            ProductionBuildingEnum.Sugarcaneplantation => 0x7577,
            ProductionBuildingEnum.Sugarmill => 0x7d1e,
            ProductionBuildingEnum.Silkplantation => 0x7578,
            ProductionBuildingEnum.Rosenursery => 0x757a,
            ProductionBuildingEnum.Hempplantation => 0x7544,
            ProductionBuildingEnum.Goldsmelter => throw new NotImplementedException(),
            ProductionBuildingEnum.Goldmine => throw new NotImplementedException(),
            ProductionBuildingEnum.Coppersmelter => 0x7d23,
            ProductionBuildingEnum.Coppermine => 0x7b13,
            ProductionBuildingEnum.Coffeeplantation => 0x7574,
            ProductionBuildingEnum.Candlemakersworkshop => 0x7d25,
            ProductionBuildingEnum.Apiary => 0x7579,
            ProductionBuildingEnum.Almondplantation => 0x756d,
            ProductionBuildingEnum.Cropfarm => 0x756e,
            ProductionBuildingEnum.Mill => 0x7d0e,
            ProductionBuildingEnum.Monasterygarden => 0x756f,
            ProductionBuildingEnum.Coalmine => 0x7b12,
            ProductionBuildingEnum.Saltmine => 0x7b10,
            ProductionBuildingEnum.Saltworks => 0x7d17,
            ProductionBuildingEnum.Pigfarm => 0x7572,
            ProductionBuildingEnum.Papermill => 0x757d,
            ProductionBuildingEnum.Indigofarm => 0x757b,
            ProductionBuildingEnum.Lumberjackshut => 0x7558,
            ProductionBuildingEnum.Cattlefarm => 0x7570,
            ProductionBuildingEnum.Trapperslodge => 0x7575,
            ProductionBuildingEnum.Vineyard => 0x7573,
            ProductionBuildingEnum.Barrelcooperage => 0x7d19,
            ProductionBuildingEnum.Quartzquarry => 0x7b0d,
            ProductionBuildingEnum.Ironmine => 0x7b0f,
            ProductionBuildingEnum.Ironsmelter => 0x7d14,
            ProductionBuildingEnum.Pearlfishershut => 0x757c,
            ProductionBuildingEnum.Confectionersworkshop => 0x7d1f,
            ProductionBuildingEnum.Perfumery => 0x7d27,
            ProductionBuildingEnum.Pearlworkshop => 0x7d2a,
            ProductionBuildingEnum.Roastinghouse => 0x7d1b,
            ProductionBuildingEnum.Carpetworkshop => 0x7d28,
            ProductionBuildingEnum.Dateplantation => 0x757e,
            ProductionBuildingEnum.Goatfarm => 0x756c,
            ProductionBuildingEnum.Toolmakersworkshop => 0x7d0b,
            ProductionBuildingEnum.Stonemasonshut => 0x7b0e,
            ProductionBuildingEnum.Ropeyard => 0x7d15,
            ProductionBuildingEnum.Weaponsmithy => 0x7d16,
            ProductionBuildingEnum.Mosaicworkshop => 0x7d0d,
            ProductionBuildingEnum.Fishermanshut => 0x7562,
            ProductionBuildingEnum.Ciderfarm => 0x753a,
            ProductionBuildingEnum.Weavershut => 0x7d00,
            ProductionBuildingEnum.Bakery => 0x7d0f,
            ProductionBuildingEnum.Monasterybrewery => 0x7d10,
            ProductionBuildingEnum.Tannery => 0x7d11,
            ProductionBuildingEnum.Printinghouse => 0x7d2b,
            ProductionBuildingEnum.Butchersshop => 0x7d18,
            ProductionBuildingEnum.Furriersworkshop => 0x7d1c,
            ProductionBuildingEnum.Winepress => 0x7d1a,
            ProductionBuildingEnum.Redsmithsworkshop => 0x7d26,
            ProductionBuildingEnum.Opticiansworkshop => 0x7d24,
            ProductionBuildingEnum.Warmachinesworkshop => 0x7d1d,
            ProductionBuildingEnum.Claypit => 0x7918,
            ProductionBuildingEnum.Silkweavingmill => throw new NotImplementedException(),
            ProductionBuildingEnum.Cannonfoundry => 0x7d21,
            ProductionBuildingEnum.Spicefarm => 0x7530,
            ProductionBuildingEnum.Charcoalburnershut => 0x7571,
            ProductionBuildingEnum.Forestglassworks => 0x7d22,
            ProductionBuildingEnum.Glasssmelter => 0x7d2c,
            _ => throw new NotImplementedException(),
        };

    // Every building procudes 1 ton per cycle, therefore the production is 60/cycletime.
    public static double GetProductionPerMinute(this ProductionBuildingEnum pb) => 60.0 / pb.GetProductionTimeInSeconds();

    private static uint GetProductionTimeInSeconds(this ProductionBuildingEnum pb) =>
        pb switch
        {
            ProductionBuildingEnum.Sugarcaneplantation => 30,
            ProductionBuildingEnum.Sugarmill => 15,
            ProductionBuildingEnum.Silkplantation => 40,
            ProductionBuildingEnum.Rosenursery => 120,
            ProductionBuildingEnum.Hempplantation => 60,
            ProductionBuildingEnum.Goldsmelter => 40,
            ProductionBuildingEnum.Goldmine => 40,
            ProductionBuildingEnum.Coppersmelter => 45,
            ProductionBuildingEnum.Coppermine => 45,
            ProductionBuildingEnum.Coffeeplantation => 60,
            ProductionBuildingEnum.Candlemakersworkshop => 45,
            ProductionBuildingEnum.Apiary => 90,
            ProductionBuildingEnum.Almondplantation => 30,
            ProductionBuildingEnum.Cropfarm => 30,
            ProductionBuildingEnum.Mill => 15,
            ProductionBuildingEnum.Monasterygarden => 30,
            ProductionBuildingEnum.Coalmine => 15,
            ProductionBuildingEnum.Saltmine => 15,
            ProductionBuildingEnum.Saltworks => 15,
            ProductionBuildingEnum.Pigfarm => 30,
            ProductionBuildingEnum.Papermill => 20,
            ProductionBuildingEnum.Indigofarm => 40,
            ProductionBuildingEnum.Lumberjackshut => 40,
            ProductionBuildingEnum.Cattlefarm => 48,
            ProductionBuildingEnum.Trapperslodge => 24,
            ProductionBuildingEnum.Vineyard => 90,
            ProductionBuildingEnum.Barrelcooperage => 30,
            ProductionBuildingEnum.Claypit => 50,
            ProductionBuildingEnum.Quartzquarry => 45,
            ProductionBuildingEnum.Ironmine => 30,
            ProductionBuildingEnum.Ironsmelter => 30,
            ProductionBuildingEnum.Pearlfishershut => 60,
            ProductionBuildingEnum.Fishermanshut => 30,
            ProductionBuildingEnum.Ciderfarm => 40,
            ProductionBuildingEnum.Weavershut => 30,
            ProductionBuildingEnum.Bakery => 15,
            ProductionBuildingEnum.Monasterybrewery => 40,
            ProductionBuildingEnum.Tannery => 15,
            ProductionBuildingEnum.Printinghouse => 20,
            ProductionBuildingEnum.Butchersshop => 24,
            ProductionBuildingEnum.Furriersworkshop => 24,
            ProductionBuildingEnum.Winepress => 30,
            ProductionBuildingEnum.Redsmithsworkshop => 30,
            ProductionBuildingEnum.Opticiansworkshop => 30,
            ProductionBuildingEnum.Confectionersworkshop => 15,
            ProductionBuildingEnum.Perfumery => 60,
            ProductionBuildingEnum.Pearlworkshop => 60,
            ProductionBuildingEnum.Roastinghouse => 60,
            ProductionBuildingEnum.Carpetworkshop => 40,
            ProductionBuildingEnum.Dateplantation => 20,
            ProductionBuildingEnum.Goatfarm => 40,
            ProductionBuildingEnum.Silkweavingmill => 20,
            ProductionBuildingEnum.Spicefarm => 30,
            ProductionBuildingEnum.Charcoalburnershut => 30,
            ProductionBuildingEnum.Forestglassworks => 30,
            ProductionBuildingEnum.Toolmakersworkshop => 30,
            ProductionBuildingEnum.Stonemasonshut => 30,
            ProductionBuildingEnum.Ropeyard => 30,
            ProductionBuildingEnum.Weaponsmithy => 30,
            ProductionBuildingEnum.Mosaicworkshop => 25,
            ProductionBuildingEnum.Warmachinesworkshop => 40,
            ProductionBuildingEnum.Cannonfoundry => 60,
            ProductionBuildingEnum.Glasssmelter => 60,
            _ => throw new NotImplementedException(),
        };

    public static double GetPlayerProductionPerMinute(this ProductionBuildingEnum pb, AnnoPlayerStatus status, uint totalBuildings, uint buildings00, uint buildings25, uint buildings50, uint buildings75)
    {
        var production = (buildings00 + buildings25 * 1.25 + buildings50 * 1.5 + buildings75 * 1.75) * pb.GetProductionPerMinute();
        if (totalBuildings > (buildings00 + buildings25 + buildings50 + buildings75))
        {
            production += (totalBuildings - (buildings00 + buildings25 + buildings50 + buildings75)) * pb.GetProductionPerMinute();
        }
        if (pb == ProductionBuildingEnum.Coalmine)
        {
            production += status.Charcoalburnershuts * ProductionBuildingEnum.Charcoalburnershut.GetProductionPerMinute();
        }
        return production;
    }

    /// <summary>
    /// Calculate the consumption in tons/minute.
    /// </summary>
    /// <param name="pb"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double GetConsumptionPerMinute(this ProductionBuildingEnum pb, AnnoPlayerStatus status) =>
        pb switch
        {
            ProductionBuildingEnum.Sugarcaneplantation => status.Sugarmills * 1.0 * ProductionBuildingEnum.Sugarmill.GetProductionPerMinute(),
            ProductionBuildingEnum.Sugarmill => status.Confectionersworkshops * 1.0 * ProductionBuildingEnum.Confectionersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Silkplantation =>
                status.Carpetworkshops * 1.0 * ProductionBuildingEnum.Carpetworkshop.GetProductionPerMinute() +
                status.Silkweavingmills * 1.0 * ProductionBuildingEnum.Silkweavingmill.GetProductionPerMinute(),
            ProductionBuildingEnum.Rosenursery => status.Perfumeries * 1.5 * ProductionBuildingEnum.Perfumery.GetProductionPerMinute(),
            ProductionBuildingEnum.Hempplantation =>
                status.Weavershuts * 1.0 * ProductionBuildingEnum.Weavershut.GetProductionPerMinute() +
                status.Ropeyards * 0.5 * ProductionBuildingEnum.Ropeyard.GetProductionPerMinute() +
                status.Warmachinesworkshops * 2.0 * ProductionBuildingEnum.Warmachinesworkshop.GetProductionPerMinute() +
                status.Candlemakersworkshops * 0.75 * ProductionBuildingEnum.Candlemakersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Goldsmelter => status.Silkweavingmills * 0.5 * ProductionBuildingEnum.Silkweavingmill.GetProductionPerMinute(),
            ProductionBuildingEnum.Goldmine => status.Goldmines * 1.0 * ProductionBuildingEnum.Goldmine.GetProductionPerMinute(),
            ProductionBuildingEnum.Coppersmelter =>
                status.Redsmithsworkshops * 0.5 * ProductionBuildingEnum.Redsmithsworkshop.GetProductionPerMinute() +
                status.Opticiansworkshops * 0.5 * ProductionBuildingEnum.Opticiansworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Coppermine => status.Coppersmelters * 1.0 * ProductionBuildingEnum.Coppersmelter.GetProductionPerMinute(),
            ProductionBuildingEnum.Coffeeplantation => status.Roastinghouses * 2.0 * ProductionBuildingEnum.Roastinghouse.GetProductionPerMinute(),
            ProductionBuildingEnum.Candlemakersworkshop => status.Redsmithsworkshops * 1.0 * ProductionBuildingEnum.Redsmithsworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Apiary => status.Candlemakersworkshops * 1.0 * ProductionBuildingEnum.Candlemakersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Almondplantation => status.Confectionersworkshops * 1.0 * ProductionBuildingEnum.Confectionersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Cropfarm =>
                status.Mills * 1.0 * ProductionBuildingEnum.Mill.GetProductionPerMinute() +
                status.Monasterybreweries * 1.333 * ProductionBuildingEnum.Monasterybrewery.GetProductionPerMinute(),
            ProductionBuildingEnum.Mill => status.Bakeries * 1.0 * ProductionBuildingEnum.Bakery.GetProductionPerMinute(),
            ProductionBuildingEnum.Monasterygarden => status.Monasterybreweries * 1.333 * ProductionBuildingEnum.Monasterybrewery.GetProductionPerMinute(),
            ProductionBuildingEnum.Coalmine =>
                status.Coppersmelters * 1.0 * ProductionBuildingEnum.Coppersmelter.GetProductionPerMinute() +
                status.Ironsmelters * 1.0 * ProductionBuildingEnum.Ironsmelter.GetProductionPerMinute() +
                status.Saltworks * 0.5 * ProductionBuildingEnum.Saltworks.GetProductionPerMinute() +
                status.Goldsmelters * 1.0 * ProductionBuildingEnum.Goldsmelter.GetProductionPerMinute(),
            ProductionBuildingEnum.Saltmine => status.Saltworks * 1.0 * ProductionBuildingEnum.Saltworks.GetProductionPerMinute(),
            ProductionBuildingEnum.Saltworks =>
                status.Tanneries * 0.5 * ProductionBuildingEnum.Tannery.GetProductionPerMinute() +
                status.Butchersshops * 0.8 * ProductionBuildingEnum.Butchersshop.GetProductionPerMinute() +
                status.Furriersworkshops * 0.53 * ProductionBuildingEnum.Furriersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Pigfarm => status.Tanneries * 1.0 * ProductionBuildingEnum.Tannery.GetProductionPerMinute(),
            ProductionBuildingEnum.Papermill => status.Printinghouses * 0.5 * ProductionBuildingEnum.Printinghouse.GetProductionPerMinute(),
            ProductionBuildingEnum.Indigofarm =>
                status.Carpetworkshops * 1.0 * ProductionBuildingEnum.Carpetworkshop.GetProductionPerMinute() +
                status.Printinghouses * 1.0 * ProductionBuildingEnum.Printinghouse.GetProductionPerMinute(),
            ProductionBuildingEnum.Lumberjackshut =>
                status.Barrelcooperages * 0.5 * ProductionBuildingEnum.Barrelcooperage.GetProductionPerMinute() +
                status.Warmachinesworkshops * 2.0 * ProductionBuildingEnum.Warmachinesworkshop.GetProductionPerMinute() +
                status.Cannonfoundries * 3.0 * ProductionBuildingEnum.Cannonfoundry.GetProductionPerMinute(),
            ProductionBuildingEnum.Cattlefarm => status.Butchersshops * 1.0 * ProductionBuildingEnum.Butchersshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Trapperslodge => status.Furriersworkshops * 1.0 * ProductionBuildingEnum.Furriersworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Vineyard => status.Winepresses * 1.0 * ProductionBuildingEnum.Winepress.GetProductionPerMinute(),
            ProductionBuildingEnum.Barrelcooperage => status.Winepresses * 1.0 * ProductionBuildingEnum.Winepress.GetProductionPerMinute(),
            ProductionBuildingEnum.Claypit => status.Mosaicworkshops * 1.0 * ProductionBuildingEnum.Mosaicworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Quartzquarry =>
                status.Mosaicworkshops * 0.5 * ProductionBuildingEnum.Mosaicworkshop.GetProductionPerMinute() +
                status.Glasssmelters * 0.5 * ProductionBuildingEnum.Glasssmelter.GetProductionPerMinute(),
            ProductionBuildingEnum.Ironmine => status.Ironsmelters * 1.0 * ProductionBuildingEnum.Ironsmelter.GetProductionPerMinute(),
            ProductionBuildingEnum.Ironsmelter =>
                status.Barrelcooperages * 0.5 * ProductionBuildingEnum.Barrelcooperage.GetProductionPerMinute() +
                status.Toolmakersworkshops * 0.5 * ProductionBuildingEnum.Toolmakersworkshop.GetProductionPerMinute() +
                status.Cannonfoundries * 1.5 * ProductionBuildingEnum.Cannonfoundry.GetProductionPerMinute() +
                status.Weaponsmithies * 1.0 * ProductionBuildingEnum.Weaponsmithy.GetProductionPerMinute(),
            ProductionBuildingEnum.Pearlfishershut => status.Pearlworkshops * 1.0 * ProductionBuildingEnum.Pearlworkshop.GetProductionPerMinute(),
            ProductionBuildingEnum.Fishermanshut => status.Beggars * 0.007 + status.Peasants * 0.01 + status.Citizens * 0.004 + status.Patricians * 0.0022 + status.Noblemen * 0.0016,
            ProductionBuildingEnum.Ciderfarm => status.Beggars * 0.003 + status.Peasants * 0.0044 + status.Citizens * 0.0044 + status.Patricians * 0.0023 + status.Noblemen * 0.0013,
            ProductionBuildingEnum.Weavershut => status.Citizens * 0.0042 + status.Patricians * 0.0019 + status.Noblemen * 0.0008,
            ProductionBuildingEnum.Bakery => status.Patricians * 0.0055 + status.Noblemen * 0.0039,
            ProductionBuildingEnum.Monasterybrewery => status.Patricians * 0.0024 + status.Noblemen * 0.0014,
            ProductionBuildingEnum.Tannery => status.Patricians * 0.0028 + status.Noblemen * 0.0016,
            ProductionBuildingEnum.Printinghouse => status.Patricians * 0.0016 + status.Noblemen * 0.0009,
            ProductionBuildingEnum.Butchersshop => status.Noblemen * 0.0022,
            ProductionBuildingEnum.Furriersworkshop => status.Noblemen * 0.0016,
            ProductionBuildingEnum.Winepress => status.Noblemen * 0.002,
            ProductionBuildingEnum.Redsmithsworkshop => status.Patricians * 0.0008 + status.Noblemen * 0.0006,
            ProductionBuildingEnum.Opticiansworkshop => status.Noblemen * 0.00117,
            ProductionBuildingEnum.Confectionersworkshop => status.Envoys * 0.00163,
            ProductionBuildingEnum.Perfumery => status.Envoys * 0.0008,
            ProductionBuildingEnum.Pearlworkshop => status.Envoys * 0.00133,
            ProductionBuildingEnum.Roastinghouse => status.Envoys * 0.001,
            ProductionBuildingEnum.Carpetworkshop => status.Nomads * 0.00165 + status.Envoys * 0.001,
            ProductionBuildingEnum.Dateplantation => status.Nomads * 0.00666 + status.Envoys * 0.005,
            ProductionBuildingEnum.Goatfarm => status.Nomads * 0.00344 + status.Envoys * 0.00225,
            ProductionBuildingEnum.Silkweavingmill => status.Noblemen * 0.00142,
            ProductionBuildingEnum.Spicefarm => status.Citizens * 0.0044 + status.Patricians * 0.0022 + status.Noblemen * 0.0016,
            ProductionBuildingEnum.Charcoalburnershut => throw new NotImplementedException(),
            ProductionBuildingEnum.Forestglassworks => status.Glasssmelters * 1.0 * ProductionBuildingEnum.Glasssmelter.GetProductionPerMinute(),
            ProductionBuildingEnum.Toolmakersworkshop => 0,
            ProductionBuildingEnum.Stonemasonshut => 0,
            ProductionBuildingEnum.Ropeyard => 0,
            ProductionBuildingEnum.Weaponsmithy => 0,
            ProductionBuildingEnum.Mosaicworkshop => 0,
            ProductionBuildingEnum.Warmachinesworkshop => 0,
            ProductionBuildingEnum.Cannonfoundry => 0,
            ProductionBuildingEnum.Glasssmelter => 0,
            _ => throw new NotImplementedException(),
        };
}

// TODO replace this sometime
public enum Anno1404ProductType
{
    Beer,
    Books,
    Bread,
    BrocadeRobes,
    Candlestick,
    Carpets,
    Cider,
    Coffee,
    Dates,
    Fish,
    FurCoats,
    Glasses,
    LeatherJerkins,
    LinenGarments,
    Marzipan,
    Meat,
    Milk,
    PearlNecklaces,
    Perfume,
    Spices,
    Wine
}