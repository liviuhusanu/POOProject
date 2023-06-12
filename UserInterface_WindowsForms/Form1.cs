using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOProject;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace UserInterface_WindowsForms
{
    public partial class Form1 : Form
    {
        private const int AnimationStep = 10;
        private const int AnimationSpeed = 10;

        private Button currentButton;
        private Form activeForm;

        AdministrareLaptop_txt admin = new AdministrareLaptop_txt("C:\\Users\\Liviu\\source\\repos\\POOProject\\POOProject\\bin\\Debug\\Laptop.txt");
        int nrLap = File.ReadAllLines("C:\\Users\\Liviu\\source\\repos\\POOProject\\POOProject\\bin\\Debug\\Laptop.txt").Length;
        IEnumerable<Laptop> searches = new List<Laptop>();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price4))
            {
                Filtre.filters.Remove(Filtre.price4);
            }
            else
            {
                Filtre.filters.Add(Filtre.price4);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price6))
            {
                Filtre.filters.Remove(Filtre.price6);
            }
            else
            {
                Filtre.filters.Add(Filtre.price6);
            }
        }

        private void Under1000Box_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price1))
            {
                Filtre.filters.Remove(Filtre.price1);
            }
            else
            {
                Filtre.filters.Add(Filtre.price1);
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price2))
            {
                Filtre.filters.Remove(Filtre.price2);
            }
            else
            {
                Filtre.filters.Add(Filtre.price2);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price3))
            {
                Filtre.filters.Remove(Filtre.price3);
            }
            else
            {
                Filtre.filters.Add(Filtre.price3);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand1))
            {
                Filtre.selectedBrands.Remove(Filtre.brand1);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand1);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price7))
            {
                Filtre.filters.Remove(Filtre.price7);
            }
            else
            {
                Filtre.filters.Add(Filtre.price7);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.price5))
            {
                Filtre.filters.Remove(Filtre.price5);
            }
            else
            {
                Filtre.filters.Add(Filtre.price5);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand2))
            {
                Filtre.selectedBrands.Remove(Filtre.brand2);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand2);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand3))
            {
                Filtre.selectedBrands.Remove(Filtre.brand3);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand3);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand4))
            {
                Filtre.selectedBrands.Remove(Filtre.brand4);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand4);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand5))
            {
                Filtre.selectedBrands.Remove(Filtre.brand5);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand5);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand6))
            {
                Filtre.selectedBrands.Remove(Filtre.brand6);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand6);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedBrands.Contains(Filtre.brand7))
            {
                Filtre.selectedBrands.Remove(Filtre.brand7);
            }
            else
            {
                Filtre.selectedBrands.Add(Filtre.brand7);
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu1))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu1);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu1);
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu2))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu2);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu2);
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu3))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu3);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu3);
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu4))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu4);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu4);
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu5))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu5);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu5);
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu6))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu6);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu6);
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu7))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu7);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu7);
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu8))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu8);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu8);
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu9))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu9);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu9);
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu10))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu10);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu10);
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu11))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu11);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu11);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu12))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu12);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu12);
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu13))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu13);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu13);
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu14))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu14);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu14);
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu15))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu15);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu15);
            }
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu16))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu16);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu16);
            }
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedCpus.Contains(Filtre.cpu17))
            {
                Filtre.selectedCpus.Remove(Filtre.cpu17);
            }
            else
            {
                Filtre.selectedCpus.Add(Filtre.cpu17);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.ram1))
            {
                Filtre.filters.Remove(Filtre.ram1);
            }
            else
            {
                Filtre.filters.Add(Filtre.ram1);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.ram2))
            {
                Filtre.filters.Remove(Filtre.ram2);
            }
            else
            {
                Filtre.filters.Add(Filtre.ram2);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.ram3))
            {
                Filtre.filters.Remove(Filtre.ram3);
            }
            else
            {
                Filtre.filters.Add(Filtre.ram3);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.ram4))
            {
                Filtre.filters.Remove(Filtre.ram4);
            }
            else
            {
                Filtre.filters.Add(Filtre.ram4);
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.screen1))
            {
                Filtre.filters.Remove(Filtre.screen1);
            }
            else
            {
                Filtre.filters.Add(Filtre.screen1);
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.screen2))
            {
                Filtre.filters.Remove(Filtre.screen2);
            }
            else
            {
                Filtre.filters.Add(Filtre.screen2);
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.screen3))
            {
                Filtre.filters.Remove(Filtre.screen3);
            }
            else
            {
                Filtre.filters.Add(Filtre.screen3);
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.filters.Contains(Filtre.screen4))
            {
                Filtre.filters.Remove(Filtre.screen4);
            }
            else
            {
                Filtre.filters.Add(Filtre.screen4);
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedGpus.Contains(Filtre.gpu1))
            {
                Filtre.selectedGpus.Remove(Filtre.gpu1);
            }
            else
            {
                Filtre.selectedGpus.Add(Filtre.gpu1);
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedGpus.Contains(Filtre.gpu2))
            {
                Filtre.selectedGpus.Remove(Filtre.gpu2);
            }
            else
            {
                Filtre.selectedGpus.Add(Filtre.gpu2);
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.selectedGpus.Contains(Filtre.gpu3))
            {
                Filtre.selectedGpus.Remove(Filtre.gpu3);
            }
            else
            {
                Filtre.selectedGpus.Add(Filtre.gpu3);
            }
        }
    }
}
