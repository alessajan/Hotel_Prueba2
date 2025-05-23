using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol2
{
    public class Cliente
    {
        public int id_cliente { set; get; }
        public string Nombre { set; get; }
        public string Ap_Paterno { set; get; }
        public string Ap_Materno { set; get; }
        public int Edad { set; get; }
        public string RFC { set; get; }
    }
}
