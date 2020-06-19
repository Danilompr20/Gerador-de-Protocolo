using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;

namespace GeradorDeProtocolo.Controllers
{
    public class OrigemDeAberturaController : Controller
    {
        private readonly IOrigemDeAberturaRepository _origemDeAberturaRepository;
        public OrigemDeAberturaController(IOrigemDeAberturaRepository origemDeAberturaRepository)
        {
            _origemDeAberturaRepository = origemDeAberturaRepository;
        }
        public IActionResult Index()
        {
            var origem = _origemDeAberturaRepository.ListarTodos();
            return View(origem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]OrigemDeAbertura origemDeAbertura)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, OrigemDeAbertura origemDeAbertura)
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
