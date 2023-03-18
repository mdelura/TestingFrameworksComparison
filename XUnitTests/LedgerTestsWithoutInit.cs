using TestingFrameworksComparison;

namespace XUnitTests;

public class LedgerTestsWithoutInit
{
    private Ledger _sut = new Ledger();

    [Fact]
    public void Increment_ShouldIncrementTheRequestedAmount()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.Equal(amount, _sut.Amount);
    }

    [Fact]
    public async Task CheckCurrentAmount_ShouldReturnCurrentAmount()
    {
        // Arrange
        const int amount = 3;
        const int incrementCount = 1000;

        for (int i = 0; i < incrementCount; i++)
        {
            _sut.Increment(amount);
        }

        var expectedResult = amount * incrementCount;

        // Act
        var result = await _sut.CheckCurrentAmmount();



        // Assert
        Assert.Equal(expectedResult, result);
    }


    [Fact]
    public void Increment_ShouldIncrementTheRequestedAmount2()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.Equal(amount, _sut.Amount);
    }

    [Fact]
    public async Task CheckCurrentAmount_ShouldReturnCurrentAmount2()
    {
        // Arrange
        const int amount = 3;
        const int incrementCount = 1000;

        for (int i = 0; i < incrementCount; i++)
        {
            _sut.Increment(amount);
        }

        var expectedResult = amount * incrementCount;

        // Act
        var result = await _sut.CheckCurrentAmmount();



        // Assert
        Assert.Equal(expectedResult, result);
    }


    [Fact]
    public void Increment_ShouldIncrementTheRequestedAmount3()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.Equal(amount, _sut.Amount);
    }

    [Fact]
    public async Task CheckCurrentAmount_ShouldReturnCurrentAmount3()
    {
        // Arrange
        const int amount = 3;
        const int incrementCount = 1000;

        for (int i = 0; i < incrementCount; i++)
        {
            _sut.Increment(amount);
        }

        var expectedResult = amount * incrementCount;

        // Act
        var result = await _sut.CheckCurrentAmmount();



        // Assert
        Assert.Equal(expectedResult, result);
    }
}