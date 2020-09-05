using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Asn1.Kisa;
using Unitech.Infra;
using Unitech.Models;

namespace Unitech.Controllers
{
    public class PessoaController : Controller
    {
        PessoaRepository _pessoaRep = new PessoaRepository();
        OngRepository _ongRep = new OngRepository();

        
        

        public ActionResult Index()
        {
            return View(_pessoaRep.ListarPessoa());
        }


        public ActionResult Details(int id)
        {
            return View(_pessoaRep.BuscarporId(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            //var ongint = _pessoaRep.ListarOngId();
            //ViewBag.OngID = new SelectList(_pessoaRep.ListarOngId(), "Ong_Id", "Descricao");

            List<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem
            {
                Text = "Selecione",
                Value = ""
            });
                foreach(var linha in _pessoaRep.ListarOngId())
            {
                lista.Add(new SelectListItem()
                {
                    Value = linha.ID.ToString(),
                    Text = linha.Descricao,
                });
            }
            ViewBag.Selecionador = lista;


                //< select asp -for= "Ong_ID" asp - items = "@ViewBag.OngID" >
  //            ViewBag.OngID = _pessoaRep.ListarOngId().Select(c => new SelectListItem { Text = c.Descricao, Value=""}).ToList();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pessoa collection)
        {

                _pessoaRep.Adicionar(collection);
                return RedirectToAction(nameof(Index));
        }


        public ActionResult Edit(int id)
        {
            return View(_pessoaRep.BuscarporId(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pessoa collection)
        {
            try
            {
                _pessoaRep.Editar(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {

            return View(_pessoaRep.BuscarporId(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pessoa collection)
        {
            try
            {
                _pessoaRep.Remover(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
