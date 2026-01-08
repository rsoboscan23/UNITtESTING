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
    public partial class ChooseAccountForm : Form
    {
        public IAccount chosenAccount { get; set; }
        private IClient _client;

        public ChooseAccountForm(IClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private void ChooseAccountForm_Load(object sender, EventArgs e)
        {
            var accountService = new AccountService();
            var clientAccounts = accountService.GetClientAccounts(_client);

            dgvAccounts.DataSource = clientAccounts;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            chosenAccount = GetSelectedAccount();
            Close();
        }

        private IAccount GetSelectedAccount()
        {
            if (dgvAccounts.CurrentRow != null)
            {
                return dgvAccounts.CurrentRow.DataBoundItem as IAccount;
            }
            return null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            chosenAccount = null;
            Close();
        }
    }
}
