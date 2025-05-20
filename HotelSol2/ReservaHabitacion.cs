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
using MySql.Data.MySqlClient;

namespace HotelSol2
{
    public partial class ReservaHabitacion : Form
    {
        private BDcs mBD;
        ArrayList listahabi;
        ArrayList listacliente;
        ArrayList ListaUsers;
        public ReservaHabitacion()
        {
            InitializeComponent();
            LeerHabi();
            LeerCliente();
            LeerUsers();
        }

        private void LeerHabi()
        {
            mBD = new BDcs();
            if (mBD.Conectar())
            {
                listahabi = mBD.ConsultarHabitacion();
                if(listahabi != null)
                {
                    DGVHabi.DataSource = null;
                    DGVHabi.DataSource = listahabi;
                }
            }
        }

        private void LeerCliente()
        {
            mBD = new BDcs();
            if (mBD.Conectar())
            {
                listacliente = mBD.ConsultarCliente();
                if(listacliente != null)
                {
                    DVGCliente.DataSource = null;
                    DVGCliente.DataSource = listacliente;
                }
            }
        }

        private void LeerUsers()
        {
            mBD = new BDcs();
            if (mBD.Conectar())
            {
                ListaUsers = mBD.ConsultarUsuarios();
                if (ListaUsers != null)
                {
                    DGVUsers.DataSource = null;
                    DGVUsers.DataSource = ListaUsers;
                }
            }
        }

        private void BttnRegistrar_Click(object sender, EventArgs e)
        {
            mBD = new BDcs();

            if(DGVHabi.CurrentRow == null || DVGCliente.CurrentRow == null || DGVUsers.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar una habitacion, cliente y usuario");
                return;
            }

            int id_hab = Convert.ToInt32(DGVHabi.CurrentRow.Cells["id_hab"].Value);
            //int id_hab = ((Habitacion)listahabi[DGVHabi.CurrentRow.Index]).id_hab;
            int id_cliente = Convert.ToInt32(DVGCliente.CurrentRow.Cells["id_cliente"].Value);
            int id_user = Convert.ToInt32(DGVUsers.CurrentRow.Cells["id_user"].Value);

            Reserva mReserva = new Reserva()
            {
                id_user = id_user,
                id_hab = id_hab,
                id_cliente = id_cliente,
                Tipo_pago = CMBTipoPago.SelectedItem.ToString(),
                Fecha_ent = DTPIngreso.Value,
                Fecha_sal = DTPSalida.Value,
                Total_pago = float.Parse(TxtTotalPagar.Text)
            };
            if (mBD.Conectar())
            {
                if (mBD.GuardarReserva(mReserva))
                {
                   

                    MessageBox.Show("Reserva guardada con exito");
                    LeerHabi();
                }
                else
                {
                    MessageBox.Show("Error al guardar la reserva");
                }
                mBD.Desconectar();
            }
            else
            {
                MessageBox.Show("Error al entrar a la base de datos");
            }
        }
    }
}
