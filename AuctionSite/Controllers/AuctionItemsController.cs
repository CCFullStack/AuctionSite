using AuctionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class AuctionItemsController : Controller
    {
        private Repository _repo = new Repository();

        // GET: AuctionItems
        public ActionResult Index()
        {
            var auctionItems = _repo.ListAuctionItems();
            return View(auctionItems);
        }

        // GET: AuctionItems/Details/5
        public ActionResult Details(int id)
        {
            var item = _repo.GetAuctionItemById(id);
            if (item == null) {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: AuctionItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionItems/Create
        [HttpPost]
        public ActionResult Create(AuctionItem item)
        {
            try
            {
                _repo.SaveAuctionItem(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetAuctionItemById(id));
        }

        // POST: AuctionItems/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuctionItem item)
        {
            try
            {
                _repo.SaveAuctionItem(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuctionItems/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
