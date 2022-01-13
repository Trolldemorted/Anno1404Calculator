namespace Anno1404Calculator.Models;

using System;
using System.Collections.Generic;
using System.Text;

public enum Anno1404IntermediateBuilding
{
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
    Indigoplantation,
    Lumberjackshut,
    Cattlefarm,
    Trapperslodge,
    Vineyard,
    Barrelcooperage,
    Quartzquarry,
    Ironmine,
    Ironsmelter,
    Pearlfishershut
}

public static class Anno1404IntermediateBuildingExtensions
{
    public static uint GetBuildingId(this Anno1404IntermediateBuilding ib) =>
        ib switch
        {
            Anno1404IntermediateBuilding.Sugarcaneplantation => 0x7577,
            Anno1404IntermediateBuilding.Sugarmill => 0x7d1e,
            Anno1404IntermediateBuilding.Silkplantation => 0x7578,
            Anno1404IntermediateBuilding.Rosenursery => 0x757a,
            Anno1404IntermediateBuilding.Hempplantation => 0x7544,
            Anno1404IntermediateBuilding.Goldsmelter => throw new NotImplementedException(),
            Anno1404IntermediateBuilding.Goldmine => throw new NotImplementedException(),
            Anno1404IntermediateBuilding.Coppersmelter => 0x7d23,
            Anno1404IntermediateBuilding.Coppermine => 0x7b13,
            Anno1404IntermediateBuilding.Coffeeplantation => 0x7574,
            Anno1404IntermediateBuilding.Candlemakersworkshop => 0x7d25,
            Anno1404IntermediateBuilding.Apiary => 0x7579,
            Anno1404IntermediateBuilding.Almondplantation => 0x756d,
            Anno1404IntermediateBuilding.Cropfarm => 0x756e,
            Anno1404IntermediateBuilding.Mill => 0x7d0e,
            Anno1404IntermediateBuilding.Monasterygarden => 0x756f,
            Anno1404IntermediateBuilding.Coalmine => 0x7b12,
            Anno1404IntermediateBuilding.Saltmine => 0x7b10,
            Anno1404IntermediateBuilding.Saltworks => 0x7d17,
            Anno1404IntermediateBuilding.Pigfarm => 0x7572,
            Anno1404IntermediateBuilding.Papermill => 0x757d,
            Anno1404IntermediateBuilding.Indigoplantation => 0x757b,
            Anno1404IntermediateBuilding.Lumberjackshut => 0x7558,
            Anno1404IntermediateBuilding.Cattlefarm => 0x7570,
            Anno1404IntermediateBuilding.Trapperslodge => 0x7575,
            Anno1404IntermediateBuilding.Vineyard => 0x7573,
            Anno1404IntermediateBuilding.Barrelcooperage => 0x7d19,
            Anno1404IntermediateBuilding.Quartzquarry => 0x7b0d,
            Anno1404IntermediateBuilding.Ironmine => 0x7b0f,
            Anno1404IntermediateBuilding.Ironsmelter => 0x7d14,
            Anno1404IntermediateBuilding.Pearlfishershut => 0x757c,
            _ => throw new NotImplementedException(),
        };
}