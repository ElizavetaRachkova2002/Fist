﻿#pragma checksum "..\..\Change_Product_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64B74C6E926F70B6097D90AF1634DDC83DE9E8531F717543B0C667EFF6F94E80"
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
    /// Change_Product_Window
    /// </summary>
    public partial class Change_Product_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_Current_Product;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Delete_Package;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas BrdAddNewProduct;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Add_New_Product;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TB_New_Legal_Entity;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_New_Name;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_New_Vendor_Code;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_New_Barcode;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TB_NewProduct_Package_Name;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_New_Brand;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Change_Product_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_LegalEnity;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock;component/change_product_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Change_Product_Window.xaml"
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
            this.Combo_Current_Product = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.Btn_Delete_Package = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Change_Product_Window.xaml"
            this.Btn_Delete_Package.Click += new System.Windows.RoutedEventHandler(this.Btn_Change_OK_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BrdAddNewProduct = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.Btn_Add_New_Product = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Change_Product_Window.xaml"
            this.Btn_Add_New_Product.Click += new System.Windows.RoutedEventHandler(this.Btn_Change_Product_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TB_New_Legal_Entity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\Change_Product_Window.xaml"
            this.TB_New_Legal_Entity.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TB_New_Legal_Entity_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_New_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TB_New_Vendor_Code = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TB_New_Barcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TB_NewProduct_Package_Name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.TB_New_Brand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Add_LegalEnity = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Change_Product_Window.xaml"
            this.Add_LegalEnity.Click += new System.Windows.RoutedEventHandler(this.Add_LegalEnity_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

