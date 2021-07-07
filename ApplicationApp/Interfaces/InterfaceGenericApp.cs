using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T Objeto);
        Task UpdateProduct(T Objeto);
        Task DeleteProduct(T Objeto);
        Task GetByIdProduct(T Objeto);
        Task<List<T>> List();
    }
}
