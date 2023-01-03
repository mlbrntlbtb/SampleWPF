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
    /// Interaction logic for ItemsControl.xaml
    /// </summary>
    public partial class ItemsControl : Window
    {
        public ItemsControl()
        {
            InitializeComponent();
            List<ToDo> list = new List<ToDo>();
            list.Add(new ToDo(){ Title="Wake up in the morning", Completion=100});
            list.Add(new ToDo() { Title = "Brush your teeth", Completion = 50 });
            list.Add(new ToDo() { Title = "Have breakfast", Completion = 75 });
            icTodoList.ItemsSource = list;
        }
    }
}
