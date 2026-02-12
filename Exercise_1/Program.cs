namespace Exercise_1
{
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
 


    public class Car : Vehicle
    {
        public Car(string brand, double speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Brand}: Їде по шосе зі швидкістю {Speed} км/год.");
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

    
    public class Airplane : Vehicle
    {
        public Airplane(string brand, double speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Brand}: Летить у повітрі зі швидкістю {Speed} км/год.");
        }
    }








    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}


















