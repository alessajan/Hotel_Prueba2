using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol2
{
    public partial class GenerarFactura : Form
    {
        private ArrayList ListaReserva = new ArrayList();
        BDcs mBD = new BDcs();

        private void LeerReserva()
        {
            if (mBD.Conectar())
            {
                ListaReserva = mBD.ConsultarReserva();
                if(ListaReserva != null)
                {
                    DGVFactura.DataSource = null;
                    DGVFactura.DataSource = ListaReserva;
                }
                else
                {
                    MessageBox.Show("No hay reservas guardadas");
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }

        public GenerarFactura()
        {
            InitializeComponent();
            LeerReserva();
        }

        private void bttnGenerarFac_Click(object sender, EventArgs e)
        {
            GuardarArchivo("Reserva.csv");
        }

        private void GuardarArchivo(string Reserva)
        {
            StreamWriter Escritor = new StreamWriter(Reserva);
            BDcs mBD = new BDcs();
            mBD.Conectar();
            ListaReserva = mBD.ConsultarReserva();
            foreach ( Reserva mReserva in ListaReserva)
            {
                Escritor.WriteLine(mReserva.id_reserva + "," + mReserva.id_user + "," + mReserva.id_hab + "," + mReserva.id_cliente + "," + mReserva.Tipo_pago + "," + mReserva.Fecha_ent + "," + mReserva.Fecha_sal + "," + mReserva.Total_pago);
            }
            Escritor.Close();
        }
    }
}
