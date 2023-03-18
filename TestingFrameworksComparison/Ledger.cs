namespace TestingFrameworksComparison;

public class Ledger
{
    public int Amount { get; private set; }

    public void Increment(int amount) => Amount += amount;

    public async Task<int> CheckCurrentAmmount()
    {
        await Task.Delay(1000);
        return Amount;
    }
}
