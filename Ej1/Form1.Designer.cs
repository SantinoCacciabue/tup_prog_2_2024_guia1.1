namespace Ej1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVida = new System.Windows.Forms.TextBox();
            this.tBvalor = new System.Windows.Forms.TextBox();
            this.tBtasa = new System.Windows.Forms.TextBox();
            this.tBmarca = new System.Windows.Forms.TextBox();
            this.nAño = new System.Windows.Forms.NumericUpDown();
            this.nModelo = new System.Windows.Forms.NumericUpDown();
            this.bCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de fabricación $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vida útil (Años)";
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(381, 83);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(100, 20);
            this.tbVida.TabIndex = 6;
            // 
            // tBvalor
            // 
            this.tBvalor.Location = new System.Drawing.Point(156, 139);
            this.tBvalor.Name = "tBvalor";
            this.tBvalor.Size = new System.Drawing.Size(100, 20);
            this.tBvalor.TabIndex = 7;
            // 
            // tBtasa
            // 
            this.tBtasa.Location = new System.Drawing.Point(381, 50);
            this.tBtasa.Name = "tBtasa";
            this.tBtasa.Size = new System.Drawing.Size(100, 20);
            this.tBtasa.TabIndex = 8;
            // 
            // tBmarca
            // 
            this.tBmarca.Location = new System.Drawing.Point(110, 50);
            this.tBmarca.Name = "tBmarca";
            this.tBmarca.Size = new System.Drawing.Size(100, 20);
            this.tBmarca.TabIndex = 9;
            // 
            // nAño
            // 
            this.nAño.Location = new System.Drawing.Point(121, 107);
            this.nAño.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nAño.Name = "nAño";
            this.nAño.Size = new System.Drawing.Size(120, 20);
            this.nAño.TabIndex = 10;
            // 
            // nModelo
            // 
            this.nModelo.Location = new System.Drawing.Point(116, 81);
            this.nModelo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nModelo.Name = "nModelo";
            this.nModelo.Size = new System.Drawing.Size(120, 20);
            this.nModelo.TabIndex = 11;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(215, 204);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(91, 45);
            this.bCalcular.TabIndex = 12;
            this.bCalcular.Text = "Calcular costo";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 273);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.nModelo);
            this.Controls.Add(this.nAño);
            this.Controls.Add(this.tBmarca);
            this.Controls.Add(this.tBtasa);
            this.Controls.Add(this.tBvalor);
            this.Controls.Add(this.tbVida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVida;
        private System.Windows.Forms.TextBox tBvalor;
        private System.Windows.Forms.TextBox tBtasa;
        private System.Windows.Forms.TextBox tBmarca;
        private System.Windows.Forms.NumericUpDown nAño;
        private System.Windows.Forms.NumericUpDown nModelo;
        private System.Windows.Forms.Button bCalcular;
    }
}

