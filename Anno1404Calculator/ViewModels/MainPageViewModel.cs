using Anno1404Calculator.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace Anno1404Calculator.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Population
        public uint Nomads { get; set; }
        public uint Envoys { get; set; }
        public uint Beggars { get; set; }
        public uint Peasants { get; set; }
        public uint Citizens { get; set; }
        public uint Patricians { get; set; }
        public uint Noblemen { get; set; }

        // Consumption
        public double FishConsumption { get; set; }
        public double CiderConsumption { get; set; }
        public double LinenGarmentsConsumption { get; set; }
        public double SpicesConsumption { get; set; }
        public double BreadConsumption { get; set; }
        public double BeerConsumption { get; set; }
        public double LeatherJerkinsConsumption { get; set; }
        public double BooksConsumption { get; set; }
        public double MeatConsumption { get; set; }
        public double FurCoatsConsumption { get; set; }
        public double WineConsumption { get; set; }
        public double GlassesConsumption { get; set; }
        public double CandlestickConsumption { get; set; }
        public double BrocadeRobesConsumption { get; set; }
        public double DatesConsumption { get; set; }
        public double MilkConsumption { get; set; }
        public double CarpetsConsumption { get; set; }
        public double CoffeeConsumption { get; set; }
        public double PearlNecklacesConsumption { get; set; }
        public double PerfumeConsumption { get; set; }
        public double MarzipanConsumption { get; set; }

        // Required production
        public double FishProductionRequired { get; set; }
        public double CiderProductionRequired { get; set; }
        public double LinenGarmentsProductionRequired { get; set; }
        public double SpicesProductionRequired { get; set; }
        public double BreadProductionRequired { get; set; }
        public double BeerProductionRequired { get; set; }
        public double LeatherJerkinsProductionRequired { get; set; }
        public double BooksProductionRequired { get; set; }
        public double MeatProductionRequired { get; set; }
        public double FurCoatsProductionRequired { get; set; }
        public double WineProductionRequired { get; set; }
        public double GlassesProductionRequired { get; set; }
        public double CandlestickProductionRequired { get; set; }
        public double BrocadeRobesProductionRequired { get; set; }
        public double DatesProductionRequired { get; set; }
        public double MilkProductionRequired { get; set; }
        public double CarpetsProductionRequired { get; set; }
        public double CoffeeProductionRequired { get; set; }
        public double PearlNecklacesProductionRequired { get; set; }
        public double PerfumeProductionRequired { get; set; }
        public double MarzipanProductionRequired { get; set; }

        public void UpdateAnnoStatus(AnnoPlayerStatus snapshot)
        {
            // Population
            Beggars = snapshot.Beggars;
            Peasants = snapshot.Peasants;
            Citizens = snapshot.Citizens;
            Patricians = snapshot.Patricians;
            Noblemen = snapshot.Noblemen;
            Nomads = snapshot.Nomads;
            Envoys = snapshot.Envoys;

            // Consumption
            // Occidental
            FishConsumption = snapshot.Beggars * 0.007 + snapshot.Peasants * 0.01 + snapshot.Citizens * 0.004 + snapshot.Patricians * 0.0022 + snapshot.Noblemen * 0.0016;
            FishProductionRequired = FishConsumption / 2;

            CiderConsumption = snapshot.Beggars * 0.003 + snapshot.Peasants * 0.0044 + snapshot.Citizens * 0.0044 + snapshot.Patricians * 0.0023 + snapshot.Noblemen * 0.0013;
            CiderProductionRequired = CiderConsumption / 1.5;
            
            LinenGarmentsConsumption = snapshot.Citizens * 0.0042 + snapshot.Patricians * 0.0019 + snapshot.Noblemen * 0.0008;
            LinenGarmentsProductionRequired = LinenGarmentsConsumption / 2;

            SpicesConsumption = snapshot.Citizens * 0.0044 + snapshot.Patricians * 0.0022 + snapshot.Noblemen * 0.0016;
            SpicesProductionRequired = SpicesConsumption / 2;

            BreadConsumption = snapshot.Patricians * 0.0055 + snapshot.Noblemen * 0.0039;
            BreadProductionRequired = BreadConsumption / 4;

            BeerConsumption = snapshot.Patricians * 0.0024 + snapshot.Noblemen * 0.0014;
            BeerProductionRequired = BeerConsumption / 1.5;

            LeatherJerkinsConsumption = snapshot.Patricians * 0.0028 + snapshot.Noblemen * 0.0016;
            LeatherJerkinsProductionRequired = LeatherJerkinsConsumption / 4;

            BooksConsumption = snapshot.Patricians * 0.0016 + snapshot.Noblemen * 0.0009;
            BooksProductionRequired = BooksConsumption / 3;

            MeatConsumption = snapshot.Noblemen * 0.0022;
            MeatProductionRequired = MeatConsumption / 2.5;

            FurCoatsConsumption = snapshot.Noblemen * 0.0016;
            FurCoatsProductionRequired = FurCoatsConsumption / 2.5;

            WineConsumption = snapshot.Noblemen * 0.002;
            WineProductionRequired = WineConsumption / 2;

            GlassesConsumption = snapshot.Noblemen * 0.00117;
            GlassesProductionRequired = GlassesConsumption / 2;

            CandlestickConsumption = snapshot.Patricians * 0.0008 + snapshot.Noblemen * 0.0006;
            CandlestickProductionRequired = CandlestickConsumption / 2;

            BrocadeRobesConsumption = snapshot.Noblemen * 0.00142;
            BrocadeRobesProductionRequired = BrocadeRobesConsumption / 3;

            // Oriental
            DatesConsumption = snapshot.Nomads * 0.00666 + snapshot.Envoys * 0.005;
            DatesProductionRequired = DatesConsumption / 3;

            MilkConsumption = snapshot.Nomads * 0.00344 + snapshot.Envoys * 0.00225;
            MilkProductionRequired = MilkConsumption / 1.5;

            CarpetsConsumption = snapshot.Nomads * 0.00165 + snapshot.Envoys * 0.001;
            CarpetsProductionRequired = CarpetsConsumption / 1.5;

            CoffeeConsumption = snapshot.Envoys * 0.001;
            CoffeeProductionRequired = CoffeeConsumption / 1;

            PearlNecklacesConsumption = snapshot.Envoys * 0.00133;
            PearlNecklacesProductionRequired = PearlNecklacesConsumption / 1;

            PerfumeConsumption = snapshot.Envoys * 0.0008;
            PerfumeProductionRequired = PerfumeConsumption / 1;

            MarzipanConsumption = snapshot.Envoys * 0.00163;
            MarzipanProductionRequired = MarzipanConsumption / 4;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
