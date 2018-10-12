using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class Validaciones
    {
        public bool EsNumeroEntero(string s)
        {
            bool r;
            Regex rg = new Regex(@"^[0-9]+$");
            r =  rg.IsMatch(s.Trim());
            if(s.Trim() == "") { r = false; }
            return r;
        }
                                                                            // NO ACEPTAN 1 SOLO NUMERO
        public bool EsNumero(string s)
        {
            bool r;
            Regex rg = new Regex(@"^-?[0-9][0-9,\.]+$");
            r = rg.IsMatch(s.Trim());
            int punto = 0;
            foreach (char c in s)
            {
                if(c == '.' || c == ',') { punto++; }
            }
            if(punto > 1) { r = false; }
            if(s.Length < 3 && punto == 1) { r = false; }
            if (s.Trim() == "") { r = false; }
            return r;
        }

        public bool EsAlfanumerico(string s)
        {
            bool r;
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            r = rg.IsMatch(s.Trim());
            if (s.Trim() == "") { r = false; }
            return r;
        }

        public void CambiarColor(MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l, char c)
        {
            switch (c)
            {
                case 'g':
                case 'G':
                    t.Style = MetroFramework.MetroColorStyle.Green;
                    l.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case 'r':
                case 'R':
                    t.Style = MetroFramework.MetroColorStyle.Red;
                    l.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 'b':
                case 'B':
                default:
                    t.Style = MetroFramework.MetroColorStyle.Blue;
                    l.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
            }
            t.Refresh();
            l.Refresh();
        }
    }
}
