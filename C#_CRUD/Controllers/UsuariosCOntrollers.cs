using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__CRUD.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace C__CRUD.Controllers
{   
    public class UsuariosController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var usuarioServices = new UsuarioServices();
            var usuario = usuarioServices.ListarUsuario();           

            return View(usuario);
        }
    }
}