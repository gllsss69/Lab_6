namespace Exercise_2
{
    
    
        public abstract class SpaceBody
        {
            public string Name { get; set; }
            public double DistanceFromSun { get; set; }

            public SpaceBody(string name, double distance)
            {
                Name = name;
                DistanceFromSun = distance;
            }

           
            public abstract void CalculateOrbitParameters();
        }
    }






















    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

