namespace PresentationLayer
{
    partial class NewTransactionForm
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
            this.txtPayerAccount = new System.Windows.Forms.TextBox();
            this.btnChoosePayerAccount = new System.Windows.Forms.Button();
            this.btnChooseReceiverAccount = new System.Windows.Forms.Button();
            this.txtReceiverAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChoosePayer = new System.Windows.Forms.Button();
            this.txtPayerClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseReceiverClient = new System.Windows.Forms.Button();
            this.txtReceiverClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account:";
            // 
            // txtPayerAccount
            // 
            this.txtPayerAccount.Enabled = false;
            this.txtPayerAccount.Location = new System.Drawing.Point(91, 49);
            this.txtPayerAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayerAccount.Name = "txtPayerAccount";
            this.txtPayerAccount.Size = new System.Drawing.Size(409, 22);
            this.txtPayerAccount.TabIndex = 1;
            // 
            // btnChoosePayerAccount
            // 
            this.btnChoosePayerAccount.Location = new System.Drawing.Point(505, 49);
            this.btnChoosePayerAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoosePayerAccount.Name = "btnChoosePayerAccount";
            this.btnChoosePayerAccount.Size = new System.Drawing.Size(35, 22);
            this.btnChoosePayerAccount.TabIndex = 2;
            this.btnChoosePayerAccount.Text = "...";
            this.btnChoosePayerAccount.UseVisualStyleBackColor = true;
            this.btnChoosePayerAccount.Click += new System.EventHandler(this.btnChoosePayerAccount_Click);
            // 
            // btnChooseReceiverAccount
            // 
            this.btnChooseReceiverAccount.Location = new System.Drawing.Point(505, 53);
            this.btnChooseReceiverAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseReceiverAccount.Name = "btnChooseReceiverAccount";
            this.btnChooseReceiverAccount.Size = new System.Drawing.Size(35, 23);
            this.btnChooseReceiverAccount.TabIndex = 5;
            this.btnChooseReceiverAccount.Text = "...";
            this.btnChooseReceiverAccount.UseVisualStyleBackColor = true;
            this.btnChooseReceiverAccount.Click += new System.EventHandler(this.BtnChooseReceiverAccount_Click);
            // 
            // txtReceiverAccount
            // 
            this.txtReceiverAccount.Enabled = false;
            this.txtReceiverAccount.Location = new System.Drawing.Point(91, 54);
            this.txtReceiverAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiverAccount.Name = "txtReceiverAccount";
            this.txtReceiverAccount.Size = new System.Drawing.Size(409, 22);
            this.txtReceiverAccount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(101, 215);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChoosePayer);
            this.groupBox1.Controls.Add(this.txtPayerClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPayerAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChoosePayerAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payer:";
            // 
            // btnChoosePayer
            // 
            this.btnChoosePayer.Location = new System.Drawing.Point(505, 21);
            this.btnChoosePayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoosePayer.Name = "btnChoosePayer";
            this.btnChoosePayer.Size = new System.Drawing.Size(35, 22);
            this.btnChoosePayer.TabIndex = 4;
            this.btnChoosePayer.Text = "...";
            this.btnChoosePayer.UseVisualStyleBackColor = true;
            this.btnChoosePayer.Click += new System.EventHandler(this.btnChoosePayerCient_Click);
            // 
            // txtPayerClient
            // 
            this.txtPayerClient.Enabled = false;
            this.txtPayerClient.Location = new System.Drawing.Point(91, 21);
            this.txtPayerClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayerClient.Name = "txtPayerClient";
            this.txtPayerClient.Size = new System.Drawing.Size(409, 22);
            this.txtPayerClient.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseReceiverClient);
            this.groupBox2.Controls.Add(this.txtReceiverClient);
            this.groupBox2.Controls.Add(this.txtReceiverAccount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnChooseReceiverAccount);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(545, 97);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver:";
            // 
            // btnChooseReceiverClient
            // 
            this.btnChooseReceiverClient.Location = new System.Drawing.Point(505, 25);
            this.btnChooseReceiverClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseReceiverClient.Name = "btnChooseReceiverClient";
            this.btnChooseReceiverClient.Size = new System.Drawing.Size(35, 23);
            this.btnChooseReceiverClient.TabIndex = 12;
            this.btnChooseReceiverClient.Text = "...";
            this.btnChooseReceiverClient.UseVisualStyleBackColor = true;
            this.btnChooseReceiverClient.Click += new System.EventHandler(this.btnChooseReceiverClient_Click);
            // 
            // txtReceiverClient
            // 
            this.txtReceiverClient.Enabled = false;
            this.txtReceiverClient.Location = new System.Drawing.Point(91, 26);
            this.txtReceiverClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiverClient.Name = "txtReceiverClient";
            this.txtReceiverClient.Size = new System.Drawing.Size(409, 22);
            this.txtReceiverClient.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(377, 255);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(84, 46);
            this.btnExecute.TabIndex = 10;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(467, 255);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 46);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 313);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayerAccount;
        private System.Windows.Forms.Button btnChoosePayerAccount;
        private System.Windows.Forms.Button btnChooseReceiverAccount;
        private System.Windows.Forms.TextBox txtReceiverAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPayerClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReceiverClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChoosePayer;
        private System.Windows.Forms.Button btnChooseReceiverClient;
    }
}