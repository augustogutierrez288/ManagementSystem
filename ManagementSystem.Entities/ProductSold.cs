using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Entities
{
    public class ProductSold
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProduct { get; set; }
        public int IdSold { get; set; }
    }
}
