using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HWTwo.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> MyStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            ViewBag.Mystack = MyStack;

            return View();
        }

        public ActionResult AddOne()
        {
            MyStack.Push("New Entry " + (MyStack.Count + 1));

            ViewBag.MyStack = MyStack;

            return View("Index");
        }

        public ActionResult AddHuge()
        {
            MyStack.Clear();

            int i = 0;

            while (i < 2000) 
            {
                MyStack.Push("New Entry " + (MyStack.Count + 1));
                i++;
            }

            ViewBag.MyStack = MyStack;

            return View("Index");
        }

        public ActionResult Display()
        {
            ViewBag.MyStack += "<table>";

            foreach (var AddString in MyStack)
            {
                ViewBag.Mystack += "<tr>";
                ViewBag.MyStack += "<td>";
            }
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Clear()
        {
            MyStack.Clear();
            ViewBag.MyStack = MyStack;
            return View("Index");
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}