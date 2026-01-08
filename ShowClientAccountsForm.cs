using BusinessLayer;
using Entities.Accounts;
using Entities.Clients;
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
    public partial class ShowClientAccountsForm : Form
    {
        public IClient chosenClient { get; set; }

        public ShowClientAccountsForm(IClient client)
        {
            InitializeComponent();
            chosenClient = client;
        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            IAccount account = GetSelectedAccount();
            ShowAccountTransactions(account);
        }

        private void ShowAccountTransactions(IAccount account)
        {
            ShowTransactionsForm form = new ShowTransactionsForm(account);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private IAccount GetSelectedAccount()
        {
            if (dgvAccounts.CurrentRow != null)
            {
                return dgvAccounts.CurrentRow.DataBoundItem as IAccount;
            }
            return null;
        }

        private void ShowClientAccountsForm_Load(object sender, EventArgs e)
        {
            ShowClientAccounts();
        }

        private void ShowClientAccounts()
        {
            if (chosenClient != null)
            {
                var accountService = new AccountService();
                var clientAccounts = accountService.GetClientAccounts(chosenClient);

                dgvAccounts.DataSource = clientAccounts;
            }
        }

        private void btnNewCheckingAccount_Click(object sender, EventArgs e)
        {
            var form = new NewCheckingAccountForm(chosenClient);
            form.ShowDialog();
            ShowClientAccounts();
        }

        private void btnNewForeignAccount_Click(object sender, EventArgs e)
        {
            var form = new NewForeignAccountForm(chosenClient);
            form.ShowDialog();
            ShowClientAccounts();
        }
    }
}
