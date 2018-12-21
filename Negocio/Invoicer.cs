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
                lstItems.Add(ItemRow.Make(pv.Producto.Descripcion, pv.Producto.Marca.Descripcion, (decimal)pv.Cantidad, (decimal)pv.PrecioU, (decimal)pv.PrecioT));
            }

            new InvoicerApi(v.IdVenta, v.FechaVenta, SizeOption.A4, OrientationOption.Portrait, "$")
            .TextColor("#CC0000")
            .BackColor("#FFD6CC")
            .Image(@"..\..\images\veggiestuff.jpg", 135, 25)
            .Company(Address.Make("DATOS VENDEDOR", new string[] { "Veggie Stuff", "Av. Mitre 2425", "Vicente Lopez", "Buenos Aires" }, "", ""))
            .Client(Address.Make("DATOS CLIENTE", new string[] { v.Cliente.NombreCompleto}))
            .Items(lstItems)
            .Totals(new List<TotalRow> {
                TotalRow.Make("Total", (decimal)v.Monto, true),
            })
            .Details(new List<DetailRow> {
                DetailRow.Make("INFORMACIÓN DE PAGO", "Destinar cheques a Veggie Stuff Incorporated.", "", "Por cualquier consulta puede contactarnos mediante correo electronico a veggiestuff@gmail.com", "", "Gracias por su compra.")
            })
            .Footer("http://www.veggiestuff.com.ar")
            .Save();
        }
    }
}
