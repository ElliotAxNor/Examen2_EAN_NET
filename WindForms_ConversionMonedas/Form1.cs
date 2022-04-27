using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindForms_ConversionMonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eventoCalcular(object sender, EventArgs e)
        {
            if (comprobarDatos())
            {
                String monedaSeleccionada = comboBoxMonedas.Text;
                int monto = int.Parse(textBoxMonto.Text);
                Form2 form2 = new Form2();
                form2.insertarOpciones(monedaSeleccionada);
                if (form2.ShowDialog()==DialogResult.OK)
                {
                    
                }
                form2.Show();
            }
        }

        

        private Boolean comprobarDatos()
        {
            try
            {
                String monedaSeleccionada = comboBoxMonedas.Text;
                if (monedaSeleccionada == "(selecciona moneda)") //Si se cumple
                {
                    //Mostramos mensaje de error
                    MessageBox.Show("Debes de seleccionar una moneda", "Moneda invalida");
                    return false;
                }
                else
                {
                    //Si no da error la siquiente linea significa que los datos son correctos y regresa true
                    int monto = int.Parse(textBoxMonto.Text);
                    return true;
                }

            }
            //Se producira la excepcion cuando se intente convertir lo que hay en el textBox de monto a un numero entero
            //Que significa que lo ingresado por el usuario tiene letras
            catch (Exception ex) 
            {
                MessageBox.Show("El monto no es valido", "Monto invalido");
                return false;
            }
        }
    }
}
