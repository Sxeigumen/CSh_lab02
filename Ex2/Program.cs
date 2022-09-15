using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        public class Vehicle
        {

            public Vehicle()
            {
                price = 0;
                speed = 0;
                release_year = 2000;
            }

            public Vehicle(int nPrice, int nSpeed, int nYear)
            {
                price = nPrice;
                speed = nSpeed;
                release_year = nYear;
            }
            public virtual void VehicleInfoPrint()
            {
                Console.WriteLine($"Цена транспортного средства - {price} руб.");
                Console.WriteLine($"Скорость транспортного средства - {speed} км/ч");
                Console.WriteLine($"Год выпуска транспортного средства - {release_year} г.");

            }
            private int price;
            private int speed;
            private int release_year;
        }

        public class Plane : Vehicle
        {
            public Plane(int nPrice, int nSpeed, int nYear, int nHeight, int nPassengers) : base(nPrice, nSpeed, nYear)  
            {
                height = nHeight;
                passengers_num = nPassengers;
            }

            public override void VehicleInfoPrint()
            {
                base.VehicleInfoPrint();
                Console.WriteLine($"Максимальная высота полёта самолёта - {height} м.");
                Console.WriteLine($"Количество пассажиров самолёта - {passengers_num} чел.");
            }

            private int height;
            private int passengers_num;
        }

        public class Ship : Vehicle
        {
            public Ship(int nPrice, int nSpeed, int nYear, string port, int nPassengers) : base(nPrice, nSpeed, nYear)
            {
                home_port = port;
                passengers_num = nPassengers;
            }

            public override void VehicleInfoPrint()
            {
                base.VehicleInfoPrint();
                Console.WriteLine($"Порт приписки корабля - {home_port}");
                Console.WriteLine($"Количество пассажиров корабля - {passengers_num} чел.");
            }

            private string home_port;
            private int passengers_num;
        }

        public class Car : Vehicle
        {
            public Car(int nPrice, int nSpeed, int nYear, string brand, int nPassengers, bool tune, string nCondition) : base(nPrice, nSpeed, nYear)
            {
                brand_name = brand;
                passengers_num = nPassengers;
                tuning = tune;
                condition = nCondition;
            }

            public override void VehicleInfoPrint()
            {
                base.VehicleInfoPrint();
                Console.WriteLine($"Марка автомобиля - {brand_name}");
                Console.WriteLine($"Количество пассажиров автомобиля - {passengers_num} чел.");
                Console.WriteLine($"Наличие тюнинга - {tuning}");
                Console.WriteLine($"Состояние - {condition}");
            }

            private string brand_name;
            private int passengers_num;
            private bool tuning;
            private string condition;
        }
        static void Main(string[] args)
        {
            Plane Cessna = new Plane(23000000, 226, 2015, 4100, 4);
            Ship Eclips = new Ship(2100000000, 46, 2009, "Hamilton", 70);
            Car Zhiguli = new Car(100000, 150, 2000, "Жигули", 5, true, "Ездит и хорошо");

            Console.WriteLine("Cessna 172");
            Cessna.VehicleInfoPrint();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Яхта Eclipse");
            Eclips.VehicleInfoPrint();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Жигули");
            Zhiguli.VehicleInfoPrint();
            Console.WriteLine("\n\n\n");
        }
    }
}
