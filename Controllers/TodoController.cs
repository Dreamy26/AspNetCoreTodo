using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            // get to-do items from AddDatabaseDeveloperPageExceptionFilter
            // put items into a model 

            // render view using the model
            return View();
        }
    }
}