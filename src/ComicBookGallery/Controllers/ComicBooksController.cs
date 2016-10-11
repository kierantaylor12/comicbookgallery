using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers // example localhost/ComicBooks
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id) // action method, example localhost/ComicBooks/Detail
        {
            var comicBookTotals = _comicBookRepository.GetComicBooks();

            if(id > comicBookTotals.Length) // whilst the ID entered into the detail parameters is equal to more than the length of the array, throw a httpnotfound page.
            {
                return HttpNotFound("The Comic ID you entered was not found!");
            }

            while (id == null)
            {
                return HttpNotFound("Sorry this destination was not found!");                     
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }

    }
}