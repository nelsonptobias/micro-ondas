using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ondas.controllers
{
    class Frango : Programa
    {
        

        public Frango()
        {
            this.NomePrograma = "frango"; 
            this.Time = 30;
            this.Power = 6;
            this.InstrucoeUso = "instrucao de como enquentar seu flango com catupily";
            this.CharEsquenta = "$";

        }

     
    }
}
