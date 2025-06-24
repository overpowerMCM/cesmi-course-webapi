using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using WebApiInvoice.Domain.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.DataAccessLayer
{
    public class ProductRepository : IProductRepository
    {
        static List<Product> _productList = new List<Product>();
        static int autoincremento = 0;
        public int Create(Product model)
        {

            model.Id = ++autoincremento;
            _productList.Add(model);
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

        public List<Product> Get(int offset = 0, int limit = 0)
        {
            return _productList.FindAll(p => true);
        }

        public Product GetById(int id)
        {
            return _productList.SingleOrDefault( p=> p.Id == id);
        }
        

        public int Update(Product model, int id)
        {
            Product pr = _productList.Find(p => p.Id == id);

            if ( pr != null )
            {
                pr.Code = model.Code;
                pr.Name = model.Name;
                pr.Price = model.Price;

                return 1;
            }
            return 0;
        }
    }
}