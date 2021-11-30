using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
    {
        private readonly ITransactionRepostiory transactionRepostiory;

        public GetTodayTransactionsUseCase(ITransactionRepostiory transactionRepostiory)
        {
            this.transactionRepostiory = transactionRepostiory;
        }

        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return transactionRepostiory.GetByDay(cashierName, DateTime.Now);
        }
    }
}
