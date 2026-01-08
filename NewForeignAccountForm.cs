
using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Clients;
using Entities.Exchange;
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
    public partial class NewForeignAccountForm : Form
    {
        private Currency _chosenCurrency;

        public IClient ChosenClient { get; set; }

        public NewForeignAccountForm(IClient client)
        {
            InitializeComponent();
            ChosenClient = client;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string iban = txtIBAN.Text;
            double balance = double.Parse(txtBalance.Text);

            var accountService = new AccountService();
            try
            {
                accountService.CreateForeignCurrencyAccount(iban, balance, _chosenCurrency, ChosenClient);
                Close();
            }
            catch (AccountException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChooseCurrency_Click(object sender, EventArgs e)
        {
            ChooseCurrencyForm form = new ChooseCurrencyForm();
            form.ShowDialog();

            _chosenCurrency = form.ChosenCurrency;
            if(_chosenCurrency == null)
            {
                txtCurrency.Text = _chosenCurrency.ToString();
            }
            else
            {
                txtCurrency.Clear();
            }
        }

        private void InitializeData()
        {
            var accountService = new AccountService();
            string iban = accountService.GenerateIBAN();

            txtIBAN.Text = iban;
            txtOwner.Text = ChosenClient.Description;
            txtBalance.Text = "0";
        }

        private void NewForeignAccountForm_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
