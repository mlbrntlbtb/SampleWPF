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

namespace SampleWPF.DataBinding
{
    /// <summary>
    /// Interaction logic for DataBindingCodeBehind.xaml
    /// </summary>
    public partial class DataBindingCodeBehind : Window
    {
        public DataBindingCodeBehind()
        {
            InitializeComponent();
            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            lblValue.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
