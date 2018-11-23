using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Negocio
{
    public class Validaciones
    {
        public bool EsNumero(string s)
        {
            if (s.Length < 1)
            {
                return false;
            }
            int p = 0, i, pp=-1;
            for (i = 0; i<s.Length; i++)
            {
                if (!char.IsDigit(s[i]) && s[i] != '.')
                {
                    return false;
                }
                if(s[i] == '.')
                {
                    p++;
                    pp = i;
                }
                if(pp == s.Length-1)
                {
                    return false;
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
            if (s.Length < 1)
            {
                return false;
            }
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsCuit(string s)
        {
            if(s.Length != 11)
            {
                return false;
            }
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsEmail(string s)
        {
            try
            {
                if (new EmailAddressAttribute().IsValid(s))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EsDni(string s)
        {
            if (s.Length != 8)
            {
                return false;
            }
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsAlfa(string s)
        {
            if (s.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s.Length > 2) { if (s[i - 1] == ' ') { return false; } }
                if (!char.IsLetter(s[i]) && s[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsAlfanum(string s)
        {
            if (s.Length < 3)
            {
                return false;
            }
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s.Length > 2) { if (s[i - 1] == ' ') { return false; } }
                if (!char.IsLetter(s[i]) && s[i] != ' ' && !char.IsNumber(s[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsAlfanumsym(string s)
        {
            if (s.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s.Length > 2) { if (s[i - 1] == ' ') { return false; } }
                if (!char.IsLetter(s[i]) && s[i] != ' ' && !char.IsPunctuation(s[i]) && !char.IsSymbol(s[i]) && !char.IsSeparator(s[i]) && !char.IsNumber(s[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsPass(string p)
        {
            bool l = false, s = false, n = false;
            if (p.Length < 6)
            {
                return false;
            }
            foreach (char c in p)
            {
                if (char.IsLetter(c))
                {
                    l = true;
                }
                else
                {
                    if(char.IsSymbol(c) || char.IsSeparator(c) || char.IsPunctuation(c))
                    {
                        s = true;
                    }
                    else
                    {
                        if(char.IsNumber(c))
                        {
                            n = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (n == true && s == true && l == true)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                    t.Style = MetroFramework.MetroColorStyle.Blue;
                    l.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case 's':
                case 'S':
                default:
                    t.Style = MetroFramework.MetroColorStyle.Silver;
                    l.Style = MetroFramework.MetroColorStyle.Silver;
                    break;
            }
            t.Refresh();
            l.Refresh();
        }
    }
}
