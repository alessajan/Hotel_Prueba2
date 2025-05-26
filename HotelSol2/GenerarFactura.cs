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
        ReservaHabitacion mReservarHabitacion = new ReservaHabitacion();

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
            if(DGVFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reservacion para facturar");
                return;
            }

            DataGridViewRow fila = DGVFactura.SelectedRows[0];

            Reserva mReserva = new Reserva()
            {
                id_reserva = Convert.ToInt32(fila.Cells["id_reserva"].Value.ToString()),
                id_user = Convert.ToInt32(fila.Cells["id_user"].Value.ToString()),
                id_hab = Convert.ToInt32(fila.Cells["id_hab"].Value.ToString()),
                id_cliente = Convert.ToInt32(fila.Cells["id_user"].Value.ToString()),
                Tipo_pago = fila.Cells["Tipo_pago"].Value.ToString(),
                Fecha_ent = Convert.ToDateTime(fila.Cells["Fecha_ent"].Value),
                Fecha_sal = Convert.ToDateTime(fila.Cells["Fecha_sal"].Value),
                Total_pago = float.Parse(fila.Cells["Total_pago"].Value.ToString())
            };

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Factura_Reserva_{mReserva.id_reserva}.pdf";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FacturaGenerator.GenerarFactura(mReserva, saveFileDialog.FileName);
                MessageBox.Show("Factura generada correctamente");
            }
        }

        private void TSBttnAgregar_Click(object sender, EventArgs e)
        {
            mReservarHabitacion.ShowDialog();
            LeerReserva();
        }

        private void TSBttnEliminar_Click(object sender, EventArgs e)
        {
            Reserva mReserva;
            DialogResult respuesta;
            int filaselecc;

            if(DGVFactura.RowCount > 0)
            {
                filaselecc = DGVFactura.CurrentRow.Index;
                if(filaselecc >= 0)
                {
                    mReserva = (Reserva)ListaReserva[filaselecc];
                    respuesta = MessageBox.Show(this, "¿Seguro que desea eliminar la reserva?", "Pregunta", MessageBoxButtons.YesNo);

                    if(respuesta == DialogResult.Yes)
                    {
                        if (mBD.Conectar())
                        {
                            if (mBD.EliminarResrva(mReserva))
                            {
                                MessageBox.Show("La reserva fue eliminada");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la reserva");
                            }
                            mBD.Desconectar();
                            LeerReserva();
                        }
                    }
                }
            }
        }
    }
}
