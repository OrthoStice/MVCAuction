using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAuction.Models
{
    public class Auction
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURl { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public decimal StartPrice { get; set; }
        public decimal? CurrentPrice { get; set; } // ? makes it nullable
    }
}