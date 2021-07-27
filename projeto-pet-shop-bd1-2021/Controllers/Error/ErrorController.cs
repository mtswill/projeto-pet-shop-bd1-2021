using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers.Error
{
    public class ErrorController : Controller
    {
        public IActionResult Index(ErrorViewModel error)
        {
            return View(error);
        }
    }
}
