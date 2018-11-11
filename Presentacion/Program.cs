using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// TODO: LOGIN
/// TODO: ALGUN FILTRO
/// TODO: VERIFICAR QUE "EDITAR" TENGA UN OBJECTO SELECCIONADO
/// </summary>
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
