﻿#pragma checksum "..\..\..\NHANVIEN\BanChoiNV.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C910AB12A8DDF8602B5BCDC6A4E90DA39033127DF1505BF6D8D83FF21A0F95E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace btl {
    
    
    /// <summary>
    /// BanChoiNV
    /// </summary>
    public partial class BanChoiNV : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\NHANVIEN\BanChoiNV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaBan;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\NHANVIEN\BanChoiNV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLoaiBan;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\NHANVIEN\BanChoiNV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiaThue;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\NHANVIEN\BanChoiNV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTrangThai;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\NHANVIEN\BanChoiNV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvBanChoi;
        
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
            System.Uri resourceLocater = new System.Uri("/btl;component/nhanvien/banchoinv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NHANVIEN\BanChoiNV.xaml"
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
            this.txtMaBan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtLoaiBan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtGiaThue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbTrangThai = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 54 "..\..\..\NHANVIEN\BanChoiNV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 55 "..\..\..\NHANVIEN\BanChoiNV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 56 "..\..\..\NHANVIEN\BanChoiNV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgvBanChoi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 60 "..\..\..\NHANVIEN\BanChoiNV.xaml"
            this.dgvBanChoi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvBanChoi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

