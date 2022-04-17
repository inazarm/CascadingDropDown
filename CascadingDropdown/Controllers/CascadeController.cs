using CascadingDropdown.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Controllers
{
    public class CascadeController : Controller
    {
        private readonly App_Context context;

        public CascadeController(App_Context _Context)
        {
            this.context = _Context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Country()
        {
            var country = context.tblCountry.ToList();
            return new JsonResult(country);
        }
        public JsonResult State(int id)
        {
            var state = context.tblState.Where(x=>x.country.Id==id).ToList();
            return new JsonResult(state);
        }
        public JsonResult City(int id)
        {
            var city = context.tblCity.Where(x => x.state.Id == id).ToList();
            return new JsonResult(city);
        }
    }
}
