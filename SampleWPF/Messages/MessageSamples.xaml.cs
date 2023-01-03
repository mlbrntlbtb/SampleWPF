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

namespace SampleWPF.Messages
{
    /// <summary>
    /// Interaction logic for MessageSamples.xaml
    /// </summary>
    public partial class MessageSamples : Window
    {
        public MessageSamples()
        {
            InitializeComponent();
        }

        private void MessageTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a sample message with Title.", "Message Title");
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a sample message with Buttons.", "Message Title", MessageBoxButton.OKCancel);
        }

        private void MessageIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a sample message with Icon.", "Message Title", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void MessageOption_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Is this is a sample question?", "Message Title", MessageBoxButton.YesNoCancel);
            switch (res)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("You have selected YES", "Message Title");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("You have selected NO", "Message Title");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("You have selected CANCEL", "Message Title");
                    break;
            }
        }
    }
}
