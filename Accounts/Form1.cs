namespace Accounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Mauricio Santana";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 1000;

            // now we can use the bankAccount object to access its properties and methods
            // time to display the bank account information in the form/grid

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);

            //placing the list of bank accounts as the data source for the grid view
            BankAccountsGrid.DataSource = bankAccounts;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
