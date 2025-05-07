using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace HotelSol2
{
    internal class BDcs : IDisposable
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;
        private bool disposed = false;

        public BDcs()
        {
            CadenaConexion = "Server=localhost;Database=HotelSol;Uid=root;Pwd=;";
        }

        public bool Conectar()
        {
            try
            {
                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Desconectar()
        {
            if (Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public bool GuardarCliente(Cliente mCliente)
        {
            string textocomando = "insert into Cliente (id_cliente, Nombre, Ap_paterno, Ap_materno, Edad, RFC) values (" +
                mCliente.id_cliente + "," +
                "\"" + mCliente.Nombre + "\"," +
                "\"" + mCliente.Ap_paterno + "\"," +
                "\"" + mCliente.Ap_materno + "\"," +
                mCliente.Edad + "," +
                mCliente.RFC + ");";

            try
            {
                Consulta = new MySqlCommand(textocomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public ArrayList ConsultarUsuarios()
        {
            ArrayList listaUser = new ArrayList();
            MySqlDataReader Lector;
            User mUser;

            string textocomando = "select * from user limit 50";
            try
            {
                Consulta = new MySqlCommand(textocomando, Conexion);
                Lector = Consulta.ExecuteReader();

                while (Lector.Read())
                {
                    mUser = new User
                    {
                        id_User = Lector.GetInt32("id_user"),
                        Nombre = Lector.GetString("Nombre"),
                        Tipo = Lector.GetString("Tipo"),
                        Contraseña = Lector.GetString("Contraseña"),
                        Ap_paterno = Lector.GetString("Ap_paterno"),
                        Ap_materno = Lector.GetString("Ap_materno")
                    };
                    listaUser.Add(mUser);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return listaUser;
        }

        public bool Eliminar(User mUser)
        {
            string textocomando = "delete from user " + "where id_user = " + mUser.id_User;

            try
            {
                Consulta = new MySqlCommand(textocomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Modificar(User mUser)
        {
            string textcomando = "update user " +
                "set Nombre = \"" + mUser.Nombre + "\"," +
                "Tipo = \"" + mUser.Tipo + "\"," +
                "Contraseña = \"" + mUser.Contraseña + "\"," +
                "Ap_paterno = \"" + mUser.Ap_paterno + "\"," +
                "Ap_materno = \"" + mUser.Ap_materno + "\"," +
                "where id_user = " + mUser.id_User + ";";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (Consulta != null) Consulta.Dispose();
                    if (Conexion != null) Conexion.Dispose();
                }
                disposed = true;
            }
        }

        ~BDcs()
        {
            Dispose(false);
        }

        public bool ValidarUsuario(string Nombre, string Contraseña)
        {
            string textcomando = "select count(*) from user where Nombre = @Nombre and Contraseña = @Contraseña";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.Parameters.AddWithValue("@Nombre", Nombre);
                Consulta.Parameters.AddWithValue("@contraseña", Contraseña);

                int count = Convert.ToInt32(Consulta.ExecuteScalar());
                return count > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
