
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeTestTransactions();
        }

        private void InitializeTestTransactions()
        {
            var accountService = new AccountService();
            var transactionService = new TransactionService();
            transactionService.MakePayment(accountService.GetAccount("HR11"), accountService.GetAccount("HR12"), 550);
            transactionService.MakePayment(accountService.GetAccount("HR11"), accountService.GetAccount("HR13"), 1200);
            transactionService.MakePayment(accountService.GetAccount("HR12"), accountService.GetAccount("HR13"), 800);
            transactionService.MakePayment(accountService.GetAccount("HR13"), accountService.GetAccount("HR14"), 220);
            transactionService.MakePayment(accountService.GetAccount("HR14"), accountService.GetAccount("HR51"), 450);
            transactionService.MakePayment(accountService.GetAccount("HR51"), accountService.GetAccount("HR52"), 150);
            transactionService.MakePayment(accountService.GetAccount("HR52"), accountService.GetAccount("HR53"), 150);
        }

        private void ShowTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowTransactionsForm();
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void ShowExchangeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowExchangeRatesForm();
            form.MdiParent = this;
            form.Show();
        }

        private void ShowCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowCurrenciesForm();
            form.MdiParent = this;
            form.Show();
        }

        private void ShowClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowClientsForm();
            form.MdiParent = this;
            form.Show();
        }

        private void NewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewClientForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
