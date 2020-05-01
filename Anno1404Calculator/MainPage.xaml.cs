using Anno1404Calculator.Shared;
using Anno1404Calculator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Anno1404Calculator
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel Model { get; set; } = new MainPageViewModel();

        public MainPage()
        {
            DataContext = Model;
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs eargs)
        {
            App.NewAnnoStatus += App_NewAnnoStatus;
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.FullTrustAppContract", 1, 0))
            {
                await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync();
            }
        }

        private async void App_NewAnnoStatus(object sender, AnnoStatus e)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => {
                if (PlayerSelectionComboBox.SelectedValue as string == "Player 1")
                {
                    Model.UpdateAnnoStatus(e.Player1);
                }
                else if (PlayerSelectionComboBox.SelectedValue as string == "Player 2")
                {
                    Model.UpdateAnnoStatus(e.Player2);
                }
                else if (PlayerSelectionComboBox.SelectedValue as string == "Player 3")
                {
                    Model.UpdateAnnoStatus(e.Player3);
                }
                else if (PlayerSelectionComboBox.SelectedValue as string == "Player 4")
                {
                    Model.UpdateAnnoStatus(e.Player4);
                }
            });
        }
    }
}
