using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTOM.Models;

namespace MvcTOM.Controllers
{
    public class TasksController : Controller
    {
        //
        // GET: /Tasks/

        private IQueryTask _repTask;

        public TasksController(){
            _repTask = new QueryTask();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Tasks TasksTable) 
        {
            QueryTask querytask = new QueryTask();

            int Flag = querytask.Insert(TasksTable);

             
            return View(); //se cachan los valores TasksTable
        }


        public ActionResult Show_Tasks()
        {
            var qtask = _repTask.Show();

            return View(qtask);
        }
    }
}
