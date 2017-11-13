using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    class Basket
    {

        public long BasketId { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public OrderedProduct OrderedProduct { get; set; }
    }
}
