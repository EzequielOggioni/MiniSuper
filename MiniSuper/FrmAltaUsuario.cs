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
    public partial class FrmAltaUsuario : Form
    {

        private Usuario usuario;
        public FrmAltaUsuario()
        {
            InitializeComponent();

         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //checkbox

            string[] formasDePago = new string[0];

            foreach(Control miControl in this.panelFormasPago.Controls)
            {
                if(miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasDePago, formasDePago.Length + 1);
                    formasDePago[formasDePago.Length - 1] = ((CheckBox)miControl).Text;
                }

            }


            //Radio Button
            string formaPago = String.Empty;
            foreach (Control item in groupBoxMedioPago.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                    formaPago = item.Text;
            }


            //ComboBox
            //esta linea llena el combo

            // this.cmbProvincia.DataSource =  coleccion propia de objetos

            string provincia= String.Empty;
            if (this.cmbProvincia.SelectedIndex == -1)
            {
                if (this.cmbProvincia.Text != String.Empty)
                    provincia = this.cmbProvincia.Text;
            }
            else
                provincia = this.cmbProvincia.SelectedItem.ToString();
            




            //Textbox y NumericUpDown
            this.usuario = new Usuario(this.txtApellido.Text, this.txtNombre.Text, 
                (long)this.numDni.Value, formasDePago, formaPago, provincia);

            this.DialogResult = DialogResult.OK;
            

        }

        private void chkEfectivo_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                this.groupBoxMedioPago.Visible = true;
            else
                this.groupBoxMedioPago.Visible = false;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAceptar.Enabled = true;
        }

        public Usuario GetUsuario()
        {
            return this.usuario;
        }

    }
}
