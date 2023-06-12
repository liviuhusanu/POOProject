using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOProject;

namespace UserInterface_WindowsForms
{
    internal class Filtre
    {

        public static List<string> filters = new List<string>();
        public static List<string> selectedBrands = new List<string>();
        public static List<string> selectedCpus = new List<string>();
        public static List<string> selectedGpus = new List<string>();

        public static string price1 = "price < 1000\n";
        public static string price2 = "price >= 1000 AND price <= 1500\n";
        public static string price3 = "price >= 1500 AND price <= 2000\n";
        public static string price4 = "price >= 2000 AND price <= 3000\n";
        public static string price5 = "price >= 3000 AND price <= 4000\n";
        public static string price6 = "price >= 4000 AND price <= 5000\n";
        public static string price7 = "price > 5000\n";

        public static string brand1 = "ASUS";
        public static string brand2 = "Lenovo";
        public static string brand3 = "HP";
        public static string brand4 = "Acer";
        public static string brand5 = "Dell";
        public static string brand6 = "MSI";
        public static string brand7 = "Apple";

        public static string cpu1 = "Celeron";
        public static string cpu2 = "Pentium";
        public static string cpu3 = "I3";
        public static string cpu4 = "I5";
        public static string cpu5 = "I7";
        public static string cpu6 = "I9";
        public static string cpu7 = "Athlon";
        public static string cpu8 = "Ryzen 3";
        public static string cpu9 = "Ryzen 5";
        public static string cpu10 = "Ryzen 7";
        public static string cpu11 = "Ryzen 9";
        public static string cpu12 = "M1";
        public static string cpu13 = "M1 Pro";
        public static string cpu14 = "M1 Max";
        public static string cpu15 = "M2";
        public static string cpu16 = "M2 Pro";
        public static string cpu17 = "M2 Max";

        public static string ram1 = "ram = 4\n";
        public static string ram2 = "ram >= 6 AND ram <= 8\n";
        public static string ram3 = "ram >= 12 AND ram <= 16\n";
        public static string ram4 = "ram > \n";

        public static string screen1 = "screen_size >= 13 AND screen_size <= 13.9\n";
        public static string screen2 = "screen_size >= 14 AND screen_size <= 14.9\n";
        public static string screen3 = "screen_size >= 15 AND screen_size <= 15.6\n";
        public static string screen4 = "screen_size > 15.6\n";

        public static string gpu1 = "RTX";
        public static string gpu2 = "GTX";
        public static string gpu3 = "MX";
    }
}
