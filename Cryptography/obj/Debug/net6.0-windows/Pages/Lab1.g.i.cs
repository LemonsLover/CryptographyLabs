﻿#pragma checksum "..\..\..\..\Pages\Lab1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44EA3F5CAF6A891BE14430188E0D1BB86B4E3F49"
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
using System.Windows.Controls.Ribbon;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Cryptography {
    
    
    /// <summary>
    /// Lab1
    /// </summary>
    public partial class Lab1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDecrypted;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEncrypted;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown UpDownControlKey;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxAlphabet;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockAlphabetLength;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCustom;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\Lab1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform ArrowAngle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cryptography;V1.0.0.0;component/pages/lab1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Lab1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Pages\Lab1.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxDecrypted = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Pages\Lab1.xaml"
            this.TextBoxDecrypted.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxDecrypted_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxEncrypted = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\..\Pages\Lab1.xaml"
            this.TextBoxEncrypted.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxEncrypted_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpDownControlKey = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            
            #line 39 "..\..\..\..\Pages\Lab1.xaml"
            this.UpDownControlKey.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.UpDownControlKey_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBoxAlphabet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\Pages\Lab1.xaml"
            this.ComboBoxAlphabet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxAlphabet_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockAlphabetLength = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBoxCustom = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\Pages\Lab1.xaml"
            this.TextBoxCustom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxCustom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ArrowAngle = ((System.Windows.Media.RotateTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

