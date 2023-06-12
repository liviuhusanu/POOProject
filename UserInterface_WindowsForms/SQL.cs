using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POOProject;

using static System.Net.Mime.MediaTypeNames;

namespace UserInterface_WindowsForms
{
    
    internal class SQLConnector
    {
        private string connectionStr = "";
        private List<Laptop> laptopuri = new List<Laptop>();
        private string c = "SELECT * FROM laptop WHERE ";
        public List<Laptop> ExtractLaptop(string connectionStr, string query)
        {
            List<Laptop> laptopList = new List<Laptop>();

            if (string.IsNullOrEmpty(query))
            {
                c = "SELECT * FROM laptop";
            }
                using (MySqlConnection connection = new MySqlConnection(connectionStr))
            {
                    connection.Open();
                    File.WriteAllText("C:\\Users\\Liviu\\source\\repos\\ProiectPIU\\WindowsFormsApp1\\bin\\Debug\\Test.txt", c+query);
                    MySqlCommand command = new MySqlCommand(c + query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Laptop laptop = new Laptop();
                            laptop.Brand = reader.GetString("brand");
                            laptop.Model = reader.GetString("model");
                            laptop.Price = reader.GetDecimal("price");
                            laptop.Cpu = reader.GetString("cpu");
                            laptop.Gpu = reader.GetString("gpu");
                            laptop.ScreenSize = reader.GetDecimal("screen_size");
                            laptop.StorageCapacity = reader.GetInt32("storage");
                            laptop.Ram = reader.GetInt32("ram");
                            laptop.Image = (byte[])reader["image"];
                            laptopList.Add(laptop);
                        }
                    }
                }
            
                return laptopList;
        }
    }
}
