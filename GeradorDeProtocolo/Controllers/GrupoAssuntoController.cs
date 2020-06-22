using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorDeProtocolo.Models;
using GeradorDeProtocolo.Interface;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

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
            return View(grupo);
        }
       
    public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]GrupoAssunto grupoAssunto)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }
            _grupoAssuntoRepository.Cadastrar(grupoAssunto);
             return  RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            
          
                if (id==null)
                {
                  throw new NotImplementedException();
                }
             GrupoAssunto grupo= _grupoAssuntoRepository.BuscarPorId(id.Value);
            return View(grupo);
           
            
        }

        [HttpPost]
        public IActionResult Edit(int id, GrupoAssunto grupoAssunto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
          
            try
            {
                
               _grupoAssuntoRepository.Atualizar(grupoAssunto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                throw new NotImplementedException(e.ToString());
            }
           
          
        }

        
        
        [HttpGet]
        public IActionResult Delete(int? id)
        {


            if (id == null)
            {
                throw new NotImplementedException();
            }
            GrupoAssunto grupo= _grupoAssuntoRepository.BuscarPorId(id.Value);
            return View(grupo);

           

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {

               GrupoAssunto grupo = _grupoAssuntoRepository.BuscarPorId(id);
                if (grupo==null)
                {
                    return NotFound();
                }
               _grupoAssuntoRepository.Excluir(grupo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                throw new NotImplementedException(e.ToString());
            }
           

        }

        [HttpGet]
        public IActionResult Details(int ? id )
        {

            if (id == null)
            {
                throw new NotImplementedException();
            }
            GrupoAssunto assunto = _grupoAssuntoRepository.BuscarPorId(id.Value);
            return View(assunto);
        }
      
    }
}
