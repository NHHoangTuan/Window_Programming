using PhoneManagement.DAO;
using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.BUS
{
    internal class PhoneBUS
    {
        private PhoneDAO _phoneDAO;

        public PhoneBUS() 
        { 
            _phoneDAO = new PhoneDAO();
            _phoneDAO.Connect();
        }

        public BindingList<PhoneDTO> getAllPhone()
        {
            return _phoneDAO.getAllPhone();
        }


        public string uploadImage(FileInfo selectedImage, int id, string key)
        {
            _phoneDAO.updateImage(id, key);

            var folder = AppDomain.CurrentDomain.BaseDirectory;

            var filePath = $"{folder}/Images/{key}.png";
            var relativePath = $"Images/{key}.png";

            File.Copy(selectedImage.FullName, filePath);

            return relativePath;
        }

        public int saveProduct(PhoneDTO phone)
        {
            int id = _phoneDAO.insertPhone(phone);

            return id;
        }

        public void deletePhone(PhoneDTO phone)
        {
            _phoneDAO.deletePhone(phone);
        }

        public void updatePhone(PhoneDTO phone)
        {
           _phoneDAO.updatePhone(phone);
            
        }

        /*public int getID (PhoneDTO phone)
        {
            return _phoneDAO.getID(phone);
        }*/
    }
}
