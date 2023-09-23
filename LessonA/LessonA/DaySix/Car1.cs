using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    public class Car
    {
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType Fuel { get; set; }
        public Wheel[] Wheels { get; } = new Wheel[4];
        public Engine carEngine { get; } = new Engine();
        public Car(string registrationNo, string model, FuelType fuel)
        {
            RegistrationNo = registrationNo;
            Model = model;
            Fuel = fuel;



            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
        }
        public enum FuelType
        {
            Petrol,
            Diesel,
            Electric,
            Hybrid
        }
        public class Wheel
        {

        }
        public class Engine
        {

        }
    }
    class enumcars
    {
        public static void details()
        {
            Car myCar = new Car("123", "RR", Car.FuelType.Hybrid);
            Console.WriteLine($"Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Fuel Type: {myCar.Fuel}");
            foreach (var wheel in myCar.Wheels)
            {
                Console.WriteLine($"Wheel: {wheel}");
            }

        }
    }
}
