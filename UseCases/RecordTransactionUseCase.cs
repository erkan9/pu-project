using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepostiory transactionRepostiory;
        private readonly IGetProductByIdByUseCase getProductByIdByUseCase;

        public RecordTransactionUseCase(
            ITransactionRepostiory transactionRepostiory,
            IGetProductByIdByUseCase getProductByIdByUseCase)
        {
            this.transactionRepostiory = transactionRepostiory;
            this.getProductByIdByUseCase = getProductByIdByUseCase;
        }

        public void Execute(string cashierName, int productId, int qty)
        {

            var product = getProductByIdByUseCase.Execute(productId);

            transactionRepostiory.Save(cashierName, productId, product.Name, product.Price.Value, product.Quanity.Value, qty);
        }
    }
}
