namespace Ej2
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
            this.bIniciar = new System.Windows.Forms.Button();
            this.bParada = new System.Windows.Forms.Button();
            this.bFin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(30, 12);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(187, 23);
            this.bIniciar.TabIndex = 0;
            this.bIniciar.Text = "Iniciar Viaje";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bParada
            // 
            this.bParada.Location = new System.Drawing.Point(30, 51);
            this.bParada.Name = "bParada";
            this.bParada.Size = new System.Drawing.Size(187, 23);
            this.bParada.TabIndex = 1;
            this.bParada.Text = "Ingresar Parada";
            this.bParada.UseVisualStyleBackColor = true;
            this.bParada.Click += new System.EventHandler(this.bParada_Click);
            // 
            // bFin
            // 
            this.bFin.Location = new System.Drawing.Point(56, 60);
            this.bFin.Name = "bFin";
            this.bFin.Size = new System.Drawing.Size(149, 23);
            this.bFin.TabIndex = 2;
            this.bFin.Text = "Finalizar Viaje";
            this.bFin.UseVisualStyleBackColor = true;
            this.bFin.Click += new System.EventHandler(this.bFin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(192, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora de finalización (HH:MM)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bFin);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalizar viaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bParada);
            this.Controls.Add(this.bIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bParada;
        private System.Windows.Forms.Button bFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

