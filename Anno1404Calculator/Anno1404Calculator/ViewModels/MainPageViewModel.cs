namespace Anno1404Calculator.ViewModels;

using Anno1404Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

public class MainPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public AnnoPlayerStatus? PlayerStatus { get; set; } = new AnnoPlayerStatus();

    // Defined consumable production
    public uint FishProductions00 { get => _FishProductions00; set { _FishProductions00 = value; Store(Anno1404ProductType.Fish, "_00", value); } }
    private uint _FishProductions00 = Load(Anno1404ProductType.Fish, "_00");
    public uint FishProductions25 { get => _FishProductions25; set { _FishProductions25 = value; Store(Anno1404ProductType.Fish, "_25", value); } }
    private uint _FishProductions25 = Load(Anno1404ProductType.Fish, "_25");
    public uint FishProductions50 { get => _FishProductions50; set { _FishProductions50 = value; Store(Anno1404ProductType.Fish, "_50", value); } }
    private uint _FishProductions50 = Load(Anno1404ProductType.Fish, "_50");
    public uint FishProductions75 { get => _FishProductions75; set { _FishProductions75 = value; Store(Anno1404ProductType.Fish, "_75", value); } }
    private uint _FishProductions75 = Load(Anno1404ProductType.Fish, "_75");
    public uint CiderProductions00 { get => _CiderProductions00; set { _CiderProductions00 = value; Store(Anno1404ProductType.Cider, "_00", value); } }
    private uint _CiderProductions00 = Load(Anno1404ProductType.Cider, "_00");
    public uint CiderProductions25 { get => _CiderProductions25; set { _CiderProductions25 = value; Store(Anno1404ProductType.Cider, "_25", value); } }
    private uint _CiderProductions25 = Load(Anno1404ProductType.Cider, "_25");
    public uint CiderProductions50 { get => _CiderProductions50; set { _CiderProductions50 = value; Store(Anno1404ProductType.Cider, "_50", value); } }
    private uint _CiderProductions50 = Load(Anno1404ProductType.Cider, "_50");
    public uint CiderProductions75 { get => _CiderProductions75; set { _CiderProductions75 = value; Store(Anno1404ProductType.Cider, "_75", value); } }
    private uint _CiderProductions75 = Load(Anno1404ProductType.Cider, "_75");
    public uint LinenGarmentsProductions00 { get => _LinenGarmentsProductions00; set { _LinenGarmentsProductions00 = value; Store(Anno1404ProductType.LinenGarments, "_00", value); } }
    private uint _LinenGarmentsProductions00 = Load(Anno1404ProductType.LinenGarments, "_00");
    public uint LinenGarmentsProductions25 { get => _LinenGarmentsProductions25; set { _LinenGarmentsProductions25 = value; Store(Anno1404ProductType.LinenGarments, "_25", value); } }
    private uint _LinenGarmentsProductions25 = Load(Anno1404ProductType.LinenGarments, "_25");
    public uint LinenGarmentsProductions50 { get => _LinenGarmentsProductions50; set { _LinenGarmentsProductions50 = value; Store(Anno1404ProductType.LinenGarments, "_50", value); } }
    private uint _LinenGarmentsProductions50 = Load(Anno1404ProductType.LinenGarments, "_50");
    public uint LinenGarmentsProductions75 { get => _LinenGarmentsProductions75; set { _LinenGarmentsProductions75 = value; Store(Anno1404ProductType.LinenGarments, "_75", value); } }
    private uint _LinenGarmentsProductions75 = Load(Anno1404ProductType.LinenGarments, "_75");
    public uint SpicesProductions00 { get => _SpicesProductions00; set { _SpicesProductions00 = value; Store(Anno1404ProductType.Spices, "_00", value); } }
    private uint _SpicesProductions00 = Load(Anno1404ProductType.Spices, "_00");
    public uint SpicesProductions25 { get => _SpicesProductions25; set { _SpicesProductions25 = value; Store(Anno1404ProductType.Spices, "_25", value); } }
    private uint _SpicesProductions25 = Load(Anno1404ProductType.Spices, "_25");
    public uint SpicesProductions50 { get => _SpicesProductions50; set { _SpicesProductions50 = value; Store(Anno1404ProductType.Spices, "_50", value); } }
    private uint _SpicesProductions50 = Load(Anno1404ProductType.Spices, "_50");
    public uint SpicesProductions75 { get => _SpicesProductions75; set { _SpicesProductions75 = value; Store(Anno1404ProductType.Spices, "_75", value); } }
    private uint _SpicesProductions75 = Load(Anno1404ProductType.Spices, "_75");
    public uint BreadProductions00 { get => _BreadProductions00; set { _BreadProductions00 = value; Store(Anno1404ProductType.Bread, "_00", value); } }
    private uint _BreadProductions00 = Load(Anno1404ProductType.Bread, "_00");
    public uint BreadProductions25 { get => _BreadProductions25; set { _BreadProductions25 = value; Store(Anno1404ProductType.Bread, "_25", value); } }
    private uint _BreadProductions25 = Load(Anno1404ProductType.Bread, "_25");
    public uint BreadProductions50 { get => _BreadProductions50; set { _BreadProductions50 = value; Store(Anno1404ProductType.Bread, "_50", value); } }
    private uint _BreadProductions50 = Load(Anno1404ProductType.Bread, "_50");
    public uint BreadProductions75 { get => _BreadProductions75; set { _BreadProductions75 = value; Store(Anno1404ProductType.Bread, "_75", value); } }
    private uint _BreadProductions75 = Load(Anno1404ProductType.Bread, "_75");
    public uint BeerProductions00 { get => _BeerProductions00; set { _BeerProductions00 = value; Store(Anno1404ProductType.Beer, "_00", value); } }
    private uint _BeerProductions00 = Load(Anno1404ProductType.Beer, "_00");
    public uint BeerProductions25 { get => _BeerProductions25; set { _BeerProductions25 = value; Store(Anno1404ProductType.Beer, "_25", value); } }
    private uint _BeerProductions25 = Load(Anno1404ProductType.Beer, "_25");
    public uint BeerProductions50 { get => _BeerProductions50; set { _BeerProductions50 = value; Store(Anno1404ProductType.Beer, "_50", value); } }
    private uint _BeerProductions50 = Load(Anno1404ProductType.Beer, "_50");
    public uint BeerProductions75 { get => _BeerProductions75; set { _BeerProductions75 = value; Store(Anno1404ProductType.Beer, "_75", value); } }
    private uint _BeerProductions75 = Load(Anno1404ProductType.Beer, "_75");
    public uint LeatherJerkinsProductions00 { get => _LeatherJerkinsProductions00; set { _LeatherJerkinsProductions00 = value; Store(Anno1404ProductType.LeatherJerkins, "_00", value); } }
    private uint _LeatherJerkinsProductions00 = Load(Anno1404ProductType.LeatherJerkins, "_00");
    public uint LeatherJerkinsProductions25 { get => _LeatherJerkinsProductions25; set { _LeatherJerkinsProductions25 = value; Store(Anno1404ProductType.LeatherJerkins, "_25", value); } }
    private uint _LeatherJerkinsProductions25 = Load(Anno1404ProductType.LeatherJerkins, "_25");
    public uint LeatherJerkinsProductions50 { get => _LeatherJerkinsProductions50; set { _LeatherJerkinsProductions50 = value; Store(Anno1404ProductType.LeatherJerkins, "_50", value); } }
    private uint _LeatherJerkinsProductions50 = Load(Anno1404ProductType.LeatherJerkins, "_50");
    public uint LeatherJerkinsProductions75 { get => _LeatherJerkinsProductions75; set { _LeatherJerkinsProductions75 = value; Store(Anno1404ProductType.LeatherJerkins, "_75", value); } }
    private uint _LeatherJerkinsProductions75 = Load(Anno1404ProductType.LeatherJerkins, "_75");
    public uint BooksProductions00 { get => _BooksProductions00; set { _BooksProductions00 = value; Store(Anno1404ProductType.Books, "_00", value); } }
    private uint _BooksProductions00 = Load(Anno1404ProductType.Books, "_00");
    public uint BooksProductions25 { get => _BooksProductions25; set { _BooksProductions25 = value; Store(Anno1404ProductType.Books, "_25", value); } }
    private uint _BooksProductions25 = Load(Anno1404ProductType.Books, "_25");
    public uint BooksProductions50 { get => _BooksProductions50; set { _BooksProductions50 = value; Store(Anno1404ProductType.Books, "_50", value); } }
    private uint _BooksProductions50 = Load(Anno1404ProductType.Books, "_50");
    public uint BooksProductions75 { get => _BooksProductions75; set { _BooksProductions75 = value; Store(Anno1404ProductType.Books, "_75", value); } }
    private uint _BooksProductions75 = Load(Anno1404ProductType.Books, "_75");
    public uint MeatProductions00 { get => _MeatProductions00; set { _MeatProductions00 = value; Store(Anno1404ProductType.Meat, "_00", value); } }
    private uint _MeatProductions00 = Load(Anno1404ProductType.Meat, "_00");
    public uint MeatProductions25 { get => _MeatProductions25; set { _MeatProductions25 = value; Store(Anno1404ProductType.Meat, "_25", value); } }
    private uint _MeatProductions25 = Load(Anno1404ProductType.Meat, "_25");
    public uint MeatProductions50 { get => _MeatProductions50; set { _MeatProductions50 = value; Store(Anno1404ProductType.Meat, "_50", value); } }
    private uint _MeatProductions50 = Load(Anno1404ProductType.Meat, "_50");
    public uint MeatProductions75 { get => _MeatProductions75; set { _MeatProductions75 = value; Store(Anno1404ProductType.Meat, "_75", value); } }
    private uint _MeatProductions75 = Load(Anno1404ProductType.Meat, "_75");
    public uint FurCoatsProductions00 { get => _FurCoatsProductions00; set { _FurCoatsProductions00 = value; Store(Anno1404ProductType.FurCoats, "_00", value); } }
    private uint _FurCoatsProductions00 = Load(Anno1404ProductType.FurCoats, "_00");
    public uint FurCoatsProductions25 { get => _FurCoatsProductions25; set { _FurCoatsProductions25 = value; Store(Anno1404ProductType.FurCoats, "_25", value); } }
    private uint _FurCoatsProductions25 = Load(Anno1404ProductType.FurCoats, "_25");
    public uint FurCoatsProductions50 { get => _FurCoatsProductions50; set { _FurCoatsProductions50 = value; Store(Anno1404ProductType.FurCoats, "_50", value); } }
    private uint _FurCoatsProductions50 = Load(Anno1404ProductType.FurCoats, "_50");
    public uint FurCoatsProductions75 { get => _FurCoatsProductions75; set { _FurCoatsProductions75 = value; Store(Anno1404ProductType.FurCoats, "_75", value); } }
    private uint _FurCoatsProductions75 = Load(Anno1404ProductType.FurCoats, "_75");
    public uint WineProductions00 { get => _WineProductions00; set { _WineProductions00 = value; Store(Anno1404ProductType.Wine, "_00", value); } }
    private uint _WineProductions00 = Load(Anno1404ProductType.Wine, "_00");
    public uint WineProductions25 { get => _WineProductions25; set { _WineProductions25 = value; Store(Anno1404ProductType.Wine, "_25", value); } }
    private uint _WineProductions25 = Load(Anno1404ProductType.Wine, "_25");
    public uint WineProductions50 { get => _WineProductions50; set { _WineProductions50 = value; Store(Anno1404ProductType.Wine, "_50", value); } }
    private uint _WineProductions50 = Load(Anno1404ProductType.Wine, "_50");
    public uint WineProductions75 { get => _WineProductions75; set { _WineProductions75 = value; Store(Anno1404ProductType.Wine, "_75", value); } }
    private uint _WineProductions75 = Load(Anno1404ProductType.Wine, "_75");
    public uint GlassesProductions00 { get => _GlassesProductions00; set { _GlassesProductions00 = value; Store(Anno1404ProductType.Glasses, "_00", value); } }
    private uint _GlassesProductions00 = Load(Anno1404ProductType.Glasses, "_00");
    public uint GlassesProductions25 { get => _GlassesProductions25; set { _GlassesProductions25 = value; Store(Anno1404ProductType.Glasses, "_25", value); } }
    private uint _GlassesProductions25 = Load(Anno1404ProductType.Glasses, "_25");
    public uint GlassesProductions50 { get => _GlassesProductions50; set { _GlassesProductions50 = value; Store(Anno1404ProductType.Glasses, "_50", value); } }
    private uint _GlassesProductions50 = Load(Anno1404ProductType.Glasses, "_50");
    public uint GlassesProductions75 { get => _GlassesProductions75; set { _GlassesProductions75 = value; Store(Anno1404ProductType.Glasses, "_75", value); } }
    private uint _GlassesProductions75 = Load(Anno1404ProductType.Glasses, "_75");
    public uint CandlestickProductions00 { get => _CandlestickProductions00; set { _CandlestickProductions00 = value; Store(Anno1404ProductType.Candlestick, "_00", value); } }
    private uint _CandlestickProductions00 = Load(Anno1404ProductType.Candlestick, "_00");
    public uint CandlestickProductions25 { get => _CandlestickProductions25; set { _CandlestickProductions25 = value; Store(Anno1404ProductType.Candlestick, "_25", value); } }
    private uint _CandlestickProductions25 = Load(Anno1404ProductType.Candlestick, "_25");
    public uint CandlestickProductions50 { get => _CandlestickProductions50; set { _CandlestickProductions50 = value; Store(Anno1404ProductType.Candlestick, "_50", value); } }
    private uint _CandlestickProductions50 = Load(Anno1404ProductType.Candlestick, "_50");
    public uint CandlestickProductions75 { get => _CandlestickProductions75; set { _CandlestickProductions75 = value; Store(Anno1404ProductType.Candlestick, "_75", value); } }
    private uint _CandlestickProductions75 = Load(Anno1404ProductType.Candlestick, "_75");
    public uint BrocadeRobesProductions00 { get => _BrocadeRobesProductions00; set { _BrocadeRobesProductions00 = value; Store(Anno1404ProductType.BrocadeRobes, "_00", value); } }
    private uint _BrocadeRobesProductions00 = Load(Anno1404ProductType.BrocadeRobes, "_00");
    public uint BrocadeRobesProductions25 { get => _BrocadeRobesProductions25; set { _BrocadeRobesProductions25 = value; Store(Anno1404ProductType.BrocadeRobes, "_25", value); } }
    private uint _BrocadeRobesProductions25 = Load(Anno1404ProductType.BrocadeRobes, "_25");
    public uint BrocadeRobesProductions50 { get => _BrocadeRobesProductions50; set { _BrocadeRobesProductions50 = value; Store(Anno1404ProductType.BrocadeRobes, "_50", value); } }
    private uint _BrocadeRobesProductions50 = Load(Anno1404ProductType.BrocadeRobes, "_50");
    public uint BrocadeRobesProductions75 { get => _BrocadeRobesProductions75; set { _BrocadeRobesProductions75 = value; Store(Anno1404ProductType.BrocadeRobes, "_75", value); } }
    private uint _BrocadeRobesProductions75 = Load(Anno1404ProductType.BrocadeRobes, "_75");
    public uint DatesProductions00 { get => _DatesProductions00; set { _DatesProductions00 = value; Store(Anno1404ProductType.Dates, "_00", value); } }
    private uint _DatesProductions00 = Load(Anno1404ProductType.Dates, "_00");
    public uint DatesProductions25 { get => _DatesProductions25; set { _DatesProductions25 = value; Store(Anno1404ProductType.Dates, "_25", value); } }
    private uint _DatesProductions25 = Load(Anno1404ProductType.Dates, "_25");
    public uint DatesProductions50 { get => _DatesProductions50; set { _DatesProductions50 = value; Store(Anno1404ProductType.Dates, "_50", value); } }
    private uint _DatesProductions50 = Load(Anno1404ProductType.Dates, "_50");
    public uint DatesProductions75 { get => _DatesProductions75; set { _DatesProductions75 = value; Store(Anno1404ProductType.Dates, "_75", value); } }
    private uint _DatesProductions75 = Load(Anno1404ProductType.Dates, "_75");
    public uint MilkProductions00 { get => _MilkProductions00; set { _MilkProductions00 = value; Store(Anno1404ProductType.Milk, "_00", value); } }
    private uint _MilkProductions00 = Load(Anno1404ProductType.Milk, "_00");
    public uint MilkProductions25 { get => _MilkProductions25; set { _MilkProductions25 = value; Store(Anno1404ProductType.Milk, "_25", value); } }
    private uint _MilkProductions25 = Load(Anno1404ProductType.Milk, "_25");
    public uint MilkProductions50 { get => _MilkProductions50; set { _MilkProductions50 = value; Store(Anno1404ProductType.Milk, "_50", value); } }
    private uint _MilkProductions50 = Load(Anno1404ProductType.Milk, "_50");
    public uint MilkProductions75 { get => _MilkProductions75; set { _MilkProductions75 = value; Store(Anno1404ProductType.Milk, "_75", value); } }
    private uint _MilkProductions75 = Load(Anno1404ProductType.Milk, "_75"); public uint CarpetsProductions00 { get => _CarpetsProductions00; set { _CarpetsProductions00 = value; Store(Anno1404ProductType.Carpets, "_00", value); } }
    private uint _CarpetsProductions00 = Load(Anno1404ProductType.Carpets, "_00");
    public uint CarpetsProductions25 { get => _CarpetsProductions25; set { _CarpetsProductions25 = value; Store(Anno1404ProductType.Carpets, "_25", value); } }
    private uint _CarpetsProductions25 = Load(Anno1404ProductType.Carpets, "_25");
    public uint CarpetsProductions50 { get => _CarpetsProductions50; set { _CarpetsProductions50 = value; Store(Anno1404ProductType.Carpets, "_50", value); } }
    private uint _CarpetsProductions50 = Load(Anno1404ProductType.Carpets, "_50");
    public uint CarpetsProductions75 { get => _CarpetsProductions75; set { _CarpetsProductions75 = value; Store(Anno1404ProductType.Carpets, "_75", value); } }
    private uint _CarpetsProductions75 = Load(Anno1404ProductType.Carpets, "_75");
    public uint CoffeeProductions00 { get => _CoffeeProductions00; set { _CoffeeProductions00 = value; Store(Anno1404ProductType.Coffee, "_00", value); } }
    private uint _CoffeeProductions00 = Load(Anno1404ProductType.Coffee, "_00");
    public uint CoffeeProductions25 { get => _CoffeeProductions25; set { _CoffeeProductions25 = value; Store(Anno1404ProductType.Coffee, "_25", value); } }
    private uint _CoffeeProductions25 = Load(Anno1404ProductType.Coffee, "_25");
    public uint CoffeeProductions50 { get => _CoffeeProductions50; set { _CoffeeProductions50 = value; Store(Anno1404ProductType.Coffee, "_50", value); } }
    private uint _CoffeeProductions50 = Load(Anno1404ProductType.Coffee, "_50");
    public uint CoffeeProductions75 { get => _CoffeeProductions75; set { _CoffeeProductions75 = value; Store(Anno1404ProductType.Coffee, "_75", value); } }
    private uint _CoffeeProductions75 = Load(Anno1404ProductType.Coffee, "_75");
    public uint PearlNecklacesProductions00 { get => _PearlNecklacesProductions00; set { _PearlNecklacesProductions00 = value; Store(Anno1404ProductType.PearlNecklaces, "_00", value); } }
    private uint _PearlNecklacesProductions00 = Load(Anno1404ProductType.PearlNecklaces, "_00");
    public uint PearlNecklacesProductions25 { get => _PearlNecklacesProductions25; set { _PearlNecklacesProductions25 = value; Store(Anno1404ProductType.PearlNecklaces, "_25", value); } }
    private uint _PearlNecklacesProductions25 = Load(Anno1404ProductType.PearlNecklaces, "_25");
    public uint PearlNecklacesProductions50 { get => _PearlNecklacesProductions50; set { _PearlNecklacesProductions50 = value; Store(Anno1404ProductType.PearlNecklaces, "_50", value); } }
    private uint _PearlNecklacesProductions50 = Load(Anno1404ProductType.PearlNecklaces, "_50");
    public uint PearlNecklacesProductions75 { get => _PearlNecklacesProductions75; set { _PearlNecklacesProductions75 = value; Store(Anno1404ProductType.PearlNecklaces, "_75", value); } }
    private uint _PearlNecklacesProductions75 = Load(Anno1404ProductType.PearlNecklaces, "_75");
    public uint PerfumeProductions00 { get => _PerfumeProductions00; set { _PerfumeProductions00 = value; Store(Anno1404ProductType.Perfume, "_00", value); } }
    private uint _PerfumeProductions00 = Load(Anno1404ProductType.Perfume, "_00");
    public uint PerfumeProductions25 { get => _PerfumeProductions25; set { _PerfumeProductions25 = value; Store(Anno1404ProductType.Perfume, "_25", value); } }
    private uint _PerfumeProductions25 = Load(Anno1404ProductType.Perfume, "_25");
    public uint PerfumeProductions50 { get => _PerfumeProductions50; set { _PerfumeProductions50 = value; Store(Anno1404ProductType.Perfume, "_50", value); } }
    private uint _PerfumeProductions50 = Load(Anno1404ProductType.Perfume, "_50");
    public uint PerfumeProductions75 { get => _PerfumeProductions75; set { _PerfumeProductions75 = value; Store(Anno1404ProductType.Perfume, "_75", value); } }
    private uint _PerfumeProductions75 = Load(Anno1404ProductType.Perfume, "_75");
    public uint MarzipanProductions00 { get => _MarzipanProductions00; set { _MarzipanProductions00 = value; Store(Anno1404ProductType.Marzipan, "_00", value); } }
    private uint _MarzipanProductions00 = Load(Anno1404ProductType.Marzipan, "_00");
    public uint MarzipanProductions25 { get => _MarzipanProductions25; set { _MarzipanProductions25 = value; Store(Anno1404ProductType.Marzipan, "_25", value); } }
    private uint _MarzipanProductions25 = Load(Anno1404ProductType.Marzipan, "_25");
    public uint MarzipanProductions50 { get => _MarzipanProductions50; set { _MarzipanProductions50 = value; Store(Anno1404ProductType.Marzipan, "_50", value); } }
    private uint _MarzipanProductions50 = Load(Anno1404ProductType.Marzipan, "_50");
    public uint MarzipanProductions75 { get => _MarzipanProductions75; set { _MarzipanProductions75 = value; Store(Anno1404ProductType.Marzipan, "_75", value); } }
    private uint _MarzipanProductions75 = Load(Anno1404ProductType.Marzipan, "_75");
    

    private static uint Load(Anno1404ProductType type, string suffix)
    {
        return ApplicationData.Current.LocalSettings.Values[Enum.GetName(typeof(Anno1404ProductType), type) + suffix] as uint? ?? 0;
    }

    private void Store(Anno1404ProductType type, string suffix, uint value)
    {
        ApplicationData.Current.LocalSettings.Values[Enum.GetName(typeof(Anno1404ProductType), type) + suffix] = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }

    public void UpdateAnnoStatus(AnnoPlayerStatus? snapshot)
    {
        this.PlayerStatus = snapshot;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }
}
