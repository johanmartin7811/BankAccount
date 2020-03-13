using LAB3;
using Xunit;



namespace TestBankAccount
 
{
    public class BankAccount
    {
       
        
            private double balance = 0;
            public double GetBalance() { return this.balance; }    // do not test!
            public bool Deposit(double amount) { return false; }   // test this
            public bool Withdraw(double amount) { return false; }  // test this
        }


    }
