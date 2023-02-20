using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicación
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a Mi primera aplicación!");
        }

        private void PaginaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Gracias por utilizar nuestro servicio, hasta pronto!");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento click del boton!");
            //this.BackColor = Color.Blue;
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void PaginaPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el boton izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el bontón derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el boton del medio");
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Cyan;
            lblNombre.Cursor = Cursors.Hand;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = System.Drawing.SystemColors.Control;
            lblNombre.Cursor = Cursors.Arrow;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNuevo.Text.Length + " caracteres");
        }
    }
}
