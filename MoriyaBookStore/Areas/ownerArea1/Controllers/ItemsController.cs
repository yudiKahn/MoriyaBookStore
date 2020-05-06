using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoriyaBookStore.Models.BI;
using MoriyaBookStore.Models.ContextDB;


namespace MoriyaBookStore.Areas.ownerArea1.Controllers
{
    public class ItemsController : Controller
    {
        private MoriyaDB db = new MoriyaDB();

        // GET: ownerArea1/Items
        public ActionResult Index()
        {
            // async Task<ActionResult>  await db.IItems.ToListAsync()
            return View();
        }

        // GET: ownerArea1/Items/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.GetItems.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: ownerArea1/Items/Create
        public ActionResult Create()
        {
            return View();
        }
        //נסיון לפתרון meny to meny
        public JsonResult SaveOrder(Item item, category[] categories)
        {
            db.GetItems.Add(item);
            foreach (var category in categories)
            {
                category.Items.Add(item);
                db.GetCategories.Add(category);
            }
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // POST: ownerArea1/Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Author,Description,Price,ImgUrl,AmountInStack")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.GetItems.Add(item);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: ownerArea1/Items/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.GetItems.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: ownerArea1/Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Author,Description,Price,ImgUrl,AmountInStack")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: ownerArea1/Items/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.GetItems.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: ownerArea1/Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Item item = await db.GetItems.FindAsync(id);
            db.GetItems.Remove(item);
            await db.SaveChangesAsync();
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
        public ActionResult Create2()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2(Models.ViewModels.ItemViewModel myViewModel)
        {
            if (ModelState.IsValid)
            {

                myViewModel.item.Categories.AddRange(myViewModel.ItemCategores);
                db.GetItems.Add(myViewModel.item);
                db.GetCategories.AddRange(myViewModel.ItemCategores);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(myViewModel);

        }
           
    }

}
