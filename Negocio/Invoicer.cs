using Invoicer;
using Invoicer.Models;
using Invoicer.Services;
using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Invoicer
    {
        public void Go(Venta v)
        {
            List<ItemRow> lstItems = new List<ItemRow>();
            foreach (ProductoVendido pv in v.LstProductosVendidos)
            {
                lstItems.Add(ItemRow.Make(pv.Producto.Descripcion, (decimal)pv.Cantidad, (decimal)pv.PrecioU, (decimal)pv.PrecioT));
            }

                new InvoicerApi(SizeOption.A4, OrientationOption.Portrait, "$")
                .TextColor("#CC0000")
                .BackColor("#FFD6CC")
                .Image(@"..\..\images\veggiestuff.jpg", 135, 25)
                .Company(Address.Make("DATOS VENDEDOR", new string[] { "Veggie Stuff Incorporated", "Buenos Aires", "Vicente Lopez", "Av. Mitre 2425" }, "1471587", "569953277"))
                .Client(Address.Make("DATOS CLIENTE", new string[] { "Isabella Marsh", "Overton Circle", "Little Welland", "Worcester", "WR## 2DJ" }))
                .Items(lstItems)
                .Totals(new List<TotalRow> {
                    TotalRow.Make("Sub Total", (decimal)v.Monto),
                    TotalRow.Make("Total", (decimal)v.Monto, true),
                })
                .Details(new List<DetailRow> {
                    DetailRow.Make("PAYMENT INFORMATION", "Make all cheques payable to Vodafone UK Limited.", "", "If you have any questions concerning this invoice, contact our sales department at sales@vodafone.co.uk.", "", "Thank you for your business.")
                })
                .Footer("http://www.veggiestuff.com.ar")
                .Save();
        }
    }
}
