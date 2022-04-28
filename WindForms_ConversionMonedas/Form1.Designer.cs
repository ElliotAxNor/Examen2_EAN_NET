namespace WindForms_ConversionMonedas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMoneda = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.comboBoxMonedas = new System.Windows.Forms.ComboBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBoxConversiones = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // labelMoneda
            // 
            this.labelMoneda.AutoSize = true;
            this.labelMoneda.Location = new System.Drawing.Point(23, 29);
            this.labelMoneda.Name = "labelMoneda";
            this.labelMoneda.Size = new System.Drawing.Size(57, 16);
            this.labelMoneda.TabIndex = 0;
            this.labelMoneda.Text = "Moneda";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(248, 29);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(44, 16);
            this.labelMonto.TabIndex = 1;
            this.labelMonto.Text = "Monto";
            // 
            // comboBoxMonedas
            // 
            this.comboBoxMonedas.FormattingEnabled = true;
            this.comboBoxMonedas.Items.AddRange(new object[] {
            "USD - Dolar estadounidense",
            "MXN - Peso mexicano",
            "CAD - Dolar canadiense",
            "EUR - Euro",
            "JPY - Yen japones"});
            this.comboBoxMonedas.Location = new System.Drawing.Point(26, 58);
            this.comboBoxMonedas.Name = "comboBoxMonedas";
            this.comboBoxMonedas.Size = new System.Drawing.Size(198, 24);
            this.comboBoxMonedas.TabIndex = 2;
            this.comboBoxMonedas.Text = "(selecciona moneda)";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(251, 60);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(129, 22);
            this.textBoxMonto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(305, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.eventoCalcular);
            // 
            // groupBoxConversiones
            // 
            this.groupBoxConversiones.Location = new System.Drawing.Point(26, 146);
            this.groupBoxConversiones.Name = "groupBoxConversiones";
            this.groupBoxConversiones.Size = new System.Drawing.Size(354, 297);
            this.groupBoxConversiones.TabIndex = 5;
            this.groupBoxConversiones.TabStop = false;
            this.groupBoxConversiones.Text = "Conversiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 466);
            this.Controls.Add(this.groupBoxConversiones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.comboBoxMonedas);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelMoneda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoneda;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.ComboBox comboBoxMonedas;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBoxConversiones;
    }
}

