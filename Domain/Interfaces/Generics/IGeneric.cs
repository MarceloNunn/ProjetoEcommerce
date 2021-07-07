using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objeto);
        Task UpdateProduct(T Objeto);
        Task DeleteProduct(T Objeto);
        Task GetByIdProduct(T Objeto);
        Task<List<T>> List();

    }
}
