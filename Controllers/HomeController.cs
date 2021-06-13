using LaunchdryMVP.Data;
using LaunchdryMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaunchdryMVP.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Laundry()
        {
            List<LaundryModel> laundry = new List<LaundryModel>();
            LaundryDAO laundryDAO = new LaundryDAO();

            laundry = laundryDAO.FetchAll();
            ViewBag.Message = "Your Laundry page.";

            return View("Laundry", laundry);
        }

        public ActionResult Order()
        {
            List<OrderModel> order = new List<OrderModel>();
            OrderDAO orderDAO = new OrderDAO();

            order = orderDAO.FetchAll();
            ViewBag.Message = "Your Order page.";

            return View("Order", order);
        }
        public ActionResult Details(int no)
        {

            OrderDAO orderDAO= new OrderDAO();

            OrderModel order = orderDAO.FetchOne(no);

            return View("OrderDetails", order);
        }

        public ActionResult Create()
        {
            return View("OrderForm");
        }

        public ActionResult ProcessCreate(OrderModel orderModel)
        {
            OrderDAO orderDAO= new OrderDAO();
            List<OrderModel> order = new List<OrderModel>();

            orderDAO.Create(orderModel);
            order = orderDAO.FetchAll();

            return View("Order", order);
        }

        public ActionResult Delete(int no)
        {
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.Delete(no);

            List<OrderModel> order = orderDAO.FetchAll();
            return View("Order", order);
        }
    }


}