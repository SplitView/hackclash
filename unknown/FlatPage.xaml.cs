using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using unknown.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace unknown
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FlatPage : Page
    {
        private ObservableCollection<Rent> Rooms;
        public FlatPage()
        {
            Rooms = new ObservableCollection<Rent>();
            this.InitializeComponent();
            RentManager.Getroom("Flat", Rooms);
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            locationButton.Content = "Kathmandu";
            RentManager.Getroom("Flat", locationButton.Content.ToString(), PriceButton.Content.ToString(), Rooms);
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            locationButton.Content = "Lalitpur";
            RentManager.Getroom("Flat", locationButton.Content.ToString(), PriceButton.Content.ToString(), Rooms);

        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            PriceButton.Content = "3000-4000";
            RentManager.Getroom("Flat", locationButton.Content.ToString(), PriceButton.Content.ToString(), Rooms);
        }

        private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {
            PriceButton.Content = "2000-3000";
            RentManager.Getroom("Flat", locationButton.Content.ToString(), PriceButton.Content.ToString(), Rooms);
        }

        private void MenuFlyoutItem_Click_4(object sender, RoutedEventArgs e)
        {
            locationButton.Content = "Bhaktapur";
            RentManager.Getroom("Flat", locationButton.Content.ToString(), PriceButton.Content.ToString(), Rooms);
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var place = (Rent)e.ClickedItem;
            Imagename.Source = new BitmapImage(new Uri("ms-appx:///" + place.Image));
            locationName.Text = place.Location;
            dimensionName.Text = place.Information;
            ContactName.Text = place.Contact;
            PriceName.Text = place.Price;
        }
    }
}
