
using BusinessLayer;
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
    public partial class NewCheckingAccountForm : Form
    {
        public new IClient Owner { get; set; }

        public NewCheckingAccountForm(IClient owner)
        {
            InitializeComponent();
            Owner = owner;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iban = txtIBAN.Text;
            double balance = double.Parse(txtBalance.Text);
            double overdraft = double.Parse(txtOverdraft.Text);

            var accountService = new AccountService();
            accountService.CreateCheckingAccount(iban, balance, overdraft, Owner);

            Close();
        }

        private void NewCheckingAccountForm_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            var accountService = new AccountService();
            string iban = accountService.GenerateIBAN();

            txtIBAN.Text = iban;
            txtOwner.Text = Owner.Description;

            var currencyService = new CurrencyService();
            var hrk = currencyService.GetCurrency("HRK");

            txtCurrency.Text = hrk.ToString();
            txtBalance.Text = "0";
            txtOverdraft.Text = "0";
        }
    }
}
