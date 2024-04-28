namespace Desafios
{
    partial class txtInteres
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
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInteresAnual = new System.Windows.Forms.TextBox();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInteresesTotales = new System.Windows.Forms.Label();
            this.lblCapitalFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(246, 63);
            this.txtMontoInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(76, 20);
            this.txtMontoInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora Capital ";
            // 
            // txtInteresAnual
            // 
            this.txtInteresAnual.Location = new System.Drawing.Point(246, 129);
            this.txtInteresAnual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInteresAnual.Name = "txtInteresAnual";
            this.txtInteresAnual.Size = new System.Drawing.Size(76, 20);
            this.txtInteresAnual.TabIndex = 2;
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(246, 201);
            this.txtInversion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(76, 20);
            this.txtInversion.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(246, 276);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 19);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInteresesTotales
            // 
            this.lblInteresesTotales.AutoSize = true;
            this.lblInteresesTotales.Location = new System.Drawing.Point(265, 244);
            this.lblInteresesTotales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInteresesTotales.Name = "lblInteresesTotales";
            this.lblInteresesTotales.Size = new System.Drawing.Size(0, 13);
            this.lblInteresesTotales.TabIndex = 5;
            // 
            // lblCapitalFinal
            // 
            this.lblCapitalFinal.AutoSize = true;
            this.lblCapitalFinal.Location = new System.Drawing.Point(265, 170);
            this.lblCapitalFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapitalFinal.Name = "lblCapitalFinal";
            this.lblCapitalFinal.Size = new System.Drawing.Size(0, 13);
            this.lblCapitalFinal.TabIndex = 6;
            this.lblCapitalFinal.Click += new System.EventHandler(this.lblCapitalFinal_Click);
            // 
            // txtInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblCapitalFinal);
            this.Controls.Add(this.lblInteresesTotales);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInversion);
            this.Controls.Add(this.txtInteresAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoInicial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "txtInteres";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInteresAnual;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblInteresesTotales;
        private System.Windows.Forms.Label lblCapitalFinal;
    }
}

