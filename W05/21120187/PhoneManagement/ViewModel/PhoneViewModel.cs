using PhoneManagement.BUS;
using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.ViewModel
{
    internal class PhoneViewModel : INotifyPropertyChanged
    {
        PhoneBUS _phoneBUS = new PhoneBUS();
        public PhoneViewModel() { 
            LoadList();
            
        }

        
        public BindingList<PhoneDTO> Phones { get; set; } = new BindingList<PhoneDTO>();

        public void LoadList()
        {
            Phones = _phoneBUS.getAllPhone();
        }

        public void addPhone(PhoneDTO phone)
        {
            _phoneBUS.saveProduct(phone);
        }

        public void deletePhone(PhoneDTO phone)
        {
            _phoneBUS.deletePhone(phone);
        }

        public void updatePhone(PhoneDTO phone)
        {
            _phoneBUS.updatePhone(phone);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
