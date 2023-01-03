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
    /// Interaction logic for DataBindingUpdateSourceTrigger.xaml
    /// </summary>
    public partial class DataBindingUpdateSourceTrigger : Window
    {
        public DataBindingUpdateSourceTrigger()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression bindingExpression = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            bindingExpression.UpdateSource();
        }
    }
}
