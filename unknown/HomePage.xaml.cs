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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace unknown
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        private List<Rent> Rooms;
        public HomePage()
        {
            Rooms = new List<Rent>();
            this.InitializeComponent();
            Rooms= RentManager.getRooms();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myListView.Visibility = Visibility.Collapsed;
            myframe.Visibility = Visibility.Visible;
            myframe.Navigate(typeof(LoginPage));           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            myframe.Visibility = Visibility.Collapsed;
        }
    }
}
