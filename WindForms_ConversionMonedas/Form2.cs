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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Metodo que inserta las opciones dentro del checkedListBox excepto la moneda pasada como parametro
        public void insertarOpciones(String monedaSeleccionada)
        {
            if (monedaSeleccionada != "USD - Dolar estadounidense") 
            {
                checkedListBoxMonedas.Items.Add("USD - Dolar estadounidense");
            }

            if (monedaSeleccionada != "MXN - Peso mexicano") 
            {
                checkedListBoxMonedas.Items.Add("MXN - Peso mexicano");
            }

            if (monedaSeleccionada != "CAD - Dolar canadiense")
            {
                checkedListBoxMonedas.Items.Add("CAD - Dolar canadiense");
            }

            if (monedaSeleccionada != "EUR - Euro")
            {
                checkedListBoxMonedas.Items.Add("EUR - Euro");
            }

            if (monedaSeleccionada != "JPY - Yen japones")
            {
                checkedListBoxMonedas.Items.Add("JPY - Yen japones");
            }
        }

        //Evento que se realizara al pulsar el boton aceptar
        private void eventoAceptar(object sender, EventArgs e)
        {
            //Si se tiene seleccionada alguna moneda
            if (checkedListBoxMonedas.SelectedItems.Count!= 0)
            {
                //Regresamos de estatus ok
                this.DialogResult = DialogResult.OK;
                //Cerramos el form
                this.Close();
            }
            else //Si no
            {
                //  Mostramos mensaje indicandolo
                MessageBox.Show("No has seleccionado ninguna moneda a la que se hara conversion","Seleccionar monedas");
            }
            
        }

        //Metodo que regresa una lista con las monedas seleccionadas en el checkedListBox
        public List<String> obtenerMonedasSeleccionadas()
        {
            List<String> monedasSeleccionadas = new List<string>();
            foreach(String moneda in checkedListBoxMonedas.CheckedItems)
            {
                monedasSeleccionadas.Add(moneda);
            }
            return monedasSeleccionadas;
        }


        private void eventoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
