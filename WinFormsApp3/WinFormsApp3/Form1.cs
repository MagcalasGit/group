using Newtonsoft.Json;
using System;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private double balance = 10000;
        private List<Transactions> transactions;
        public Form1()
        {
            InitializeComponent();
            LoadTransaction();
        }

        private void LoadTransaction()
        {
            try
            {
                string json = File.ReadAllText("transaction.json");
                transactions = JsonConvert.DeserializeObject<List<Transactions>>(json);
            } catch (FileNotFoundException)
            {
                transactions = new List<Transactions>();    
            }
            dgvTransactions.DataSource = transactions;
        } 

        private void SaveTransaction()
        {
            string json = JsonConvert.SerializeObject(transactions);
            File.WriteAllText("transaction.json", json);
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Inavlid Input");
            }
            else
            {
                double amount;
                if (double.TryParse(txtAmount.Text, out amount) && amount != 0)
                {
                    balance += amount;
                    transactions.Add(new Transactions { Type = "Deposit", Time = DateTime.Now, Amount = amount, Balance = balance });
                    SaveTransaction();
                    LoadTransaction();
                    lblCurrentBal.Text = balance.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid amount");
                }
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Inavlid Input");
            }
            else
            {
                double amount;
                if (double.TryParse(txtAmount.Text, out amount) && amount != 0)
                {
                    if (amount <= balance)
                    {
                        balance -= amount;
                        transactions.Add(new Transactions { Type = "Withdraw", Time = DateTime.Now, Amount = amount, Balance = balance });
                        SaveTransaction();
                        LoadTransaction();
                        lblCurrentBal.Text = balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount");
                }
            }
        }
    }
    public class Transactions
    {
        public string Type { get; set; }
        public DateTime Time {  get; set; }
        public double Amount { get; set; }  
        public double Balance { get; set; }
    }
}
