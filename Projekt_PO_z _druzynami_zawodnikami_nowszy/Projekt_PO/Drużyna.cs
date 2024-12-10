using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    public class Drużyna 

    {
        public string Nazwa_Drużyny {  get; set; }
        public Gry Gry { get; set; }
        public Gracz[] zespół {  get; set; }
    }
}
