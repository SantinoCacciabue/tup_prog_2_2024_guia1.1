namespace Ej3
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
            this.lBinforme = new System.Windows.Forms.ListBox();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBinforme
            // 
            this.lBinforme.FormattingEnabled = true;
            this.lBinforme.Location = new System.Drawing.Point(24, 13);
            this.lBinforme.Name = "lBinforme";
            this.lBinforme.Size = new System.Drawing.Size(258, 199);
            this.lBinforme.TabIndex = 0;
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(301, 29);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 1;
            this.bRegistrar.Text = "Registrar peaje";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(301, 80);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 23);
            this.bVer.TabIndex = 2;
            this.bVer.Text = "Ver informe";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 247);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.lBinforme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBinforme;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bVer;
    }
}

