namespace Leticia_Funes_Casting
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
            this.lblConversionImplicita = new System.Windows.Forms.Label();
            this.lblConversionExplicita = new System.Windows.Forms.Label();
            this.txtInteger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertirDouble = new System.Windows.Forms.Button();
            this.btnConvertiEntero = new System.Windows.Forms.Button();
            this.lblDouble = new System.Windows.Forms.Label();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConversionImplicita
            // 
            this.lblConversionImplicita.AutoSize = true;
            this.lblConversionImplicita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionImplicita.Location = new System.Drawing.Point(34, 44);
            this.lblConversionImplicita.Name = "lblConversionImplicita";
            this.lblConversionImplicita.Size = new System.Drawing.Size(123, 13);
            this.lblConversionImplicita.TabIndex = 0;
            this.lblConversionImplicita.Text = "Conversión Implícita";
            // 
            // lblConversionExplicita
            // 
            this.lblConversionExplicita.AutoSize = true;
            this.lblConversionExplicita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionExplicita.Location = new System.Drawing.Point(31, 167);
            this.lblConversionExplicita.Name = "lblConversionExplicita";
            this.lblConversionExplicita.Size = new System.Drawing.Size(124, 13);
            this.lblConversionExplicita.TabIndex = 1;
            this.lblConversionExplicita.Text = "Conversión Explícita";
            // 
            // txtInteger
            // 
            this.txtInteger.Location = new System.Drawing.Point(37, 103);
            this.txtInteger.Name = "txtInteger";
            this.txtInteger.Size = new System.Drawing.Size(128, 20);
            this.txtInteger.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un número Entero";
            // 
            // btnConvertirDouble
            // 
            this.btnConvertirDouble.Location = new System.Drawing.Point(203, 103);
            this.btnConvertirDouble.Name = "btnConvertirDouble";
            this.btnConvertirDouble.Size = new System.Drawing.Size(155, 20);
            this.btnConvertirDouble.TabIndex = 4;
            this.btnConvertirDouble.Text = "Convertir a Doble";
            this.btnConvertirDouble.UseVisualStyleBackColor = true;
            this.btnConvertirDouble.Click += new System.EventHandler(this.btnConvertirDouble_Click);
            // 
            // btnConvertiEntero
            // 
            this.btnConvertiEntero.Location = new System.Drawing.Point(203, 244);
            this.btnConvertiEntero.Name = "btnConvertiEntero";
            this.btnConvertiEntero.Size = new System.Drawing.Size(155, 20);
            this.btnConvertiEntero.TabIndex = 7;
            this.btnConvertiEntero.Text = "Convertir a Doble";
            this.btnConvertiEntero.UseVisualStyleBackColor = true;
            this.btnConvertiEntero.Click += new System.EventHandler(this.btnConvertiEntero_Click);
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(31, 210);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(194, 13);
            this.lblDouble.TabIndex = 6;
            this.lblDouble.Text = "Ingrese un número Double (por ej: 15,3)";
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(37, 245);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(128, 20);
            this.txtDouble.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.btnConvertiEntero);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.btnConvertirDouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInteger);
            this.Controls.Add(this.lblConversionExplicita);
            this.Controls.Add(this.lblConversionImplicita);
            this.Name = "Form1";
            this.Text = "Casting o Conversión en C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversionImplicita;
        private System.Windows.Forms.Label lblConversionExplicita;
        private System.Windows.Forms.TextBox txtInteger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertirDouble;
        private System.Windows.Forms.Button btnConvertiEntero;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.TextBox txtDouble;
    }
}

