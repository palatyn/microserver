﻿using System;

using Bytewizer.TinyCLR.Http.Mvc;
using Bytewizer.TinyCLR.Http.Mvc.Filters;

namespace Bytewizer.TinyCLR.WebServer.Controllers
{
    public class ExampleController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {            
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

        // Any public IActionResult method inherited from Controller is made available as an endpoint
        public IActionResult GetById(long id)
        {
            string response = "<doctype !html><html><head><title>Hello, world!</title>" +
                "<style>body { background-color: #111 }" +
                "h1 { font-size:3cm; text-align: center; color: white;}</style></head>" +
                "<body><h1>" + $"{id}" + "</h1></body></html>\r\n";

            return Content(response, "text/html");
        }

        public IActionResult GetByName(string name)
        {
            string response = "<doctype !html><html><head><title>Hello, world!</title>" +
                "<style>body { background-color: #111 }" +
                "h1 { font-size:3cm; text-align: center; color: white;}</style></head>" +
                "<body><h1>" + $"{name}" + "</h1></body></html>\r\n";

            return Content(response, "text/html");
        }

        public IActionResult GetOK()
        {
            return Ok();
        }

        public IActionResult GetBadRequest()
        {
            return BadRequest();
        }
    }
}
