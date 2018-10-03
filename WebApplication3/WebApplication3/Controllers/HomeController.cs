using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using PagedList;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {



        RunnerDetailsDataContext run = new RunnerDetailsDataContext();

        public ActionResult Index(string searchString, string currentFilter, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var rundata = run.runners.ToList();

            var data = rundata;

            if (!String.IsNullOrEmpty(searchString))
            {
                data = rundata.Where(t => t.Name.Contains(searchString)).ToList();
            }

            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(data.ToPagedList(pageNumber, pageSize));
        }

        // GET: Home/DetailsIndex
        public ActionResult DetailsIndex(int id)
        {
            var databyid = run.runners.Single(x => x.Bib == id);
            return View(databyid);
        }



        // GET: Home
        [Authorize]
        public ActionResult Admin(string searchString, string currentFilter, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var rundata = run.runners.ToList();

            var data = rundata;

            if (!String.IsNullOrEmpty(searchString))
            {
                data = rundata.Where(t => t.Name.Contains(searchString)).ToList();
            }

            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(data.ToPagedList(pageNumber, pageSize));
        }

        // GET: Home/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            var databyid = run.runners.Single(x => x.Bib == id);
            return View(databyid);
        }

        // GET: Home/Create
        [Authorize]
        public ActionResult Create()
        {

            return View();
        }

        // POST: Home/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(runner collection)
        {
            try
            {
                // TODO: Add insert logic here
                run.runners.InsertOnSubmit(collection);
                run.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var databyid = run.runners.Single(x => x.Bib == id);
            return View(databyid);
        }

        // POST: Home/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, runner collection)
        {
            try
            {
                // TODO: Add update logic here
                runner runobj = run.runners.Single(x => x.Bib == id);
                runobj.Age = collection.Age;
                runobj.City = collection.City;
                runobj.DivPl = collection.DivPl;
                runobj.Name = collection.Name;
                runobj.Overall = collection.Overall;
                runobj.Sex = collection.Sex;
                runobj.SexPl = collection.SexPl;
                runobj.State = collection.State;
                runobj.Time = collection.Time;
                run.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            var databyid = run.runners.Single(x => x.Bib == id);
            return View(databyid);
        }

        // POST: Home/Delete/5
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id, runner collection)
        {
            try
            {
                // TODO: Add delete logic here
                var data = run.runners.Single(x => x.Bib == id);
                run.runners.DeleteOnSubmit(data);
                run.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public JsonResult DataJson()
        {

            var rundata = run.runners.Select(u => new { u.Age , u.Sex });

            return Json(rundata, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Data2Json()
        {
            var rundata = run.runners.Select(u => new { u.State });

            return Json(rundata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Statistics()
        {
            return View();
        }

    }
}
