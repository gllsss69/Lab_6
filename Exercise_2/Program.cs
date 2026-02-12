using System.Text;

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




    public class Planet : SpaceBody
    {
        public Planet(string name, double distance) : base(name, distance) { }

        public override void CalculateOrbitParameters()
        {
            // Спрощена формула Кеплера: T = sqrt(a^3)
            double period = Math.Sqrt(Math.Pow(DistanceFromSun, 3));
            Console.WriteLine($"\nПланета {Name}: Стабільна еліптична орбіта. " +
                            $"Рік триває приблизно {period:F2} земних років.");
        }
    }


    public class Asteroid : SpaceBody
    {
        public Asteroid(string name, double distance) : base(name, distance) { }

        public override void CalculateOrbitParameters()
        {
            Console.WriteLine($"\nАстероїд {Name}: Рухається у складі астероїдного поясу на відстані {DistanceFromSun} AU.");
        }
    }


    public class Comet : SpaceBody
    {
        public double Eccentricity { get; set; }

        public Comet(string name, double distance, double eccentricity) : base(name, distance)
        {
            Eccentricity = eccentricity;
        }

        public override void CalculateOrbitParameters()
        {
            Console.WriteLine($"\nКомета {Name}: Дуже витягнута орбіта (ексцентриситет: {Eccentricity}). " +
                            $"Наближається до Сонця на {DistanceFromSun} AU.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            List<SpaceBody> solarSystem = new List<SpaceBody>
            {
                new Planet("Марс", 1.52),
                new Asteroid("Церера", 2.77),
                new Comet("Галлея", 0.58, 0.967),
                new Planet("Юпітер", 5.20)
            };

            Console.WriteLine("--- Аналіз орбіт космічних об'єктів ---");


            foreach (var body in solarSystem)
            {
                body.CalculateOrbitParameters();
            }

            Console.WriteLine("\nРозрахунок завершено.");
            Console.ReadKey();
        }
    }
}
