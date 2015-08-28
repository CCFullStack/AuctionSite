using AuctionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class BidsController : Controller
    {
        private Repository _repo = new Repository();
        
        // POST: Bids/Create
        [HttpPost]
        public ActionResult PlaceBid(PlaceBidViewModel model) {

            _repo.PlaceBid(model.Bid, _repo.GetAuctionItemById(model.AuctionItemId));

            return RedirectToAction("Index", "AuctionItems");
        }
    }
}