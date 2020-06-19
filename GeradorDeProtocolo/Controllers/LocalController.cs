using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;

namespace GeradorDeProtocolo.Controllers
{
    public class LocalController : Controller
    {
        private readonly ILocalRepository _localRepository;
        public LocalController(ILocalRepository localRepository)
      
        {
            _localRepository = localRepository;
        }
        public IActionResult Index()
        {
            var local = _localRepository.ListarTodos();
            return View(local);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Local local)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int?id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, Local local)
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
