using MvcData.Models.Domain;
using MvcData.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcData.Controllers
{
    public class TodoController : Controller
    {   
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateTodoViewModel
            model)
        {
            //creating a todo
            var newTodo = new Todo();
            newTodo.Id = 1;
            newTodo.Title = model.Title;
            newTodo.Description = model.Description;
            newTodo.DueDate = model.DueDate;

            //saving to the database
            
            return null;
        }
    }
}