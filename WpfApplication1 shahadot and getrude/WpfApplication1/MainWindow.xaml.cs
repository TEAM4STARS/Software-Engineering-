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
using System.Data;
using System.Data.OleDb;


namespace WpfApplication1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication1._DATABASE___ERD_software_engineering__DataSet _DATABASE___ERD_software_engineering__DataSet = ((WpfApplication1._DATABASE___ERD_software_engineering__DataSet)(this.FindResource("_DATABASE___ERD_software_engineering__DataSet")));
            // Load data into the table Alarm. You can modify this code as needed.
            WpfApplication1._DATABASE___ERD_software_engineering__DataSetTableAdapters.AlarmTableAdapter _DATABASE___ERD_software_engineering__DataSetAlarmTableAdapter = new WpfApplication1._DATABASE___ERD_software_engineering__DataSetTableAdapters.AlarmTableAdapter();
            _DATABASE___ERD_software_engineering__DataSetAlarmTableAdapter.Fill(_DATABASE___ERD_software_engineering__DataSet.Alarm);
            System.Windows.Data.CollectionViewSource alarmViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("alarmViewSource")));
            alarmViewSource.View.MoveCurrentToFirst();
        }

        private void alarmDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
