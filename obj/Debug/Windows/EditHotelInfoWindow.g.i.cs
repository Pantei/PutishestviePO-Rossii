﻿#pragma checksum "..\..\..\Windows\EditHotelInfoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18B9FF679046A4B420AD8D0D651609D59D6547C11CDEF577A7BCF0D22032AAA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PuteshestviePo_Rossii.Windows;
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


namespace PuteshestviePo_Rossii.Windows {
    
    
    /// <summary>
    /// EditHotelInfoWindow
    /// </summary>
    public partial class EditHotelInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNameHotel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCountStars;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDescriptionHotel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbNameCountry;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteHotel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\EditHotelInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateHptelInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/PuteshestviePo Rossii;component/windows/edithotelinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditHotelInfoWindow.xaml"
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
            this.TxtNameHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtCountStars = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtDescriptionHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CmbNameCountry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BtnDeleteHotel = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\EditHotelInfoWindow.xaml"
            this.BtnDeleteHotel.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteHotel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnUpdateHptelInfo = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\EditHotelInfoWindow.xaml"
            this.BtnUpdateHptelInfo.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateHptelInfo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
