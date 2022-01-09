namespace Anno1404Calculator;

using Anno1404Calculator.Models;
using Anno1404Calculator.ViewModels;
using Microsoft.UI.Xaml;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

public sealed partial class MainWindow : Window
{
    public MainPageViewModel Model { get; set; } = new MainPageViewModel();
    public string Version { get; } = $"Anno 1404 Calculator v{Assembly.GetExecutingAssembly().GetName().Version}";
    private readonly AnnoApi annoApi = new AnnoApi();

    public MainWindow()
    {
        this.InitializeComponent();
        Task.Run(PollLoop);
    }

    async Task PollLoop()
    {
        while (true)
        {
            try
            {
                var annoStatus = this.annoApi.Read();
                this.DispatcherQueue.TryEnqueue(() =>
                {
                    if (PlayerSelectionComboBox.SelectedValue as string == "Player 1")
                    {
                        Model.UpdateAnnoStatus(annoStatus.Player1);
                    }
                    else if (PlayerSelectionComboBox.SelectedValue as string == "Player 2")
                    {
                        Model.UpdateAnnoStatus(annoStatus.Player2);
                    }
                    else if (PlayerSelectionComboBox.SelectedValue as string == "Player 3")
                    {
                        Model.UpdateAnnoStatus(annoStatus.Player3);
                    }
                    else if (PlayerSelectionComboBox.SelectedValue as string == "Player 4")
                    {
                        Model.UpdateAnnoStatus(annoStatus.Player4);
                    }
                });
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e}");
            }
            await Task.Delay(1000);
        }
    }
}
