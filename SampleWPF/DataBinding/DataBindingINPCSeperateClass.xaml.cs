using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SampleWPF.DataBinding;

namespace SampleWPF.DataBinding
{
    /// <summary>
    /// Interaction logic for DataBindingINPCSeperateClass.xaml
    /// </summary>
    public partial class DataBindingINPCSeperateClass : Window
    {

        private ObservableCollection<User> users = new ObservableCollection<User>();

        public DataBindingINPCSeperateClass()
        {
            InitializeComponent();

            users.Add(new User() { Name = "Melbourne Talibutab", Address = "Makati" });
            users.Add(new User() { Name = "Venice Talibutab", Address = "Taguig" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New Talibutab", Address = "Pasig" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                (lbUsers.SelectedItem as User).Name = "Random Talibutab";
                (lbUsers.SelectedItem as User).Address = "Mandaluyong";
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                users.Remove(lbUsers.SelectedItem as User);
            }
        }

        private void btnChangeDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.DisplayMemberPath == "Name")
                lbUsers.DisplayMemberPath = "Address";
            else if (lbUsers.DisplayMemberPath == "Address")
                lbUsers.DisplayMemberPath = "Name";

            lbUsers.Items.Refresh();
        }
    }
}
