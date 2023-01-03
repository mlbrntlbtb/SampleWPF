using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for DataBindingINotifyPropertyChanged.xaml
    /// </summary>
    public partial class DataBindingINotifyPropertyChanged : Window
    {
        //private List<Users> users = new List<Users>(); 
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public DataBindingINotifyPropertyChanged()
        {
            InitializeComponent();

            users.Add(new User() { Name = "Melbourne Talibutab", Address="Makati"});
            users.Add(new User() { Name = "Venice Talibutab", Address="Taguig" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New Talibutab", Address="Pasig" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if(lbUsers.SelectedItem != null)
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

        //public class Users
        //{
        //    public string Name { get; set; }
        //}

        public class User : INotifyPropertyChanged 
       {
            private string name;
            public string Name { 
                get 
                { 
                    return name;
                }
                set
                {
                    if(this.name != value)
                    {
                        this.name = value;
                        this.NotifyPropertyChanged("Name");
                    }
                }
            }

            private string address;
            public string Address 
            {
                get
                {
                    return address;
                }
                set
                {
                    if(this.address != value)
                    {
                        this.address = value;
                        this.NotifyPropertyChanged("Address");
                    }
                }
            }


            public event PropertyChangedEventHandler PropertyChanged;

            public void NotifyPropertyChanged(string propName)
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
                }
            }

       }
       
    }
}
