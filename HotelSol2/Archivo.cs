using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelSol2
{
    internal class Archivo
    {
       private string Factura;
        private StreamWriter Escritor;
        private StreamReader Lector;


        public Archivo(string Factura)
        {
            this.Factura = Factura;
        }
        public void CrearArchivo()
        {
            Escritor = new StreamWriter(Factura);
            Escritor.Close();

        }
        public void EscribirReserv(Reserva mReserva)
        {
            Escritor = new StreamWriter(Factura, true);
            Escritor.WriteLine(mReserva.id_reserva 
                + "," + mReserva.id_user 
                + "," + mReserva.id_hab 
                + "," + mReserva.id_cliente 
                + "," + mReserva.Tipo_pago 
                + "," + mReserva.Fecha_ent 
                + "," + mReserva.Fecha_sal 
                + "," + mReserva.Total_pago);
            Escritor.Close();
        }
        public void EscribirCliente(Cliente mCliente)
        {
            Escritor = new StreamWriter(Factura, true);
            Escritor.WriteLine(mCliente.id_cliente
                + "," + mCliente.Nombre
                + "," + mCliente.Ap_Paterno
                + "," + mCliente.Ap_Materno
                + "," + mCliente.Edad
                + "," + mCliente.RFC
                );
            Escritor.Close();
        }
        public void EscribirHab(Habitacion mHabitacion)
        {
            Escritor = new StreamWriter(Factura, true);
            Escritor.WriteLine(mHabitacion.id_hab
                + "," + mHabitacion.Tipo
                + "," + mHabitacion.Numero
                + "," + mHabitacion.Precio
                + "," + mHabitacion.Estado);
            Escritor.Close();
        }
        public List<Reserva> LeerReserva()
        {
            string linea;
            string[] Datos;
            List<Reserva> ReservaList = new List<Reserva>();
            Reserva mReserva;
            Lector = new StreamReader(Factura);
            while (Lector.EndOfStream == false)
            {
                linea = Lector.ReadLine();
                Datos = linea.Split(',');
                mReserva = new Reserva();
                mReserva.id_reserva = int.Parse(Datos[0]);
                mReserva.id_user = int.Parse(Datos[1]);
                mReserva.id_hab = int.Parse(Datos[2]);
                mReserva.id_cliente = int.Parse(Datos[3]);
                mReserva.Tipo_pago =  Datos[4];
                mReserva.Fecha_ent = DateTime.Parse(Datos[5]);
                mReserva.Fecha_sal = DateTime.Parse(Datos[6]);
                mReserva.Total_pago = int.Parse(Datos[7]);
                ReservaList.Add(mReserva);
            }
            Lector.Close();
            return ReservaList;
        }
        public List<Cliente> LeerCliente()
        {
            string linea;
            string[] Datos;
            List<Cliente> ClienteList = new List<Cliente>();
            Cliente mCliente;
            Lector = new StreamReader(Factura);
            while (Lector.EndOfStream == false)
            {
                linea = Lector.ReadLine();
                Datos = linea.Split(',');
                mCliente = new Cliente();
                mCliente.id_cliente = int.Parse(Datos[0]);
                mCliente.Nombre = Datos[1];
                mCliente.Ap_Paterno = Datos[2];
                mCliente.Ap_Materno = Datos[3];
                mCliente.Edad = int.Parse(Datos[4]);
                mCliente.RFC = Datos[5];
                ClienteList.Add(mCliente);
            }
            Lector.Close();
            return ClienteList;
        }
        public List<Habitacion> LeerHabitacion()
        {
            string linea;
            string[] Datos;
            List<Habitacion > HabitacionList = new List<Habitacion>();
            Habitacion mHabitacion;
            Lector = new StreamReader(Factura);
            while (Lector.EndOfStream == false)
            {
                linea = Lector.ReadLine();
                Datos = linea.Split(',');
                mHabitacion = new Habitacion();
                mHabitacion.id_hab = int.Parse(Datos[0]);
                mHabitacion.Tipo = Datos[1];
                mHabitacion.Numero= int.Parse(Datos[2]);
                mHabitacion.Precio = int.Parse(Datos[3]);
                mHabitacion.Estado= Datos[4];
               
                HabitacionList.Add(mHabitacion);
            }
            Lector.Close();
            return HabitacionList;
        }
    }
}
