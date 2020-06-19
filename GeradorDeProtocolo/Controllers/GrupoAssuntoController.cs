using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;

namespace GeradorDeProtocolo.Controllers
{
    public class GrupoAssuntoController : Controller
    {
        private readonly IGrupoAssuntoRepository _grupoAssuntoRepository;
        public GrupoAssuntoController(IGrupoAssuntoRepository grupoAssuntoRepository)
        {
            _grupoAssuntoRepository = grupoAssuntoRepository;
        }
       
        public IActionResult Index()
        {
          var grupo = _grupoAssuntoRepository.ListarTodos();
            return View();
        }
       
    public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]GrupoAssunto grupoAssunto)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, GrupoAssunto grupoAssunto)
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
        public IActionResult Details(int id )
        {
            return View();
        }
      
    }
}
