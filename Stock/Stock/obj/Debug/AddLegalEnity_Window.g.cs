﻿#pragma checksum "..\..\AddLegalEnity_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F6EF3E29DF9D26EA67E6C2B6CFB1B3FDF20F76F109831B6795B1B9589CCB5D6"
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
    /// AddLegalEnity_Window
    /// </summary>
    public partial class AddLegalEnity_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 106 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_New_LE;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Delete_LE;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas_Add;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox New_LegalEnity;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_New_LegalEnity;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas_Delete;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_LegalEnity;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\AddLegalEnity_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TB_Delete_LE;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock;component/addlegalenity_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddLegalEnity_Window.xaml"
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
            this.Btn_New_LE = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\AddLegalEnity_Window.xaml"
            this.Btn_New_LE.Click += new System.Windows.RoutedEventHandler(this.Btn_New_LE_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Delete_LE = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\AddLegalEnity_Window.xaml"
            this.Btn_Delete_LE.Click += new System.Windows.RoutedEventHandler(this.Btn_Delete_LE_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Canvas_Add = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.New_LegalEnity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Add_New_LegalEnity = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\AddLegalEnity_Window.xaml"
            this.Add_New_LegalEnity.Click += new System.Windows.RoutedEventHandler(this.Add_New_LegalEnity_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Canvas_Delete = ((System.Windows.Controls.Canvas)(target));
            return;
            case 7:
            this.Delete_LegalEnity = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\AddLegalEnity_Window.xaml"
            this.Delete_LegalEnity.Click += new System.Windows.RoutedEventHandler(this.Delete_LegalEnity_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TB_Delete_LE = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

