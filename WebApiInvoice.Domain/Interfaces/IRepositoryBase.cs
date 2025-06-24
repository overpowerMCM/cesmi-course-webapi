
using System;
using System.Collections.Generic;

namespace WebApiInvoice.Domain.Interfaces
{
    public interface IRepositoryBase<tModel>
    { 
        // CRUD + Select 
        List<tModel> Get( int offset = 0, int limit = 0 );
        tModel GetById(int id);
        int Create(tModel model);
        int Update(tModel model, int id);
        int Delete(int id);
    }
}