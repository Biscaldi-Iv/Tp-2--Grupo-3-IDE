﻿using System;
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

        /*public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);               
                if (!Models.SessionHepler.Sessionstate(filterContext.HttpContext.Session))
                {

                    if ((filterContext.Controller is AccesoController) == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Acceso");
                        //filterContext.ActionDescriptor.
                        return;
                    }
                }

            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Acceso");
            }

        }
        */
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EstadoRequerido requirement)
        {
            //estado requerido deberia ser = true
            var httpcontx = context.Resource as AuthorizationFilterContext;
            if(httpcontx is null)
            {
                //httpcontx = new AuthorizationFilterContext();
                //httpcontx.Result = new RedirectToActionResult("Index", "Acceso", null);
                return Task.CompletedTask;
            }
            if (Models.SessionHepler.Sessionstate(httpcontx.HttpContext.Session)==requirement.Requerido)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            else
            {
                httpcontx.Result = new RedirectToActionResult("Index", "Acceso", null);
                return Task.CompletedTask;
            }
            throw new NotImplementedException();
        }
    }
}
