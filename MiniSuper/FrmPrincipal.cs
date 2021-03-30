using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void btnNuevoClient_Click(object sender, EventArgs e)
        {

            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Location = this.Location;
            if (frmAltaUsuario.ShowDialog() == DialogResult.OK)
                MiniSuper.AgregarUsuario(frmAltaUsuario.GetUsuario());


            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = MiniSuper.GetUsuarios();

        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere cerrar el programa sin calificarnos? ", "cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

        }
    }
}
