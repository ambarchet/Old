using RetailManagementTool.Models.Department;
using RetailManagementTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetailManagementTool.WebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            var service = new DepartmentService();
            var model = service.GetDepartments();
            return View(model);
        }

        //CREATE:GET
        public ActionResult Create()
        {
            return View();
        }
        //CREATE:POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = new DepartmentService();

            service.CreateDepartment(model);

            return RedirectToAction("Index");
        }

        //GET BY ID
        public ActionResult DepartmentDetails(int id)
        {
            var service = new DepartmentService();
            var model = service.GetDepartmentById(id);

            return View(model);
        }

    }
}