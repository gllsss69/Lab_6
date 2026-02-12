using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public interface IRefuelable
    {
        void Refill();
    }

    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public abstract void Move();
    }

    public class Car : Vehicle, IRefuelable
    {
        public Car(string brand, double speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Brand}: Їде по шосе зі швидкістю {Speed} км/год.");
        }

        public void Refill()
        {
            Console.WriteLine("   -> Заряджється електрикою.");
        }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(string brand, double speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Brand}: Їде по велодоріжці зі швидкістю {Speed} км/год.");
        }
    }

    public class Airplane : Vehicle, IRefuelable
    {
        public Airplane(string brand, double speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Brand}: Летить у повітрі зі швидкістю {Speed} км/год.");
        }

        public void Refill()
        {
            Console.WriteLine("   -> Заправка авіаційним паливом.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Vehicle> transportList = new List<Vehicle>
            {
                new Car("Tesla", 150),
                new Bicycle("Cube", 25),
                new Airplane("Boeing", 900),
            };

            foreach (var vehicle in transportList)
            {
                vehicle.Move(); 

                
                if (vehicle is IRefuelable refuelableVehicle)
                {
                    refuelableVehicle.Refill();
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


















