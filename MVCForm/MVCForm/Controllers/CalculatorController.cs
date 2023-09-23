﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCForm.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View();
        }
        public int Add(int x,int y)
        {
            return x+y;
        }


        // GET: CalculatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculatorController/Create
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

        // GET: CalculatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculatorController/Edit/5
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

        // GET: CalculatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculatorController/Delete/5
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
