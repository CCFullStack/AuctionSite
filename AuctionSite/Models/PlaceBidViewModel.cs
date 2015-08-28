using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models {
    public class PlaceBidViewModel {
        public Bid Bid { get; set; }
        public int AuctionItemId { get; set; }
    }
}