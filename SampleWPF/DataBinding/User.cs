using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.DataBinding
{
    public class User : ObservableObject
    {
        private string name;
        public string Name
        {
            get
            {
                if(String.IsNullOrEmpty(name))
                {
                    return "Unknown";
                }
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string address;
        public string Address
        {
            get
            {
                if (String.IsNullOrEmpty(address))
                {
                    return "Unknown";
                }
                return address;
            }
            set
            {
                address = value;
                NotifyPropertyChanged("Address");
            }
        }

        private string gender;
        public string Gender
        {
            get
            {
                if (String.IsNullOrEmpty(gender))
                {
                    return "Unknown";
                }
                return gender;
            }
            set
            {
                gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        private string contact;
        public string Contact
        {
            get
            {
                if (String.IsNullOrEmpty(gender))
                {
                    return "1234567890";
                }
                return contact;
            }
            set
            {
                gender = value;
                NotifyPropertyChanged("Contact");
            }
        }
    }
}
