﻿#pragma checksum "..\..\Help.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "62F21EE01E925CF067CD31D88FBFC7E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Rapid_Reporter {
    
    
    /// <summary>
    /// Help
    /// </summary>
    public partial class Help : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Help.xaml"
        internal System.Windows.Controls.Label appName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Help.xaml"
        internal System.Windows.Controls.Label appVers;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Help.xaml"
        internal System.Windows.Controls.TextBlock helpApp;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Help.xaml"
        internal System.Windows.Controls.Button Ok;
        
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
            System.Uri resourceLocater = new System.Uri("/RapidReporter;component/help.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Help.xaml"
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
            
            #line 4 "..\..\Help.xaml"
            ((Rapid_Reporter.Help)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 4 "..\..\Help.xaml"
            ((Rapid_Reporter.Help)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.appName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.appVers = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.helpApp = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 27 "..\..\Help.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ok = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

