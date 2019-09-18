using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> toidud = new List<Food>
            {
                new Food("banaan", 1.2),
                new Food("õun", 0.5),
                new Food("sai", 0.7)
            };

            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perenimi");
            string perenimi = Console.ReadLine();

            Console.WriteLine("Tere " + eesnimi + " " + perenimi + "!");

            Person klient = new Person(eesnimi, perenimi);

            Console.WriteLine("Tere tulemast meie poodi, " + klient);

            klient.ShoppingCart = new ShoppingCart();

            ValiToidud(toidud, klient);
            while (Console.ReadLine() == "j")
            {
                ValiToidud(toidud, klient);
            }
            Console.WriteLine("Summa: " + klient.ShoppingCart.CalculateSum());

            Console.ReadKey();
        }

        private static void ValiToidud(List<Food> toidud, Person klient)
        {
            Console.WriteLine("Mida sa soovid osta?");
            string toit = Console.ReadLine();
            Food valitudToit = toidud.FirstOrDefault(x => x.Name == toit);

            if (valitudToit != null)
            {
                Console.WriteLine("Sisesta kogus");
                string kogus = Console.ReadLine();
                int a;
                bool success = int.TryParse(kogus, out a);
                while (!success)
                {
                    Console.WriteLine("Kogus peab olema täisarv, sisesta uuesti:");
                    kogus = Console.ReadLine();
                    success = int.TryParse(kogus, out a);
                }
                klient.ShoppingCart.AddToCart(valitudToit, a);
            }
            else
            {
                Console.WriteLine(toit + " puudub valikust");
            }
            Console.WriteLine("Kas veel midagi? (j/e)");
        }
    }
}
