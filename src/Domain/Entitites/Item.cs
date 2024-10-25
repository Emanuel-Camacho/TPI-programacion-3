using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitites
{
    public class Item
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

    }
}
