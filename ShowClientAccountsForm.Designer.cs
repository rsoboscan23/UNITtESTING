namespace PresentationLayer
{
    partial class ShowClientAccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.btnNewCheckingAccount = new System.Windows.Forms.Button();
            this.btnNewForeignAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account list:";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(9, 24);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(773, 295);
            this.dgvAccounts.TabIndex = 1;
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTransactions.Location = new System.Drawing.Point(662, 323);
            this.btnShowTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.Size = new System.Drawing.Size(121, 44);
            this.btnShowTransactions.TabIndex = 2;
            this.btnShowTransactions.Text = "Show transactions";
            this.btnShowTransactions.UseVisualStyleBackColor = true;
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // btnNewCheckingAccount
            // 
            this.btnNewCheckingAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCheckingAccount.Location = new System.Drawing.Point(9, 323);
            this.btnNewCheckingAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCheckingAccount.Name = "btnNewCheckingAccount";
            this.btnNewCheckingAccount.Size = new System.Drawing.Size(121, 44);
            this.btnNewCheckingAccount.TabIndex = 3;
            this.btnNewCheckingAccount.Text = "New checking account";
            this.btnNewCheckingAccount.UseVisualStyleBackColor = true;
            this.btnNewCheckingAccount.Click += new System.EventHandler(this.btnNewCheckingAccount_Click);
            // 
            // btnNewForeignAccount
            // 
            this.btnNewForeignAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewForeignAccount.Location = new System.Drawing.Point(134, 323);
            this.btnNewForeignAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewForeignAccount.Name = "btnNewForeignAccount";
            this.btnNewForeignAccount.Size = new System.Drawing.Size(121, 44);
            this.btnNewForeignAccount.TabIndex = 4;
            this.btnNewForeignAccount.Text = "New foreign account";
            this.btnNewForeignAccount.UseVisualStyleBackColor = true;
            this.btnNewForeignAccount.Click += new System.EventHandler(this.btnNewForeignAccount_Click);
            // 
            // ShowClientAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 377);
            this.Controls.Add(this.btnNewForeignAccount);
            this.Controls.Add(this.btnNewCheckingAccount);
            this.Controls.Add(this.btnShowTransactions);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowClientAccountsForm";
            this.Text = "Show client\'s accounts";
            this.Load += new System.EventHandler(this.ShowClientAccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button btnShowTransactions;
        private System.Windows.Forms.Button btnNewCheckingAccount;
        private System.Windows.Forms.Button btnNewForeignAccount;
    }
}