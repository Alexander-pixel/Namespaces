using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces_HW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Seven_World_Wonders.Colossus_of_Rhodes colossusOfRhodes = new Seven_World_Wonders.Colossus_of_Rhodes();
            Seven_World_Wonders.Lighthouse_of_Alexandria lighthouseOfAlexandria = new Seven_World_Wonders.Lighthouse_of_Alexandria();
            Seven_World_Wonders.Mausoleum_at_Halicarnassus mausoleumAtHalicarnassus = new Seven_World_Wonders.Mausoleum_at_Halicarnassus();
            Seven_World_Wonders.Temple_of_Artemis templeOfArtemis = new Seven_World_Wonders.Temple_of_Artemis();
            Seven_World_Wonders.Great_Pyramid_of_Giza greatPyramidOfGiza = new Seven_World_Wonders.Great_Pyramid_of_Giza();
            Seven_World_Wonders.Hanging_Gardens_of_Babylon hangingGardensOfBabylon =
                new Seven_World_Wonders.Hanging_Gardens_of_Babylon();
            Seven_World_Wonders.Statue_of_Zeus_at_Olympia statueOfZeusAtOlympia = new Seven_World_Wonders.Statue_of_Zeus_at_Olympia();

            Console.WriteLine(colossusOfRhodes.ToString());
            Console.WriteLine();
            Console.WriteLine(lighthouseOfAlexandria.ToString());
            Console.WriteLine();
            Console.WriteLine(mausoleumAtHalicarnassus.ToString());
            Console.WriteLine();
            Console.WriteLine(templeOfArtemis.ToString());
            Console.WriteLine();
            Console.WriteLine(greatPyramidOfGiza.ToString());
            Console.WriteLine();
            Console.WriteLine(hangingGardensOfBabylon.ToString());
            Console.WriteLine();
            Console.WriteLine(statueOfZeusAtOlympia.ToString());
            Console.WriteLine();
        }
    }
}