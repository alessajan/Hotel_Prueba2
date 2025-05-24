using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;


namespace HotelSol2
{
    internal class FacturaGenerator
    {
        public static void GenerarFactura(Reserva mReserva, string rutaArchivo)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            doc.Add(new Paragraph("Hotel El Sol - FACTURA DE RESERVA", FontFactory.GetFont("Arial", 18, Font.BOLD)));
            doc.Add(new Paragraph($"Fecha de emision: {DateTime.Now.ToShortDateString()}"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph($"Usuario: { mReserva.id_user }"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Datos de cliente", FontFactory.GetFont("Arial", 14, Font.BOLD)));
            doc.Add(new Paragraph($"Nombre: {mReserva.id_cliente}"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Reserva", FontFactory.GetFont("Arial", 14, Font.BOLD)));
            doc.Add(new Paragraph($"Fecha Entrada: {mReserva.Fecha_ent.ToShortDateString()}"));
            doc.Add(new Paragraph($"Fecha Salida: {mReserva.Fecha_sal.ToShortDateString()}"));
            doc.Add(new Paragraph($"Total: ${mReserva.Total_pago:0.00}"));

            doc.Close();
        }
    }
}
