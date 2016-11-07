using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace Techhere_silverlight_
{
    public partial class Page_anasayfa : PhoneApplicationPage
    {
        public Page_anasayfa()
        {
            InitializeComponent();
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void gridView_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void slider()
        {

            DispatcherTimer dpt = new DispatcherTimer();
            dpt.Interval = new TimeSpan(0, 0, 2);
            dpt.Tick += Dpt_Tick;
            dpt.Start();


        }

        private void Dpt_Tick(object sender, object e)
        {
            /*int saniye;
            saniye = DateTime.Now.Second;
            if (saniye % 2 == 0) { slider_pivot.SelectedIndex = 1; }
            else { slider_pivot.SelectedIndex = 0; }*/
            if (slider_pivot.SelectedIndex == 4) { slider_pivot.SelectedIndex = 0; }
            else { slider_pivot.SelectedIndex = slider_pivot.SelectedIndex + 1; }

        }

        private void button_menu_Click(object sender, RoutedEventArgs e)
        {
            pivot_page.SelectedIndex = 0;

        }


        private void pivot_page_PivotItemLoaded(Pivot sender, PivotItemEventArgs args)
        {
            if (pivot_page.SelectedIndex == 1)
            {

                alti_menu_buton.Opacity = 0;
                alti_kullanici_buton.Opacity = 0;
                alti_sepet_buton.Opacity = 0;

            }
            if (pivot_page.SelectedIndex == 0)
            {

                alti_menu_buton.Opacity = 100;
                alti_kullanici_buton.Opacity = 0;
                alti_sepet_buton.Opacity = 0;

            }
            if (pivot_page.SelectedIndex == 2)
            {

                alti_menu_buton.Opacity = 0;
                alti_kullanici_buton.Opacity = 100;
                alti_sepet_buton.Opacity = 0;

            }

        }

        private void button_kullanici_Click(object sender, RoutedEventArgs e)
        {
            pivot_page.SelectedIndex = 2;
        }

        private void image_logo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
           
        }
    }


}
