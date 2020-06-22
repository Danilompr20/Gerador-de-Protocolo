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
    public class SublocalController : Controller
    {
        private readonly ISublocalRepository _sublocalRepository;
        private readonly ILocalRepository _localRepository;
        public SublocalController(ISublocalRepository sublocalRepository, ILocalRepository localRepository)
        {
            _sublocalRepository = sublocalRepository;
            _localRepository = localRepository;
        }
        public IActionResult Index()
        {
            var sublocal = _sublocalRepository.ListarSubLocalComLocal();
            return View(sublocal);
        }

        public IActionResult Create()
        {
            ViewData["local"] = new SelectList(_localRepository.ListarTodos(),"LocalId", "LocalDescricao");
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]Sublocal sublocal)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, Sublocal sublocal)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int?id)
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
