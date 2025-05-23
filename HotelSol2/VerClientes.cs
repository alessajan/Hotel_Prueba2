using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol2
{
    public partial class VerClientes : Form
    {
        private BDcs mBD = new BDcs();
        ArrayList ListaClientes;
        IngresarCliente mIngresarCliente = new IngresarCliente();

        public VerClientes()
        {
            InitializeComponent();
            LeerClientes();
        }

        private void LeerClientes()
        {
            if (mBD.Conectar())
            {
                ListaClientes = mBD.ConsultarCliente();
                if(ListaClientes != null)
                {
                    DGVClientes.DataSource = null;
                    DGVClientes.DataSource = ListaClientes;
                }
                else
                {
                    MessageBox.Show("No hay clientes guardados");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }
        }

        private void TSBttnAgregar_Click(object sender, EventArgs e)
        {
            mIngresarCliente.ShowDialog();
            LeerClientes();
        }

        private void TSBttnEliminar_Click(object sender, EventArgs e)
        {
            Cliente mCliente;
            DialogResult respuesta;
            int filaselecc;

            if(DGVClientes.RowCount > 0)
            {
                filaselecc = DGVClientes.CurrentRow.Index;
                if(filaselecc >= 0)
                {
                    mCliente = (Cliente)ListaClientes[filaselecc];
                    respuesta = MessageBox.Show(this, "¿Seguro que deseas eliminar a " + mCliente.Nombre + "?", "Pregunta", MessageBoxButtons.YesNo);

                    if(respuesta == DialogResult.Yes)
                    {
                        if (mBD.Conectar())
                        {
                            if (mBD.EliminarCliente(mCliente))
                            {
                                MessageBox.Show("El cliente fue eliminado");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar al cliente");
                            }
                            mBD.Desconectar();
                            LeerClientes();
                        }
                    }
                }
            }
        }

        private void TSBttnModificar_Click(object sender, EventArgs e)
        {
            Cliente mCliente;
            int filaselecc;
            IngresarCliente mIngresarCliente = new IngresarCliente();

            if(DGVClientes.RowCount > 0)
            {
                filaselecc = DGVClientes.CurrentRow.Index;
                if(filaselecc >= 0)
                {
                    mCliente = (Cliente)ListaClientes[filaselecc];
                    mIngresarCliente.setClientes(mCliente);
                    mIngresarCliente.ShowDialog();
                    LeerClientes();
                }
            }
        }
    }
}
