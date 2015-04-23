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
   
    public sealed partial class Create : Page
    {
        
        public Create()
        {
            this.InitializeComponent();
            btnScreenshot.Click += btnScreenshot_Click;
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

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Create2));
        }
        Uri uri;

        private void clmg1_tapp(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "bananas")
            {
                uri = new Uri("ms-appx:///Assets/bananas.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImage.Source = bitmapImage;
        }

        private void img1_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img1_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg2_tapp(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "barrel")
            {
                uri = new Uri("ms-appx:///Assets/Barrel.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg2.Source = bitmapImage;
        }

        private void img2_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img2_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void cImg3_tapp(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "boat")
            {
                uri = new Uri("ms-appx:///Assets/boat2.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg3.Source = bitmapImage;
        }

        private void img3_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img3_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg4_tapp(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "coconut")
            {
                uri = new Uri("ms-appx:///Assets/coconuts.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg4.Source = bitmapImage;
        }

        private void img4_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img4_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg5(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "crab")
            {
                uri = new Uri("ms-appx:///Assets/crab.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg5.Source = bitmapImage;
        }

        private void img5_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img5_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg6_tapp(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "dolphin")
            {
                uri = new Uri("ms-appx:///Assets/dolphin.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg6.Source = bitmapImage;
        }

        private void img6_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img6_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg7_tapp(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "fish")
            {
                uri = new Uri("ms-appx:///Assets/Fish.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg7.Source = bitmapImage;
        }

        private void img7_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img7_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg8_tapp(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "magicCillian")
            {
                uri = new Uri("ms-appx:///Assets/MagicCillian.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg8.Source = bitmapImage;
        }

        private void img8_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img8_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg9(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "monkey1")
            {
                uri = new Uri("ms-appx:///Assets/monkey1.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            dispalyImg9.Source = bitmapImage;
        }

        private void img9_pressed(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img9_release(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg10(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " cillian")
            {
                uri = new Uri("ms-appx:///Assets/PirateCillian.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg10.Source = bitmapImage;
        }

        private void img10_press(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img10_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg11(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " monkey3")
            {
                uri = new Uri("ms-appx:///Assets/monkey3.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg11.Source = bitmapImage;
        }

        private void img11_press(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img11_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;

        }

        private void clmg12(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " parrot")
            {
                uri = new Uri("ms-appx:///Assets/parrot.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg12.Source = bitmapImage;
        }

        private void img12_press(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img12_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg14(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " seagul")
            {
                uri = new Uri("ms-appx:///Assets/Seagul.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg14.Source = bitmapImage;
        }

        private void clmg13(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " pirate")
            {
                uri = new Uri("ms-appx:///Assets/Pirate.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg13.Source = bitmapImage;
        }

        private void img13_press(object sender, PointerRoutedEventArgs e)
        {

            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img13_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null ;
        }

        private void img14_press(object sender, PointerRoutedEventArgs e)
        {

            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img14_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg15(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "seahorse")
            {
                uri = new Uri("ms-appx:///Assets/seahorse.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg15.Source = bitmapImage;
        }

        private void img15_press(object sender, PointerRoutedEventArgs e)
        {
            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img15_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;
        }

        private void clmg16(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " spider")
            {
                uri = new Uri("ms-appx:///Assets/Spider.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg16.Source = bitmapImage;
        }

        private void img16_press(object sender, PointerRoutedEventArgs e)
        {

            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img16_reles(object sender, PointerRoutedEventArgs e)
        {
            holding = null;

        }

        private void clmg17(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == " starfish")
            {
                uri = new Uri("ms-appx:///Assets/starfish.png");
            }
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg17.Source = bitmapImage;
        }

        private void img17_press(object sender, PointerRoutedEventArgs e)
        {

            holding = sender as Image;
            imageOffset = e.GetCurrentPoint(holding).Position;
        }

        private void img17_reles(object sender, PointerRoutedEventArgs e)
        {
            holding= null;
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

        private void backBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        


    }
}
