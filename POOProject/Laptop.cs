using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProject
{
    public class Laptop
    {
        // Proprietăți ale laptopului
        private const int ID = 0;
        private const int BRAND = 1;
        private const int MODEL = 2;
        private const int PRICE = 3;
        private const int CPU = 4;
        private const int SCREENSIZE = 5;
        private const int RAM = 6;
        private const int STORAGECAPACITY = 7;
        private const int GPU = 8;

        public int idLaptop;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Cpu { get; set; }
        public decimal ScreenSize { get; set; }
        public int Ram { get; set; }
        public int StorageCapacity { get; set; }
        public string Gpu { get; set; }
        public byte[] Image { get; set; }

        public Laptop() { }

        public override string ToString()
        {
            return $"ID: {idLaptop}\nBrand: {Brand}\nModel: {Model}\nPrice: {Price}\nCPU: {Cpu}\nScreen Size: {ScreenSize} inch\nRAM: {Ram} GB\nStorage Capacity: {StorageCapacity} GB\nGPU: {Gpu}\n";
        }

        public int GetIdLap()
        {
            return idLaptop;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idLaptop.ToString(),
                (Brand.Trim() ?? "\0"),
                (Model.Trim() ?? "\0"),
                (Price.ToString() ?? "\0"),
                (Cpu.Trim() ?? "\0"),
                (ScreenSize.ToString() ?? "\0"),
                (Ram.ToString() ?? "\0"),
                (StorageCapacity.ToString() ?? "\0"),
                (Gpu.Trim() ?? "\0"));

            return obiectPentruFisier;
        }

        public Laptop(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idLaptop = Convert.ToInt32(dateFisier[ID]);
            Brand = dateFisier[BRAND];
            Model = dateFisier[MODEL];
            Price = Convert.ToDecimal(dateFisier[PRICE]);
            Cpu = dateFisier[CPU];
            ScreenSize = Convert.ToDecimal(dateFisier[SCREENSIZE]);
            Ram = Convert.ToInt32(dateFisier[RAM]);
            StorageCapacity = Convert.ToInt32(dateFisier[STORAGECAPACITY]);
            Gpu = dateFisier[GPU];
        }

    }
}
