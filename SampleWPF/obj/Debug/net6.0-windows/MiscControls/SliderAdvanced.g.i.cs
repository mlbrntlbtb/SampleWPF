﻿#pragma checksum "..\..\..\..\MiscControls\SliderAdvanced.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0C8808622119C2D5CD8E416533F59402F6E32849"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SampleWPF.MiscControls;
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


namespace SampleWPF.MiscControls {
    
    
    /// <summary>
    /// SliderAdvanced
    /// </summary>
    public partial class SliderAdvanced : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorR;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorG;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SampleWPF;V1.0.0.0;component/misccontrols/slideradvanced.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.slColorR = ((System.Windows.Controls.Slider)(target));
            
            #line 13 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
            this.slColorR.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.slColorG = ((System.Windows.Controls.Slider)(target));
            
            #line 19 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
            this.slColorG.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.slColorB = ((System.Windows.Controls.Slider)(target));
            
            #line 25 "..\..\..\..\MiscControls\SliderAdvanced.xaml"
            this.slColorB.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
