using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetProductByIdByUseCase : IGetProductByIdByUseCase
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdByUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int productId)
        {
            return productRepository.GetProductById(productId);
        }
    }
}
