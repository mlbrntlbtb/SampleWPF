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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleWPF.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlForButtonListBox.xaml
    /// </summary>
    public partial class UserControlForButtonListBox : UserControl
    {
        public UserControlForButtonListBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string TextToAdd { get; set; }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCont.Items.Add(TextToAdd);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCont.Items.RemoveAt(ListBoxCont.Items.Count - 1);
        }
    }
}
