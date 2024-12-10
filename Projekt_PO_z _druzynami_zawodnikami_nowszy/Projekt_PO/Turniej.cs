using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projekt_PO
{
    public class Turniej
    {
        public string Nazwa_Turnieju { get; set; }
        public int Data { get; set; }
        public string Waga_Turnieju { get; set; }

        public Mecz[] Mecze { get; set; }

        public Gry Gra {  get; set; }
    }
}
