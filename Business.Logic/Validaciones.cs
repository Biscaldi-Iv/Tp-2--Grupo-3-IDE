using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Business.Entities;
using Data.Database;

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

        public static bool BorraComision(int id)//true si se puede borrar, false si tiene cursos
        {
            return true;//hardcodeado- sin uso
        }

        public static bool ValidaCurso(Curso c)
        {
            List<Curso> cursos = new CursosAdapter().getAll();
            var b = from crs in cursos where crs.IDComision == c.IDComision && crs.IDMateria == c.IDMateria && crs.AnioCalendario==c.AnioCalendario select crs;
            foreach(Curso crs in b)
            {
                return false;//false si ya existe un curso para esa materia comision y año
            }
            return true;//true porque todavia no existe un curso igual
        }
    }
}
