﻿#pragma checksum "..\..\TaskAlert.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B5CA9EC85DAC3F129A9B5AB7B1C2D2B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace AlzUI {
    
    
    /// <summary>
    /// TaskAlert
    /// </summary>
    public partial class TaskAlert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\TaskAlert.xaml"
        internal System.Windows.Controls.TextBlock txt_Message;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\TaskAlert.xaml"
        internal System.Windows.Controls.Button btn_ImportantTask;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\TaskAlert.xaml"
        internal System.Windows.Controls.DockPanel dock_RegularTask;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AlzUI;component/taskalert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TaskAlert.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_Message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btn_ImportantTask = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\TaskAlert.xaml"
            this.btn_ImportantTask.Click += new System.Windows.RoutedEventHandler(this.SeeTask_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dock_RegularTask = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            
            #line 35 "..\..\TaskAlert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LaunchRegularTask_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\TaskAlert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Continue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

