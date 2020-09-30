using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SERIAL_PORT_ACC
{
    public partial class Form_Principal : Form
    {
        // PARA HACER EL BORDE DEL FORMULARIO REDONDEADO //
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        // --------------------------------------------- //

        public Form_Principal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30)); //RADIO DEL BORDE DE 30
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boton_cerrar_select.Visible = false;
            boton_cerrar_unselect.Visible = true;
            boton_minimizar_select.Visible = false;
            label_cabecera.Text = "- NOMBRE DEL PROGRAMA -";
        }

        private void boton_cerrar_unselect_MouseEnter(object sender, EventArgs e)
        {
            boton_cerrar_select.Visible = true;
        }

        private void boton_cerrar_select_MouseLeave(object sender, EventArgs e)
        {
            boton_cerrar_select.Visible = false;
        }

        private void boton_cerrar_select_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_minimizar_unselect_MouseEnter(object sender, EventArgs e)
        {
            boton_minimizar_select.Visible = true;
        }

        private void boton_minimizar_select_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void boton_minimizar_select_MouseLeave(object sender, EventArgs e)
        {
            boton_minimizar_select.Visible = false;
        }

        int posX = 0;
        int posY = 0;

        private void label_cabecera_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void panel_cabecera_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
