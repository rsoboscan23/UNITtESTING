using BusinessLayer;
using Entities.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ShowTransactionsForm : Form
    {
        private IAccount selectedAccount;
        public IAccount SelectedAccount { get => selectedAccount; set => selectedAccount = value; }

        public ShowTransactionsForm()
        {
            InitializeComponent();
        }

        public ShowTransactionsForm(IAccount account)
        {
            InitializeComponent();
            SelectedAccount = account;
        }

        private void ShowTransactionsForm_Load(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                ShowAccountTransactions();
                btnNewTransaction.Visible = false;
            }
            else
            {
                ShowAllTransactions();
                btnNewTransaction.Visible = true;
            }
        }

        private void ShowAllTransactions()
        {
            var transactionService = new TransactionService();
            var transactions = transactionService.GetTransactions();

            dgvTransactions.DataSource = transactions;
        }

        private void ShowAccountTransactions()
        {
            var transactionService = new TransactionService();
            var accountTransactions = transactionService.GetAccountTransactions(selectedAccount);

            dgvTransactions.DataSource = accountTransactions;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            var form = new NewTransactionForm();
            form.ShowDialog();
            ShowAllTransactions();
        }
    }
}
