using System.Text;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Artifact> inventory = new List<Artifact>();

            inventory.Add(new MagicScroll(101));
            inventory.Add(new AncientSword(202));

            Console.WriteLine("--- Аналіз інвентарю ---");

            foreach (var item in inventory)
            {
                item.Identify();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
