using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class ExchangeRateException : BankException
    {
        public ExchangeRateException(string message) : base(message)
        {
        }
    }
}
