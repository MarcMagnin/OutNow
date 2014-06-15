
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace OutNow.Events
{
    [DataContract]
    public class EventList
    {
        [DataMember(Name="Results")]
        public List<Event> Events { get; set; }
    }

    [DataContract]
    public class Event
    {
        public Geopoint Location { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

}
