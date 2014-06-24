
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace OutNow.Events
{
    [DataContract]
    public class EventList
    {
        [DataMember(Name="Results")]
        public List<Event> Events { get; set; }
    }
    [DataContract]
    public class Event : INotifyPropertyChanged
    { 
        [IgnoreDataMember]
        public BitmapImage ThemeBitmap
        {
            get
            {
                return ThemeDatas.ThemeBitmaps[Theme];
            }
        }
        
        [IgnoreDataMember]
        public BitmapImage ThemeInvertBitmap
        {
            get
            {
                return ThemeDatas.ThemeInvertBitmaps[Theme];
            }
        }
        private bool selected;
        [IgnoreDataMember]
        public bool Selected
        {
            get
            {
                return this.selected;
            }

            set
            {

                if (value != this.selected)
                {
                    this.selected = value;
                    NotifyPropertyChanged();
                }
            }

        }


        public Geopoint Location { get; set; }
        private string theme = "Autre";
        [DataMember]
        public string Theme
        {
            get
            {
                return this.theme;
            }

            set
            {

                if (value != this.theme)
                {
                    this.theme= value;
                    NotifyPropertyChanged();
                }
            }

        }

        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public string Address { get; set; }

        private string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [DataMember(Name="@metadata")]
        public Metadata Metadata { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
    [DataContract]
    public class Metadata
    {
        [DataMember(Name="@id")]
        public string Id{ get; set; }
        [DataMember(Name="Last-Modified")]
        public string LastModified { get; set; }
    }
    //@metadata\":{\"Raven-Entity-Name\":\"Event\",\"@id\":\"Events/16\",\"Temp-Index-Score\":0.9574404,\"Last-Modified\":\"2014-06-15T22:17:36.3590480Z\",

}
