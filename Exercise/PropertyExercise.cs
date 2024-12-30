using FluentAssertions;

namespace Exercise;

public class PropertyExercise
{
    [Fact]
    public void Method()
    {
        Assert.Throws<Exception>(() =>
        {
            var service = new BankService();
            var transfer = new Transfer();
            transfer.Currency = "TWD";
            transfer.Amount = -1;

            service.Transfer(transfer);
        });
    }

    private class BankService
    {
        public void Transfer(Transfer transfer)
        {
            // do nothing
        }
    }

    private class Transfer
    {
        public string Currency { get; set; }

        public int Amount { get; set; }
    }
}
