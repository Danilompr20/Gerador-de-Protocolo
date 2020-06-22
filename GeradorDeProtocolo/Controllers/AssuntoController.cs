using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeradorDeProtocolo.Controllers
{
    public class AssuntoController : Controller
    {
        private readonly IAssuntoRepository _assuntoRepository;
        private readonly IGrupoAssuntoRepository _grupoassuntoRepository;
        public AssuntoController(IAssuntoRepository assuntoRepository, IGrupoAssuntoRepository grupoAssuntoRepository)
        {
            _assuntoRepository = assuntoRepository;
            _grupoassuntoRepository = grupoAssuntoRepository;
        }
        public IActionResult Index()
        {
            var assunto = _assuntoRepository.BuscarAssuntoComGrupo();
            return View(assunto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Grupo"] = new SelectList(_grupoassuntoRepository.ListarTodos(),"GrupoAssuntoId","Descricao") ;
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Assunto  assunto)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int? id, Assunto assunto)
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
        
 
        public IActionResult Details(int id)
        {
            return View();
        }
        
    }
}
