using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class Phone : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone() { return MemberwiseClone(); }
    }
}
