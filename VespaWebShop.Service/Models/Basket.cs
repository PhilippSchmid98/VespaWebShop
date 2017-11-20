using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class Basket
    {

        public long Id { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public IList<OrderedProduct> OrderedProduct { get; set; }
    }
}
