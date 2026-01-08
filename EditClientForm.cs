using BusinessLayer;
using Entities.Clients;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditClientForm : Form
    {
        public IClient Client { get; private set; }

        public EditClientForm(IClient client)
        {
            InitializeComponent();
            Client = client;
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            ShowClientData();
        }

        private void ShowClientData()
        {
            if (Client.Type == ClientType.Basic)
            {
                ShowBasicClient(Client as BasicClient);
            }
            else
            {
                ShowPremiumClient(Client as PremiumClient);
            }
        }

        private void ShowBasicClient(BasicClient client)
        {
            txtOIB.Text = client.OIB;
            txtFirstname.Text = client.FirstName;
            txtLastname.Text = client.LastName;
            cmbClientType.SelectedIndex = 0;
            txtCompany.Enabled = false;
        }

        private void ShowPremiumClient(PremiumClient client)
        {
            txtOIB.Text = client.OIB;
            txtFirstname.Text = client.FirstName;
            txtLastname.Text = client.LastName;
            cmbClientType.SelectedIndex = 1;
            txtCompany.Text = client.CompanyName;
            txtCompany.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClientData();
            Close();
        }

        private void SaveClientData()
        {
            if (Client.Type == ClientType.Basic)
            {
                SaveBasicClient(Client as BasicClient);
            }
            else
            {
                SavePremiumClient(Client as PremiumClient);
            }
        }

        private void SavePremiumClient(PremiumClient client)
        {
            var clientService = new ClientService();
            clientService.UpdatePremiumClient(client, txtOIB.Text, txtCompany.Text, txtFirstname.Text, txtLastname.Text);
        }

        private void SaveBasicClient(BasicClient client)
        {
            var clientService = new ClientService();
            clientService.UpdateBasicClient(client, txtOIB.Text, txtFirstname.Text, txtLastname.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
