using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Business.Logic
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            //expresiones regulares
            //RegEx--clase de expr regulares
            //IsMatch
            if (Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            return false;
        }

        public static bool NomApellidoValido(string cadena)
        {
            if (Regex.IsMatch(cadena, @"\s*\w*\s*"))
            {
                return true;
            }
            return false;
        }
    }
}
