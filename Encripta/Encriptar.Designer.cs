namespace Encripta
{
    partial class Encriptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encriptar));
            this.Encripta = new System.Windows.Forms.Button();
            this.Desencripta = new System.Windows.Forms.Button();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encripta
            // 
            this.Encripta.Location = new System.Drawing.Point(29, 163);
            this.Encripta.Name = "Encripta";
            this.Encripta.Size = new System.Drawing.Size(75, 23);
            this.Encripta.TabIndex = 0;
            this.Encripta.Text = "Encriptar";
            this.Encripta.UseVisualStyleBackColor = true;
            this.Encripta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desencripta
            // 
            this.Desencripta.Location = new System.Drawing.Point(110, 163);
            this.Desencripta.Name = "Desencripta";
            this.Desencripta.Size = new System.Drawing.Size(75, 23);
            this.Desencripta.TabIndex = 1;
            this.Desencripta.Text = "Desencriptar";
            this.Desencripta.UseVisualStyleBackColor = true;
            this.Desencripta.Click += new System.EventHandler(this.button2_Click);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(77, 64);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(195, 20);
            this.textContraseña.TabIndex = 2;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(77, 109);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(195, 20);
            this.textResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Encriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.Desencripta);
            this.Controls.Add(this.Encripta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encriptar";
            this.Text = "Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encripta;
        private System.Windows.Forms.Button Desencripta;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

