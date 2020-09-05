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
    public class TesteController : Controller
    {
        // GET: TesteController

        OngRepository _ongRep = new OngRepository();

        public ActionResult Index()
        {
            return View(_ongRep.ListarOng());
        }

        // GET: TesteController/Details/5
        public ActionResult Details(int id)
        {
            return View(_ongRep.BuscarporId(id));
        }

        // GET: TesteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesteController/Create
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

        // GET: TesteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_ongRep.BuscarporId(id));
        }

        // POST: TesteController/Edit/5
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

        // GET: TesteController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(_ongRep.BuscarporId(id));
        }

        // POST: TesteController/Delete/5
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
    }
}
