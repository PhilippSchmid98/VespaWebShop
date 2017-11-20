using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class Order
    {
        public long Id  { get; set; }

        public IList<OrderedProduct> OrderedProducts { get; set; }

        public DateTime OrderDate { get; set; }

        public bool Sended { get; set; }

        public DateTime SendDate { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        [NotMapped]
        public float Summary
        {
            get
            {
                float summary = 0;

                foreach(OrderedProduct orderdProd in OrderedProducts)
                {
                    summary += orderdProd.Amount * orderdProd.Product.Price;
                }

                return summary;
            }
        }
        
    }
}
