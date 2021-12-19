using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PShop.Areas.Identity.Data;
using PShop.Data;
using PShop.Models;

namespace PShop.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly StoreContext _context;
        private readonly UsersContext _ucontext;
        private readonly UserManager<User> userManager;

        public ReviewsController(StoreContext context, UsersContext ucontext, UserManager<User> userManager)
        {
            _context = context;
            _ucontext = ucontext;
            this.userManager = userManager;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.Include(r => r.Item).ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        public async Task<IActionResult> Generate()
        {
            var Items = _context.Items.ToList<Item>();
            var rnd = new[] { "LemonCat", "qqForest", "goga", "ghost666", "killer", "asd312", "pripapupa", "popster", "llkers", "kiboe", "milfhunter", "kuckoi", "roldan" };
            Random r = new();

            foreach (Item _item in Items)
            {
                for(int i=0;i<r.Next(3,10);i++)
                {
                    Review review = new();
                    review.Item = _item;
                    review.Id = Guid.NewGuid();
                    review.Author = rnd[r.Next(0, rnd.Length)] + r.Next(0, rnd.Length).ToString();
                    DateTime dateTime = new();
                    //dateTime.AddHours(r.Next(rnd.Length, rnd.Length));
                    review.Date = dateTime;
                    review.Score = r.Next(5, 10);

                    review.Item.ScoreCount++;
                    review.Item.ScoreSumm += review.Score;
                    var vgood = new[] { "Замечательный товар!", "Прекрастная покупка!", "Великолепная вещь!", "Всем рекомендую" };
                    var norm = new[] { "Неплохо за такие деньги", "Ну пойдет", "норм" };
                    var bad = new[] { "такое себе", "плохо", "оч плохо(" };


                    if (review.Score >= 8)
                        review.Text = vgood[r.Next(0, vgood.Length)];
                    else if (review.Score >= 6)
                        review.Text = norm[r.Next(0, norm.Length)];
                    else
                        review.Text = bad[r.Next(0, bad.Length)];
                    _item.ScoreCount++;
                    _item.ScoreSumm+= review.Score;
                    review.Item.UpdateAvgScore();
                    _context.Update(_item);
                    _context.Add(review);
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteAll()
        {
            var Items = _context.Items.ToList<Item>();
            var Reviews = _context.Reviews.ToList<Review>();

            foreach (Item item in Items)
            {
                item.ScoreCount=0;
                item.ScoreSumm=0;
                item.UpdateAvgScore();
                _context.Items.Update(item);
                foreach (Review review in Reviews)
                    _context.Reviews.Remove(review);
            }


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
