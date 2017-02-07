using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
namespace Viikkotehtvat
{
    class Program
    {

        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
            Console.WriteLine("Anna 1,2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            if (luku == 1)
            {
                retval = "yksi";
            }
            else if (luku == 2)
            {
                retval = "kaksi";
            }
            else if (luku == 3)
            {
                retval = "kolme";
            }
            //tulostus käyttäjälle
            Console.WriteLine(retval);
        }


        static void Main(string[] args)
        {
            Labra5Tehtava1();
        }

        static void Labra5Tehtava1()
        {
            //testataan Tyre ja vehicle loukkia
            Vehicle auto = new JAMK.IT.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55R16";
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);
            Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());
        }
    }
}