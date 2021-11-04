using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Http;
using UI.Web.Controllers;

namespace UI.Web.Filters
{
    public class EstadoRequerido: IAuthorizationRequirement
    {
        public bool Requerido { get; set; }

        public EstadoRequerido()
        {
            Requerido = true;
        }
    }


    public class authFilter : AuthorizationHandler<EstadoRequerido>
    {

        IHttpContextAccessor _httpContextAccessor = null;

        public authFilter(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EstadoRequerido requirement)
        {
            //estado requerido deberia ser = true
            //var httpcontx = context.Resource as AuthorizationFilterContext;
            /*if(httpcontx is null)
            {
                //httpcontx = new AuthorizationFilterContext();
                //httpcontx.Result = new RedirectToActionResult("Index", "Acceso", null);
                return Task.CompletedTask;
            }*/
            string path = _httpContextAccessor.HttpContext.GetEndpoint().ToString();
            ISession se = _httpContextAccessor.HttpContext.Session;
            if (path.Contains("Acceso"))
            {
                return Task.CompletedTask;
            }
            //posiblemente este if no es necesario
            if (se is null)
            {
                _httpContextAccessor.HttpContext.Response.Redirect("/Acceso", true);
                return Task.CompletedTask;
            }
            if (Models.SessionHepler.Sessionstate(_httpContextAccessor.HttpContext.Session) ==requirement.Requerido)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            else
            {
                //httpcontx.Result = new RedirectToActionResult("Index", "Acceso", null);
                _httpContextAccessor.HttpContext.Response.Redirect("/Acceso",true);
                return Task.CompletedTask;
            }
            throw new NotImplementedException();
        }
    }
}
