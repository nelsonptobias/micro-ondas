using micro_ondas.controllers;
using System;

namespace micro_ondas
{
    internal class Macarrao : Programa
    {

        public Macarrao()
        {
            this.NomePrograma = "macarrao";
            this.Time = 30;
            this.Power = 6;
            this.InstrucoeUso = "instrucao de como enquentar seu miojo";
            this.CharEsquenta = "@";
        }
    }
}