namespace Ej3
{
    partial class Cargar_peaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nDia = new System.Windows.Forms.NumericUpDown();
            this.tBcantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día del mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de autos";
            // 
            // nDia
            // 
            this.nDia.Location = new System.Drawing.Point(141, 20);
            this.nDia.Name = "nDia";
            this.nDia.Size = new System.Drawing.Size(40, 20);
            this.nDia.TabIndex = 2;
            // 
            // tBcantidad
            // 
            this.tBcantidad.Location = new System.Drawing.Point(142, 58);
            this.tBcantidad.Name = "tBcantidad";
            this.tBcantidad.Size = new System.Drawing.Size(71, 20);
            this.tBcantidad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(33, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b.Location = new System.Drawing.Point(141, 123);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 5;
            this.b.Text = "Cerrar";
            this.b.UseVisualStyleBackColor = true;
            // 
            // Cargar_peaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 170);
            this.Controls.Add(this.b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBcantidad);
            this.Controls.Add(this.nDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cargar_peaje";
            this.Text = "Cargar_peaje";
            ((System.ComponentModel.ISupportInitialize)(this.nDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nDia;
        public System.Windows.Forms.TextBox tBcantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b;
    }
}