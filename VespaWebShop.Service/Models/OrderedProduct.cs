using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    class OrderedProduct
    {
        public long OrderedProdcutId { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
