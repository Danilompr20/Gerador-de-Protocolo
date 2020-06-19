using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDeProtocolo.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            var usuario = _usuarioRepository.ListarTodos();
            return View(usuario);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Usuario usuario)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, Usuario usuario)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            return View();

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
