using System;
using System.Collections;
using System.Data;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public bool GuardarUsuario(Usuario mUsuario)
        {
            string textcomando = "insert into user (Nombre, Tipo, Contraseña, Ap_paterno, Ap_materno) values (" +
                "\"" + mUsuario.Nombre + "\"," +
                "\"" + mUsuario.Tipo + "\"," +
                "\"" + mUsuario.Contraseña + "\"," +
                "\"" + mUsuario.Ap_paterno + "\"," +
                "\"" + mUsuario.Ap_materno + "\");";

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

        public bool GuardarCliente(Cliente mCliente)
        {
            string textocomando = "insert into cliente (Nombre, Ap_paterno, Ap_materno, Edad, RFC) values (" +
                "\"" + mCliente.Nombre + "\"," +
                "\"" + mCliente.Ap_Paterno + "\"," +
                "\"" + mCliente.Ap_Materno + "\"," +
                mCliente.Edad + "," +
                "\"" + mCliente.RFC + "\");";

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

        public bool GuardarHabitacion(Habitacion mHabitacion)
        {
            string textcomando = "insert into habitacion (Tipo, Numero, Precio, Estado) values (" +
                "\"" + mHabitacion.Tipo + "\"," +
                mHabitacion.Numero + "," +
                mHabitacion.Precio + "," +
                "\"" + mHabitacion.Estado + "\")";

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

        public bool GuardarReserva(Reserva mReserva)
        {
            string textcomando = "insert into reserva (id_user, id_hab, id_cliente, Tipo_pago, Fecha_ent, Fecha_sal, Total_pago) values " +
                "(@id_user, @id_hab, @id_cliente, @Tipo_pago, @Fecha_ent, @Fecha_sal, @Total_pago)";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.Parameters.AddWithValue("@id_user", mReserva.id_user);
                Consulta.Parameters.AddWithValue("@id_hab", mReserva.id_hab);
                Consulta.Parameters.AddWithValue("@id_cliente", mReserva.id_cliente);
                Consulta.Parameters.AddWithValue("@Tipo_pago", mReserva.Tipo_pago);
                Consulta.Parameters.AddWithValue("@Fecha_ent", mReserva.Fecha_ent.Date);
                Consulta.Parameters.AddWithValue("@Fecha_sal", mReserva.Fecha_sal.Date);
                Consulta.Parameters.AddWithValue("@Total_pago", mReserva.Total_pago);
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
            Usuario mUser;

            string textocomando = "select * from user limit 50";
            try
            {
                Consulta = new MySqlCommand(textocomando, Conexion);
                Lector = Consulta.ExecuteReader();

                while (Lector.Read())
                {
                    mUser = new Usuario
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

        public ArrayList ConsultarHabitacion()
        {
            ArrayList listahabi = new ArrayList();
            MySqlDataReader Lector;
            Habitacion mHabitacion;

            string textcomando = "select * from habitacion limit 50";
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Lector = Consulta.ExecuteReader();

                while (Lector.Read())
                {
                    mHabitacion = new Habitacion
                    {
                        id_hab = Lector.GetInt32("id_hab"),
                        Tipo = Lector.GetString("Tipo"),
                        Numero = Lector.GetInt32("Numero"),
                        Precio = Lector.GetInt32("Precio"),
                        Estado = Lector.GetString("Estado")

                    };
                    listahabi.Add(mHabitacion);
                }
            }
            catch(Exception e)
            {
                return null;
            }
            return listahabi;
        }

        public ArrayList ConsultarCliente()
        {
            ArrayList listaCliente = new ArrayList();
            MySqlDataReader Lector;
            Cliente mCliente;

            string textcomando = "select * from cliente limit 50";
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Lector = Consulta.ExecuteReader();

                while (Lector.Read())
                {
                    mCliente = new Cliente
                    {
                        id_cliente = Lector.GetInt32("id_cliente"),
                        Nombre = Lector.GetString("Nombre"),
                        Ap_Paterno = Lector.GetString("Ap_paterno"),
                        Ap_Materno = Lector.GetString("Ap_materno"),
                        Edad = Lector.GetInt32("Edad"),
                        RFC = Lector.GetString("RFC")
                    };
                    listaCliente.Add(mCliente);
                }
            }catch(Exception e)
            {
                return null;
            }
            return listaCliente;
        }
        public ArrayList ConsultarReserva()
        {
            ArrayList ListaReserva = new ArrayList();
            MySqlDataReader Lector;
            Reserva mReserva;

            string textcomando = "select * from reserva limit 50";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Lector = Consulta.ExecuteReader();

                while (Lector.Read())
                {
                    mReserva = new Reserva
                    {
                        id_reserva = Lector.GetInt32("id_reserva"),
                        id_user = Lector.GetInt32("id_user"),
                        id_hab = Lector.GetInt32("id_hab"),
                        id_cliente = Lector.GetInt32("id_cliente"),
                        Tipo_pago = Lector.GetString("Tipo_pago"),
                        Fecha_ent = Lector.GetDateTime("Fecha_ent"),
                        Fecha_sal = Lector.GetDateTime("Fecha_sal")
                    };
                    ListaReserva.Add(mReserva);
                }
            }catch (Exception e)
            {
                return null;
            }
            return ListaReserva;
        }

        public bool EliminarUser(Usuario mUser)
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

        public bool EliminarCliente(Cliente mCliente)
        {
            string textcomando = "delete from cliente " + "where id_cliente = " + mCliente.id_cliente;
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool EliminarHab(Habitacion mHabitacion)
        {
            string textcomando = "delete from habitacion " + "where id_hab = " + mHabitacion.id_hab;
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool EliminarResrva(Reserva mReserva)
        {
            string textcomando = "delete from reserva " + "where id_reserva = " + mReserva.id_reserva;
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool ModificarUser(Usuario mUser)
        {
            string textcomando = "update user " +
                "set Nombre = \"" + mUser.Nombre + "\"," +
                "Tipo = \"" + mUser.Tipo + "\"," +
                "Contraseña = \"" + mUser.Contraseña + "\"," +
                "Ap_paterno = \"" + mUser.Ap_paterno + "\"," +
                "Ap_materno = \"" + mUser.Ap_materno + "\"" +
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

        public bool ModificarCliente(Cliente mCliente)
        {
            string textcomando = "update cliente " +
                "set Nombre = \"" + mCliente.Nombre + "\"," +
                "Ap_paterno = \"" + mCliente.Ap_Paterno + "\"," +
                "Ap_materno = \"" + mCliente.Ap_Materno + "\"," +
                "Edad = \'" + mCliente.Edad + "\'," +
                "RFC = \'" + mCliente.RFC + "\'" + 
                "where id_cliente = " + mCliente.id_cliente + ";";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool ModificarHabita(Habitacion mHabitacion)
        {
            string textcomando = "update habitacion " +
                "set Tipo = \"" + mHabitacion.Tipo + "\"," +
                "Numero = \'" + mHabitacion.Numero + "\'," +
                "Precio = \'" + mHabitacion.Estado + "\"" +
                "where id_hab = " + mHabitacion.id_hab + ";";

            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool EliminarFactura(Factura mFactura)
        {
            string textcomando = "delete from factura " + "where id_fact = " + mFactura.id_fact;
            try
            {
                Consulta = new MySqlCommand(textcomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
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
