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
    public partial class VerUsuarios : Form
    {
        private BDcs mBD;
        ArrayList ListaUsers;
        AgregarUsuario mAgregarUsuario;

        public VerUsuarios()
        {
            InitializeComponent();
            LeerUsers();
        }

        private void LeerUsers()
        {
            mBD = new BDcs();
            if (mBD.Conectar())
            {
                ListaUsers = mBD.ConsultarUsuarios();
                if(ListaUsers != null)
                {
                    DGVUsers.DataSource = null;
                    DGVUsers.DataSource = ListaUsers;
                }
                else
                {
                    MessageBox.Show("No hay ususarios que mostrar");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar a la Base de datos");
            }
        }

        private void TSBttnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario mAgregarUsuario = new AgregarUsuario();
            mAgregarUsuario.Show();
            LeerUsers();
        }

        private void TSBttnEliminar_Click(object sender, EventArgs e)
        {
            Usuario mUsuario;
            DialogResult respuesta;
            int filaselecc;

            if (DGVUsers.RowCount > 0)
            {
                filaselecc = DGVUsers.CurrentRow.Index;
                if (filaselecc >= 0)
                {
                    mUsuario = (Usuario)ListaUsers[filaselecc];
                    respuesta = MessageBox.Show(this, "¿Seguro que deseas eliminar a " + mUsuario.Nombre + "?", "Pregunta", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (mBD.Conectar())
                        {
                            if (mBD.EliminarUser(mUsuario))
                            {
                                MessageBox.Show("Usuario eliminado");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar al usuario");
                            }
                            mBD.Desconectar();
                            LeerUsers();
                        }
                    }
                }
            }
        }

        private void TSBttnModificar_Click(object sender, EventArgs e)
        {
            Usuario mUsuario;
            int filaselecc;
            AgregarUsuario mAgregarUsuario;

            if(DGVUsers.RowCount > 0)
            {
                filaselecc = DGVUsers.CurrentRow.Index;
                if(filaselecc >= 0)
                {
                    mUsuario = (Usuario)ListaUsers[filaselecc];
                    mAgregarUsuario = new AgregarUsuario();
                    mAgregarUsuario.setUsuarios(mUsuario);
                    mAgregarUsuario.ShowDialog();
                    LeerUsers();
                }
            }
        }
    }
}
