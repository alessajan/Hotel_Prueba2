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
    public partial class IngresarHabitacion : Form
    {
        public IngresarHabitacion()
        {
            InitializeComponent();
        }

        private void BttnGuardarHabi_Click(object sender, EventArgs e)
        {
            Habitacion mHabitacion = new Habitacion();
            mHabitacion.Tipo = CBTipoHabit.Text;
            mHabitacion.Numero = int.Parse(TxtNumHab.Text);
            mHabitacion.Precio = int.Parse(TxtPrecio.Text);
            mHabitacion.Estado = CBEstado.Text;

            BDcs mBD = new BDcs();

            if (mBD.Conectar())
            {
                if (mBD.GuardarHabitacion(mHabitacion))
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
