using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641

namespace OutNow
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static Uri eventsURL = new Uri("http://192.168.137.239:8081/databases/OutNow/indexes/Raven/DocumentsByEntityName?&query=Tag%3AEvent&pageSize=30&noCache=1446174288");
        private static Uri eventsURLAdd = new Uri("http://192.168.137.239:8081/databases/OutNow/docs/Events/");

        private ObservableCollection<Event> Events = new ObservableCollection<Event>();
     
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            GeoPoint p;
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d’événement décrivant la manière dont l’utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: préparer la page pour affichage ici.

            // TODO: si votre application comporte plusieurs pages, assurez-vous que vous
            // gérez le bouton Retour physique en vous inscrivant à l’événement
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Si vous utilisez le NavigationHelper fourni par certains modèles,
            // cet événement est géré automatiquement.
        }
    }

    
     public class Event
    {
       // public GeoCoordinate Coordinate { get; set; }
        public double Latitude { get; set; }
        public double Longitude{ get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }

}
