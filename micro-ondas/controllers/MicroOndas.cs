using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace micro_ondas.controllers
{
    public class Programa
    {

        private int _time;
        private int _power;
        private String programa = "";
        private String instrucoeUso;
        private String charEsquenta = ".";
      



        public string InstrucoeUso { get => instrucoeUso; set => instrucoeUso = value; }

        public int Time {
            get
            {
                return _time;
            }
            set
            {
                if (value < 1 || value > 121){
                    throw new System.ArgumentException("Tempo nao pode ser maior que 2 minutos (120 segundos) nem menor que 1 segundo", "time");
                     
                }
                _time = value;
            }
        }
        public int Power {
            get
            {
                return _power;
            }
            set
            {
                if (value < 1 || value > 11)
                {
                    throw new System.ArgumentException("Potencia nao pode ser maior que 10 nem menor que 1", "power");
                }
                _power = value;

            }
        }

        public string CharEsquenta { get => charEsquenta; set => charEsquenta = value; }
        public string NomePrograma { get => programa; set => programa = value; }

        public String turnOn()
        {
            String points = "";
            String powerPoints = this.getPowerPoints();
            for (int i = 0; i < this.Time; i++)
            {
                Thread.Sleep(1000);
                points += powerPoints;


            }
            return points + "aquecida";
        }

        private string getPowerPoints()
        {
            switch (this.Power)
            {
                case 1:  return this.charEsquenta;
                case 2:  return this.charEsquenta + this.charEsquenta;
                case 3:  return this.charEsquenta + this.charEsquenta + this.charEsquenta;
                case 4:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta;
                case 5:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta ;
                case 6:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta +
                                this.charEsquenta ;
                case 7:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta +
                                this.charEsquenta + this.charEsquenta ;
                case 8:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta +
                                this.charEsquenta + this.charEsquenta + this.charEsquenta ;
                case 9:  return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta +
                                this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta ;
                case 10: return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta +
                                this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta  ;
                default: return this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + this.charEsquenta + 
                                this.charEsquenta + this.charEsquenta + this.charEsquenta ;


            }
        }

        public String print()
        {
            return "Nome : " + this.NomePrograma + Environment.NewLine +
                   "Instrucao: " + this.instrucoeUso + Environment.NewLine +
                   "Tempo: " + this.Time + Environment.NewLine +
                   "Potencia: " + this.Power + Environment.NewLine;


        }
    }


}
