using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proje.Models;
using proje.Models.ViewModels;


namespace proje.Controllers
{
    public class IMDBController : Controller
    {
        // GET: IMDBController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult ActorList()
        {
            var actorList = new List<Actor>();
            actorList.Add(new Actor { Actor_ID = 1, First_Name = "Parker", Last_Name = "Posey", Last_Update = DateTime.Now });

            return View(actorList);
        }
        public IActionResult DirectorFilms()
        {
            DirectorFilmViewModel viewModel = new DirectorFilmViewModel();
            viewModel.Director = new Director() { Name = "Tarantino" };
            viewModel.Films = new List<Film>();

            viewModel.Films.Add(new Film() { Name = "Pulp Fiction" });
            return View(viewModel);
        }

        // GET: IMDBController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IMDBController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IMDBController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: IMDBController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IMDBController/Edit/5
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

        // GET: IMDBController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IMDBController/Delete/5
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
