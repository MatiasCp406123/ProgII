namespace Banco.Presentacion
{
    partial class FrmCuenta
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
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.ColCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColultMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbCbu = new System.Windows.Forms.Label();
            this.lbCuenta = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbUltMov = new System.Windows.Forms.Label();
            this.cboTIPcuent = new System.Windows.Forms.ComboBox();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtultMov = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbDNi = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCBU,
            this.ColTC,
            this.ColSaldo,
            this.ColultMov,
            this.ColBorrar});
            this.dtgClientes.Location = new System.Drawing.Point(12, 245);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.Size = new System.Drawing.Size(743, 150);
            this.dtgClientes.TabIndex = 0;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // ColCBU
            // 
            this.ColCBU.HeaderText = "CBU";
            this.ColCBU.Name = "ColCBU";
            this.ColCBU.ReadOnly = true;
            this.ColCBU.Width = 200;
            // 
            // ColTC
            // 
            this.ColTC.HeaderText = "Tipo de cuenta";
            this.ColTC.Name = "ColTC";
            this.ColTC.ReadOnly = true;
            this.ColTC.Width = 200;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            // 
            // ColultMov
            // 
            this.ColultMov.HeaderText = "Ultimo Movimiento";
            this.ColultMov.Name = "ColultMov";
            this.ColultMov.ReadOnly = true;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            // 
            // lbCbu
            // 
            this.lbCbu.AutoSize = true;
            this.lbCbu.Location = new System.Drawing.Point(30, 125);
            this.lbCbu.Name = "lbCbu";
            this.lbCbu.Size = new System.Drawing.Size(26, 13);
            this.lbCbu.TabIndex = 1;
            this.lbCbu.Text = "Cbu";
            // 
            // lbCuenta
            // 
            this.lbCuenta.AutoSize = true;
            this.lbCuenta.Location = new System.Drawing.Point(27, 154);
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(80, 13);
            this.lbCuenta.TabIndex = 2;
            this.lbCuenta.Text = "Tipo de Cuenta";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(27, 181);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbSaldo.TabIndex = 3;
            this.lbSaldo.Text = "Saldo";
            // 
            // lbUltMov
            // 
            this.lbUltMov.AutoSize = true;
            this.lbUltMov.Location = new System.Drawing.Point(27, 213);
            this.lbUltMov.Name = "lbUltMov";
            this.lbUltMov.Size = new System.Drawing.Size(93, 13);
            this.lbUltMov.TabIndex = 4;
            this.lbUltMov.Text = "Ultimo Movimiento";
            // 
            // cboTIPcuent
            // 
            this.cboTIPcuent.FormattingEnabled = true;
            this.cboTIPcuent.Location = new System.Drawing.Point(125, 151);
            this.cboTIPcuent.Name = "cboTIPcuent";
            this.cboTIPcuent.Size = new System.Drawing.Size(121, 21);
            this.cboTIPcuent.TabIndex = 5;
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(126, 125);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(100, 20);
            this.txtCBU.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(126, 178);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // txtultMov
            // 
            this.txtultMov.Enabled = false;
            this.txtultMov.Location = new System.Drawing.Point(126, 210);
            this.txtultMov.Name = "txtultMov";
            this.txtultMov.Size = new System.Drawing.Size(100, 20);
            this.txtultMov.TabIndex = 8;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(431, 208);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(171, 415);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 10;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(431, 414);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(27, 9);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(54, 13);
            this.lbCliente.TabIndex = 12;
            this.lbCliente.Text = "Cliente N*";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(30, 39);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(30, 68);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 14;
            this.lbApellido.Text = "Apellido";
            // 
            // lbDNi
            // 
            this.lbDNi.AutoSize = true;
            this.lbDNi.Location = new System.Drawing.Point(30, 94);
            this.lbDNi.Name = "lbDNi";
            this.lbDNi.Size = new System.Drawing.Size(26, 13);
            this.lbDNi.TabIndex = 15;
            this.lbDNi.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(125, 94);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 18;
            // 
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbDNi);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtultMov);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.cboTIPcuent);
            this.Controls.Add(this.lbUltMov);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbCuenta);
            this.Controls.Add(this.lbCbu);
            this.Controls.Add(this.dtgClientes);
            this.Name = "FrmCuenta";
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.FrmCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label lbCbu;
        private System.Windows.Forms.Label lbCuenta;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbUltMov;
        private System.Windows.Forms.ComboBox cboTIPcuent;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtultMov;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbDNi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColultMov;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
    }
}