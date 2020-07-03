
using ClienteDelJuego.Modelo;

namespace ClienteDelJuego
{
    partial class FormBuscarPartida
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
            this.labelBuscarPartida = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBuscarPartida
            // 
            this.labelBuscarPartida.AutoSize = true;
            this.labelBuscarPartida.Location = new System.Drawing.Point(87, 56);
            this.labelBuscarPartida.Name = "labelBuscarPartida";
            this.labelBuscarPartida.Size = new System.Drawing.Size(89, 13);
            this.labelBuscarPartida.TabIndex = 0;
            this.labelBuscarPartida.Text = "buscando partida";
            
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(88, 99);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
           // this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormBuscarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 149);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelBuscarPartida);
            this.Name = "FormBuscarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscando...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscarPartida;
        private System.Windows.Forms.Button buttonCancelar;
    }
}