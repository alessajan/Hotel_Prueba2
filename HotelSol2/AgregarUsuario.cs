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
    public partial class AgregarUsuario : Form
    {
        private int Modo;
        public AgregarUsuario()
        {
            InitializeComponent();
            Modo = 0;
        }

        public void setUsuarios(Usuario mUsuario)
        {
            Modo = 1;
            TxtNombre.Text = mUsuario.Nombre;
            TxtTipo.Text = mUsuario.Tipo;
            TxtContraseña.Text = mUsuario.Contraseña;
            TxtAp_paterno.Text = mUsuario.Ap_paterno;
            TxtAp_materno.Text = mUsuario.Ap_materno;
        }
        private void BttnAgregar_Click(object sender, EventArgs e)
        {
            Usuario mUsuario = new Usuario();

            mUsuario.Nombre =  (TxtNombre.Text);
            mUsuario.Ap_paterno = (TxtAp_paterno.Text);
            mUsuario.Ap_materno = (TxtAp_materno.Text);
            mUsuario.Tipo = (TxtTipo.Text);
            mUsuario.Contraseña = (TxtContraseña.Text);

            BDcs mBD = new BDcs();

            if (mBD.Conectar())
            {
                if (Modo == 0)
                {
                    if (mBD.GuardarUsuario(mUsuario))
                    {
                        MessageBox.Show("Usuario guardado");
                        mBD.Desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar");
                    }
                }
                else
                {
                    if (mBD.Modificar(mUsuario))
                    {
                        MessageBox.Show("Usuario modificado");
                        mBD.Desconectar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el usuario");
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la Base de datos");
            }
        }
    }
}
