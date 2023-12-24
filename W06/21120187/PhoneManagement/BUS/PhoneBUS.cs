using PhoneManagement.Config;
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

        public BindingList<Phone> getAllPhone()
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

        public int saveProduct(Phone phone)
        {
            int id = _phoneDAO.insertPhone(phone);

            return id;
        }

        public void deletePhone(Phone phone)
        {
            _phoneDAO.deletePhone(phone);
        }

        public void updatePhone(Phone phone)
        {
            _phoneDAO.updatePhone(phone);
        }

        // Compare method for sorting phones by name
        public int ComparePhonesByNameInCreasing(Phone x, Phone y)
        {

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            
        }

        public int ComparePhonesByNameDeCreasing(Phone x, Phone y)
        {

            return string.Compare(y.Name, x.Name, StringComparison.OrdinalIgnoreCase);

        }

        public int ComparePhonesByPriceIncreasing(Phone x, Phone y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            return x.Price.CompareTo(y.Price);
        }

        public int ComparePhonesByPriceDecreasing(Phone x, Phone y)
        {
            // Đảo ngược kết quả so sánh để có thứ tự giảm dần
            return ComparePhonesByPriceIncreasing(y, x);
        }

        // Merge Sort implementation
        public  List<Phone> MergeSort(List<Phone> list, Comparison<Phone> comparison)
        {
            if (list.Count <= 1)
                return list;

            int middle = list.Count / 2;
            List<Phone> left = new List<Phone>(list.GetRange(0, middle));
            List<Phone> right = new List<Phone>(list.GetRange(middle, list.Count - middle));

            left = MergeSort(left, comparison);
            right = MergeSort(right, comparison);

            return Merge(left, right, comparison);
        }

        private List<Phone> Merge(List<Phone> left, List<Phone> right, Comparison<Phone> comparison)
        {
            List<Phone> result = new List<Phone>(left.Count + right.Count);
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (comparison(left[leftIndex], right[rightIndex]) <= 0)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }

        public int getRowPerPage()
        {
            int _rowsPerPage;
            string rowsPerPageString = AppConfig.GetValue(AppConfig.NumberProductPerPage);
            if (int.TryParse(rowsPerPageString, out int parsedRowsPerPage))
            {
                _rowsPerPage = parsedRowsPerPage;
            }
            else
            {
                // Giá trị mặc định nếu không thể chuyển đổi sang int
                _rowsPerPage = 5;
            }

            return _rowsPerPage;
        }

    }
}
