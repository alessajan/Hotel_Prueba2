using System;
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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void BttnGuardarClien_Click(object sender, EventArgs e)
        {
            Cliente mCliente = new Cliente();

            mCliente.Nombre = TxtNomCliente.Text;
            mCliente.Ap_Paterno = TxtApCliente.Text;
            mCliente.Ap_Materno = TxtAmCliente.Text;
            mCliente.Edad = int.Parse(TxtEdad.Text);
            mCliente.RFC = TxtRFC.Text;

            BDcs mBD = new BDcs();

            if (mBD.Conectar())
            {
                if (mBD.GuardarCliente(mCliente))
                {
                    MessageBox.Show("Habitacion Guardada");
                }
                else
                {
                    MessageBox.Show("Error al guardar habitacion");
                }
                mBD.Desconectar();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }
    }
}
