using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CrazyWords.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Splash : Page
    {
        private Rect splashRect;

        public Splash()
        {
            this.InitializeComponent();
        }

        public Splash(SplashScreen splashScreen, bool loadState) : this()
        {
            this.splashRect = splashScreen.ImageLocation;

            splashScreen.Dismissed += new TypedEventHandler<SplashScreen, object>(SplashScreen_Dismissed); 
            PositionAdvertisement();
        }

        private void PositionAdvertisement()
        {
            SplashImage.SetValue(Canvas.TopProperty, splashRect.Y);
            SplashImage.SetValue(Canvas.LeftProperty, splashRect.X);
            SplashImage.Height = splashRect.Height;
            SplashImage.Width = splashRect.Width;
            SplashImage.Visibility = Visibility.Visible;

            AdvertisementImage.SetValue(Canvas.TopProperty, (splashRect.Y + splashRect.Height + 100));
            AdvertisementImage.SetValue(Canvas.LeftProperty, splashRect.X);
            AdvertisementImage.Visibility = Visibility.Visible;
        }

        private void SplashScreen_Dismissed(SplashScreen sender, object args)
        {

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
