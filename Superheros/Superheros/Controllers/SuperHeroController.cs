using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheros.Models;

namespace Superheros.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHeroController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeroController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeroController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHeroModel superHero)
        {
            return View();
        }

        // GET: SuperHeroController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
