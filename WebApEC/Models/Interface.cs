using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApEC.Models
{
  public   interface Iproductservice
    {
       Task<List<string>> GetProduct();
    }
}
