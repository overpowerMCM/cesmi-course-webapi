using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace WebApiInvoice.DataAccessLayer
{
    public static class DataAccessLayerExtension
    {
        public static void AddDataAccessLayer( this IServiceCollection services )
        { 
            // configuraciones por ejemplo de EF
        }
    }
}