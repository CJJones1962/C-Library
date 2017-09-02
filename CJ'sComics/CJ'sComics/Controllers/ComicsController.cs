using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CJ_sComics.Models;

namespace CJ_sComics.Controllers
{
    public class ComicsController : Controller
    {
        private ComicBooksEntities db = new ComicBooksEntities();

        // GET: Comics
        public ActionResult Index()
        {
            return View(db.Comics.ToList());
        }

        // GET: Comics/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comic comic = db.Comics.Find(id);
            if (comic == null)
            {
                return HttpNotFound();
            }
            return View(comic);
        }

        // GET: Comics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComicBookId,ComicTitle,EpisodeNumber,EpisodeTitle,Characters")] Comic comic)
        {
            if (ModelState.IsValid)
            {
                comic.ComicBookId = Guid.NewGuid();
                db.Comics.Add(comic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comic);
        }

        // GET: Comics/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comic comic = db.Comics.Find(id);
            if (comic == null)
            {
                return HttpNotFound();
            }
            return View(comic);
        }

        // POST: Comics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComicBookId,ComicTitle,EpisodeNumber,EpisodeTitle,Characters")] Comic comic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comic);
        }

        // GET: Comics/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comic comic = db.Comics.Find(id);
            if (comic == null)
            {
                return HttpNotFound();
            }
            return View(comic);
        }

        // POST: Comics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Comic comic = db.Comics.Find(id);
            db.Comics.Remove(comic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
