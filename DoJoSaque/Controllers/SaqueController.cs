using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DoJoSaque.Models;
using DoJoSaque.Classes;

namespace DoJoSaque.Controllers
{
    public class SaqueController : Controller
    {
        // GET: Saque
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Saque/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Saque/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SaqueModel objSaqueModel)
        {
            decimal valSaque;
            Saque objSaque = new Saque();

            try
            {
                valSaque = objSaqueModel.valorSaque;

                ViewData["retorno"] = objSaque.RetornarNotas(objSaqueModel.valorSaque);

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Saque/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Saque/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}