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
using System.Windows.Shapes;
using MonitorPlatform.ViewModel;

namespace MonitorPlatform
{
    /// <summary>
    /// RightWindows.xaml 的交互逻辑
    /// </summary>
    public partial class RightWindows : Window
    {
        public RightWindows()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.DataContext = MonitorDataModel.Instance();
        }

        public void ShowTrafficImage()
        {
            infoborder.Visibility = Visibility.Visible;

        }

        public void CloseTrafficImage()
        {
            infoborder.Visibility = Visibility.Hidden;
        }

        private void btnClose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WindowManager.Instance.CloseTrafficImage();
        }
    }
}
