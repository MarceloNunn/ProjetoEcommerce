using ApplicationApp.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        
         
        public AppProduct()
        {
                
        }
        public Task Add(Product Objeto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteProduct(Product Objeto)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdProduct(Product Objeto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> List()
        {
            throw new NotImplementedException();
        }
        public Task AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
