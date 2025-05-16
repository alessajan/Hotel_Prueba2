using System;
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
    public partial class MenuPrincipal : Form
    {
        ReservaHabitacion mReservarHabitacion;
        IngresarCliente mIngresarCliente = new IngresarCliente();
        IngresarHabitacion mIngresarHabitacion = new IngresarHabitacion();
        VerUsuarios mVerUsuarios = new VerUsuarios();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BttnVer1_Click(object sender, EventArgs e)
        {
            mReservarHabitacion = new ReservaHabitacion();

            mReservarHabitacion.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BttnVRegistrarC_Click(object sender, EventArgs e)
        {
            mIngresarCliente.ShowDialog();
        }

        private void BttnVRegistrarH_Click(object sender, EventArgs e)
        {
            mIngresarHabitacion.ShowDialog();
        }

        private void btnUsuarios2_Click(object sender, EventArgs e)
        {
            mVerUsuarios.ShowDialog();
        }
    }
}
