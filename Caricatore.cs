using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCellulare
{
    class Caricatore
    {
        private string codice;
        public Caricatore(string codice)
        {
            this.codice = codice;
        }

        public void CaricaCell(Cellulare cell)
        {
            cell.CaricaBatteria(this.codice);
        }
    }
}
