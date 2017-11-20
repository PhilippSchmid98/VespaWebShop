using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class Product
    {

        public long Id { get; set; }

        public string ProductNumber { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public float Price { get; set; }

        public int Stock { get; set; }

        public IList<Tag> Tags { get; set; }

        public IList<Image> Images { get; set; }

        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
