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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {

            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\larre\\Source\\Repos\\hemuppgift-wpf-EmilAlexLarsson\\Hemuppgift_WPFtemplate\\TrophyImage.jpg"));
            image.Height = 300;
            image.Width = 300;

            mainDockpanel.Children.Remove(btnCenter);
            mainDockpanel.Children.Add(image);
        }
    }
}
