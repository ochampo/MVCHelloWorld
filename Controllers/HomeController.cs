using MVCHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.MysuperProperty = "This is my first App";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomer(Customer postedCustomer)
        {
            Customer customer = new Customer();
            customer.id = Guid.NewGuid().ToString();
            customer.Name = postedCustomer.Name;
            customer.Telephone = postedCustomer.Telephone;
            return View(customer);
        }

        public ActionResult AddCustomer()
        {

            return View();
        }

        public ActionResult CustomerList()
        {
            List<Customer> customers = new List<Customer>();
            {
                customers.Add(new Customer() { Name = "peter", Telephone = "7145926137" });
                customers.Add(new Customer() { Name = "Daniel", Telephone = "4151324512" });


            }

            return View(customers);


        }




    }
}