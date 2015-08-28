using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AuctionSite.Models {
    public class Repository {

        private DataContext _db = new DataContext();

        public IList<AuctionItem> ListAuctionItems() {
            return (from ai in _db.AuctionItems
                    select ai).ToList();
        }

        public AuctionItem GetAuctionItemById(int id) {
            return (from ai in _db.AuctionItems
                    where ai.Id == id
                    select ai).FirstOrDefault();
        }

        public void SaveAuctionItem(AuctionItem item) {
            if (item.Id != 0) {
                var dbItem = GetAuctionItemById(item.Id);
                dbItem.Name = item.Name;
                dbItem.MinimumBid = item.MinimumBid;
                dbItem.Description = item.Description;
                dbItem.NumberOfBids = item.NumberOfBids;
            }
            else {
                _db.AuctionItems.Add(item);
            }

            _db.SaveChanges();
        }

        public Bid GetBidById(int id) {
            return (from b in _db.Bids
                    where b.Id == id
                    select b).FirstOrDefault();
        }

        public void PlaceBid(Bid bid, AuctionItem auctionItem) {

            if (bid.BidAmount > auctionItem.MinimumBid) {
                bid.AuctionItem = auctionItem;
                auctionItem.MinimumBid = bid.BidAmount;

                _db.SaveChanges();
            }
        }
    }
}