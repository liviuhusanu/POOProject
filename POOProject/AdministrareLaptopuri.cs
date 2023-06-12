using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace POOProject
{
    public class AdministrareLaptop_txt
    {
        private string numeFisier = "Laptop.txt";
        
        public AdministrareLaptop_txt(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddLaptop(Laptop laptop)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                if (laptop.GetIdLap() != 0)
                {
                    streamWriterFisierText.WriteLine(laptop.ConversieLaSir_PentruFisier());
                }
            }
        }

        public Laptop[] GetLaptopuri(int nrLaptopuri)
        {
            Laptop[] laptopuri = new Laptop[nrLaptopuri];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrLaptopuri = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    laptopuri[nrLaptopuri++] = new Laptop(linieFisier);
                }
            }
            return laptopuri;
        }

        public IEnumerable<Laptop> Search(Func<Laptop, bool> predicate)
        {
            {
                Laptop[] laptopuri = GetLaptopuri(File.ReadAllLines(numeFisier).Length);
                foreach (Laptop laptop in laptopuri)
                {
                    if (predicate(laptop))
                    {
                        yield return laptop;
                    }
                }
            }
        }
    }
}