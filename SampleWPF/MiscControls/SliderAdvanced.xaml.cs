﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SampleWPF.MiscControls
{
    /// <summary>
    /// Interaction logic for SliderAdvanced.xaml
    /// </summary>
    public partial class SliderAdvanced : Window
    {
        public SliderAdvanced()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            this.Background = new SolidColorBrush(color);
        }
    }
}
