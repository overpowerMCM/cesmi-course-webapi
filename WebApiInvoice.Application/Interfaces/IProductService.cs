using System.Collections.Generic;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.Application.Interfaces
{
    public interface IProductService
    {
        bool Add(Product model);
        bool Delete(int id);
        List<Product> SelectAll();
        Product SelectById(int id);
        bool Update(Product model);
    }
}
