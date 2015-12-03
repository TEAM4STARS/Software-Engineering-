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
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace Patient_Monitoring_System
{
    /// <summary>
    /// Interaction logic for management.xaml
    /// </summary>
    public partial class management : Window
    {
        public management()
        {
            InitializeComponent();
        }

        OleDbConnection dataConnection = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        MsgBox ErrorMsg = new MsgBox();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Patient_Monitoring_System.DatabaseDataSet databaseDataSet = ((Patient_Monitoring_System.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table Medical_Staff. You can modify this code as needed.
            Patient_Monitoring_System.DatabaseDataSetTableAdapters.Medical_StaffTableAdapter databaseDataSetMedical_StaffTableAdapter = new Patient_Monitoring_System.DatabaseDataSetTableAdapters.Medical_StaffTableAdapter();
            databaseDataSetMedical_StaffTableAdapter.Fill(databaseDataSet.Medical_Staff);
            System.Windows.Data.CollectionViewSource medical_StaffViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("medical_StaffViewSource")));
            medical_StaffViewSource.View.MoveCurrentToFirst();
            // Load data into the table Alarm. You can modify this code as needed.
            Patient_Monitoring_System.DatabaseDataSetTableAdapters.AlarmTableAdapter databaseDataSetAlarmTableAdapter = new Patient_Monitoring_System.DatabaseDataSetTableAdapters.AlarmTableAdapter();
            databaseDataSetAlarmTableAdapter.Fill(databaseDataSet.Alarm);
            System.Windows.Data.CollectionViewSource alarmViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("alarmViewSource")));
            alarmViewSource.View.MoveCurrentToFirst();       
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Hide();
        }

        private void btn_staff_search_Click(object sender, RoutedEventArgs e)
        {
              try {
                OleDbCommand Query = new OleDbCommand();
                Query.CommandText = "select * from Medical_Staff where Staff_ID = "+ int.Parse(txtStaffSearch.Text);
                Query.Connection = dataConnection;  
                Query.Connection.Open();
                Query.ExecuteNonQuery();
                DataTable dt = new DataTable();               
                OleDbDataAdapter adapt = new OleDbDataAdapter(Query);
                adapt.Fill(dt);
                medical_StaffDataGrid.DataContext = dt;
                Query.Connection.Close();
            }

            catch (Exception ex)
            {
                ErrorMsg.ErrorMsgBox(ex);
            }
 
            
        }
    }
}
