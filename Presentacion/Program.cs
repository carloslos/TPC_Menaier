using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// TODO: FILTROS (VENTAS)
/// TODO: MOTIVO ANULACIONES
/// TODO: BAJA DE STOCK
/// TODO: IMPRIMIR FACTURA PDF 
/// TODO: FORMATO FECHAS
namespace Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
}
