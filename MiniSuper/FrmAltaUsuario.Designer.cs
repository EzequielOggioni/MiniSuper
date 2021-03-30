
namespace MiniSuper
{
    partial class FrmAltaUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkApp = new System.Windows.Forms.CheckBox();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.groupBoxMedioPago = new System.Windows.Forms.GroupBox();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optApp = new System.Windows.Forms.RadioButton();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            this.panelFormasPago.SuspendLayout();
            this.groupBoxMedioPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 28);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 88);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(101, 20);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // numDni
            // 
            this.numDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDni.Location = new System.Drawing.Point(101, 86);
            this.numDni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(140, 16);
            this.numDni.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(166, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(37, 116);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(79, 13);
            this.lblFormaPago.TabIndex = 7;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Checked = true;
            this.chkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEfectivo.Location = new System.Drawing.Point(22, 9);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 8;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            this.chkEfectivo.CheckStateChanged += new System.EventHandler(this.chkEfectivo_CheckStateChanged);
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Checked = true;
            this.chkTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTarjeta.Location = new System.Drawing.Point(107, 9);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 9;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkApp
            // 
            this.chkApp.AutoSize = true;
            this.chkApp.Checked = true;
            this.chkApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApp.Location = new System.Drawing.Point(189, 9);
            this.chkApp.Name = "chkApp";
            this.chkApp.Size = new System.Drawing.Size(75, 17);
            this.chkApp.TabIndex = 10;
            this.chkApp.Text = "Aplicacion";
            this.chkApp.UseVisualStyleBackColor = true;
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.chkApp);
            this.panelFormasPago.Controls.Add(this.chkTarjeta);
            this.panelFormasPago.Controls.Add(this.chkEfectivo);
            this.panelFormasPago.Location = new System.Drawing.Point(40, 141);
            this.panelFormasPago.Name = "panelFormasPago";
            this.panelFormasPago.Size = new System.Drawing.Size(287, 39);
            this.panelFormasPago.TabIndex = 11;
            // 
            // groupBoxMedioPago
            // 
            this.groupBoxMedioPago.Controls.Add(this.optApp);
            this.groupBoxMedioPago.Controls.Add(this.optTarjeta);
            this.groupBoxMedioPago.Controls.Add(this.optEfectivo);
            this.groupBoxMedioPago.Location = new System.Drawing.Point(39, 190);
            this.groupBoxMedioPago.Name = "groupBoxMedioPago";
            this.groupBoxMedioPago.Size = new System.Drawing.Size(287, 56);
            this.groupBoxMedioPago.TabIndex = 12;
            this.groupBoxMedioPago.TabStop = false;
            this.groupBoxMedioPago.Text = "Medio de pago";
            this.groupBoxMedioPago.Visible = false;
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(15, 28);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(109, 28);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optApp
            // 
            this.optApp.AutoSize = true;
            this.optApp.Location = new System.Drawing.Point(192, 31);
            this.optApp.Name = "optApp";
            this.optApp.Size = new System.Drawing.Size(74, 17);
            this.optApp.TabIndex = 2;
            this.optApp.TabStop = true;
            this.optApp.Text = "Aplicacion";
            this.optApp.UseVisualStyleBackColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(46, 257);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 13;
            this.lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "CABA",
            "Buenos Aires",
            "La Pampa",
            "Santa Fe",
            "Cordoba",
            "Mendoza",
            "Entre Rios"});
            this.cmbProvincia.Location = new System.Drawing.Point(120, 257);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 14;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 406);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.groupBoxMedioPago);
            this.Controls.Add(this.panelFormasPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(1500, 0);
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmAltaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            this.groupBoxMedioPago.ResumeLayout(false);
            this.groupBoxMedioPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkApp;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.GroupBox groupBoxMedioPago;
        private System.Windows.Forms.RadioButton optApp;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
    }
}