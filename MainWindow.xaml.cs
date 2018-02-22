/*
 * Josh Degazio
 * Feb 13, 2018
 * Computer Parts
 * User can browse through the computer parts selected for a build created by me.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JoshComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void cpu_btn_active(object sender, RoutedEventArgs e)
        {
            cpu_details.Visibility = System.Windows.Visibility.Visible;
            cpu_picture.Visibility = System.Windows.Visibility.Visible;

            ///Visibility.Hidden to any possible buttons that could be active, ensures that only one
            ///computer part has its info and image displayed at a certain time.
           
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void cpu_cooler_btn_active(object sender, RoutedEventArgs e)
        {
            cpu_cooler_details.Visibility = System.Windows.Visibility.Visible;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;

        }
        public void motherboard_btn_active(object sender, RoutedEventArgs e)
        {
            motherboard_details.Visibility = System.Windows.Visibility.Visible;
            motherboard_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;

        }
        public void ram_btn_active(object sender, RoutedEventArgs e)
        {
            ram_details.Visibility = System.Windows.Visibility.Visible;
            ram_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void ssd_btn_active(object sender, RoutedEventArgs e)
        {
            ssd_details.Visibility = System.Windows.Visibility.Visible;
            ssd_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;

        }
        public void vcard_btn_active(object sender, RoutedEventArgs e)
        {
            vcard_details.Visibility = System.Windows.Visibility.Visible;
            vcard_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void case_btn_active(object sender, RoutedEventArgs e)
        {
            case_details.Visibility = System.Windows.Visibility.Visible;
            case_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void psu_btn_active(object sender, RoutedEventArgs e)
        {
            psu_details.Visibility = System.Windows.Visibility.Visible;
            psu_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void monitor_btn_active(object sender, RoutedEventArgs e)
        {
            monitor_details.Visibility = System.Windows.Visibility.Visible;
            monitor_picture.Visibility = System.Windows.Visibility.Visible;
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
        }
        public void clear_btn_active(object sender, RoutedEventArgs e)
        {
            cpu_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_picture.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_details.Visibility = System.Windows.Visibility.Hidden;
            cpu_cooler_picture.Visibility = System.Windows.Visibility.Hidden;
            motherboard_details.Visibility = System.Windows.Visibility.Hidden;
            motherboard_picture.Visibility = System.Windows.Visibility.Hidden;
            ram_details.Visibility = System.Windows.Visibility.Hidden;
            ram_picture.Visibility = System.Windows.Visibility.Hidden;
            ssd_details.Visibility = System.Windows.Visibility.Hidden;
            ssd_picture.Visibility = System.Windows.Visibility.Hidden;
            vcard_details.Visibility = System.Windows.Visibility.Hidden;
            vcard_picture.Visibility = System.Windows.Visibility.Hidden;
            case_details.Visibility = System.Windows.Visibility.Hidden;
            case_picture.Visibility = System.Windows.Visibility.Hidden;
            psu_details.Visibility = System.Windows.Visibility.Hidden;
            psu_picture.Visibility = System.Windows.Visibility.Hidden;
            monitor_details.Visibility = System.Windows.Visibility.Hidden;
            monitor_picture.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
