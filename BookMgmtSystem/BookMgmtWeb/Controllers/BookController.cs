using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookMgmtWeb.Controllers
{
    public class BookController : Controller
    {
        BookBL bbl=new BookBL();
        public IActionResult Index()
        {
            List<Book> blist = bbl.getAllbooks();
            return View(blist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book bk)
        {
            bool res=bbl.AddBooks(bk);
            if (res)
            {
                ViewData["msg"] = "Books added successfully!!";
                return View("Success", bk);
            }
            return View();
        }

    }
}
