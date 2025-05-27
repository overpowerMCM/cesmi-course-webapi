using System;
using System.Collections.Generic;
using WebApiInvoice.Domain.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.DataAccessLayer
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _productList = new List<Product>();
        public int Create(Product model)
        {
            _productList.Add( model );
            return 1;
        }

        public int Delete(int id)
        {
            Product pr = _productList.Find( p => p.Id == id);

            if (pr != null)
            {
                _productList.Remove(pr);
                return 1;
            }

            return 0;
        }

        public List<Product> Select(Predicate<Product> predicate, int offset = 0, int limit = 0)
        {
            return _productList.FindAll(predicate);
        }

        public int Update(Product model, int id)
        {
            Product pr = _productList.Find(p => p.Id == id);

            if ( pr != null )
            {
                pr.Code = model.Code;

                return 1;
            }
            return 0;
        }
    }
}