﻿#pragma checksum "..\..\Panel_Administracji_Kontami.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F22165DF0322DBDA518FDF9E700EC166"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
using System.Windows.Shell;


namespace WarsztatMalina {
    
    
    /// <summary>
    /// Panel_Administracji_Kontami
    /// </summary>
    public partial class Panel_Administracji_Kontami : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Panel_Administracji_Kontami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListaKont;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Panel_Administracji_Kontami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwaUzyt;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Panel_Administracji_Kontami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HasloUzyt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Panel_Administracji_Kontami.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HasloUzytPotw;
        
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
            System.Uri resourceLocater = new System.Uri("/WarsztatMalina;component/panel_administracji_kontami.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Panel_Administracji_Kontami.xaml"
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
            this.ListaKont = ((System.Windows.Controls.ListBox)(target));
            
            #line 6 "..\..\Panel_Administracji_Kontami.xaml"
            this.ListaKont.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 7 "..\..\Panel_Administracji_Kontami.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DodajKonto);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 8 "..\..\Panel_Administracji_Kontami.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZmienDane);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 9 "..\..\Panel_Administracji_Kontami.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Usun);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NazwaUzyt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.HasloUzyt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.HasloUzytPotw = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

