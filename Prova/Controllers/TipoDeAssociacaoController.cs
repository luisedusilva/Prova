using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {

        private ApplicationDbContext _context;
        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: TipoDeAssociacao

        public ActionResult Index()
        {

            var TiposDeAssociacao = _context.TiposDeAssociacao.ToList();


            return View(TiposDeAssociacao);
        }

        public ActionResult Details(int id)
        {
            var TiposDeAssociacao = _context.TiposDeAssociacao.SingleOrDefault(t => t.Id == id);

            if (TiposDeAssociacao == null)
            {
                return HttpNotFound();
            }

            return View(TiposDeAssociacao);

        }
    }

}
