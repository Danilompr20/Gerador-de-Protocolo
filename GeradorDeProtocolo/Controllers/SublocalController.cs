using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;
using AspNetCore;

namespace GeradorDeProtocolo.Controllers
{
    public class SublocalController : Controller
    {
        private readonly ISublocalRepository _sublocalRepository;
        public SublocalController(ISublocalRepository sublocalRepository)
        {
            _sublocalRepository = sublocalRepository;
        }
        public IActionResult Index()
        {
            var sublocal = _sublocalRepository.ListarTodos();
            return View(sublocal);
        }

        public IActionResult Create()
        {
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
