using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly ITransactionRepostiory transactionRepostiory;

        public GetTransactionsUseCase(ITransactionRepostiory transactionRepostiory)
        {
            this.transactionRepostiory = transactionRepostiory;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return transactionRepostiory.Search(cashierName, startDate, endDate);
        }
    }
}
