﻿#pragma checksum "..\..\ListOfPackages.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7242D04DC8E5EC782278076EB57F690450113E82861BE5C466CB1140E17C03A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Stock;
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


namespace Stock {
    
    
    /// <summary>
    /// ListOfPackages
    /// </summary>
    public partial class ListOfPackages : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\ListOfPackages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Brd_list_packages;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ListOfPackages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridlistpackage;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\ListOfPackages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkHeader;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\ListOfPackages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add_packages;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ListOfPackages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_WithoutPackage;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock;component/listofpackages.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListOfPackages.xaml"
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
            this.Brd_list_packages = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.gridlistpackage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.chkHeader = ((System.Windows.Controls.CheckBox)(target));
            
            #line 79 "..\..\ListOfPackages.xaml"
            this.chkHeader.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 79 "..\..\ListOfPackages.xaml"
            this.chkHeader.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_add_packages = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\ListOfPackages.xaml"
            this.btn_add_packages.Click += new System.Windows.RoutedEventHandler(this.btn_add_packages_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_WithoutPackage = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\ListOfPackages.xaml"
            this.btn_WithoutPackage.Click += new System.Windows.RoutedEventHandler(this.btn_without_Package_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

