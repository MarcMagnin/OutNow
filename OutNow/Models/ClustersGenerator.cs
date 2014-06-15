using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutNow.Models
{
    class ClustersGenerator // : MapChildControl
    {
        //const double MAXDISTANCE = 75;

        //private Map _map;
        //private List<Pushpin> _pushpins;
        //public DataTemplate ClusterTemplate { get; set; }

        //public ClustersGenerator(Map map, List<Pushpin> pushpins, DataTemplate clusterTemplate)
        //{
        //    _map = map;
        //    _pushpins = pushpins;
        //    this.ClusterTemplate = clusterTemplate;
        //    // maps event
        //    //_map.ResolveCompleted += (s, e) => GeneratePushpins();
        //    //_map.ViewChanged += (s, e) => GeneratePushpins();
        //    _map.ZoomLevelChanged += (s, e) => GeneratePushpins();
        //    _map.CenterChanged += (s, e) => GeneratePushpins();

        //    // first generate
        //    GeneratePushpins();
        //}

        //private void GeneratePushpins()
        //{
        //    List<PushpinsGroup> pushpinsToAdd = new List<PushpinsGroup>();
        //    foreach (var pushpin in _pushpins)
        //    {
        //        bool addGroup = true;
        //        var newGroup = new PushpinsGroup(pushpin, _map.ConvertGeoCoordinateToViewportPoint(pushpin.GeoCoordinate));

        //        foreach (var pushpinToAdd in pushpinsToAdd)
        //        {
        //            double distance = pushpinToAdd.MapLocation.GetDistanceTo(newGroup.MapLocation);

        //            if (distance < MAXDISTANCE)
        //            {
        //                pushpinToAdd.IncludeGroup(newGroup);
        //                addGroup = false;
        //                break;
        //            }
        //        }

        //        if (addGroup)
        //            pushpinsToAdd.Add(newGroup);
        //    }

        //    _map.Dispatcher.BeginInvoke(() =>
        //    {
        //        _map.Layers.Clear();
        //        MapLayer layer = new MapLayer();
        //        foreach (var visibleGroup in pushpinsToAdd.Where(p => _map.IsVisiblePoint(p.MapLocation)))
        //        {
        //            var cluster = visibleGroup.GetElement(this.ClusterTemplate) as Pushpin;
        //            if (cluster != null)
        //            {
        //                layer.Add(new MapOverlay() { GeoCoordinate = cluster.GeoCoordinate, Content = cluster.Content, ContentTemplate = cluster.ContentTemplate });

        //            }
        //        }
        //        if (layer.Count > 0)
        //            _map.Layers.Add(layer);
        //    });
        //}
    }
}
