using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ReVancedSite
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Header_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            string selectedItemTag = (string)args.InvokedItemContainer.Tag;
            Console.WriteLine(selectedItemTag);
            string pageName = "ReVancedSite.Pages." + selectedItemTag + "." + selectedItemTag;
            Type pageType = Type.GetType(pageName);
            Console.WriteLine(pageType);
            contentFrame.Navigate(pageType);
        }

        private void Header_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri("https://revanced.pages.dev/logo.svg"));
            img.ImageSource = bitmapImage;
        }
    }
}
