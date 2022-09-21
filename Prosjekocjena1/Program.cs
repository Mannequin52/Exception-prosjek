using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosjekocjena1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int brojOcjena, ocjena;
            double prosjek, zbrojOcjena = 0;

            //zaglavlje aplikacije
            Console.WriteLine("###############################");
            Console.WriteLine("#   Izračunavanje prosjeka.   #");
            Console.WriteLine("###############################");
            Console.WriteLine(">Za kraj unesi nulu.<");

            //unos broja ocjena
            Console.WriteLine("Unesi broj ocjena: ");
            brojOcjena = Convert.ToInt32(Console.ReadLine());
            //unos ocjena
            start:  Console.WriteLine("Unesi ocjene: ");
            try
            {
                do
                {

                    ocjena = Convert.ToInt32(Console.ReadLine());


                    if (ocjena == 1)
                    {
                        Console.WriteLine("Ocjena negativna. Ne prolaziš razred. ");
                        goto au;

                    }
                    else if (ocjena < 1 && ocjena > 5) //ocjena mora biti veća od jedan i manja od 5
                    {
                        Console.WriteLine("Unosi ocjene od 1 do 5.");
                        goto au;
                    }
                    zbrojOcjena += ocjena;
                } while (ocjena != 0);
            }
            //catch
            catch (Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovo. ");
                Console.WriteLine("Opis greske: " + greska.Message);
                goto start;
            }
            prosjek = zbrojOcjena / brojOcjena;
            //ispis
            Console.WriteLine("Prosjek je: " + prosjek);

           au:  Console.ReadKey();
        }
    }
}
