﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD1453E98F59D424319209DF062CA1E534E7ACFBE0FAD91B744DC3F60892E317"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 495 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainContent;
        
        #line default
        #line hidden
        
        
        #line 519 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProduct;
        
        #line default
        #line hidden
        
        
        #line 520 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_WarmUp;
        
        #line default
        #line hidden
        
        
        #line 522 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProduct;
        
        #line default
        #line hidden
        
        
        #line 523 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrakProduct;
        
        #line default
        #line hidden
        
        
        #line 524 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeProduct;
        
        #line default
        #line hidden
        
        
        #line 535 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPackage;
        
        #line default
        #line hidden
        
        
        #line 536 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePackage;
        
        #line default
        #line hidden
        
        
        #line 542 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid productGrid;
        
        #line default
        #line hidden
        
        
        #line 555 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid packageGrid;
        
        #line default
        #line hidden
        
        
        #line 569 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button History_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.MainContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.AddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 519 "..\..\MainWindow.xaml"
            this.AddProduct.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_WarmUp = ((System.Windows.Controls.Button)(target));
            
            #line 520 "..\..\MainWindow.xaml"
            this.Btn_WarmUp.Click += new System.Windows.RoutedEventHandler(this.Btn_WarmUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 521 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteProduct = ((System.Windows.Controls.Button)(target));
            
            #line 522 "..\..\MainWindow.xaml"
            this.DeleteProduct.Click += new System.Windows.RoutedEventHandler(this.DeleteProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BrakProduct = ((System.Windows.Controls.Button)(target));
            
            #line 523 "..\..\MainWindow.xaml"
            this.BrakProduct.Click += new System.Windows.RoutedEventHandler(this.Brak_list_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ChangeProduct = ((System.Windows.Controls.Button)(target));
            
            #line 524 "..\..\MainWindow.xaml"
            this.ChangeProduct.Click += new System.Windows.RoutedEventHandler(this.ChangeProduct_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddPackage = ((System.Windows.Controls.Button)(target));
            
            #line 535 "..\..\MainWindow.xaml"
            this.AddPackage.Click += new System.Windows.RoutedEventHandler(this.AddPackage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeletePackage = ((System.Windows.Controls.Button)(target));
            
            #line 536 "..\..\MainWindow.xaml"
            this.DeletePackage.Click += new System.Windows.RoutedEventHandler(this.Delete_Package_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.productGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 543 "..\..\MainWindow.xaml"
            this.productGrid.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.grid_MouseUp);
            
            #line default
            #line hidden
            
            #line 543 "..\..\MainWindow.xaml"
            this.productGrid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ProductGrid_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 11:
            this.packageGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 556 "..\..\MainWindow.xaml"
            this.packageGrid.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.grid_MouseUp_Package);
            
            #line default
            #line hidden
            
            #line 556 "..\..\MainWindow.xaml"
            this.packageGrid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PackageGrid_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 12:
            this.History_button = ((System.Windows.Controls.Button)(target));
            
            #line 569 "..\..\MainWindow.xaml"
            this.History_button.Click += new System.Windows.RoutedEventHandler(this.History_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

