using TestingFrameworksComparison;

namespace NUnitTests;

[TestFixture]
public class LedgerTests
{
    private Ledger _sut;

    [SetUp]
    public void TestInitialize()
    {
        _sut = new Ledger();
    }

    [Test]
    public void Increment_ShouldIncrementTheRequestedAmount()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.AreEqual(amount, _sut.Amount);
    }

    [Test]
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
        Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void Increment_ShouldIncrementTheRequestedAmount2()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.AreEqual(amount, _sut.Amount);
    }

    [Test]
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
        Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void Increment_ShouldIncrementTheRequestedAmount3()
    {
        // Arrange
        const int amount = 3;

        // Act
        _sut.Increment(amount);

        // Assert
        Assert.AreEqual(amount, _sut.Amount);
    }

    [Test]
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
        Assert.AreEqual(expectedResult, result);
    }
}