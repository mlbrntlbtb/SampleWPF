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

namespace SampleWPF.Lists
{
    /// <summary>
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        public ListBox()
        {
            InitializeComponent();
            List<ToDo> list = new List<ToDo>();
            list.Add(new ToDo() { Title = "Wake up in the morning", Completion = 100 });
            list.Add(new ToDo() { Title = "Brush your teeth", Completion = 50 });
            list.Add(new ToDo() { Title = "Have breakfast", Completion = 75 });
            lbTodoList.ItemsSource = list;
        }

        private void lbTodoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbTodoList.SelectedItem != null)
                this.Title = lbTodoList.SelectedItem.ToString();
        }

        private void ShowSelected_Click(object sender, RoutedEventArgs e)
        {
            if(lbTodoList.SelectedItem != null)
            {
                string selectedItems = "";
                foreach(var item in lbTodoList.SelectedItems)
                {
                    selectedItems += (item as ToDo).Title + "\n";
                }
                MessageBox.Show("You have selected [" + selectedItems + "].", "Selected Item", MessageBoxButton.OK);
            }
        }

        private void SelectFirst_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
            {
                lbTodoList.SelectedIndex = 0;
            }
        }

        private void SelectNext_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
            {
                lbTodoList.SelectedIndex += 1;
            }
        }

        private void SelectLast_Click(object sender, RoutedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
            {
                lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
            }
        }

        private void SelectText_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lbTodoList.Items)
            {
                if((item as ToDo).Title.ToLower().Contains("brush"))
                    lbTodoList.SelectedItem = item;
            }
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lbTodoList.Items)
                lbTodoList.SelectedItems.Add(item);
        }
    }
}
