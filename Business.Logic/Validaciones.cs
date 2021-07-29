using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            //expresiones regulares
            //RegEx--clase de expr regulares
            //IsMatch
            if (!(mail.Contains("@") && mail.Contains(".com") && mail.Length >= 7))
            {
                return false;
            }
            return true;
        }
    }
}
