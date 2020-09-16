using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheros.Data;
using Superheros.Models;

namespace Superheros.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHeroController1
        public ActionResult Index()
        {
            var superHeroes = _context.Superheroes;
            return View(superHeroes);
        }

        // GET: SuperHeroController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeroController1/Create
        public ActionResult Create()
        {
            SuperHeroModel superHero = new SuperHeroModel();
            return View(superHero);
        }

        // POST: SuperHeroController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHeroModel superHero)
        {
            _context.Add(superHero);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
            SuperHeroModel super = _context.Superheroes.Where(d => d.Id == id).FirstOrDefault();

            return View(super);

        }

        // POST: SuperHeroController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SuperHeroModel super)
        {
            try
            {
                _context.Remove(super);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
