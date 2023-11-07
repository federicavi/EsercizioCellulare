using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCellulare
{

     /*
    ESERCIZIO CELLULARE – BATTERIA
    Realizzare una classe cellulare, ogni cellulare contiene una batteria,
    ogni batteria è caratterizzata dalla capacità di carica (misurata in unità intere u) e dal livello di carica.
    Con il cellulare si possono mandare sms e fare telefonate, 
    ovviamente entrambe queste cose vanno a incidere sul livello della batteria, 
    un sms consuma un’unità di carica una chiamata consuma un’unità di carica ogni 5 secondi (approssimando per eccesso).
    Ovviamente si può sapere il livello di carica del cellulare.
    Implementare le classi con tutti i metodi che si ritiene opportuno al fine di simulare gli oggetti reali.
    Dopo aver realizzato le classi provarle.
     */

    class Cellulare
    {
        private bool acceso;
        Batteria batteria;
        Display display;

        public Cellulare()
        {
            this.acceso = false;
            this.display = new Display();
            this.batteria = new Batteria();
        }

        public void Accendi()
        {
            this.acceso = true;
            CeckLivelloBatt();
            MostraLivelloBatti();
        }

        public void SpegniCell()
        {
            this.acceso = false;
        }

        public bool GetAcceso()
        {
            return this.acceso;
        }

/*
        public void Ricarica(int minuti)
        {
            batteria.CapacitaRicarica(minuti);

            if(this.acceso)
            {
                MostraLivelloBatti();
            }
        }
*/

        public void Chiama(int minuti)
        {
            if(this.acceso)
            {
                batteria.SelezioneFunzioni("tel", minuti);
                CeckLivelloBatt();
                MostraLivelloBatti();
            }
        }

        public void InviaSms(int numSms)
        {
            if(this.acceso)
            {
                batteria.SelezioneFunzioni("sms", numSms);
                CeckLivelloBatt();
                MostraLivelloBatti();
            }     
        }

        private void MostraLivelloBatti()
        {
            display.MostraString("Livello Batteria: " + batteria.getLivelloCarica() + "%\n");
            CeckLivelloBatt();
        }

        private void CeckLivelloBatt()
        {
            if(batteria.getLivelloCarica() == 0)
            {
                this.acceso = false;
                MostraMessBattScarica();
            }
        }

        private void MostraMessBattScarica()
        {
            display.MostraString("Telefono spento!\n");
            
        }

        public void CaricaBatteria(string codice)
        {
            bool caricamento;
            
            caricamento = this.batteria.CaricaBatteria(codice);

            if(caricamento)
            {
                MostraLivelloBatti();
            }
            else
            {
                this.display.MostraString("Caricabatteria non compatibile");
            }

        }
    }
}

