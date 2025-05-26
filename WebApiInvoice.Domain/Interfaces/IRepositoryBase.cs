
using System;
using System.Collections.Generic;

namespace WebApiInvoice.Domain.Interfaces
{
    public interface IRepositoryBase<tModel>
    { 
        // CRUD + Select 
        List<tModel> Select( Predicate<tModel> model, int offset = 0, int limit = 0);
        int Create(tModel model);
        int Update(tModel model, int id);
        int Delete(int id);
    }
}