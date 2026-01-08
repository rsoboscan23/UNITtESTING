using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Exceptions;

namespace PresentationLayer
{
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            var clientService = new ClientService();

            string oib = txtOIB.Text;
            string company = txtCompany.Text;
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;

            try
            {
                if (cmbType.SelectedIndex == 0)
                {
                    clientService.CreateBasicClient(oib, firstname, lastname);
                }
                else
                {
                    clientService.CreatePremiumClient(oib, company, firstname, lastname);
                }
            }
            catch (ClientException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                txtCompany.Enabled = false;
            }
            else
            {
                txtCompany.Enabled = true;
            }
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
