   M S B A M L   `   `   `  ����I  EPatientMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PatientMonitorPatientMonitor  5   	       PatientMonitor.management   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PatientMonitor     5   	   -   5          � Title$  
management��5   
   $��723.857��6   $��534.586��6.    � 	Resources 5	      $   PatientMonitor.DatabaseDataSet   databaseDataSet  medical_StaffViewSource �� Source �� Source  alarmViewSource��%�   &	        &	      7   &	 F     7     5
   
   6    �� 5   
    6?   �� *Medical_Staff+8   �� 5   
    67   �� *Alarm+8   5      .��5      �  � DataContext# [ 6   $��0,0,0,11q�6B   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ medical_StaffDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��88,408,112,125q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6m   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        staff_IDColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Staff ID��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
Staff_ID+6l     5      -   5        full_NameColumn��$
 	Full Name��5   \   $ SizeToHeader 6o    6>   �� *	Full_Name+6o     5      -   5        email_or_NumberColumn��$
 Email or Number��5   h   $ SizeToHeader 6�    6D   �� *Email_or_Number+6�     5      -   5        time_InColumn��$
 Time In��5   X   $ SizeToHeader 6i    6<   �� *	Time_In+6i     5      -   5        time_OutColumn��$
 Time Out��5   Z   $ SizeToHeader 6l    6=   �� *
Time_Out+6l   5        5   
   -   5        $ alarmDataGrid��5       .   . $��111,99,112,430q�6�   $ VisibleWhenSelected=�6�   ��6e   �� # [ 	 5        5      -	   5        nHS_IDColumn��$
 NHS ID��5   V   $ SizeToHeader 6f    6;   �� *NHS_ID+6f     5      -
   5        alarm_TypeColumn��$
 
Alarm Type��5   ^   $ SizeToHeader 6r    6?   �� *
Alarm_Type+6r     5      -   5        generated_TimeColumn��$
 Generated Time��5   f   $ SizeToHeader 6~    6C   �� *Generated_Time+6~     5      -   5        rectified_TimeColumn��$
 Rectified Time��5   f   $ SizeToHeader 6~    6C   �� *Rectified_Time+6~   5      �� 5    
   -   5         ��Name$ btn_alarm_search��5       $��SEARCH��6+   $
��Left=�6<   $��	84,44,0,0q�6W   $	��Top=�6j   $��75��6�   �� 5!   
   -   5         ��Name$ txtAlarmSearch��5!      $
��Left=�6*   $��23��6E   $��
183,44,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��232��6�   �� 5"   
   -   5        $ txtStaffSearch��5"      $
��Left=�6*   $��23��6E   $��170,364,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��245��6�   �� 5#   
   -   5        $ btn_staff_search��5#      $��SEARCH��6+   $
��Left=�6<   $��
84,364,0,0q�6W   $	��Top=�6k   $��75��6�    J� RenderTransformOrigin$ 0.202,0.415&�6�   6�   5%      5&      