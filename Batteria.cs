using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCellulare
{
    class Batteria
    {
        private int livelloCarica;
        private int u;

        public Batteria()
        {
            this.livelloCarica = 30;
            this.u = 10;
        }

        public int getLivelloCarica()
        {
            return this.livelloCarica;
        }

        public bool CaricaBatteria(string codice)
        {
            if(codice == "111!")
            {
                this.livelloCarica++;
                if(this.livelloCarica > 100)
                {
                    this.livelloCarica = 100;
                }
                return true;
            }
            else
                return false;
        }

        public void CapacitaRicarica(int minuti)
        {

            this.livelloCarica += minuti * (this.u / 8);

            if(this.livelloCarica > 100)
            {
                this.livelloCarica = 100;
            }

            /*
            if(minuti >= 8)
            { 
                for(int i = 0; i < minuti; i+=8)
                {
                    if(this.livelloCarica >= 100)
                    {
                        this.livelloCarica = 100;
                    }
                    else
                    {
                        this.livelloCarica += this.u;
                    }
                }
            }

            if(minuti < 8 && minuti >= 1)
            {
                if(this.livelloCarica < 100)
                {
                    for (int i = 0; i < minuti; i++)
                    {
                        if (this.livelloCarica < 100)
                        {
                            this.livelloCarica +=1.75;
                        }
                        else
                        {
                            this.livelloCarica = 100;
                        }
                    }

                }
            }
            */
        }

        /*
        public void CapacitaScaricaBatteria(int sms, int minuti)
        {
           if((this.livelloCarica > 1) && (sms > 0))
           {
                for(int i=0; ((i<sms) && (this.livelloCarica > 0)); i++)
                {
                    this.livelloCarica -= 1;
                    
                }
                if (this.livelloCarica <= 0)
                {
                    this.livelloCarica = 0;
                }
           }

            if((minuti > 2) && (this.livelloCarica >=  1))
            {
                for (int i = 0; (i < minuti) && (this.livelloCarica > 0); i += 2)
                {
                    this.livelloCarica -= 1;
                }
            }
            else if(this.livelloCarica < 0)
            {
                this.livelloCarica = 0;
            }
        }
        */

        public void SelezioneFunzioni(string funct, int qnt)
        {
            if(this.livelloCarica > 2)
            {
                switch (funct)
                {
                    case "tel":
                        this.livelloCarica -= (qnt * 2);
                        if (this.livelloCarica < 0)
                            this.livelloCarica = 0;
                        break;
                    case "sms":
                        this.livelloCarica -= qnt;
                        if (this.livelloCarica < 0)
                            this.livelloCarica = 0;
                        break;
                } 
            }
           
        }
    }
} 
