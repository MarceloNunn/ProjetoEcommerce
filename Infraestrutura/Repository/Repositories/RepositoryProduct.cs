using Domain.Interfaces.InterfacesProducts;
using Entities.Entities;
using Infraestrutura.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct
    {
    }
}
