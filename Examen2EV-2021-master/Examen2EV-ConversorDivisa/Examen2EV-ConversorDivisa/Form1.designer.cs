namespace Ejercicio10
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
            this.tImporte = new System.Windows.Forms.TextBox();
            this.tResultado = new System.Windows.Forms.TextBox();
            this.bAPesetas = new System.Windows.Forms.Button();
            this.bAEuros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe:";
            // 
            // tImporte
            // 
            this.tImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tImporte.Location = new System.Drawing.Point(158, 69);
            this.tImporte.Margin = new System.Windows.Forms.Padding(2);
            this.tImporte.Name = "tImporte";
            this.tImporte.Size = new System.Drawing.Size(103, 38);
            this.tImporte.TabIndex = 2;
            // 
            // tResultado
            // 
            this.tResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tResultado.Location = new System.Drawing.Point(158, 122);
            this.tResultado.Margin = new System.Windows.Forms.Padding(2);
            this.tResultado.Name = "tResultado";
            this.tResultado.ReadOnly = true;
            this.tResultado.Size = new System.Drawing.Size(104, 38);
            this.tResultado.TabIndex = 3;
            // 
            // bAPesetas
            // 
            this.bAPesetas.Location = new System.Drawing.Point(45, 200);
            this.bAPesetas.Margin = new System.Windows.Forms.Padding(2);
            this.bAPesetas.Name = "bAPesetas";
            this.bAPesetas.Size = new System.Drawing.Size(101, 34);
            this.bAPesetas.TabIndex = 4;
            this.bAPesetas.Text = "Dólares a Euros";
            this.bAPesetas.UseVisualStyleBackColor = true;
            this.bAPesetas.Click += new System.EventHandler(this.btDolaresAEuros_Click);
            // 
            // bAEuros
            // 
            this.bAEuros.Location = new System.Drawing.Point(221, 200);
            this.bAEuros.Margin = new System.Windows.Forms.Padding(2);
            this.bAEuros.Name = "bAEuros";
            this.bAEuros.Size = new System.Drawing.Size(99, 36);
            this.bAEuros.TabIndex = 5;
            this.bAEuros.Text = "Euros a Dólares";
            this.bAEuros.UseVisualStyleBackColor = true;
            this.bAEuros.Click += new System.EventHandler(this.btEurosADolares_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Euros a Libras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btEurosALibras_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Libras a Euros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btLibrasAEuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bAEuros);
            this.Controls.Add(this.bAPesetas);
            this.Controls.Add(this.tResultado);
            this.Controls.Add(this.tImporte);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tImporte;
        private System.Windows.Forms.TextBox tResultado;
        private System.Windows.Forms.Button bAPesetas;
        private System.Windows.Forms.Button bAEuros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

