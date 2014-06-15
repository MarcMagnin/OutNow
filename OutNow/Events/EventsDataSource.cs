﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Web.Http;
using OutNow.Common;
using Windows.Devices.Geolocation;

namespace OutNow.Events
{
    class EventsDataSource
    {
        private HttpClient httpClient;
        private CancellationTokenSource cts;
        private static Uri eventsURL = new Uri("http://169.254.210.210:8081/databases/OutNow/indexes/Raven/DocumentsByEntityName?&query=Tag%3AEvent&pageSize=30&noCache=1446174288");

        private ObservableCollection<Event> _events = new ObservableCollection<Event>();
        public ObservableCollection<Event> Events
        {
            get { return this._events; }
        }

        private static EventsDataSource _dataSource = new EventsDataSource();

        public static async Task<ObservableCollection<Event>> GetEventsAsync()
        {
            await _dataSource.GetEventsDataAsync();

            return _dataSource.Events;
        }

        private async Task GetEventsDataAsync()
        {
            if (this._events.Count != 0)
                return;

            httpClient = new HttpClient();
            cts = new CancellationTokenSource();

            //Helpers.ScenarioStarted(StartButton, CancelButton, OutputField);
            //rootPage.NotifyUser("In progress", NotifyType.StatusMessage);

            try
            {
                // get first level nav
                HttpResponseMessage response = await httpClient.GetAsync(eventsURL).AsTask(cts.Token);

                var responseBodyAsText = await response.Content.ReadAsStringAsync().AsTask(cts.Token);
                var rootNode = responseBodyAsText.FromJsonString<EventList>();
                foreach (var evt in rootNode.Events)
                {
                    evt.Location = new Windows.Devices.Geolocation.Geopoint(new BasicGeoposition() { Latitude = evt.Latitude, Longitude = evt.Longitude });
                    Events.Add(evt);
                }
                cts.Token.ThrowIfCancellationRequested();
                // rootPage.NotifyUser("Completed", NotifyType.StatusMessage);
            }
            catch (TaskCanceledException)
            {
            }
            catch (Exception ex)
            {
            }
            finally
            {
                //  Helpers.ScenarioCompleted(StartButton, CancelButton);
            }
        }
    }
}
