﻿#pragma checksum "..\..\medialStaff.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1E3B6D304ED4DF21459EDDFAD267852F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PatientMonitor;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PatientMonitor {
    
    
    /// <summary>
    /// medialStaff
    /// </summary>
    public partial class medialStaff : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start_shift;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStaffID;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button end_shift;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullname;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumberEmail;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_staff_id;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_full_name;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_number_email;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\medialStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PatientMonitor;component/medialstaff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\medialStaff.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.start_shift = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\medialStaff.xaml"
            this.start_shift.Click += new System.Windows.RoutedEventHandler(this.start_shift_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtStaffID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.end_shift = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\medialStaff.xaml"
            this.end_shift.Click += new System.Windows.RoutedEventHandler(this.end_shift_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtFullname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNumberEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lbl_staff_id = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbl_full_name = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lbl_number_email = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.menu = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\medialStaff.xaml"
            this.menu.Click += new System.Windows.RoutedEventHandler(this.menu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

