﻿using AuthorApplication2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorApplication2.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {   
            List<CreateEMP> empList= EmpDbRepository.GetEmpList();  
             return View(empList);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {   
            if(id<=0)
            {
                return RedirectToAction("Index");   
            }
            CreateEMP emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {   
            CreateEMP emp = new CreateEMP();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,CreateEMP pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            CreateEMP employee = EmpDbRepository.GetEmpById(id);
            return View(employee);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, CreateEMP Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(Emp);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            CreateEMP emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {   
                if(ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);  
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
