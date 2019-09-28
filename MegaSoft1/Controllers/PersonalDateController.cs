using MegaSoft1.Models;
using MegaSoft1.Models.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaSoft1.Controllers
{
    public class PersonalDateController : Controller
    {
        // GET: PersonalDate
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            PeronalDatePanelRepository repository = new PeronalDatePanelRepository(db);
            var result = repository.personalListMdl();
            return View(result);
        }

        // GET: PersonalDate/Details/5
        public ActionResult Details(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            PeronalDatePanelRepository repository = new PeronalDatePanelRepository(db);
            var result = repository.getDetailsPersonal(id);
            return View(result);
        }

        // GET: PersonalDate/Create
        public ActionResult Create()
        {
            return View(new PersonalDateCreateMdl());
        }

        // POST: PersonalDate/Create
        [HttpPost]
        public ActionResult Create(PersonalDateCreateMdl model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            PeronalDatePanelRepository repository = new PeronalDatePanelRepository(db);
            var result = repository.Insert(model);
            if (result == false)
            {
                ViewBag.ErrorMessage = "У вас ошибка при добавление!!!Внимательно проверьте еще раз заполнение";
                return View(model);
            }
            return RedirectToAction("Index");
        }

        // GET: PersonalDate/Delete/5
        public ActionResult Delete(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            PeronalDatePanelRepository repository = new PeronalDatePanelRepository(db);
            var result = repository.Delete(id);
            if (result == false)
            {
                ViewBag.ErrorMessage = "У вас ошибка при удаление!!!Проверьте сеть Wifi или Интернет провайдера";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}