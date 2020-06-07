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

namespace WpfApp1
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var fullname = $"{txtFirstName.Text} {txtLastName.Text}";

            lblMyNameIs.Content = fullname;

            var time = DateTime.Now;

            lblTimeResult.Content = time.ToString("dd/MM/yyyy");

            DateTime? BirthDate = calDOB.SelectedDate;
            DateTime? SchoolDate = calSchoolStart.SelectedDate;

            lblDob1.Content = BirthDate.Value;
            lblSchoolStart.Content = SchoolDate.Value;
            lblSchoolStartedResult.Content = SchoolDate.Value;

            var Birthday = BirthDate.Value.ToString("dd/MM/yyyy");
            var now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            var dob = int.Parse(BirthDate.Value.ToString("yyyyMMdd"));
            var school = int.Parse(SchoolDate.Value.ToString("yyyyMMdd"));
            var age = (now - dob) / 10000;

            lblMyAgeIs.Content = $"{age} ({Birthday})";
            lblMySchoolAge.Content = (school - dob) / 10000;
        }

        // Kalenderen er lidt buggy
        private void boxDob_Checked(object sender, RoutedEventArgs e)
        {
            calDOB.Visibility = Visibility.Visible;
        }
        private void boxDob_Unchecked(object sender, RoutedEventArgs e)
        {
            calDOB.Visibility = Visibility.Hidden;
        }

        private void boxSchoolStart_Checked(object sender, RoutedEventArgs e)
        {
            calSchoolStart.Visibility = Visibility.Visible;
        }
        private void boxSchoolStart_Unchecked(object sender, RoutedEventArgs e)
        {
            calSchoolStart.Visibility = Visibility.Hidden;
        }


    }
}
