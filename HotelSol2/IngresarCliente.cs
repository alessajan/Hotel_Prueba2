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
        private int Modo;
        BDcs mBD = new BDcs();

        public IngresarCliente()
        {
            InitializeComponent();
            Modo = 0;
        }

        public void setClientes(Cliente mCliente)
        {
            Modo = 1;
            TxtNomCliente.Text = mCliente.Nombre;
            TxtApCliente.Text = mCliente.Ap_Paterno;
            TxtAmCliente.Text = mCliente.Ap_Materno;
            TxtEdad.Text = mCliente.Edad.ToString();
            TxtRFC.Text = mCliente.RFC;
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
                if (Modo == 0)
                {
                    if (mBD.GuardarCliente(mCliente))
                    {
                        MessageBox.Show("Habitacion Guardada");
                        mBD.Desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar habitacion");
                    }
                }
                else
                {
                    if (mBD.ModificarCliente(mCliente))
                    {
                        MessageBox.Show("Cliente modificado");
                        mBD.Desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Error al modifcar al cliente");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }
    }
}
