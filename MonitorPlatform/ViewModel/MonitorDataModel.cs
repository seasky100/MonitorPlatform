﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MonitorPlatform.Controls;

#if NETFX_CORE
using Windows.UI.Xaml;
#else

#endif

namespace MonitorPlatform.ViewModel
{
    public class MenuItems : INotifyPropertyChanged
    {
        private string selectedChartType = null;
        public string SelectedChartType
        {
            get
            {
                return selectedChartType;
            }
            set
            {
                selectedChartType = value;
                NotifyPropertyChanged("SelectedChartType");
            }
        }

        public ObservableCollection<string> ChartTypes { get; set; }
        public MenuItems()
        {
            ChartTypes = new ObservableCollection<string>();
            ChartTypes.Add("总裁界面");
            ChartTypes.Add("客流信息");
            ChartTypes.Add("列车位置");
            ChartTypes.Add("设施设备");
            ChartTypes.Add("视频监控");
            ChartTypes.Add("地理信息");
            SelectedChartType = ChartTypes.FirstOrDefault();
        }

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public class PropertyNodeItem
    {

        public string Icon { get; set; }
        public string EditIcon { get; set; }

        public string DisplayName { get; set; }

        public string Name { get; set; }



        public List<PropertyNodeItem> Children { get; set; }
        public PropertyNodeItem()
        {

            Children = new List<PropertyNodeItem>();

        }

    }

    public class MonitorDataModel : INotifyPropertyChanged
    {

        private const string cameraimg = "/Resource/camera.png";
        public Dictionary<string, string[]> subway = new Dictionary<string, string[]>();
        public DelegateCommand AddSeriesCommand { get; set; }
       
        public List<double> FontSizes { get; set; }
        public List<double> DoughnutInnerRadiusRatios { get; set; }
        public Dictionary<string, De.TorstenMandelkow.MetroChart.ResourceDictionaryCollection> Palettes { get; set; }
        public List<string> SelectionBrushes { get; set; }

     
        private object selectedPalette = null;
        public object SelectedPalette
        {
            get
            {
                return selectedPalette;
            }
            set
            {
                selectedPalette = value;
                NotifyPropertyChanged("SelectedPalette");
            }
        }

        private bool darkLayout = false;
        public bool DarkLayout
        {
            get
            {
                return darkLayout;
            }
            set
            {
                darkLayout = value;
                NotifyPropertyChanged("DarkLayout");
                NotifyPropertyChanged("Foreground");
                NotifyPropertyChanged("Background");
                NotifyPropertyChanged("MainBackground");
                NotifyPropertyChanged("MainForeground");
            }
        }

        public string Foreground
        {
            get
            {
                if (darkLayout)
                {
                    return "#FFEEEEEE";
                }
                return "#FF666666";
            }
        }
        public string MainForeground
        {
            get
            {
                if (darkLayout)
                {
                    return "#FFFFFFFF";
                }
                return "#FF666666";
            }
        }
        public string Background
        {
            get
            {
                if (darkLayout)
                {
                    return "#FF333333";
                }
                return "#FFF9F9F9";
            }
        }
        public string MainBackground
        {
            get
            {
                if (darkLayout)
                {
                    return "#FF000000";
                }
                return "#FFEFEFEF";
            }
        }


        private string selectedBrush = null;
        public string SelectedBrush
        {
            get
            {
                return selectedBrush;
            }
            set
            {
                selectedBrush = value;
                NotifyPropertyChanged("SelectedBrush");
            }
        }

        private double selectedDoughnutInnerRadiusRatio = 0.75;
        public double SelectedDoughnutInnerRadiusRatio
        {
            get
            {
                return selectedDoughnutInnerRadiusRatio;
            }
            set
            {
                selectedDoughnutInnerRadiusRatio = value;
                NotifyPropertyChanged("SelectedDoughnutInnerRadiusRatio");
                NotifyPropertyChanged("SelectedDoughnutInnerRadiusRatioString");
            }
        }

        public string SelectedDoughnutInnerRadiusRatioString
        {
            get
            {
                return String.Format("{0:P1}.", SelectedDoughnutInnerRadiusRatio);
            }
        }


        private void InitSubWayData()
        {
            SubWayLines = new ObservableCollection<SubLine>();
            SubLine line1 = new SubLine() { Name = "1号线", CameraTotalNumber = 25 };
            SubLine line2 = new SubLine() { Name = "2号线", CameraTotalNumber = 30 };

            string[] line1str =  { "木渎站", "金枫路", "汾湖路", "玉山路", "苏州乐园","塔园路","滨河路","西环路",
                                       "桐泾北路 ","广济南路","养育巷","乐桥站","临顿路","相门","东环路",
                                       "中央公园","星海广场","东方之门","文化博览中心","时代广场","星湖街",
                                       "南施街","星塘街","钟南街"};
            string[] line2str = { "苏州北站", "大湾", "富元路", "蠡口", "徐图港", "阳澄湖中路", "陆慕", "平泷路东", "平河路", "苏州火车站", "山塘街", "石路", "广济南路", "三香广场", "劳动路", "胥江路", "桐泾公园", "友联", "盘蠡路", "新家桥", "石湖东路", "宝带桥南" };
            foreach (string stationname in line1str)
            {
                line1.Stations.Add(new Station() { Name = stationname, CameraNumber = 3 });
            }

            foreach (string stationname in line2str)
            {
                line2.Stations.Add(new Station() { Name = stationname, CameraNumber = 3 });
            }
            SubWayLines.Add(line1);
            SubWayLines.Add(line2);

        }

        public MonitorDataModel()
        {
            LoadPalettes();

            AddSeriesCommand = new DelegateCommand(x => AddSeries());

            InitSubWayData();


            FontSizes = new List<double>();
            FontSizes.Add(9.0);
            FontSizes.Add(11.0);
            FontSizes.Add(13.0);
            FontSizes.Add(18.0);
            SelectedFontSize = 11.0;

            DoughnutInnerRadiusRatios = new List<double>();
            DoughnutInnerRadiusRatios.Add(0.90);
            DoughnutInnerRadiusRatios.Add(0.75);
            DoughnutInnerRadiusRatios.Add(0.5);
            DoughnutInnerRadiusRatios.Add(0.25);
            DoughnutInnerRadiusRatios.Add(0.1);
            SelectedDoughnutInnerRadiusRatio = 0.75;

            SelectionBrushes = new List<string>();
            SelectionBrushes.Add("Orange");
            SelectionBrushes.Add("Red");
            SelectionBrushes.Add("Yellow");
            SelectionBrushes.Add("Blue");
            SelectionBrushes.Add("[NoColor]");
            SelectedBrush = SelectionBrushes.FirstOrDefault();

            Series = new ObservableCollection<SeriesData>();

            Errors = new ObservableCollection<TestClass>();
            Warnings = new ObservableCollection<TestClass>();
            FirstLine = new ObservableCollection<TestClass>();
            SecondLine = new ObservableCollection<TestClass>();
            ObservableCollection<TestClass> Infos = new ObservableCollection<TestClass>();

            Errors.Add(new TestClass() { Category = "Globalization", Number = 75 });
            Errors.Add(new TestClass() { Category = "Features", Number = 2 });
            Errors.Add(new TestClass() { Category = "ContentTypes", Number = 12 });
            Errors.Add(new TestClass() { Category = "Correctness", Number = 83 });
            //Errors.Add(new TestClass() { Category = "Naming", Number = 80 });
            Errors.Add(new TestClass() { Category = "Best Practices", Number = 29 });

            Warnings.Add(new TestClass() { Category = "Globalization", Number = 34 });
            Warnings.Add(new TestClass() { Category = "Features", Number = 23 });
            Warnings.Add(new TestClass() { Category = "ContentTypes", Number = 15 });
            Warnings.Add(new TestClass() { Category = "Correctness", Number = 66 });
            Warnings.Add(new TestClass() { Category = "Naming", Number = 56 });
            Warnings.Add(new TestClass() { Category = "Best Practices", Number = 34 });

            Infos.Add(new TestClass() { Category = "Globalization", Number = 14 });
            Infos.Add(new TestClass() { Category = "Features", Number = 3 });
            Infos.Add(new TestClass() { Category = "ContentTypes", Number = 55 });
            Infos.Add(new TestClass() { Category = "Correctness", Number = 26 });
            Infos.Add(new TestClass() { Category = "Naming", Number = 3 });
            Infos.Add(new TestClass() { Category = "Best Practices", Number = 8 });

            FirstLine.Add(new TestClass() { Category = "1号线", Number = 8 });
            SecondLine.Add(new TestClass() { Category = "2号线", Number = 78 });

            Camera = new List<PropertyNodeItem>();


            foreach (SubLine subline in SubWayLines)
            {
                PropertyNodeItem line = new PropertyNodeItem() { DisplayName = subline.Name };
                foreach (Station val in subline.Stations)
                {
                    PropertyNodeItem station = new PropertyNodeItem() { DisplayName = val.Name};
                    for (int i = 1; i < val.CameraNumber;i++ )
                    {
                        station.Children.Add(new PropertyNodeItem() { DisplayName = "摄像头"+i.ToString(), Icon = cameraimg });
                    }
                    line.Children.Add(station);
                }
                Camera.Add(line);
            }

            

            Series.Add(new SeriesData() { SeriesDisplayName = "Errors", Items = Errors });
            Series.Add(new SeriesData() { SeriesDisplayName = "Warnings", Items = Warnings });
            Series.Add(new SeriesData() { SeriesDisplayName = "Info", Items = Infos });
        }

        int newSeriesCounter = 1;
        private void AddSeries()
        {
            ObservableCollection<TestClass> data = new ObservableCollection<TestClass>();

            data.Add(new TestClass() { Category = "Globalization", Number = 5 });
            data.Add(new TestClass() { Category = "Features", Number = 10 });
            data.Add(new TestClass() { Category = "ContentTypes", Number = 15 });
            data.Add(new TestClass() { Category = "Correctness", Number = 20 });
            data.Add(new TestClass() { Category = "Naming", Number = 15 });
            data.Add(new TestClass() { Category = "Best Practices", Number = 10 });

            Series.Add(new SeriesData() { SeriesDisplayName = "New Series " + newSeriesCounter.ToString(), Items = data });

            newSeriesCounter++;
        }

        private void LoadPalettes()
        {
            Palettes = new Dictionary<string, De.TorstenMandelkow.MetroChart.ResourceDictionaryCollection>();
            Palettes.Add("Default", null);

            var resources = Application.Current.Resources.MergedDictionaries.ToList();
            foreach (var dict in resources)
            {
                foreach (var objkey in dict.Keys)
                {
                    if (dict[objkey] is De.TorstenMandelkow.MetroChart.ResourceDictionaryCollection)
                    {
                        Palettes.Add(objkey.ToString(), dict[objkey] as De.TorstenMandelkow.MetroChart.ResourceDictionaryCollection);
                    }
                }
            }

            SelectedPalette = Palettes.FirstOrDefault();
        }

        private bool isRowColumnSwitched = false;
        public bool IsRowColumnSwitched
        {
            get
            {
                return isRowColumnSwitched;
            }
            set
            {
                isRowColumnSwitched = value;
                NotifyPropertyChanged("IsRowColumnSwitched");
            }
        }

        public List<PropertyNodeItem> Camera
        {
            get;
            set;
        }
    
    


        private bool isLegendVisible = true;
        public bool IsLegendVisible
        {
            get
            {
                return isLegendVisible;
            }
            set
            {
                isLegendVisible = value;
                NotifyPropertyChanged("IsLegendVisible");
            }
        }

        private bool isTitleVisible = true;
        public bool IsTitleVisible
        {
            get
            {
                return isTitleVisible;
            }
            set
            {
                isTitleVisible = value;
                NotifyPropertyChanged("IsTitleVisible");
            }
        }

        private double fontSize = 11.0;
        public double SelectedFontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
                NotifyPropertyChanged("SelectedFontSize");
                NotifyPropertyChanged("SelectedFontSizeString");
            }
        }

        public string SelectedFontSizeString
        {
            get
            {
                return SelectedFontSize.ToString() + "px";
            }
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        public ObservableCollection<SeriesData> Series
        {
            get;
            set;
        }

        public ObservableCollection<TestClass> Errors
        {
            get;
            set;
        }

        public ObservableCollection<TestClass> Warnings
        {
            get;
            set;
        }

        public ObservableCollection<TestClass> FirstLine
        {
            get;
            set;
        }
        public ObservableCollection<TestClass> SecondLine
        {
            get;
            set;
        }


        public ObservableCollection<SubLine> SubWayLines
        {
            get;
            set;
        }


        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToolTipFormat
        {
            get
            {
                return "{0} in series '{2}' has value '{1}' ({3:P2})";
            }
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute,
                       Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }

}
