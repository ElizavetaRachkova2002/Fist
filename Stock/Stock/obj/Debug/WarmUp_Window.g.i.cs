﻿#pragma checksum "..\..\WarmUp_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1DA60F7ADBCAFB9BE47B79701C833A12D99BDA62BA041C2298ECCC65B7029D0A"
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
    /// WarmUp_Window
    /// </summary>
    public partial class WarmUp_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\WarmUp_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_WarmUp_Name;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\WarmUp_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WarmUp_Count;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\WarmUp_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WarmUp_Brak;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\WarmUp_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_WarmUp_Product;
        
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
            System.Uri resourceLocater = new System.Uri("/Мой склад;component/warmup_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WarmUp_Window.xaml"
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
            this.Combo_WarmUp_Name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.WarmUp_Count = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.WarmUp_Brak = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Btn_WarmUp_Product = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\WarmUp_Window.xaml"
            this.Btn_WarmUp_Product.Click += new System.Windows.RoutedEventHandler(this.Btn_WarmUp_Product_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

