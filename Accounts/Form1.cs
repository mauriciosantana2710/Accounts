namespace Accounts
{
    public partial class Form1 : Form
    {   // now we can use the bankAccount object to access its properties and methods
        // time to display the bank account information in the form/grid
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();


        }
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                return;
            }

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            bankAccounts.Add(bankAccount);
            RefreshGrid();
            OwnerTxt.Text = "";


        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
            //placing the list of bank accounts as the data source for the grid view

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.CurrentRow == null) return;
            BankAccount account = (BankAccount)BankAccountsGrid.CurrentRow.DataBoundItem;
            decimal amount = numericUpDown1.Value;
            
            try
            {
                account.Deposit(amount);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            RefreshGrid();
        }

       
    }
}
