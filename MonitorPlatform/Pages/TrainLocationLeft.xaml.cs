﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using MonitorPlatform.ViewModel;

namespace MonitorPlatform.Pages
{
    /// <summary>
    /// TrainLocationLeft.xaml 的交互逻辑
    /// </summary>
    public partial class TrainLocationLeft : Page
    {
        public TrainLocationLeft()
        {
            InitializeComponent();
            this.SizeChanged += new SizeChangedEventHandler(TrainLocationLeft_SizeChanged);
        }

        void TrainLocationLeft_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ReCalculateAll();
        }

        void ReCalculateAll()
        {
            double widthfactor = firstlineup.ActualWidth / 24;
            if (this.DataContext != null)
            {
                MonitorDataModel data = this.DataContext as MonitorDataModel;
                firstlineup.Children.Clear();
                firstlinedown.Children.Clear();
                secondlineup.Children.Clear();
                secondlinedown.Children.Clear();

                foreach (Train train in data.SubWayLines[0].Trains)
                {
                    Image image = new Image();
                    image.Cursor = Cursors.Hand;
                    image.Width = 10;
                    image.Tag = train;
                    image.Height = 10;
                    image.Stretch = Stretch.Fill;
                    image.Source = new BitmapImage(new Uri("/MonitorPlatform;component/Resource/Car_Normal.png", UriKind.RelativeOrAbsolute));
                    image.MouseUp += new MouseButtonEventHandler(image_MouseUp);
                    double orgin_car_posX = widthfactor * (train.Location - 0.5) - image.Width/2;  //first(train.Location);
                    if (train.IsDown)
                    {
                        firstlinedown.Children.Add(image);
                    }
                    else
                    {
                        firstlineup.Children.Add(image);
                    }
                    Canvas.SetTop(image, 5);
                    Canvas.SetLeft(image, orgin_car_posX);
                  
                }

                foreach (Train train in data.SubWayLines[1].Trains)
                {
                    Image image = new Image();
                    image.Cursor = Cursors.Hand;
                    image.Tag = train;
                    image.Width = 10;
                    image.Height = 10;
                    image.Stretch = Stretch.Fill;
                    image.MouseUp += new MouseButtonEventHandler(image_MouseUp);
                    image.Source = new BitmapImage(new Uri("/MonitorPlatform;component/Resource/Car_Normal.png", UriKind.RelativeOrAbsolute));

                    double orgin_car_posX = widthfactor * (train.Location - 0.5) - image.Width / 2;  //first(train.Location);
                    if (train.IsDown)
                    {
                        secondlinedown.Children.Add(image);
                    }
                    else
                    {
                        secondlineup.Children.Add(image);
                    }
                    Canvas.SetTop(image, 5);
                    Canvas.SetLeft(image, orgin_car_posX);
                }
            }
        }

        void image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Train trainin = (sender as Image).Tag as Train;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ReCalculateAll();
        }

        void chart_MouseEnter(object sender, MouseEventArgs e)
        {
            Control c = (sender as Control);
            Station stat = (c.DataContext as Station);

            string st = (c.Parent as Grid).Tag as string;
            string []lines = st.Split(',');
            if (lines[0] == "1")
            {
                LineName.Text = "1号线";
                if (lines[1] == "1")
                {
                    Direction.Text = "钟南街-木渎";
                }
                else
                {
                    Direction.Text = "木渎-钟南街";
                }
            }
            else
            {
                LineName.Text = "2号线";
                if (lines[1] == "1")
                {
                    Direction.Text = "苏州北站-宝带桥南";
                }
                else
                {
                    Direction.Text = "宝带桥南-苏州北站";
                }
            }
          
            StationName.Text = stat.Name;
            traininfo.IsOpen = true;
            traininfo.PlacementTarget = sender as UIElement;
             
           
        }
        void chart_MouseLeave(object sender, MouseEventArgs e)
        {
            traininfo.IsOpen = false;
            traininfo.PlacementTarget = sender as UIElement;
             
            //pointTooltip.IsOpen = false;
        }
    }
}
