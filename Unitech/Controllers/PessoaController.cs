using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using K4os.Hash.xxHash;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Asn1.Kisa;
using Unitech.Infra;
using Unitech.Models;

namespace Unitech.Controllers
{
    public class PessoaController : BaseController
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
            List<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem
            {
                Text = "Selecione",
                Value = ""
            });
                foreach(var linha in _ongRep.ListarOng())
            {
                lista.Add(new SelectListItem()
                {
                    Value = linha.ID.ToString(),
                    Text = linha.Descricao,
                });
            }
            ViewBag.Selecionador = lista;
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

        [HttpGet]
        public IActionResult Pesquisa(string pesquisa)
        {
            //refatorar codigo
            var ong = from m in _pessoaRep.ListarPessoa()
                         select m;
           // List<int> buscaid = new List<int>();
            ong = ong.Where(s => s.Descricao.Contains(pesquisa));
                //foreach (int i in ong.Select(s=> s.ID))
                //{
                //    buscaid = _ongRep.buscarid(i).ToList();
                //    //por isso em formato visivel na view
                //}
               
            
            return View(ong.ToList());
        }
    }
}
