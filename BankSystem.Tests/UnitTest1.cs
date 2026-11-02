
using BankSystem;

namespace BankSystem.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_ShouldSetInitialBalance()
        {
            bankAccount account = new bankAccount(100m, 1);

            Assert.Equal(100m, account.Balance);
        }

        [Fact]
        public void WithdrawMoney_ShouldDecreaseBalance()
        {
            bankAccount account = new bankAccount(100m, 4);

            Assert.True(account.withdrawMoney(40m));
            Assert.Equal(60m, account.Balance);
        }

        [Fact]
        public void Constructor_ShouldRejectNegativeInitialBalance()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new bankAccount(-100m, 1)
            );
        }

        [Theory]
        [InlineData(100, 50, 150)]
        [InlineData(200, 30, 230)]
        [InlineData(500, 100, 600)]
        public void DepositMoney_ShouldIncreaseBalance(
            decimal initialBalance,
            decimal amount,
            decimal expectedBalance)
        {
            bankAccount account = new bankAccount(initialBalance, 1);

            Assert.True(account.depositMoney(amount));
            Assert.Equal(expectedBalance, account.Balance);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-50)]
        [InlineData(150)]
        public void WithdrawMoney_ShouldRejectInvalidAmount(decimal amount)
        {
            bankAccount account = new bankAccount(100m, 1);

            Assert.False(account.withdrawMoney(amount));
            Assert.Equal(100m, account.Balance);
        }

        [Fact]
        public void SubstractTransferMoney_ShouldDecreaseBalance()
        {
            bankAccount account = new bankAccount(500m, 1);

            Assert.True(account.SubstractTransferMoney(200m));
            Assert.Equal(300m, account.Balance);
        }

        [Fact]
        public void AddTransferMoney_ShouldAddBalance()
        {
            bankAccount account = new bankAccount(100m, 1);

            Assert.True(account.AddTransferMoney(200m));
            Assert.Equal(300m, account.Balance);
        }

        [Fact]
        public void AddTransferMoney_ShouldRejectZeroAmount()
        {
            bankAccount account = new bankAccount(100m, 1);

            Assert.False(account.AddTransferMoney(0m));
            Assert.Equal(100m, account.Balance);
        }
    }
}
