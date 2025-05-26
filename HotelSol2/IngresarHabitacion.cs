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
        private int Modo;
        private int id_hab;
        public IngresarHabitacion()
        {
            InitializeComponent();
            Modo = 0;
        }

        public void setHabitacion(Habitacion mHabitacion)
        {
            Modo = 1;
            id_hab = mHabitacion.id_hab;
            CBTipoHabit.Text = mHabitacion.Tipo;
            TxtNumHab.Text = mHabitacion.Numero.ToString();
            TxtPrecio.Text = mHabitacion.Precio.ToString();
            CBEstado.Text = mHabitacion.Estado;

        }

        private void BttnGuardarHabi_Click(object sender, EventArgs e)
        {
            Habitacion mHabitacion = new Habitacion();

            mHabitacion.id_hab = id_hab;
            mHabitacion.Tipo = CBTipoHabit.Text;
            mHabitacion.Numero = int.Parse(TxtNumHab.Text);
            mHabitacion.Precio = int.Parse(TxtPrecio.Text);
            mHabitacion.Estado = CBEstado.Text;

            BDcs mBD = new BDcs();

            if (mBD.Conectar())
            {
                if (Modo == 0)
                {
                    if (mBD.GuardarHabitacion(mHabitacion))
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
                    if (mBD.ModificarHabita(mHabitacion))
                    {
                        MessageBox.Show("Habitacion modificada");
                        mBD.Desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la habitacion");
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
