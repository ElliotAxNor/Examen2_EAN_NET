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
                if(form2.ShowDialog()==DialogResult.OK)
                {
                    //Vaciamos el contenido de la seccion conversiones
                    groupBoxConversiones.Controls.Clear();
                    int ejeY = 30;
                    foreach (String moneda in form2.obtenerMonedasSeleccionadas())
                    {
                        TextBox textBoxConversion = new TextBox();
                        textBoxConversion.Location = new Point(150,ejeY);
                        
                        Label labelMoneda = new Label();
                        labelMoneda.AutoSize = true;
                        labelMoneda.Location = new Point(5, ejeY);
                        
                        textBoxConversion.Text = determinarSigno(moneda)+" "+conversionMoneda(monedaSeleccionada,moneda,monto);
                        labelMoneda.Text = moneda;

                        groupBoxConversiones.Controls.Add(labelMoneda);
                        groupBoxConversiones.Controls.Add(textBoxConversion);
                        
                        ejeY += 50;

                    }
                }
            }
        }


        private String determinarSigno(String moneda)
        {
            if (moneda == "USD - Dolar estadounidense" || moneda == "MXN - Peso mexicano" || moneda == "CAD - Dolar canadiense")
            {
                return "$";
            }
            if (moneda == "EUR - Euro")
            {
                return "€";
            }

            else
            {
                return "¥";
            }
        }

        private double conversionMoneda(String moneda, String monedaAconvertir, int monto)
        {
           
            if (moneda == "USD - Dolar estadounidense")
            {
                return convertirMonedaUSD(monedaAconvertir,monto);
            }

            if (moneda == "MXN - Peso mexicano")
            {
                return convertirMonedaMXN(monedaAconvertir,monto);
            }

            if (moneda == "CAD - Dolar canadiense")
            {
                return convertirMonedaCAD(monedaAconvertir,monto);
            }

            if (moneda == "EUR - Euro")
            {
                return convertirMonedaEUR(monedaAconvertir,monto);
            }

            else
            {
                return convertirMonedaJPY(monedaAconvertir,monto);
            }
        }

        private double convertirMonedaUSD(String monedaAconvertir, int monto)
        {
            if (monedaAconvertir == "MXN - Peso mexicano")
            {
                return monto * 21.23;
            }

            if (monedaAconvertir == "CAD - Dolar canadiense")
            {
                return monto * 1.28;
            }

            if (monedaAconvertir == "EUR - Euro")
            {
                return monto * 0.89;
            }

            else
            {
                return monto * 113.05;
            }
        }

        private double convertirMonedaMXN(String monedaAconvertir, int monto)
        {
            if (monedaAconvertir == "USD - Dolar estadounidense")
            {
                return monto * 0.05;
            }

            if (monedaAconvertir == "CAD - Dolar canadiense")
            {
                return monto * 0.06;
            }

            if (monedaAconvertir == "EUR - Euro")
            {
                return monto * 0.04;
            }

            else
            {
                return monto * 5.32;
            }
        }

        private double convertirMonedaCAD(String monedaAconvertir, int monto)
        {
            if (monedaAconvertir == "USD - Dolar estadounidense")
            {
                return monto * 0.78;
            }

            if (monedaAconvertir == "MXN - Peso mexicano")
            {
                return monto * 16.55;
            }

            if (monedaAconvertir == "EUR - Euro")
            {
                return monto * 0.69;
            }

            else
            {
                return monto * 88.12;
            }
        }

        private double convertirMonedaEUR(String monedaAconvertir, int monto)
        {
            if (monedaAconvertir == "USD - Dolar estadounidense")
            {
                return monto * 1.13;
            }

            if (monedaAconvertir == "MXN - Peso mexicano")
            {
                return monto * 23.96;
            }

            if (monedaAconvertir == "CAD - Dolar canadiense")
            {
                return monto * 1.45;
            }

            else
            {
                return monto * 127.56;
            }
        }

        private double convertirMonedaJPY(String monedaAconvertir, int monto)
        {
            if (monedaAconvertir == "USD - Dolar estadounidense")
            {
                return monto * 0.0088;
            }

            if (monedaAconvertir == "MXN - Peso mexicano")
            {
                return monto * 0.1878;
            }

            if (monedaAconvertir == "CAD - Dolar canadiense")
            {
                return monto * 0.0113;
            }

            else
            {
                return monto * 0.0078;
            }
        }

        private void vaciarSeccionConversiones()
        {
            
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
