using Banco.Datos;
using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Presentacion
{
    public partial class FrmCuenta : Form
    {
        DBHelper gestor=null;
        Cliente cl = null;
        public FrmCuenta()
        {
            gestor = new DBHelper();
            InitializeComponent();
            cl = new Cliente();
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            txtultMov.Text = DateTime.Now.ToShortDateString();
            lbCliente.Text = lbCliente.Text + " " + gestor.ProximoCliente().ToString();
            CargarCuentas();
        }

        private void CargarCuentas()
        {
            DataTable t = gestor.Consultar("SP_CONSULTAR_TIPOSCUENTA");
            cboTIPcuent.DataSource = t;
            cboTIPcuent.ValueMember = t.Columns[0].ColumnName;
            cboTIPcuent.DisplayMember = t.Columns[1].ColumnName;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (cboTIPcuent.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cuenta...","Control",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
        
            if (string.IsNullOrEmpty(txtCBU.Text))
            {
                MessageBox.Show("ingrese el CBU...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show("Ingrese el saldo...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRowView item = (DataRowView)cboTIPcuent.SelectedItem;
            int nom = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom2= item.Row.ItemArray[1].ToString();
            TipoCuenta tp = new TipoCuenta(nom);
            int cbu = Convert.ToInt32(txtCBU.Text);
            double saldo = Convert.ToDouble(txtSaldo.Text);
            DateTime ult = Convert.ToDateTime(txtultMov.Text);
            Cuenta cuenta = new Cuenta(cbu,saldo,ult,tp);
            cl.AgregarCuenta(cuenta);
            dtgClientes.Rows.Add(new object[] {cbu,nom2,saldo,ult,"Quitar"});


        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgClientes.CurrentCell.ColumnIndex==4)
            {
                cl.QuitarDetalle(dtgClientes.CurrentRow.Index);
                dtgClientes.Rows.RemoveAt(dtgClientes.CurrentRow.Index);

            }

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Ingrese el DNI...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Grabar();
        }

        private void Grabar()
        {
            cl.Nombre = txtNombre.Text;
            cl.Apellido = txtApellido.Text;
            cl.Dni = Convert.ToInt32(txtDNI.Text);
            if (gestor.Confirmar(cl))
            {
                MessageBox.Show("Se registro con exito...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la pestaña?","Cerrando",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Dispose();
            }
          
        }
    }
}
