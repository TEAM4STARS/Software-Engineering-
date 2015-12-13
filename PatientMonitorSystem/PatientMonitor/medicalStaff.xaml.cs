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
using System.Data;
using System.Data.OleDb;
using System.Windows.Shapes;
using System.Configuration;
namespace PatientMonitor
{
    /// <summary>
    /// Interaction logic for medicalStaff.xaml
    /// </summary>
    public partial class medicalStaff : Window
    {
        public medicalStaff()
        {
            InitializeComponent();
        }
        OleDbConnection dataConnection = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString); // this specifies the connection string (where the connection is stored)

        MsgBox ErrorMsg = new MsgBox();
        MsgBox ValidationMsg = new MsgBox();

        public object Connection { get; private set; }

        private void start_shift_Click(object sender, RoutedEventArgs e)
        {
            DateTime myTime = DateTime.Now;
            string StaffID;
            string EmailNumber;
            string Fullname;
            StaffID = txtStaffID.Text;
            EmailNumber = txtNumberEmail.Text;
            Fullname = txtFullname.Text;

            if (StaffID == "" || EmailNumber == "" || Fullname == "") //if the button is pressed and the fields are empty show message box......
            {
                ValidationMsg.ValidationMsgBox(); //gets the field vaidation message from the MsgBox class
            }

            else
            {
                try  //The code inside this try block may cause the exception and it is executed until an exception is thrown or it has completed successfully.
                {


                    OleDbCommand Query = new OleDbCommand();

                    Query.CommandText = "INSERT INTO Medical_Staff (Staff_ID, Full_Name, Email_or_Number, Time_In) VALUES ('" + txtStaffID.Text + "', '" + txtFullname.Text + "', '" + txtNumberEmail.Text + "', '" + myTime.ToString() + "')";
                    Query.Connection = dataConnection;
                    Query.Connection.Open();
                    Query.ExecuteNonQuery();
                    Query.Connection.Close();
                    MessageBox.Show("You are starting your shift at " + myTime.ToShortTimeString(), "STARTING SHIFT", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtStaffID.Text = "";
                    txtNumberEmail.Text = "";
                    txtFullname.Text = "";
                }

                catch (Exception ex)
                {
                    ErrorMsg.ErrorMsgBox(ex); //gets the exeption error message from the MsgBox class when the catch throws an error
                }
            }
        }

        private void end_shift_Click(object sender, RoutedEventArgs e)
        {
            DateTime myTime = DateTime.Now;  //gets the local time
            string StaffID;
            string EmailNumber;
            string Fullname;
            StaffID = txtStaffID.Text;
            EmailNumber = txtNumberEmail.Text;
            Fullname = txtFullname.Text;

            if (StaffID == "")
            {
                ValidationMsg.ValidationMsgBox(); //gets this from the MsgBox class
            }

            else
            {
                try //The code inside this try block may cause the exception and it is executed until an exception is thrown or it has completed successfully.
                {
                    OleDbCommand Query = new OleDbCommand();
                    Query.CommandText = "UPDATE Medical_Staff SET Time_Out = '" + myTime.ToString() + "' WHERE Staff_ID =" + txtStaffID.Text + ""; //sql command to be executed
                    Query.Connection = dataConnection; //gets connection of data source
                    Query.Connection.Open(); // opens the connection to the database
                    Query.ExecuteNonQuery(); // executes the query
                    Query.Connection.Close(); // closes the connection to the database
                    MessageBox.Show("You are ending your shift at " + myTime.ToShortTimeString(), "ENDING SHIFT", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtStaffID.Text = "";
                }

                catch (Exception ex) //catches an exception
                {
                    ErrorMsg.ErrorMsgBox(ex);  //gets the exeption error message from the MsgBox class
                }

                finally
                {

                }

            }
        }
    }
}