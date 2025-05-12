using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol2
{
    internal class Reserva
    {
        public int id_reserva { set; get; }
        public int id_user { set; get; }
        public int id_hab { set; get; }
        public int id_cliente { set; get; }
        public string Tipo_pago { set; get; }
        public DateTime Fecha_ent { set; get; }
        public DateTime Fecha_sal { set; get; }
        public float Total_pago { set; get; }

    }
}
