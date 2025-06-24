using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiInvoice.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
