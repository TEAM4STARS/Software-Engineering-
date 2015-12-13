using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PatientMonitor
{
    /// <summary>
    /// Interaction logic for MainWindowInterface.xaml
    /// </summary>
    public partial class MainWindowInterface : Window
    {
        public MainWindowInterface()
        {
            InitializeComponent();
        }

        private void btn_medical_staff_Click(object sender, RoutedEventArgs e)
        {
            new medicalStaff().Show();
          
        }

        private void btn_management_Click(object sender, RoutedEventArgs e)
        {
               new management().Show();
            
        }

        private void btn_Bed_Monitoring_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            
        }
    }
}
