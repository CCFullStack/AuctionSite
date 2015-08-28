using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models {
    public class AuctionItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MinimumBid { get; set; }
        public int NumberOfBids { get; set; }
    }
}