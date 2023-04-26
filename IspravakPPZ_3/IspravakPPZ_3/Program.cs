using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IspravakPPZ_3
{
    internal class Program
    {
        /*Definirajte klasu KlasaX sa sljedećim članicama:
niz tipa int veličine 100 elemenata arr
indeks koji će vraćati i postavljati vrijednost svakog pojedinog člana niza arr.
Definirajte objekt x tipa KlasaX, te koristeći indekse dodijelite nizu arr prvih 100 brojeva i ispišite 50. član niza.
*/
       class KlasaX
        {
            int[] Arr = new int[100];

            public int[] Arr1 { get => Arr; set => Arr = value; }
        }
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();

            for(int i = 0; i < 100; i++)
            {
                x.Arr1[i] = x.Arr1[i] + 1;
            }
            string ispis = x.Arr1[50].ToString();
            Console.WriteLine(ispis);
            Console.ReadKey();
            
        }
    }
}
