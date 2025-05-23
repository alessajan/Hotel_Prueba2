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
    public partial class VerHabitacion : Form
    {
        private BDcs mBD;
        ArrayList ListaHabi;
        IngresarHabitacion mIngresarHabitacion;

        public VerHabitacion()
        {
            InitializeComponent();
            LeerHab();
        }

        private void LeerHab()
        {
            mBD = new BDcs();
            if (mBD.Conectar())
            {
                ListaHabi = mBD.ConsultarHabitacion();
                if(ListaHabi != null)
                {
                    DGVHabi.DataSource = null;
                    DGVHabi.DataSource = ListaHabi;
                }
                else
                {
                    MessageBox.Show("No hay habitaciones que mostrar");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }
        }

        private void TSBttnAgregar_Click(object sender, EventArgs e)
        {
            mIngresarHabitacion.ShowDialog();
            LeerHab();
        }

        private void TSBttnEliminar_Click(object sender, EventArgs e)
        {
            Habitacion mHabitacion;
            DialogResult respuesta;
            int filaselecc;

            if (DGVHabi.RowCount > 0)
            {
                filaselecc = DGVHabi.CurrentRow.Index;
                if (filaselecc >= 0)
                {
                    mHabitacion = (Habitacion)ListaHabi[filaselecc];
                    respuesta = MessageBox.Show(this, "¿Seguro que deseas eliminar la habitacion?", "Pregunta", MessageBoxButtons.YesNo);

                    if(respuesta == DialogResult.Yes)
                    {
                        if (mBD.Conectar())
                        {
                            if (mBD.EliminarHab(mHabitacion))
                            {
                                MessageBox.Show("Habitacion eliminada");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la habitacion");
                            }
                            mBD.Desconectar();
                            LeerHab();
                        }
                    }
                }
            }
        }

        private void TSBttnModificar_Click(object sender, EventArgs e)
        {
            Habitacion mHabitacion;
            int filaselecc;
            IngresarHabitacion mIngresarHabitacion;

            if(DGVHabi.RowCount > 0)
            {
                filaselecc = DGVHabi.CurrentRow.Index;
                if(filaselecc >= 0)
                {
                    mHabitacion = (Habitacion)ListaHabi[filaselecc];
                    mIngresarHabitacion = new IngresarHabitacion();
                    mIngresarHabitacion.setHabitacion(mHabitacion);
                    mIngresarHabitacion.ShowDialog();
                    LeerHab();
                }
            }
        }
    }
}
