
namespace tarea_7
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonNotas = new System.Windows.Forms.Button();
            this.buttonProm = new System.Windows.Forms.Button();
            this.labelpromedio1 = new System.Windows.Forms.Label();
            this.labelpromedio2 = new System.Windows.Forms.Label();
            this.labelpromedio3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(53, 32);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(115, 23);
            this.buttonCargar.TabIndex = 4;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(199, 12);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(298, 238);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(49, 80);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(118, 24);
            this.buttonNombres.TabIndex = 5;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(521, 12);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(196, 238);
            this.listBoxResultado.TabIndex = 6;
            // 
            // buttonNotas
            // 
            this.buttonNotas.Location = new System.Drawing.Point(53, 128);
            this.buttonNotas.Name = "buttonNotas";
            this.buttonNotas.Size = new System.Drawing.Size(113, 25);
            this.buttonNotas.TabIndex = 7;
            this.buttonNotas.Text = "Notas parciales";
            this.buttonNotas.UseVisualStyleBackColor = true;
            this.buttonNotas.Click += new System.EventHandler(this.buttonNotas_Click);
            // 
            // buttonProm
            // 
            this.buttonProm.Location = new System.Drawing.Point(51, 174);
            this.buttonProm.Name = "buttonProm";
            this.buttonProm.Size = new System.Drawing.Size(115, 55);
            this.buttonProm.TabIndex = 8;
            this.buttonProm.Text = "Promedio, mayor y menor notas";
            this.buttonProm.UseVisualStyleBackColor = true;
            this.buttonProm.Click += new System.EventHandler(this.buttonProm_Click);
            // 
            // labelpromedio1
            // 
            this.labelpromedio1.AutoSize = true;
            this.labelpromedio1.Location = new System.Drawing.Point(216, 324);
            this.labelpromedio1.Name = "labelpromedio1";
            this.labelpromedio1.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio1.TabIndex = 9;
            // 
            // labelpromedio2
            // 
            this.labelpromedio2.AutoSize = true;
            this.labelpromedio2.Location = new System.Drawing.Point(216, 347);
            this.labelpromedio2.Name = "labelpromedio2";
            this.labelpromedio2.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio2.TabIndex = 9;
            // 
            // labelpromedio3
            // 
            this.labelpromedio3.AutoSize = true;
            this.labelpromedio3.Location = new System.Drawing.Point(216, 371);
            this.labelpromedio3.Name = "labelpromedio3";
            this.labelpromedio3.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 501);
            this.Controls.Add(this.labelpromedio3);
            this.Controls.Add(this.labelpromedio2);
            this.Controls.Add(this.labelpromedio1);
            this.Controls.Add(this.buttonProm);
            this.Controls.Add(this.buttonNotas);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonNotas;
        private System.Windows.Forms.Button buttonProm;
        private System.Windows.Forms.Label labelpromedio1;
        private System.Windows.Forms.Label labelpromedio2;
        private System.Windows.Forms.Label labelpromedio3;
    }
}

