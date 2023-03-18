namespace TestingFrameworksComparison;

public class Ledger
{
    private int _amount;

    public void Increment(int amount) => _amount += amount;

    public async Task<int> CheckCurrentAmmount()
    {
        await Task.Delay(1000);
        return _amount;
    }
}
