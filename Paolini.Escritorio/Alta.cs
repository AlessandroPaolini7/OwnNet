using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paolini.Entidades;
using Paolini.Negocio;

namespace Paolini.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GuardarCambios()
        {
            Entidades.Usuario user = new Entidades.Usuario();
            user.NombreUsuario = txtNombreUsuario.Text;
            user.Clave = txtClave.Text;
            user.Email = txtEmail.Text;
            user.TipoUsuario = Convert.ToInt32(txtTipoUsuario.Text);
            // user.UltimoIngreso = Convert.ToDateTime(txtUltimoIngreso.Text);
            Paolini.Negocio.Usuario.Agregar(user);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombreUsuario.Text != "" & txtUltimoIngreso.Text != "" & txtClave.Text != "" & txtEmail.Text !="" & txtTipoUsuario.Text != "" & Validaciones.EsMailValido(txtEmail.Text))
            {
                GuardarCambios();
                this.Close();
            }
            else { MessageBox.Show("No pasó validaciones", "ERROR", MessageBoxButtons.OK); }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
