﻿using PShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PShop.Data;
using Microsoft.AspNetCore.Identity;
using PShop.Areas.Identity.Data;
using System.Text.Json;
using System.Globalization;

namespace PShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StoreContext _context;
        private readonly UsersContext _ucontext;
        private readonly SignInManager<User> signInManager;
        User user;

        public HomeController(ILogger<HomeController> logger, StoreContext context, UsersContext ucontext, SignInManager<User> signInManager)
        {
            _logger = logger;
            _context = context;
            _ucontext = ucontext;
            this.signInManager = signInManager;
        }

        public string GetCulture(string code = "")
        {
            if (!String.IsNullOrEmpty(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }

        public async Task<IActionResult> Index()
        {
            Random r = new Random();

            var lst = _context.Items.ToList<Item>();

            var user = await signInManager.UserManager.GetUserAsync(User);
            List<Item> items;

            if (user?.WishList != null)
                items = JsonSerializer.Deserialize<List<Item>>(user.WishList);
            else
                items = new();

            if (items.Count >= 3)
            {
                var c1 = items[r.Next(0, items.Count)]; items.Remove(c1);
                var c2 = items[r.Next(0, items.Count)]; items.Remove(c2);
                var c3 = items[r.Next(0, items.Count)]; items.Remove(c3);

                ViewData["IsWlist"] = true;
                ViewData["CItem1"] = c1;
                ViewData["CItem2"] = c2;
                ViewData["CItem3"] = c3;
            }
            else
            {
                var c1 = lst[r.Next(0, lst.Count)]; lst.Remove(c1);
                var c2 = lst[r.Next(0, lst.Count)]; lst.Remove(c2);
                var c3 = lst[r.Next(0, lst.Count)]; lst.Remove(c3);

                ViewData["IsWlist"] = false;
                ViewData["CItem1"] = c1;
                ViewData["CItem2"] = c2;
                ViewData["CItem3"] = c3;
            }

            var TagArr = _context.Tags.ToList<Tag>();
            var tag = TagArr[r.Next(0, TagArr.Count)].tag;

            List<Item> TagItems = new();

            ViewData["Tag"] = tag;
            ViewData["TagItems"] = TagItems;
            ViewData["Tags"] = _context.Tags.ToList<Tag>();
            List<Item> SaleItems = new();
            foreach (Item i in _context.Items)
            {
                if(i.Sale>0)
                SaleItems.Add(i);
            }
            ViewData["SaleItems"] = SaleItems;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
