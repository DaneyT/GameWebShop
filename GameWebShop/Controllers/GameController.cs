using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameWebShop.Models;
using GameWebShop.ViewModels;

namespace GameWebShop.Controllers
{
    public class GameController : Controller
    {
        // GET: Game/Random
        public ActionResult Random()
        {
            var game = new Game() { Name = "Wow" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Jack Daniels"},
                new Customer { Name = "Clint Eastwood"}
            };

            var viewModel = new RandomGameViewModel
            {
                Game = game,
                Customers = customers
            };


            return View(viewModel);

        }


    }
}