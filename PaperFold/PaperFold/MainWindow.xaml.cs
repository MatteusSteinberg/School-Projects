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

namespace PaperFold
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double t = double.Parse(txtThickness.Text);
            double n = double.Parse(txtFold.Text);
            double pi = Math.PI;
            double result = pi * t / 6 * (Math.Pow(2, n) + 4) * (Math.Pow(2, n) - 1);
            lblResult.Content = Math.Round(result, 2, MidpointRounding.ToEven);
        }
    }
}
