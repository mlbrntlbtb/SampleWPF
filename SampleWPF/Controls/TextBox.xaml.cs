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
    /// Interaction logic for TextBox.xaml
    /// </summary>
    public partial class TextBox : Window
    {
        public TextBox()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            textBoxSamp.Text = "Selection start: " + textBoxSender.SelectionStart + Environment.NewLine;
            textBoxSamp.Text += "Selection is: " + textBoxSender.SelectionLength + " characters long." + Environment.NewLine;
            textBoxSamp.Text += "Selected text: " + textBoxSender.SelectedText + Environment.NewLine;
        }
    }
}
