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
using Windows.UI.Xaml.Media.Imaging;


namespace cillian
{
    
    public sealed partial class OddEve : Page
    {
        public OddEve()
        {
            this.InitializeComponent();
        }

        Image holding = null;
        Point imageOffset;

        private void backBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fun));
        }

        private void ptr_moved(object sender, PointerRoutedEventArgs e)
        {
        
            if (holding != null)
            {
                var position = e.GetCurrentPoint(sender as Grid).Position;
                holding.Margin = new Thickness(position.X - imageOffset.X, position.Y - imageOffset.Y, 0, 0);
            }
        
        }
     
        private void fish1_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish1_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img1.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish2_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish2_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img2.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish3_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish3_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img3.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish4_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish4_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img4.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish5_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish5_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img5.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish6_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish6_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img6.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish7_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish7_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img7.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        private void fish8_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void fish8_released(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
            img8.Visibility = Visibility.Collapsed;
            fishMedia.Play();
        }

        

       

        
    }
}
