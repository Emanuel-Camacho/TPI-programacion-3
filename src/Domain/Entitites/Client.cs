using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitites
{
    public class Client : User
    {
        public List<Cart> Carts {  get; set; } = new List<Cart>();
    }
}
