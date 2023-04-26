using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspravakPPZ_2
{
    internal class Program
    {
        /*Definirajte klasu Stablo sa sljedećim članicama:
varijabla tipa bool otpadajuListovi
varijabla tipa string vrstaStabla
svojstvo OtpadajuListovi (get() i set())
konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli otpadajuListovi
override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost false.
Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je vrijednost 
varijable otpadajuListovi true, vrijednost varijable vrstaStabla je bijelogorično, a ukoliko je vrijednost 
varijable otpadajuListovi false, vrijednost varijable vrstaStabla je crnogorično.*/
        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
            public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }

            public Stablo(bool otpadajuListovi, string vrstaStabla)
            {
                OtpadajuListovi=otpadajuListovi;
                VrstaStabla=vrstaStabla;

            }
            public string toString()
            {
                string ispis = ("Vrsta stabla: " + this.vrstaStabla + "\nOtpadaju listovi: " + this.otpadajuListovi + "\n");
                return ispis;
            }

            
        }
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false, "");
            Stablo stablo2 = new Stablo(true, "");
            if(stablo1.OtpadajuListovi == false)
            {
                stablo1.VrstaStabla = "Crnogorično";
            }
            else
            {
                stablo1.VrstaStabla = "Bijelogorično";
            }

            if (stablo2.OtpadajuListovi == false)
            {
                stablo2.VrstaStabla = "Crnogorično";
            }
            else
            {
                stablo2.VrstaStabla = "Bijelogorično";
            }
            Console.WriteLine(stablo1.toString() + stablo2.toString());
            Console.ReadKey();
        }
    }
}
