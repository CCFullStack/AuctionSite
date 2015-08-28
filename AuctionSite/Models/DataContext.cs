using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionSite.Models {
    public class DataContext : DbContext {
        public IDbSet<AuctionItem> AuctionItems { get; set; }
        public IDbSet<Bid> Bids { get; set; }
    }
}