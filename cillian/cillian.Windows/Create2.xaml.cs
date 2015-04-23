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
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;


namespace cillian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Create2 : Page
    {
        public Create2()
        {
            this.InitializeComponent();
        }

        Image holding = null;
        Point imageOffset;


        private void ptr_moved(object sender, PointerRoutedEventArgs e)
        {
            if (holding != null)
            {
                var position = e.GetCurrentPoint(sender as Grid).Position;
                holding.Margin = new Thickness(position.X - imageOffset.X, position.Y - imageOffset.Y, 0, 0);
            }
        }
        Uri uri;

        private void cImg1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "bananas")
            {
                uri = new Uri("ms-appx:///Assets/bananas.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Image.Source = bitmapImage;
        }


        private void img1_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img1_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "barrel")
            {
                uri = new Uri("ms-appx:///Assets/Barrel.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img2.Source = bitmapImage;
        }

        private void img2_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img2_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "coconuttree")
            {
                uri = new Uri("ms-appx:///Assets/Coconut_tree.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img3.Source = bitmapImage;
        }

        private void img3_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img3_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "coconut")
            {
                uri = new Uri("ms-appx:///Assets/coconuts.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img4.Source = bitmapImage;
        }

        private void img4_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img4_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg5_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "crab")
            {
                uri = new Uri("ms-appx:///Assets/crab.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img5.Source = bitmapImage;
        }

        private void img5_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img5_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        
        private void cImg6_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "dolphin")
            {
                uri = new Uri("ms-appx:///Assets/dolphin.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img6.Source = bitmapImage;
        }

        private void img6_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img6_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg7_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "fish")
            {
                uri = new Uri("ms-appx:///Assets/Fish.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img7.Source = bitmapImage;
        }
        private void img7_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img7_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg8_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "magicCillian")
            {
                uri = new Uri("ms-appx:///Assets/MagicCillian.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img8.Source = bitmapImage;
        }

        private void img8_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img8_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg9_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "monkey1")
            {
                uri = new Uri("ms-appx:///Assets/monkey1.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img9.Source = bitmapImage;
        }

        private void img9_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img9_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg10_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "cillian")
            {
                uri = new Uri("ms-appx:///Assets/PirateCillian.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img10.Source = bitmapImage;
        }

        private void img10_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img10_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg11_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "monkey3")
            {
                uri = new Uri("ms-appx:///Assets/monkey3.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img11.Source = bitmapImage;
        }

        private void img11_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img11_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;

        }

        private void cImg12_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "parrot")
            {
                uri = new Uri("ms-appx:///Assets/parrot.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img12.Source = bitmapImage;
        }


        private void img12_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img12_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg13_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "pirate")
            {
                uri = new Uri("ms-appx:///Assets/pirate.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img13.Source = bitmapImage;
        }

        private void img13_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img13_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg14_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "seagul")
            {
                uri = new Uri("ms-appx:///Assets/seagul.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img14.Source = bitmapImage;
        }

        private void img14_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img14_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg15_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "seahorse")
            {
                uri = new Uri("ms-appx:///Assets/seahorse.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img15.Source = bitmapImage;
        }
        private void img15_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img15_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg16_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "spider")
            {
                uri = new Uri("ms-appx:///Assets/spider.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img16.Source = bitmapImage;
        }

        private void img16_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img16_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg17_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "starfish")
            {
                uri = new Uri("ms-appx:///Assets/starfish.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img17.Source = bitmapImage;

        }

        private void img17_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img17_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg18_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "treasure")
            {
                uri = new Uri("ms-appx:///Assets/treasure.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img18.Source = bitmapImage;
        }

        private void img18_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img18_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg19_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "turtle")
            {
                uri = new Uri("ms-appx:///Assets/turtle.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img19.Source = bitmapImage;
        }

        private void img19_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img19_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg20_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "whale")
            {
                uri = new Uri("ms-appx:///Assets/whale.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            display2Img20.Source = bitmapImage;
        }

        private void img20_pressed2(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img20_release2(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void backBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Create));
        }

        async void btnScreenshot_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var bitmap = await SaveScreenshotAsync(controlsGrid);

            }
            catch (Exception ex)
            {
                string except = ex.Message;
            }


        }

        async Task<RenderTargetBitmap> SaveScreenshotAsync(FrameworkElement uielement)
        {
            var file = await PickSaveImageAsync();

            return await SaveToFileAsync(uielement, file);
        }


        async Task<StorageFile> PickSaveImageAsync()
        {
            var filePicker = new FileSavePicker();
            filePicker.FileTypeChoices.Add("Bitmap", new List<string>() { ".bmp" });
            filePicker.FileTypeChoices.Add("JPEG format", new List<string>() { ".jpg" });
            filePicker.FileTypeChoices.Add("Compuserve format", new List<string>() { ".gif" });
            filePicker.FileTypeChoices.Add("Portable Network Graphics", new List<string>() { ".png" });
            filePicker.FileTypeChoices.Add("Tagged Image File Format", new List<string>() { ".tif" });
            filePicker.DefaultFileExtension = ".jpg";
            filePicker.SuggestedFileName = "screenshot";
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.SettingsIdentifier = "picture picker";
            filePicker.CommitButtonText = "Save picture";

            return await filePicker.PickSaveFileAsync();
        }
        async Task<RenderTargetBitmap> SaveToFileAsync(FrameworkElement uielement, StorageFile file)
        {
            if (file != null)
            {
                CachedFileManager.DeferUpdates(file);

                Guid encoderId = GetBitmapEncoder(file.FileType);

                try
                {
                    using (var stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        return await CaptureToStreamAsync(uielement, stream, encoderId);
                    }
                }
                catch (Exception ex)
                {
                    DisplayMessage(ex.Message);
                }

                var status = await CachedFileManager.CompleteUpdatesAsync(file);
            }

            return null;
        }
        Guid GetBitmapEncoder(string fileType)
        {
            Guid encoderId = BitmapEncoder.JpegEncoderId;
            switch (fileType)
            {
                case ".bmp":
                    encoderId = BitmapEncoder.BmpEncoderId;
                    break;
                case ".gif":
                    encoderId = BitmapEncoder.GifEncoderId;
                    break;
                case ".png":
                    encoderId = BitmapEncoder.PngEncoderId;
                    break;
                case ".tif":
                    encoderId = BitmapEncoder.TiffEncoderId;
                    break;
            }

            return encoderId;
        }
        async Task<RenderTargetBitmap> CaptureToStreamAsync(FrameworkElement uielement, IRandomAccessStream stream, Guid encoderId)
        {
            try
            {
                var renderTargetBitmap = new RenderTargetBitmap();
                await renderTargetBitmap.RenderAsync(uielement);

                var pixels = await renderTargetBitmap.GetPixelsAsync();

                var logicalDpi = DisplayInformation.GetForCurrentView().LogicalDpi;
                var encoder = await BitmapEncoder.CreateAsync(encoderId, stream);
                encoder.SetPixelData(
                    BitmapPixelFormat.Bgra8,
                    BitmapAlphaMode.Ignore,
                    (uint)renderTargetBitmap.PixelWidth,
                    (uint)renderTargetBitmap.PixelHeight,
                    logicalDpi,
                    logicalDpi,
                    pixels.ToArray());

                await encoder.FlushAsync();

                return renderTargetBitmap;
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return null;
        }
        async void DisplayMessage(string error)
        {
            var dialog = new MessageDialog(error);

            await dialog.ShowAsync();
        }















        public FrameworkElement controlsGrid { get; set; }
    }
}
