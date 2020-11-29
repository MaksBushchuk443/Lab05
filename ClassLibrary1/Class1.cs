using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string MarkaCar;
        public string ModelCar;
        public string BodyTipe;
        public double EngineСapacity;
        public int Price;
        public string ManufacturerCountry;
        public bool Electro;
        public static void Avto() {
            Console.WriteLine("Введіть марку автомобіля: ");
            string sMarkaCar = Console.ReadLine();
            Console.WriteLine("Введiть модель автомобіля: ");
            string sModelCar = Console.ReadLine();
            Console.WriteLine("Введiть тип кузова: ");
            string sBodyTipe = Console.ReadLine();
            Console.WriteLine("Введiть Об'єм двигуна: ");
            string sEngineCapacity = Console.ReadLine();
            Console.WriteLine("Введiть ціну автомобіля в грн: ");
            string sPrice = Console.ReadLine();
            Console.WriteLine("Введiть країну виробництва: ");
            string sManufacturerCountry = Console.ReadLine();
            Console.Write("Це електомавтомобіль?(t - так , n - ні) ");
            ConsoleKeyInfo keyElectro = Console.ReadKey();

            Class1 OurCar = new Class1
            {
                MarkaCar = sMarkaCar,
                ModelCar = sModelCar,
                BodyTipe = sBodyTipe,
                EngineСapacity = double.Parse(sEngineCapacity),
                Price = int.Parse(sPrice),
                ManufacturerCountry = sManufacturerCountry,
                Electro = keyElectro.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Марка автомобіля: " + OurCar.MarkaCar);
            Console.WriteLine("Його модель: " + OurCar.ModelCar);
            Console.WriteLine("Тип кузову: " + OurCar.BodyTipe);
            Console.WriteLine("Об'єм двигуна: " + OurCar.EngineСapacity);
            Console.WriteLine("Ціна автомобіля: " + OurCar.Price + "грн.");
            Console.WriteLine("Країна виробник: " + OurCar.ManufacturerCountry);
            Console.WriteLine(OurCar.Electro ? "Це електро автомобіль" : "Це не електро");
            Console.ReadKey();

        }
    }
}
