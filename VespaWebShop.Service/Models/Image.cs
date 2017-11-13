using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class Image
    {
        public long ImageId { get; set; }
        public byte[] Binary { get; set; }
    }
}
