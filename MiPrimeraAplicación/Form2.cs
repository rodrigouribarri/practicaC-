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
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) 
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<TextBox> DatosPersonales = new List<TextBox>();


            DatosPersonales.Add(txtApellido);
            DatosPersonales.Add(txtNombre);
            DatosPersonales.Add(txtEdad);
            DatosPersonales.Add(txtDireccion);

            foreach (var item in DatosPersonales)
            {
                if (item.TextLength == 0)
                    item.BackColor = Color.Red;
            }

            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + "\r\n" + "Edad: " + txtEdad.Text + "\r\n" + "Dirección: " + txtDireccion.Text;
            
        }

     
    }
}
