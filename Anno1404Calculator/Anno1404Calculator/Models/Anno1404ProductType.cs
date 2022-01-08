namespace Anno1404Calculator.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

public static class Anno1404ProductTypeMethods
{
    public static double GetProductionsRequired(this Anno1404ProductType pt, double consumption) =>
    pt switch
    {
        Anno1404ProductType.Beer => consumption / 1.5,
        Anno1404ProductType.Books => consumption / 3.0,
        Anno1404ProductType.Bread => consumption / 4.0,
        Anno1404ProductType.BrocadeRobes => consumption / 3.0,
        Anno1404ProductType.Candlestick => consumption / 2.0,
        Anno1404ProductType.Carpets => consumption / 1.5,
        Anno1404ProductType.Cider => consumption / 1.5,
        Anno1404ProductType.Coffee => consumption / 1.0,
        Anno1404ProductType.Dates => consumption / 3.0,
        Anno1404ProductType.Fish => consumption / 2.0,
        Anno1404ProductType.FurCoats => consumption / 2.5,
        Anno1404ProductType.Glasses => consumption / 2.0,
        Anno1404ProductType.LeatherJerkins => consumption / 4.0,
        Anno1404ProductType.LinenGarments => consumption / 2.0,
        Anno1404ProductType.Marzipan => consumption / 4.0,
        Anno1404ProductType.Meat => consumption / 2.5,
        Anno1404ProductType.Milk => consumption / 1.5,
        Anno1404ProductType.PearlNecklaces => consumption / 1.0,
        Anno1404ProductType.Perfume => consumption / 1.0,
        Anno1404ProductType.Spices => consumption / 2.0,
        Anno1404ProductType.Wine => consumption / 2.0,
        _ => throw new NotImplementedException()
    };
}
