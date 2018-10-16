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
        public bool EsNumero(string s)
        {
            int p = 0;
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',')
                {
                    return false;
                }
                if(c == '.' || c == ',')
                {
                    p++;
                }
                if(p > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsNumeroEntero(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsAlfanumerico(string s)
        {
            bool r;
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            r = rg.IsMatch(s.Trim());
            if (s.Trim() == "") { r = false; }
            return r;
        }

        public bool EsAlfa(string s)
        {
            bool r;
            Regex rg = new Regex(@"^[a-zA-Z\s,]*$");
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
