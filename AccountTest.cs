using System;
using Xunit;
using LAB3;

namespace TestBankAccount
{
    public class AccountTest
    {  
        


        [Fact]
        public void ShouldReturnFalse_DepositNegativAmount()
        {
            // arrange
            BankAccount bankAccount = new BankAccount();
            double amount = -500.0;

            // act
            bool result = bankAccount.Deposit(amount);

            //assert
            Assert.False(result);

        }

        [Fact]
        
        public void ShouldReturnTrue_DepositPositiveAmount()
        {
            //arrange
            BankAccount bankAccount = new BankAccount();
            double amount = 500.0;
            //act
            bool result = bankAccount.Deposit(amount);
            //assert
            Assert.True(result);
        }

        [Fact]

        public void ShouldReturnFalse_WithdrawPositiveAmount()
        {
            //arrange
            BankAccount bankAccount = new BankAccount();
            double amount = -1000.0;
            //act
            bool result = bankAccount.Withdraw(amount);
            //assert
            Assert.False(result);
        }

        [Fact]

        public void ShouldReturnFalse_WithdrawZeroAmount()
        {
            //arrange
            BankAccount bankAccount = new BankAccount();
            double amount = 0;
            //act
            bool result = bankAccount.Withdraw(amount);
            //assert
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalse_IfNotEnoughMoneyInAccount()
        {
            BankAccount bankAccount = new BankAccount();
            double amount = 500;

            bool result = bankAccount.Withdraw(amount);
            double balance = bankAccount.GetBalance();

            Assert.False(result);
        }












    }

    }

    

