using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiInvoice.Application.Interfaces;
using WebApiInvoice.Domain.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.Application.Services
{

    public class ProductService : IProductService
    {
        readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Product model)
        {
            if (string.IsNullOrEmpty(model.Name))
                return false;
            if (model.Price <= 0)
                return false;

            return _repository.Create(model) != 0;
        }
        public bool Update(Product model)
        {
            if (model.Id == 0)
                return false;
            return _repository.Update(model, model.Id) != 0;
        }

        public bool Delete(int id)
        {
            if (id == 0)
                return false;
            return _repository.Delete(id) != 0;
        }

        public Product SelectById(int id)
        {
            if (id == 0) return null;

            return _repository.GetById(id); 
        }

        public List<Product> SelectAll()
        {
            return _repository.Get();
        }


    }
}
