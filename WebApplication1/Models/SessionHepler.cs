using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Models
{
    public class SessionHepler
    {
        public static bool Sessionstate(ISession s)
        {
            var c = from string clave in s.Keys where clave == "usuario" select clave;
            int n = c.ToList().Count();
            if (n >= 1)
            {
                //el usuario esta logueado
                return true;
            }
            //usuario no logueado
            return false;
        }

        public static Usuario GetUsuario(ISession s)
        {
            string ustr = s.GetString("usuario");
            Usuario u=JsonConvert.DeserializeObject<Usuario>(ustr);
            return u;
        }

        public static Plan GetPlan(ISession s)
        {
            string plstr = s.GetString("plan");
            Plan p = JsonConvert.DeserializeObject<Plan>(plstr);
            return p;
        }

        public static TipoPersonas GetTipoPersona(ISession s)
        {
            string tpstr = s.GetString("TipoPer");
            TipoPersonas tp = JsonConvert.DeserializeObject<TipoPersonas>(tpstr);
            return tp;
        }

        public static void IniciarSesion(ISession s, string username, string clave)
        {
            //guarda el usuario
            UsuarioLogic ul = new UsuarioLogic();
            if (!ul.VerificarUsuario(username, clave))
            {
                throw new Exception("Es posible que haya escrito mal el usuario o contraseña");
            }
            
            Usuario usr = ul.RecuperarUsuario(username, clave);
            var struser = JsonConvert.SerializeObject(usr);
            s.SetString("usuario", struser);

            //se guarda el tipo de persona
            PersonaLogic pl = new PersonaLogic();
            Persona per = pl.GetOne(usr.IdPersona);
            TipoPersonaLogic tpl = new TipoPersonaLogic();
            TipoPersonas tipo = tpl.GetOne(per.TipoPersona);
            var strTP = JsonConvert.SerializeObject(tipo);
            s.SetString("TipoPer", strTP);

            //se guarda el plan
            PlanesLogic planL = new PlanesLogic();
            Plan plan = planL.GetOne(per.IDPlan);
            var strplan = JsonConvert.SerializeObject(plan);
            s.SetString("plan", strplan);

        }
    }
}
