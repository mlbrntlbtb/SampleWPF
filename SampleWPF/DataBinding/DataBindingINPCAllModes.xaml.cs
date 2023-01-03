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
    /// Interaction logic for DataBindingINPCMultiFields.xaml
    /// </summary>
    public partial class DataBindingINPCAllModes : Window
    {
        private User user = new User();
        public DataBindingINPCAllModes()
        {
            InitializeComponent();
            DataContext = user;
        }
    }
}
