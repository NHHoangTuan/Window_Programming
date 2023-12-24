using Microsoft.Data.SqlClient;
using PhoneManagement.DTO;
using PhoneManagement.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    internal class PhoneDAO : SQLData
    {
        public BindingList<Phone> getAllPhone()
        {
            var sqlquery = "select * from Phone";
            var command = new SqlCommand(sqlquery, Connection);
            var reader = command.ExecuteReader();

            BindingList<Phone> list = new BindingList<Phone>();
            while (reader.Read())
            {
                var ID = (int)reader["PhoneID"];
                var Name = (string)reader["Name"];
                var ImagePath = (string)reader["ImagePath"];
                var Manufacturer = (string)reader["Manufacturer"];
                var Price = (int)reader["Price"];


                Phone phone = new Phone()
                {
                    ID = ID,
                    Name = Name,
                    ImagePath = ImagePath,
                    Manufacturer = Manufacturer,
                    Price = Price,
                };

                list.Add(phone);
            }
            reader.Close();
            return list;
        }


        public int insertPhone(Phone phone)
        {
            // insert to SQL
            var sqlquery = "insert into Phone (Name, Manufacturer, Price) values (@Name, @Manufacturer, @Price)";
            var command = new SqlCommand(sqlquery, Connection);

            command.Parameters.AddWithValue("@Name", phone.Name);
            command.Parameters.AddWithValue("@Manufacturer", phone.Manufacturer);
            command.Parameters.AddWithValue("@Price", phone.Price);

            command.ExecuteNonQuery();

            // select SQL
            int id = -1;
            string sql1 = "SELECT TOP 1 PhoneID FROM Phone ORDER BY PhoneID DESC ";

            var command1 = new SqlCommand(sql1, Connection);

            var reader = command1.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["PhoneID"];
            }

            reader.Close();

            return id;
        }


        public void updateImage(int id, string key)
        {
            // update SQL
            string sql = $"""
                update Phone 
                set ImagePath = 'Images/{key}.png'
                where PhoneID = {id}
                """;

            var command = new SqlCommand(sql, Connection);

            command.ExecuteNonQuery();
        }

        public void deletePhone(Phone phone)
        {
            var query = "delete from Phone where PhoneID = @ID";
            var command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ID", phone.ID);
            command.ExecuteNonQuery();
        }

        public void updatePhone(Phone phone)
        {
            var query = "update Phone set Name = @Name, Manufacturer = @Manufacturer, Price = @Price " +
                "where PhoneID = @ID";
            var command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Name", phone.Name);
            command.Parameters.AddWithValue("@Manufacturer", phone.Manufacturer);
            command.Parameters.AddWithValue("@Price", phone.Price);
            command.Parameters.AddWithValue("@ID", phone.ID);

            command.ExecuteNonQuery();

        }
    }
}
