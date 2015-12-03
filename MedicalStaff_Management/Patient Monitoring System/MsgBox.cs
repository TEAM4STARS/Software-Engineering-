using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    class MsgBox
    {
        public void ErrorMsgBox(Exception exception)
        {
            System.Windows.MessageBox.Show(exception.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);       
        }

        public void ValidationMsgBox()
        {
            System.Windows.MessageBox.Show("Please enter your details", "MISSING DETAILS", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }
    }
}
