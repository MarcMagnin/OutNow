using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;

namespace OutNow.Models
{
    public class PushpinsGroup
    {
        //private List<Pushpin> _pushpins = new List<Pushpin>();
        //public Point MapLocation { get; set; }

        //public PushpinsGroup(Pushpin pushpin, Point location)
        //{
        //    _pushpins.Add(pushpin);
        //    MapLocation = location;
        //}

        //public FrameworkElement GetElement(DataTemplate clusterTemplate)
        //{
        //    if (_pushpins.Count == 1)
        //        return _pushpins[0];

        //    // more pushpins
        //    return new Pushpin()
        //    {
        //        // just need the first coordinate
        //        GeoCoordinate = _pushpins.First().GeoCoordinate,
        //        Content = _pushpins.Select(p => p.DataContext).ToList(),
        //        ContentTemplate = clusterTemplate,
        //    };
        //}

        //public void IncludeGroup(PushpinsGroup group)
        //{
        //    foreach (var pin in group._pushpins)
        //        _pushpins.Add(pin);
        //}
    }

}
