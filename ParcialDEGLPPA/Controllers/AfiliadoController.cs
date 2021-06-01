using ParcialDEGLPPA.Business;
using ParcialDEGLPPA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcialDEGLPPA.Controllers
{
    public class AfiliadoController : Controller
    {
        AfiliadoB afiliadoB = new AfiliadoB();


        public ActionResult Index()
        {
            var lista = afiliadoB.Listar();
            return View(lista);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Afiliados model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            afiliadoB.Agregar(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var afiliado = afiliadoB.Get(id);
            if (afiliado == null)
            {
                return View();
            }

            return View(afiliado);
        }
        [HttpPost]
        public ActionResult Edit(Afiliados model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            afiliadoB.Update(model);

            return RedirectToAction("Index");
        }
        //por defecto es GET
        public ActionResult Delete(int id)
        {
            var afiliado = afiliadoB.Get(id);
            if (afiliado == null)
            {
                return View();
            }

            return View(afiliado);
        }

        [HttpPost]
        public ActionResult Delete(Afiliados model)
        {
            if (model == null)
            {
                return View();
            }

            var afiliado = afiliadoB.Get(model.Id);

            afiliadoB.Eliminar(afiliado);
            return RedirectToAction("Index");
        }
    }
}