using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POOProject
{
    class Program
    {
        static void Main()
        {
            Laptop laptop = new Laptop();
            string numeFisier = "Laptop.txt";
            AdministrareLaptop_txt adminLaptop = new AdministrareLaptop_txt(numeFisier);
            int nrLap = File.ReadAllLines(numeFisier).Length;

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii dispozitiv.");
                Console.WriteLine("A. Afisare dispozitiv.");
                Console.WriteLine("F. Afisare laptopuri din fisier.");
                Console.WriteLine("S. Salvare laptop in fisier.");
                Console.WriteLine("X. Inchidere program.");
                Console.WriteLine("C. Cauta laptop.");
                Console.WriteLine("Alegeti o optiune:");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int idLap = nrLap + 1;
                        //Laptop laptop = new Laptop();
                        Console.WriteLine("INTRODU DATE LAPTOP #{0}\n", idLap);
                        Console.WriteLine("BRAND: ");
                        laptop.Brand = Console.ReadLine();
                        Console.WriteLine("MODEL: ");
                        laptop.Model = Console.ReadLine();
                        Console.WriteLine("PRET(LEI): ");
                        laptop.Price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("CPU: ");
                        laptop.Cpu = Console.ReadLine();
                        Console.WriteLine("DIMENSIUNE DISPLAY(INCH): ");
                        laptop.ScreenSize = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("RAM(GB): ");
                        laptop.Ram = int.Parse(Console.ReadLine());
                        Console.WriteLine("MEMORIA INTERNA(GB): ");
                        laptop.StorageCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("GPU: ");
                        laptop.Gpu = Console.ReadLine();
                        nrLap++;
                        laptop.idLaptop = idLap;
                        Console.WriteLine(laptop);
                        adminLaptop.AddLaptop(laptop);
                        
                        break;

                    case "A":
                        Console.WriteLine(laptop);

                        break;

                    case "F":
                        Laptop[] laptopuri = adminLaptop.GetLaptopuri(nrLap);
                        foreach (Laptop laptop1 in laptopuri)
                        {
                            Console.WriteLine(laptop1);
                        }

                        break;

                    case "S":
                        adminLaptop.AddLaptop(laptop);
                        adminLaptop.AddLaptop(laptop);

                        break;

                    case "C":
                        Laptop filtru = new Laptop();


                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}
