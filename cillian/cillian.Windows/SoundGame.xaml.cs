using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace cillian
{
   
    public sealed partial class SoundGame : Page
    {
        public SoundGame()
        {
            this.InitializeComponent();
        }

        private void back_tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fun));
        }
    
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media1.Play();
            media1.Stop();
            dolphinTxt.Visibility = Visibility.Visible;
        }

        private void Image2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media2.Play();
            media2.Stop();
            monkeyTxt.Visibility = Visibility.Visible;
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            media3.Play();
            media3.Stop();
            seagullTxt.Visibility = Visibility.Visible;
        }

        private void image4_tapped(object sender, TappedRoutedEventArgs e)
        {
            media4.Play();
            media4.Stop();
            parrotTxt.Visibility = Visibility.Visible;
        }

        private void image5_tapped(object sender, TappedRoutedEventArgs e)
        {
            media5.Play();
            media5.Stop();
            snakeTxt.Visibility = Visibility.Visible;
        }

        private void image6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media6.Play();
            media6.Stop();
            elephantTxt.Visibility = Visibility.Visible;
        }

        private void image7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            media7.Play();
            media7.Stop();
            tigerTxt.Visibility = Visibility.Visible;
        }

        private void txtDelp_tapp(object sender, TappedRoutedEventArgs e)
        {
            dolphinTxt.Visibility = Visibility.Collapsed;
        }

        private void txtMonk_tapp(object sender, TappedRoutedEventArgs e)
        {
            monkeyTxt.Visibility = Visibility.Collapsed;
        }

        private void txtParr_tapp(object sender, TappedRoutedEventArgs e)
        {
            parrotTxt.Visibility = Visibility.Collapsed;
        }

        private void txtSeagull_tapp(object sender, TappedRoutedEventArgs e)
        {
            seagullTxt.Visibility = Visibility.Collapsed;
        }

        private void txtsnake_Tapp(object sender, TappedRoutedEventArgs e)
        {
            snakeTxt.Visibility = Visibility.Collapsed;
        }

        private void txtElephant_Tapp(object sender, TappedRoutedEventArgs e)
        {
            elephantTxt.Visibility = Visibility.Collapsed;
        }

        private void txtTiger_tapp(object sender, TappedRoutedEventArgs e)
        {
            tigerTxt.Visibility = Visibility.Collapsed;
        }
    
   

              
    }
}
