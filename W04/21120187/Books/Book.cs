using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Book : INotifyPropertyChanged
    {

        public string Name {  get; set; }
        public string ImagePath { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
