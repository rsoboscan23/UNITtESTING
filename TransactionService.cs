using BusinessLayer.Exceptions;
using DAL;
using Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TransactionService
    {
        public List<Transaction> GetAccountTransactions(IAccount account)
        {
            return UnitOfWork.TransactionRepository.GetByAccount(account);
        }

        public List<Transaction> GetTransactions()
        {
            return UnitOfWork.TransactionRepository.GetAll();
        }

        public void MakePayment(IAccount payerAccount, IAccount recieverAccount, double amount)
        {
            ValidatePaymentData(payerAccount, recieverAccount, amount);

            var exchangeService = new ExchangeService();

            double amountToPay = amount;
            double amountToRecieve = exchangeService.ChangeMoney(amount, payerAccount.Currency, recieverAccount.Currency);

            var transaction = new Transaction(payerAccount, recieverAccount, amountToPay, amountToRecieve);
            transaction.Execute();

            UnitOfWork.TransactionRepository.Add(transaction);
        }

        private static void ValidatePaymentData(IAccount payerAccount, IAccount recieverAccount, double amount)
        {
            if (payerAccount.IBAN == recieverAccount.IBAN)
            {
                throw new TransactionException("Payer and reciever account can't be the same!");
            }
            else if (amount <= 0)
            {
                throw new TransactionException("Amount must be greater than 0!");
            }
            else if (payerAccount.Balance < amount)
            {
                throw new TransactionException("Payer account doesn't have enough money!");
            }
        }
    }
}
