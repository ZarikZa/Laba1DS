﻿#pragma checksum "..\..\Unitaz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "814018C895AE58B620C29A53DAD99B9FE535DED8965BF2F15BD2B6ED79439632"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PervayaLabaDataSet;
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


namespace PervayaLabaDataSet {
    
    
    /// <summary>
    /// Unitaz
    /// </summary>
    public partial class Unitaz : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\Unitaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datygridy;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Unitaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTbox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Unitaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltrCbox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Unitaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtm;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Unitaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearBtm;
        
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
            System.Uri resourceLocater = new System.Uri("/PervayaLabaDataSet;component/unitaz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Unitaz.xaml"
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
            this.datygridy = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.SearchTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FiltrCbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\Unitaz.xaml"
            this.FiltrCbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltrCbox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchBtm = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Unitaz.xaml"
            this.SearchBtm.Click += new System.Windows.RoutedEventHandler(this.SearchBtm_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClearBtm = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Unitaz.xaml"
            this.ClearBtm.Click += new System.Windows.RoutedEventHandler(this.ClearBtm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

