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
    
    public sealed partial class PicMatch : Page
    {
        public PicMatch()
        {
            this.InitializeComponent();
        }

        //public variables 
        public Uri uri;
        public Image prevImage;
        public Image currentImage = new Image();

        //WE ARE USING ONLY ONE  CLICKED EVENT HANDELER ->SENDER DETERMINE WHICH SPECIFIC IMAGE WAS CLICKED
        private void imgTapped(object sender, TappedRoutedEventArgs e)
        {
            findMatch(sender);

        }

        private void findMatch(object sender)
        {
            Image currImage = sender as Image;
            string currTag = currImage.Tag.ToString();

            BitmapImage bitmapImage2 = new BitmapImage();
            bitmapImage2.UriSource = new Uri("ms-appx:///Assets/CaptainCillianLogo.png");

            //checking the tag of an image clicked and setting up the uri 
            if (currTag == "banana")
            {
                uri = new Uri("ms-appx:///Assets/bananas.png");
            }
            else if (currTag == "parrot")
            {
                uri = new Uri("ms-appx:///Assets/parrot.png");

            }
            //setting the current Image (sender) image source to the above uri
            BitmapImage currImg = new BitmapImage();
            currImg.UriSource = uri;
            currImage.Source = currImg;


            if (prevImage != null)
            {
                //if match is found then reset the prevImg and currImage variable to null coz we want to match new 
                //images in next turn, therefore getting reference to old image that was clicked make no sense :) and only screw up the things

                if (currImage.Tag.ToString().Equals(prevImage.Tag.ToString()))
                {
                    prevImage = null;
                    currImage = null;
                    return;

                }
                else
                {
                    prevImage.Source = bitmapImage2;
                    currImage.Source = bitmapImage2;
                    prevImage = null;
                    currImage = null;
                    return;

                }
            }

            //When you click an image for the first time, the following code will be executed
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            prevImage = currImage;
            prevImage.Source = bitmapImage;
            prevImage.Tag = currImage.Tag;
        }

        private void backBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fun));
        }
    }
}
