using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace OutNow.Events
{
    public class EventControl : ContentControl
    {
        private bool alreadyLoaded;
        public EventControl()
        {
            DefaultStyleKey = typeof(EventControl);
            this.Loaded += EventControl_Loaded;

        }

        void EventControl_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (alreadyLoaded)
                return;
            VisualStateManager.GoToState(this, "Loaded", false);
            alreadyLoaded = true;
            
        }
        
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

    }
}
