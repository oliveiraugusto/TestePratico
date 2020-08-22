using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestePratico
{
    public partial class FormPrincipal : Form
    {
       
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void textBoxDiametroTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void textBoxDistanciaEntrePilares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void textBoxDistanciaBaseReforcada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxDistanciaTotal.Text) ||
               !string.IsNullOrEmpty(textBoxDistanciaTotal.Text) ||
               !string.IsNullOrEmpty(textBoxDistanciaTotal.Text))
            {
                double distanciaTotal = Convert.ToDouble(textBoxDistanciaTotal.Text);
                double distanciaPilares = Convert.ToDouble(textBoxDistanciaEntrePilares.Text);
                double distanciaBaseReforcada = Convert.ToDouble(textBoxDistanciaBaseReforcada.Text);

                IntPtr ptr = Program.GetConsoleWindow();
                
                if(ptr !=  IntPtr.Zero)
                {
                    Program.ShowWindow(ptr, 1);// show console
                    Console.Clear();
                    Console.WriteLine($"Realizando calculos");

                    
                    
                    
                    Console.WriteLine($"{i} pilares\n\n(pressione qualquer tecla para continuar)");
                    Console.ReadKey();

                    Program.ShowWindow(ptr, 0);  //hide console

                    labelResultado.Text = String.Empty;  //limpa caso haja texto
                    labelResultado.Text = $"{i} pilares";
                }
            }     
            else
            {
                MessageBox.Show("Não deixe os campos em branco");
            }

            
        }
    }
}
