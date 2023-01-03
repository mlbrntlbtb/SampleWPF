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
    /// Interaction logic for DatePickerSample.xaml
    /// </summary>
    public partial class DatePickerSample : Window
    {
        public DatePickerSample()
        {
            InitializeComponent();
            dpSamp.SelectedDate = DateTime.Today;
            dpSamp.DisplayDate = DateTime.Today;
        }
    }
}
