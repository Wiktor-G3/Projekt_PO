using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Wyb_Gre : Wyś_Gry
    {
        public void WybierzGre()
        {
            Console.Clear();
            Console.WriteLine("Wybierz grę, którą chcesz obserwować:\n"+
                "1.League_of_Legends\n"+ 
                "2.Counter_Strike\n" +
                "3.World_of_Warcraft\n" +
                "4.EA_FC_25\n" +
                "5. Wyloguj");
            string wybor = Console.ReadLine();
            string wybranaGra = null;

            switch (wybor)
            {
                case "1":
                    wybranaGra = "League_of_Legends";
                    break;
                case "2":
                    wybranaGra = "Counter_Strike";
                    break;
                case "3":
                    wybranaGra = "World_of_Warcraft";
                    break;
                case "4":
                    wybranaGra = "EA_FC_25";
                    break;
                case "5":
                    Console.WriteLine("Wylogowano. Powrót do menu głównego.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    WybierzGre(); // Rekurencja do ponownego wyboru
                    return;
            }

            WyswietlDruzyny(wybranaGra);
        }
       
    }
}
