using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARSimulator.Controllers
{
    public class ARSimulatorController : Controller
    {
        // GET: ARSimulator
        public ActionResult Index()
        {
            return View();
        }

        // GET: ARSimulator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ARSimulator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ARSimulator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ARSimulator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ARSimulator/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ARSimulator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ARSimulator/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
