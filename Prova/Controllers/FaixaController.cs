using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class FaixaController : Controller
    {

        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Faixa

        public ActionResult Index()
        {

            var faixas = _context.Faixas.ToList();


            return View(faixas);
        }

        public ActionResult Details(int id)
        {
            var Faixas = _context.Faixas.SingleOrDefault(f => f.Id == id);

            if (Faixas == null)
            {
                return HttpNotFound();
            }

            return View(Faixas);

        }
    }

}
