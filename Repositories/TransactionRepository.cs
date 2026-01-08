using Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TransactionRepository : Repository<Transaction>
    {
        public List<Transaction> GetByAccount(IAccount account)
        {
            return items.FindAll(x => x.PayerAccount == account || x.ReceiverAccount == account);
        }
    }
}
