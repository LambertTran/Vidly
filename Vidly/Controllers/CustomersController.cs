using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer{Name = "Customer 1", Id =1},
                new Customer{Name = "Customer 2", Id =2}
            };
        // GET: Customers
        public ActionResult Index()
        {
            

            var randomList = new RandomMovieViewModel
            {
                Movie = null,
                Customers = customers

            };

            return View(randomList);
        }

        public ActionResult Details(int id)
        {
            foreach (var customer in customers)
            {
                if ( customer.Id == id)
                {
                    return View(customer);
                }
            }

            return new HttpNotFoundResult("Not Found");
        }
    }
}