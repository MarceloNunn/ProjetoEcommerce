using Domain.Interfaces.InterfaceServices;
using Domain.Interfaces.InterfacesProducts;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        public async Task AddProduct(Product product)
        {
            var validaPropriedadeNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaPropriedadeValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");
            if (validaPropriedadeNome && validaPropriedadeValor )
            {
                product.Estado = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validaPropriedadeNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaPropriedadeValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");
            if (validaPropriedadeNome && validaPropriedadeValor)
            {
                product.Estado = true;
                await _IProduct.UpdateProduct(product);
            }
        }
    }
}
