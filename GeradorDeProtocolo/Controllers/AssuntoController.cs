using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;

namespace GeradorDeProtocolo.Controllers
{
    public class AssuntoController : Controller
    {
        private readonly IAssuntoRepository _assuntoRepository;
        public AssuntoController(IAssuntoRepository assuntoRepository)
        {
            _assuntoRepository = assuntoRepository;
        }
        public IActionResult Index()
        {
            var assunto = _assuntoRepository.BuscarAssuntoComGrupo();
            return View(assunto);
        }

        [HttpGet]
        public IActionResult Create()
        {
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
