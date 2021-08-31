using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Trabajo_Practico_02.Models;
using NLog;

namespace Trabajo_Practico_02.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        public string GuardarEmpleado(string _Nombre, string _Apellido, string _Direccion, DateTime _FechaNacimiento, DateTime _FechaIngreso) {
            
            Empleado nuevo = new Empleado(_Nombre,_Apellido,_Direccion,_FechaNacimiento,_FechaIngreso);
            _logger.LogInformation($"[{nuevo.Apellido},{nuevo.Nombre}][Edad:{nuevo.Edad}][Antiguedad:{nuevo.Antiguedad}][Salario:{nuevo.Salario}]");
            return "exito";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

   

}
