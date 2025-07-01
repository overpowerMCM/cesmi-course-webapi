using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiInvoice.Domain.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ciudad { get; set; }

        public string Telefono { get; set; }
        public int CodigoPostal { get; set; }
    }
}