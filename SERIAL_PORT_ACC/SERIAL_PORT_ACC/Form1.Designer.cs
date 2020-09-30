namespace SERIAL_PORT_ACC
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.boton_cerrar_select = new System.Windows.Forms.PictureBox();
            this.boton_cerrar_unselect = new System.Windows.Forms.PictureBox();
            this.boton_minimizar_select = new System.Windows.Forms.PictureBox();
            this.boton_minimizar_unselect = new System.Windows.Forms.PictureBox();
            this.label_cabecera = new System.Windows.Forms.Label();
            this.panel_cabecera = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar_unselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar_unselect)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_cerrar_select
            // 
            this.boton_cerrar_select.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar_select.Image")));
            this.boton_cerrar_select.Location = new System.Drawing.Point(827, 7);
            this.boton_cerrar_select.Name = "boton_cerrar_select";
            this.boton_cerrar_select.Size = new System.Drawing.Size(40, 40);
            this.boton_cerrar_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_cerrar_select.TabIndex = 208;
            this.boton_cerrar_select.TabStop = false;
            this.boton_cerrar_select.Click += new System.EventHandler(this.boton_cerrar_select_Click);
            this.boton_cerrar_select.MouseLeave += new System.EventHandler(this.boton_cerrar_select_MouseLeave);
            // 
            // boton_cerrar_unselect
            // 
            this.boton_cerrar_unselect.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar_unselect.Image")));
            this.boton_cerrar_unselect.Location = new System.Drawing.Point(829, 8);
            this.boton_cerrar_unselect.Name = "boton_cerrar_unselect";
            this.boton_cerrar_unselect.Size = new System.Drawing.Size(36, 36);
            this.boton_cerrar_unselect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_cerrar_unselect.TabIndex = 207;
            this.boton_cerrar_unselect.TabStop = false;
            this.boton_cerrar_unselect.MouseEnter += new System.EventHandler(this.boton_cerrar_unselect_MouseEnter);
            // 
            // boton_minimizar_select
            // 
            this.boton_minimizar_select.Image = ((System.Drawing.Image)(resources.GetObject("boton_minimizar_select.Image")));
            this.boton_minimizar_select.Location = new System.Drawing.Point(783, 7);
            this.boton_minimizar_select.Name = "boton_minimizar_select";
            this.boton_minimizar_select.Size = new System.Drawing.Size(40, 40);
            this.boton_minimizar_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_minimizar_select.TabIndex = 210;
            this.boton_minimizar_select.TabStop = false;
            this.boton_minimizar_select.Click += new System.EventHandler(this.boton_minimizar_select_Click);
            this.boton_minimizar_select.MouseLeave += new System.EventHandler(this.boton_minimizar_select_MouseLeave);
            // 
            // boton_minimizar_unselect
            // 
            this.boton_minimizar_unselect.Image = ((System.Drawing.Image)(resources.GetObject("boton_minimizar_unselect.Image")));
            this.boton_minimizar_unselect.Location = new System.Drawing.Point(785, 9);
            this.boton_minimizar_unselect.Name = "boton_minimizar_unselect";
            this.boton_minimizar_unselect.Size = new System.Drawing.Size(36, 36);
            this.boton_minimizar_unselect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_minimizar_unselect.TabIndex = 209;
            this.boton_minimizar_unselect.TabStop = false;
            this.boton_minimizar_unselect.MouseEnter += new System.EventHandler(this.boton_minimizar_unselect_MouseEnter);
            // 
            // label_cabecera
            // 
            this.label_cabecera.AutoSize = true;
            this.label_cabecera.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cabecera.ForeColor = System.Drawing.Color.Gray;
            this.label_cabecera.Location = new System.Drawing.Point(270, 15);
            this.label_cabecera.Name = "label_cabecera";
            this.label_cabecera.Size = new System.Drawing.Size(319, 23);
            this.label_cabecera.TabIndex = 211;
            this.label_cabecera.Text = "- NOMBRE DEL PROGRAMA - ";
            this.label_cabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_cabecera_MouseMove);
            // 
            // panel_cabecera
            // 
            this.panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cabecera.Location = new System.Drawing.Point(0, 0);
            this.panel_cabecera.Name = "panel_cabecera";
            this.panel_cabecera.Size = new System.Drawing.Size(875, 54);
            this.panel_cabecera.TabIndex = 212;
            this.panel_cabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_cabecera_MouseMove);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.label_cabecera);
            this.Controls.Add(this.boton_minimizar_select);
            this.Controls.Add(this.boton_minimizar_unselect);
            this.Controls.Add(this.boton_cerrar_select);
            this.Controls.Add(this.boton_cerrar_unselect);
            this.Controls.Add(this.panel_cabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar_unselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar_unselect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar_select;
        private System.Windows.Forms.PictureBox boton_cerrar_unselect;
        private System.Windows.Forms.PictureBox boton_minimizar_select;
        private System.Windows.Forms.PictureBox boton_minimizar_unselect;
        private System.Windows.Forms.Label label_cabecera;
        private System.Windows.Forms.Panel panel_cabecera;
    }
}

