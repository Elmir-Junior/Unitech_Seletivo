using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unitech.Infra;
using Unitech.Models;

namespace Unitech.Controllers
{
    public class OngController : BaseController
    {
        OngRepository _ongRep = new OngRepository();

        public ActionResult Index()
        {
            var item = _ongRep.ListarOng();
            if (HTTPExtensions.IsAjaxRequest(Request))
                return PartialView(item);
            else
                return View(item); 
        }

        
        public ActionResult Details(int id)
        {
                return View(_ongRep.BuscarporId(id));
        }

        
        public ActionResult Create()
        {
                return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ong collection)
        {
            try
            {
                _ongRep.Adicionar(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
                return View(_ongRep.BuscarporId(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ong collection)
        {
            try
            {
                _ongRep.Editar(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
                return View(_ongRep.BuscarporId(id));   
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _ongRep.Remover(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Pesquisa(string pesquisa)
        {

            var ong = from m in _ongRep.ListarOng()
                      select m;

            ong = ong.Where(s => s.Descricao.Contains(pesquisa));
            return View(ong.ToList());
        }
    }
}
