using System;
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
    /// Interaction logic for CalendarMultiDates.xaml
    /// </summary>
    public partial class CalendarMultiDates : Window
    {
        public CalendarMultiDates()
        {
            InitializeComponent();
            //clndrSamp.SelectedDate = DateTime.Now;
            clndrSamp.BlackoutDates.AddDatesInPast();
            clndrSamp.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
        }

        private void Month_Click(object sender, RoutedEventArgs e)
        {
            clndrSamp.DisplayMode = CalendarMode.Month;
        }

        private void Year_Click(object sender, RoutedEventArgs e)
        {
            clndrSamp.DisplayMode = CalendarMode.Year;
        }

        private void Decade_Click(object sender, RoutedEventArgs e)
        {
            clndrSamp.DisplayMode = CalendarMode.Decade;
        }
    }
}
