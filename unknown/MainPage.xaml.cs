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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace unknown
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

        private void myHamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (room.IsSelected)
            {
                myTitle.Text = "Room";
                myFrame.Navigate(typeof(RoomPage));
            }
            else if (house.IsSelected)
            {
                myTitle.Text = "House";
                myFrame.Navigate(typeof(BuildingPage));
            }
            else if (flat.IsSelected)
            {
                myTitle.Text = "Flat";
                myFrame.Navigate(typeof(FlatPage));
            }
            else if (home.IsSelected)
            {
                myTitle.Text = "Home";
                myFrame.Navigate(typeof(HomePage));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            home.IsSelected = true;
        }
    }
}
