using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    public class StatusController : ControllerBase
    {

        [HttpGet("/status")]
        public ActionResult GetTheServerStatus()
        {
            var response = new GetStatusResponse
            {
                StatusMessage = "Looks Good Here!",
                LastChecked = DateTime.Now,
                CheckedBy = "Fred"
            };
            return Ok(response);
        }
    }
}
