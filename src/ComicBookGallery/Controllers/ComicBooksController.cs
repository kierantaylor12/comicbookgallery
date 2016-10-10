using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers // example localhost/ComicBooks
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() // action method, example localhost/ComicBooks/Detail
        {
            return View();
        }
    }
}