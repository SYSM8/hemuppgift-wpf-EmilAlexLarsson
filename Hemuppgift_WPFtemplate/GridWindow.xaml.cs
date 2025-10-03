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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, RoutedEventArgs e)
        {
            int row = Convert.ToInt32(rowBox.Text);
            int col = Convert.ToInt32(colBox.Text);
            Button greenBtn = new Button();

            if (row < 0 || row > 3 || col < 0 || col > 3)
            {
                MessageBox.Show("Du är utanför fönstret!");
            }
            else
            {
                greenBtn.Content = "Row " + row + " Column " + col;
                //greenBtn.Width = 100;
                //greenBtn.Height = 70;
                greenBtn.Background = new SolidColorBrush(Colors.LightGreen);

                Grid.SetRow(greenBtn, row);
                Grid.SetColumn(greenBtn, col);

                MainGrid.Children.Add(greenBtn);
            }
        }
    }
}
