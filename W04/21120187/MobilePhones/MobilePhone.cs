using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    class MobilePhone : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
