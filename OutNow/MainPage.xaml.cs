using OutNow.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using OutNow.Common;
using System.Threading;
using System.Linq;
// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641

namespace OutNow
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static Uri eventsURL = new Uri("http://169.254.210.210:8081/databases/OutNow/indexes/Raven/DocumentsByEntityName?&query=Tag%3AEvent&pageSize=30&noCache=1446174288");
        private static Uri eventsURLAdd = new Uri("http://169.254.210.210:8081/databases/OutNow/docs/Events/");
        private CancellationTokenSource cts;
        private ObservableCollection<Event> Events = new ObservableCollection<Event>();
     
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
         
            MapItems.ItemsSource = Events;
        }
        private async void AddEvent(Geopoint location)
        {
            var evt = new Event() { Location = location, Latitude = location.Position.Latitude, Longitude = location.Position.Longitude, Name = "new evt" };
            Events.Add(evt);
            // get first level nav
            var httpClient = new HttpClient();
            
            httpClient.DefaultRequestHeaders.Add("Raven-Entity-Name","Event");
            cts = new CancellationTokenSource();

            StringContent queryString = new StringContent(evt.ToJson<Event>());
            HttpResponseMessage response = await httpClient.PutAsync(eventsURLAdd, queryString);
            response.EnsureSuccessStatusCode();
            String content = response.Content.ReadAsStringAsync().Result;


        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d’événement décrivant la manière dont l’utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            MapCtrl.Center = new Geopoint(new BasicGeoposition() { Latitude = 47.604, Longitude = -122.329 });
            MapCtrl.ZoomLevel = 12;
            MapCtrl.MapHolding += MapCtrl_MapHolding;

            var test = (await EventsDataSource.GetEventsAsync()).ToList();
            foreach (var tt in test)
            {
                Events.Add(tt);
            }
        }

        void MapCtrl_MapHolding(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
            AddEvent(args.Location);
            
        }

    }

    
    

}
