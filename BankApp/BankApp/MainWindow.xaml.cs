using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BankApp.Bank;

namespace BankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables to be used as a "Storage".
        int depositMoney { get; set; }
        int withdrawMoney { get; set; }
        int money { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Wannabe Login.
            lblName.Content = txtName.Text;
            lblAddress.Content = txtAddress.Text;
            lblbankAccount.Content = txtBankNum.Text;
        }

        public void btnDeposit_Click(object sender, EventArgs e)
        {
            //If clicked, the amount will be translated to an integer and then runs the selected method. 
            depositMoney = int.Parse(txtDepositAmount.Text);
            Deposit();
        }

        public void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Same as above.
            withdrawMoney = int.Parse(txtWithdrawAmount.Text);
            Withdraw();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            //If clicked, the amount gets translated to a Double and then goes through an equation.
            double interest = double.Parse(txtInterestAmount.Text);
            interest = interest * 3 * 4.6 / 10;
            //Gets rounded
            lblInterestResult.Content = Math.Round(interest, 2, MidpointRounding.ToEven);
        }

        public int Deposit()
        {
            //Changes the amount of the storage variable and then displays the new amount.
            money += depositMoney;
            lblMoney.Content = money;
            //Returns the new value to the storage variable.
            return money;
        }
        public int Withdraw()
        { 
            //Same as above.
            money = money - withdrawMoney;
            lblMoney.Content = money;
            return money;
        }
    }
}
