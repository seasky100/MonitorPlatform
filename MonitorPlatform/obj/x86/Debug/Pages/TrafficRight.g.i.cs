﻿#pragma checksum "..\..\..\..\Pages\TrafficRight.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5249D084C267BA98E5CDF28839D4A722"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using De.TorstenMandelkow.MetroChart;
using DevExpress.Core;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.Themes;
using DevExpress.Xpf.Grid.TreeList;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MonitorPlatform.Pages {
    
    
    /// <summary>
    /// TrafficRight
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class TrafficRight : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas 线路;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path 矩形_10;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path 矩形_3;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkLine;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock 线路1;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl grid;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal De.TorstenMandelkow.MetroChart.ChartSeries stationInoutChart;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.ChartControl detailchart;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.BarSideBySideStackedSeries2D stationTimeInChart;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.BarSideBySideStackedSeries2D stationTimeOutChart;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup pointTooltip;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\..\Pages\TrafficRight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.TextEdit ttContent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MonitorPlatform;component/pages/trafficright.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\TrafficRight.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.线路 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.矩形_10 = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            this.矩形_3 = ((System.Windows.Shapes.Path)(target));
            return;
            case 4:
            this.chkLine = ((System.Windows.Controls.CheckBox)(target));
            
            #line 51 "..\..\..\..\Pages\TrafficRight.xaml"
            this.chkLine.Click += new System.Windows.RoutedEventHandler(this.chkLine_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.线路1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.grid = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            case 7:
            this.stationInoutChart = ((De.TorstenMandelkow.MetroChart.ChartSeries)(target));
            return;
            case 8:
            this.detailchart = ((DevExpress.Xpf.Charts.ChartControl)(target));
            
            #line 163 "..\..\..\..\Pages\TrafficRight.xaml"
            this.detailchart.MouseMove += new System.Windows.Input.MouseEventHandler(this.chart_MouseMove);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\..\Pages\TrafficRight.xaml"
            this.detailchart.MouseLeave += new System.Windows.Input.MouseEventHandler(this.chart_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.stationTimeInChart = ((DevExpress.Xpf.Charts.BarSideBySideStackedSeries2D)(target));
            return;
            case 10:
            this.stationTimeOutChart = ((DevExpress.Xpf.Charts.BarSideBySideStackedSeries2D)(target));
            return;
            case 11:
            this.pointTooltip = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 12:
            this.ttContent = ((DevExpress.Xpf.Editors.TextEdit)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

