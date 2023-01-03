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

namespace SampleWPF.Controls
{
    /// <summary>
    /// Interaction logic for CheckBox.xaml
    /// </summary>
    public partial class CheckBox : Window
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void checkBoxAll_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool isChecked = (checkBoxAll.IsChecked == true);
            checkBox1.IsChecked = isChecked;
            checkBox2.IsChecked = isChecked;
            checkBox3.IsChecked = isChecked;
            checkBox4.IsChecked = isChecked;
            checkBox5.IsChecked = isChecked;
        }

        private void checkBoxItem_CheckedChanged(object sender, RoutedEventArgs e)
        {
            checkBoxAll.IsChecked = null;
            //bool cb1 = (checkBox1.IsChecked == true);
            //bool cb2 = (checkBox2.IsChecked == true);
            //bool cb3 = (checkBox3.IsChecked == true);
            //bool cb4 = (checkBox4.IsChecked == true);
            //bool cb5 = (checkBox5.IsChecked == true);

            //if (cb1 & cb2 & cb3 & cb4 & cb5)
            //    checkBoxAll.IsChecked = true;

            //if (!cb1 & !cb2 & !cb3 & !cb4 & !cb5)
            //    checkBoxAll.IsChecked = false;

            if (checkBox1.IsChecked == true && 
                checkBox2.IsChecked == true && 
                checkBox3.IsChecked == true && 
                checkBox4.IsChecked == true && 
                checkBox5.IsChecked == true)
            {
                checkBoxAll.IsChecked = true;
            }

            if (checkBox1.IsChecked == false &&
                checkBox2.IsChecked == false &&
                checkBox3.IsChecked == false &&
                checkBox4.IsChecked == false &&
                checkBox5.IsChecked == false)
            {
                checkBoxAll.IsChecked = false;
            }
        }
    }
}
