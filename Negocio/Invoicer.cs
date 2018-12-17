﻿using Invoicer;
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
                lstItems.Add(ItemRow.Make(pv.Producto.Descripcion, "-",(decimal)pv.Cantidad, 0,(decimal)pv.PrecioU, (decimal)pv.PrecioT));
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

/*
   new InvoicerApi(SizeOption.A4, OrientationOption.Landscape, "£")
    .TextColor("#CC0000")
    .BackColor("#FFD6CC")
    .Image(@"vodafone.jpg", 125, 27)
    .Company(Address.Make("FROM", "Vodafone Limited", "Vodafone House", "The Connection", "Newbury", "Berkshire RG14 2FN"))
    .Client(Address.Make("BILLING TO", "Isabella Marsh", "Overton Circle", "Little Welland", "Worcester", "WR## 2DJ"))
    .Items(new List<ItemRow> { 
        ItemRow.Make("Nexus 6", "Midnight Blue", (decimal)1, 20, (decimal)166.66, (decimal)199.99),
        ItemRow.Make("24 Months (£22.50pm)", "100 minutes, Unlimited texts, 100 MB data 3G plan with 3GB of UK Wi-Fi", (decimal)1, 20, (decimal)360.00, (decimal)432.00),
        ItemRow.Make("Special Offer", "Free case (blue)", (decimal)1, 0, (decimal)0, (decimal)0),
    })
    .Totals(new List<TotalRow> {
        TotalRow.Make("Sub Total", (decimal)526.66),
        TotalRow.Make("VAT @ 20%", (decimal)105.33),
        TotalRow.Make("Total", (decimal)631.99, true),
    })
    .Details(new List<DetailRow> {
        DetailRow.Make("PAYMENT INFORMATION", "Make all cheques payable to Vodafone UK Limited.", "", "If you have any questions concerning this invoice, contact our sales department at sales@vodafone.co.uk.", "", "Thank you for your business.")
    })
    .Footer("http://www.vodafone.co.uk")
    .Save();
*/