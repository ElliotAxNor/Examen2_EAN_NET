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

        

        /*public List<String> obtenerMonedasAcalcular()
        {
            if (hayMonedasSeleccionadas())
            {
                //return checkedListBoxMonedas.Items.ToString;
            }
            else
            {
                return null;
            }
        }*/

        private Boolean hayMonedasSeleccionadas()
        {
            if (checkedListBoxMonedas.Items.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void eventoAceptar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void eventoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
