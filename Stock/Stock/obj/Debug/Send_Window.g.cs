﻿#pragma checksum "..\..\Send_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E534D511182FFE232A4AB93C593DD52741C9B35EE0D0A39E6CE987C6EF43CC39"
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
    /// Send_Window
    /// </summary>
    public partial class Send_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 162 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NewGrid;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MyGrid;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas_First;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_product_send_1;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Send_Product_Count_1;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas_Last;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Comment;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Plus_Product_For_Delete;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\Send_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Send_Product;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock;component/send_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Send_Window.xaml"
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
            this.NewGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.MyGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Canvas_First = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.Combo_product_send_1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.TB_Send_Product_Count_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Canvas_Last = ((System.Windows.Controls.Canvas)(target));
            return;
            case 7:
            this.TB_Comment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Btn_Plus_Product_For_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\Send_Window.xaml"
            this.Btn_Plus_Product_For_Delete.Click += new System.Windows.RoutedEventHandler(this.Btn_Plus_Product_For_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Btn_Send_Product = ((System.Windows.Controls.Button)(target));
            
            #line 189 "..\..\Send_Window.xaml"
            this.Btn_Send_Product.Click += new System.Windows.RoutedEventHandler(this.Btn_Add_Send_Product_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

