using MicroServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServices.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int ProductId);

        void InsertProduct(Product product);

        void DeleteProduct(int ProductId);

        void UodateProduct(Product product);

        void Save();
    }
}
