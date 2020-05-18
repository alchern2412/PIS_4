using lab3_1_new.Models;
using lab3_1_new.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace lab3_1_new.Controllers
{
    public class DictController : Controller
    {
        
        private RecordRepository recordRepository = new RecordRepository();

        private static Random random = new Random();
        // GET: Dict
        public ActionResult Index()
        {
            List<Record> dictionary = recordRepository.GetRecords();

            ViewBag.Dictionary = dictionary;

            return View();
        }

        // GET: Dict/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dict/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: Dict/AddSave
        [HttpPost]
        public ActionResult AddSave(string name, string number)
        {
            try
            {
                // TODO: Add insert logic here
                Record record = new Record(random.Next(), name, number);
                recordRepository.AddRecord(record);



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dict/Update/5
        public ActionResult Update(int id)
        {
            HttpContextBase context = HttpContext;
            HttpRequestBase req = context.Request;
            ViewBag.Request = req;
            return View();
        }

        // POST: Dict/UpdateSave/5
        [HttpPost]
        public ActionResult UpdateSave(int id, string name, string number)
        {
            try
            {
                // TODO: Add update logic here
                Record record = new Record(id, name, number);
                recordRepository.Update(record);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dict/Delete/5
        public ActionResult Delete(int id)
        {
            HttpContextBase context = HttpContext;
            HttpRequestBase req = context.Request;
            ViewBag.Request = req;
            return View();
        }

        // POST: Dict/DeleteSave
        [HttpPost]
        public ActionResult DeleteSave(string record_id)
        {
            try
            {
                // TODO: Add delete logic here
                recordRepository.Delete(int.Parse(record_id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
