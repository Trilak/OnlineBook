using Online_BookStore.Context;
using Online_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Online_BookStore.Controllers
{
    public class BookController : Controller
    {
        BookContext db = new BookContext();

        // GET: Book
        public ActionResult Index()
        {
            return View(db.Book.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here
                db.Book.Add(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var databyid = db.Book.Single(x => x.Id == id);
            return View(databyid);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book collection)
        {
            try
            {
                // TODO: Add update logic here
                Book bookOjb = db.Book.Single(x => x.Id == id);

                bookOjb.Id = collection.Id;
                bookOjb.Title = collection.Title;
                bookOjb.Category = collection.Category;
                bookOjb.Price = collection.Price;
                bookOjb.Image = collection.Image;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var databyid = db.Book.Single(x => x.Id == id);
            return View(databyid);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                var bookdataid = db.Book.Single(x => x.Id == id);
                db.Book.Remove(bookdataid);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
