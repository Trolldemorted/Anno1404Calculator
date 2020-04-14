using Anno1404Calculator;
using Anno1404Calculator.Shared;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Anno1404DesktopExtension
{
    class Program
    {
        static void Main()
        {
            Loop().Wait();
        }

        static async Task Loop()
        {
            using var connection = new AppServiceConnection
            {
                AppServiceName = "Anno1404InteropService",
                PackageFamilyName = Package.Current.Id.FamilyName
            };
            var status = await connection.OpenAsync();
            connection.ServiceClosed += Connection_ServiceClosed;
            while (true)
            {
                try
                {
                    var anno = new AnnoApi();
                    var snapshot = anno.Read();
                    //var snapshot = new AnnoStatus();
                    //snapshot.Nomads = 2000; // (uint)new Random().Next() % 10000;
                    await connection.SendMessageAsync(snapshot.Serialize());
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"{e}");
                }
                await Task.Delay(1000);
            }
        }

        private static void Connection_ServiceClosed(AppServiceConnection sender, AppServiceClosedEventArgs args)
        {
            Debug.WriteLine("Client Connection_ServiceClosed");
            Environment.Exit(0);
        }
    }
}
