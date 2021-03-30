
namespace MiniSuper
{
    partial class FrmPrincipal
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 9);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(219, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Bienvenido al Minisuper de Avellaneda, Mitre";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(310, 12);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(151, 23);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoClient_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(31, 51);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarios.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 98);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.lblDireccion);
            this.Name = "FrmPrincipal";
            this.Text = "Mini Super";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}

