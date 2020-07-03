namespace ClienteDelJuego
{
    partial class FormEstadisticasUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticasUsuario));
            this.buttonAjustes = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelCantPorcentaje = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.labelVictorias = new System.Windows.Forms.Label();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAjustes
            // 
            this.buttonAjustes.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAjustes.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjustes.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjustes.Image")));
            this.buttonAjustes.Location = new System.Drawing.Point(315, 12);
            this.buttonAjustes.Name = "buttonAjustes";
            this.buttonAjustes.Size = new System.Drawing.Size(32, 32);
            this.buttonAjustes.TabIndex = 0;
            this.buttonAjustes.UseVisualStyleBackColor = false;
            this.buttonAjustes.Click += new System.EventHandler(this.buttonAjustes_Click);
            this.buttonAjustes.MouseEnter += new System.EventHandler(this.buttonAjustes_MouseEnter);
            this.buttonAjustes.MouseLeave += new System.EventHandler(this.buttonAjustes_MouseLeave);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Jokerman", 7F, System.Drawing.FontStyle.Bold);
            this.labelBienvenida.Location = new System.Drawing.Point(47, 29);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(129, 15);
            this.labelBienvenida.TabIndex = 1;
            this.labelBienvenida.Text = "Bienvenido Usuario!!";
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Bold);
            this.labelPuntos.Location = new System.Drawing.Point(65, 157);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(82, 28);
            this.labelPuntos.TabIndex = 3;
            this.labelPuntos.Text = "Puntos";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Bold);
            this.labelPorcentaje.Location = new System.Drawing.Point(219, 157);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(32, 28);
            this.labelPorcentaje.TabIndex = 6;
            this.labelPorcentaje.Text = "%";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(359, 336);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(50, 95);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(110, 117);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(200, 95);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(110, 117);
            // 
            // labelCantPorcentaje
            // 
            this.labelCantPorcentaje.AutoSize = true;
            this.labelCantPorcentaje.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Bold);
            this.labelCantPorcentaje.Location = new System.Drawing.Point(244, 157);
            this.labelCantPorcentaje.Name = "labelCantPorcentaje";
            this.labelCantPorcentaje.Size = new System.Drawing.Size(49, 28);
            this.labelCantPorcentaje.TabIndex = 8;
            this.labelCantPorcentaje.Text = "100";
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Bold);
            this.labelPuntaje.Location = new System.Drawing.Point(74, 119);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(63, 28);
            this.labelPuntaje.TabIndex = 9;
            this.labelPuntaje.Text = "1000";
            this.labelPuntaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVictorias
            // 
            this.labelVictorias.AutoSize = true;
            this.labelVictorias.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Bold);
            this.labelVictorias.Location = new System.Drawing.Point(204, 119);
            this.labelVictorias.Name = "labelVictorias";
            this.labelVictorias.Size = new System.Drawing.Size(105, 28);
            this.labelVictorias.TabIndex = 10;
            this.labelVictorias.Text = "Victorias";
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(233, 42);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(114, 31);
            this.buttonCerrarSesion.TabIndex = 11;
            this.buttonCerrarSesion.Text = "Cerrar sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Visible = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonJugar
            // 
            this.buttonJugar.BackColor = System.Drawing.Color.Gold;
            this.buttonJugar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Location = new System.Drawing.Point(272, 274);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 50);
            this.buttonJugar.TabIndex = 2;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            this.buttonJugar.MouseEnter += new System.EventHandler(this.buttonJugar_MouseEnter);
            this.buttonJugar.MouseLeave += new System.EventHandler(this.buttonJugar_MouseLeave);
            // 
            // FormEstadisticasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.labelVictorias);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelCantPorcentaje);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.buttonAjustes);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FormEstadisticasUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstadisticasUsuario_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEstadisticasUsuario_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjustes;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelPorcentaje;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label labelCantPorcentaje;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label labelVictorias;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonJugar;
    }
}