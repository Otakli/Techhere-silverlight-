using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Techhere_silverlight_.Resources;

using System.Net.NetworkInformation;
using Techhere_silverlight_.webservices_techere;

namespace Techhere_silverlight_
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            bool internet_var = NetworkInterface.GetIsNetworkAvailable();
            if (internet_var)
            {

                WebService_denemeSoapClient baglanti = new WebService_denemeSoapClient();
                baglanti.kontrolAsync(textBox.Text,textBox1.Text);
                baglanti.kontrolCompleted += Baglanti_kontrolCompleted;


            }
            else { }




        }

        private void Baglanti_kontrolCompleted(object sender, kontrolCompletedEventArgs e)
        {
            textBlock.Text = "";
            textBlock1.Text = "";
            textBlock2.Text = "";
            textBlock3.Text = "";
            textBlock4.Text = "";
            textBlock5.Text = "";

            if (e.Result.Count == 1)
            {
                textBlock.Text = e.Result[0];

            }
            else
            {
                for (int i = 0; i < e.Result.Count; i++)
                {
                    textBlock.Text = e.Result[0];
                    textBlock1.Text = e.Result[1];
                    textBlock2.Text = e.Result[2];
                    textBlock3.Text = e.Result[3];
                    textBlock4.Text = e.Result[4];
                    textBlock5.Text = e.Result[5];

                }
                Console.Write(e.Result.ToString());
            }
             
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page_anasayfa.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}