using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol2
{
    public partial class Form1 : Form
    {
        MenuPrincipal mMenuPrincipal;
        public Form1()
        {
            InitializeComponent();
        }

        private void BttnLogin_Click(object sender, EventArgs e)
        {
            mMenuPrincipal = new MenuPrincipal();
            using (BDcs mBD = new BDcs())
            {
                if (mBD.Conectar())
                {
                    string user = TxtUser.Text;
                    string contra = TxtContraseña.Text;

                    if(mBD.ValidarUsuario(user, contra))
                    {
                        MessageBox.Show("Inicio Exitoso");
                        mMenuPrincipal.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
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
}
