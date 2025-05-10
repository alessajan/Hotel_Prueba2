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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BttnVer1_Click(object sender, EventArgs e)
        {
            mReservarHabitacion = new ReservaHabitacion();

            mReservarHabitacion.ShowDialog();

        }
    }
}
