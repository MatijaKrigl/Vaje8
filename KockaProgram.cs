using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocka
{
    internal class KockaProgram
    {
        static void Main(string[] args)
        {
            try
            {
                // Ustvarimo objekt
                RazredKocka kocka = new RazredKocka(3);
                Console.WriteLine("Dolžina stranice kocke je enaka: " + kocka.Stranica);
                Console.WriteLine("Površina kocke je: " + kocka.Povrsina());
                Console.WriteLine("Volumen pa: " + kocka.Volumen());

                RazredKocka kocka2 = new RazredKocka();
                kocka2.Stranica = -2;
                Console.WriteLine("Dolžina stranice kocke je enaka: " + kocka2.Stranica);
                Console.WriteLine("Površina kocke je: " + kocka2.Povrsina());

                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Pozor, nekaj si falil: " + ex.Message);
            }
            Console.ReadLine();

        }
    }
}
