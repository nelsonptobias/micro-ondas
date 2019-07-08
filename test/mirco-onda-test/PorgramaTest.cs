using System;
using Xunit;
using System.Reflection;
using Xunit.Sdk;
using micro_ondas.controllers;

namespace mirco_onda_test
{
    public class ProgramaTest : BeforeAfterTestAttribute
    {
        public static Programa novoPrograma; 


        [Fact]
        [Before]
        public void Property_set_time_sucess()
        {

            novoPrograma.Time = 10;
            Assert.True(novoPrograma.Time == 10);
        }

        [Fact]
        [Before]
        public void Property_set_time_fail()
        {
            Assert.Throws<TimeValueExcetpion>(() => novoPrograma.Time = 1111111);
        }

        [Fact]
        [Before]
        public void Property_set_power_sucess()
        {

            novoPrograma.Power = 5;
            Assert.True(novoPrograma.Power == 5);
        }

        [Fact]
        [Before]
        public void Property_set_CharHeating_sucess()
        {

            novoPrograma.CharHeating = "%";
            Assert.True(novoPrograma.CharHeating == "%");
        }

        [Fact]
        [Before]
        public void Property_set_ProgramName_sucess()
        {

            novoPrograma.ProgramName = "TestName";
            Assert.True(novoPrograma.ProgramName == "TestName");
        }


        [Fact]
        [Before]
        public void Property_set_UseInstructions_sucess()
        {

            novoPrograma.UseInstructions = "Use this correct";
            Assert.True(novoPrograma.UseInstructions == "Use this correct");
        }

        [Fact]
        [Before]
        public void TurnOn_NoParameters_sucess()
        {

            String answer =  novoPrograma.turnOn();
            Assert.Equal("aquecida", answer);
        }

        [Fact]
        [Before]
        public void TurnOn_WithParameters_sucess()
        {
            novoPrograma.Time = 10;
            novoPrograma.Power= 2;

            String answer = novoPrograma.turnOn();
            Assert.Equal("....................aquecida", answer);
        }

        [Fact]
        [Before]
        public void Print_NoParameters_sucess()
        {

            String answer = novoPrograma.print();
            Assert.Equal("Nome : " + Environment.NewLine +
                         "Instrucao: " + Environment.NewLine +
                         "Tempo: 0" + Environment.NewLine +
                         "Potencia: 0" + Environment.NewLine, answer);
        }

        [Fact]
        [Before]
        public void Print_WithParameters_sucess()
        {

            novoPrograma.Time = 10;
            novoPrograma.Power = 2;
            novoPrograma.ProgramName = "Test Program name";
            novoPrograma.UseInstructions = "Use instruction test";

            String answer = novoPrograma.print();
            Assert.Equal("Nome : Test Program name" + Environment.NewLine +
                         "Instrucao: Use instruction test" + Environment.NewLine +
                         "Tempo: 10" + Environment.NewLine +
                         "Potencia: 2" + Environment.NewLine, answer);
        }




        public class BeforeAttribute : BeforeAfterTestAttribute
        {

            public override void Before(MethodInfo methodUnderTest)
            {
                //Procurei referencias e vi que o novo .net tem garbage collector
                novoPrograma = new Programa();                
            }
        }
    }

}

