using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class OrderedProduct
    {
        public long Id { get; set; }

        public long OrderedProdcutId { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
