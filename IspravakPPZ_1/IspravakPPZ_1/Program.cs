using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspravakPPZ_1
{
    internal class Program
    {
        /**Napišite program koji će zatražiti od korisnika da unese tri 
         * dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja 
         * (npr. 12,17,15 -> 17).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 3 dvoznamenkasta broja: ");
            int prvi = Convert.ToInt32(Console.ReadLine());
            int drugi = Convert.ToInt32(Console.ReadLine());
            int treci = Convert.ToInt32(Console.ReadLine());    

            if (prvi > drugi && prvi > treci)
            {
                Console.WriteLine(prvi);
            }
            if (drugi > prvi && drugi > treci)
            {
                Console.WriteLine(drugi);
            }
            if (treci > prvi && treci > drugi)
            {
                Console.WriteLine(treci);
            }
            Console.ReadKey();
        }
    }
}
