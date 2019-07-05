using micro_ondas.controllers;
using System;

namespace micro_ondas
{
    internal class Carne : Programa
    {


        public Carne()
        {
            this.NomePrograma = "carne";
            this.Time = 7;
            this.Power = 5;
            this.InstrucoeUso = "instrucao de como enquentar sua carne";
            this.CharEsquenta = "#";
        }


    }
}