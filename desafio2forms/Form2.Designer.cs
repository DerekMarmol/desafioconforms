namespace Prestamo
{
    partial class Form2
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
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtTasaInteresMensual = new System.Windows.Forms.TextBox();
            this.txtPlazoMeses = new System.Windows.Forms.TextBox();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(350, 82);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(167, 22);
            this.txtMontoPrestamo.TabIndex = 0;
            this.txtMontoPrestamo.Text = "Cuanto DineroDesea?";
            // 
            // txtTasaInteresMensual
            // 
            this.txtTasaInteresMensual.Location = new System.Drawing.Point(350, 138);
            this.txtTasaInteresMensual.Name = "txtTasaInteresMensual";
            this.txtTasaInteresMensual.Size = new System.Drawing.Size(167, 22);
            this.txtTasaInteresMensual.TabIndex = 1;
            this.txtTasaInteresMensual.Text = "Intereses";
            // 
            // txtPlazoMeses
            // 
            this.txtPlazoMeses.Location = new System.Drawing.Point(350, 198);
            this.txtPlazoMeses.Name = "txtPlazoMeses";
            this.txtPlazoMeses.Size = new System.Drawing.Size(167, 22);
            this.txtPlazoMeses.TabIndex = 2;
            this.txtPlazoMeses.Text = "Cuantos Meses?";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Location = new System.Drawing.Point(412, 241);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(0, 16);
            this.lblCuotaMensual.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(350, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.txtPlazoMeses);
            this.Controls.Add(this.txtTasaInteresMensual);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.TextBox txtTasaInteresMensual;
        private System.Windows.Forms.TextBox txtPlazoMeses;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Button btnCalcular;
    }
}

