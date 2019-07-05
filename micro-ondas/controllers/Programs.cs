using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ondas.controllers
{
    public class Programs
    {

        List<Programa> programList = new List<Programa>();

        public List<Programa> ProgramList { get => programList; set => programList = value; }

        internal Programa searchByName(string text)
        {
            Programa programaBuscado = ProgramList.Find(p => p.NomePrograma == text);
            if (programaBuscado == null)
            {
                throw new System.ArgumentException("Nenhum programa encontrado para: " + text, "programa");
            }
            return ProgramList.Find(p => p.NomePrograma == text);
        }
    }
}
