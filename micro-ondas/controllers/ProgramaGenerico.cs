using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ondas.controllers
{
    class ProgramaGenerico : Programa
    {
        public ProgramaGenerico(int tempo, int potencia, String nome, String instrucoesDeUso, String cacacterFinaliza)
        {
            this.Time = tempo;
            this.Power = potencia;
            this.NomePrograma = nome;
            this.InstrucoeUso = instrucoesDeUso;
            this.CharEsquenta = cacacterFinaliza;
        }
    }
}
