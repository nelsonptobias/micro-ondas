using micro_ondas.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace micro_ondas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public Programa mOndas;

        public Programs programas = new Programs();

        
        public MainWindow()
        {
            programas.ProgramList.Add(new Frango());
            programas.ProgramList.Add(new Carne());
            programas.ProgramList.Add(new Macarrao());

            InitializeComponent();
        }

        //singleton
        public Programa GetMicroOndas()
        {
            if (mOndas == null)
            {
                if (txtProgram.Text.ToLower() == "frango")
                {
                    return mOndas = new Frango();
                } else if (txtProgram.Text.ToLower() == "carne")
                {
                    return mOndas = new Carne();
                } else if (txtProgram.Text.ToLower() == "macarrao")
                {
                    return mOndas = new Macarrao();
                } else if (txtProgram.Text.ToLower() != "")
                {
                    throw new System.ArgumentException("Nenhum programa encotrado para: " + txtProgram.Text, "programa");
                } else
                {
                    return mOndas = new Programa();
                }

            }
            return mOndas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TimeInput.Text != "" && PowerInput.Text != "")
                {
                    GetMicroOndas().Time = Int32.Parse(TimeInput.Text);
                    GetMicroOndas().Power = Int32.Parse(PowerInput.Text);
                } else
                {
                    GetMicroOndas().Time = 30;
                    GetMicroOndas().Power = 8;
                }

                lbTimeOn.Content = GetMicroOndas().turnOn();


            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.GetType().FullName + ", " + exc.Message); 
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                lbTimeOn.Content = GetMicroOndas().turnOn();
            }  
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.GetType().FullName + ", " + exc.Message);
            }

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          

            int cont = 0;
            txtbLista.Text = "";
            while (cont < programas.ProgramList.Count)
            {
                txtbLista.Text += programas.ProgramList[cont].print();
                cont++;
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtbLista.Text = "";
            try
            {
                mOndas = programas.searchByName(txtProgram.Text);
                txtbLista.Text += "Programa encontrado : " + Environment.NewLine +
                mOndas.print();
            } catch (ArgumentException exc)
            {
                MessageBox.Show(exc.GetType().FullName + ", " + exc.Message);
            }                        
            
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            programas.ProgramList.Add(new ProgramaGenerico(Int32.            Parse(novoTempo.Text),
                                                           Int32.Parse(novaPotencia.Text),
                                                           novoNome.Text,
                                                           novoInstrucao.Text,
                                                           novoCaractere.Text));
        }
    }
}
