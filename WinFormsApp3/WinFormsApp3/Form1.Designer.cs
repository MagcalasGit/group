namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTransactions = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            txtAmount = new TextBox();
            label1 = new Label();
            lblCurrentBal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(362, 107);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(426, 331);
            dgvTransactions.TabIndex = 0;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(45, 299);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(265, 43);
            DepositBtn.TabIndex = 1;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(45, 359);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(265, 43);
            WithdrawBtn.TabIndex = 2;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(45, 107);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(265, 43);
            txtAmount.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 65);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 4;
            label1.Text = "Balance:";
            // 
            // lblCurrentBal
            // 
            lblCurrentBal.AutoSize = true;
            lblCurrentBal.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentBal.Location = new Point(464, 65);
            lblCurrentBal.Name = "lblCurrentBal";
            lblCurrentBal.Size = new Size(47, 32);
            lblCurrentBal.TabIndex = 5;
            lblCurrentBal.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentBal);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(dgvTransactions);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransactions;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private TextBox txtAmount;
        private Label label1;
        private Label lblCurrentBal;
    }
}
