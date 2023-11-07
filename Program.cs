using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCellulare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cellulare cell = new Cellulare();
            Caricatore car01 = new Caricatore("111!");
            Caricatore car02 = new Caricatore("131!");

            cell.Accendi(); 
            cell.Chiama(10);
            //cell.Ricarica(150);
            cell.InviaSms(4);
            //cell.Ricarica(100);
            cell.Chiama(430);
            //cell.Ricarica(30);
            cell.InviaSms(2);
            cell.Accendi();
            cell.InviaSms(2);

            car01.CaricaCell(cell);
            car02.CaricaCell(cell);

            cell.CaricaBatteria("111!");

            Console.ReadLine();
        }
    }
}
