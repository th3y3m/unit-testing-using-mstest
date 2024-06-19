namespace PrimeService.Tests;

[TestClass]
public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(1)]
    public void IsPrime_InputIsNotPrime_ReturnFalse(int value)
    {
        bool result = _primeService.IsPrime(value);

        Assert.IsFalse(result, $"{value} should not be prime");
    }

    [TestMethod]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(5)]
    [DataRow(7)]
    public void IsPrime_InputIsPrime_ReturnTrue(int value)
    {
        bool result = _primeService.IsPrime(value);

        Assert.IsTrue(result, $"{value} should be prime");
    }

    [TestMethod]
    [DataRow(4)]
    [DataRow(6)]
    [DataRow(8)]
    [DataRow(9)]
    public void IsPrime_InputIsNotPrime_ReturnFalseAgain(int value)
    {
        bool result = _primeService.IsPrime(value);

        Assert.IsFalse(result, $"{value} should not be prime");
    }

    [TestMethod]
    public void IsPrime_InputIs11_ReturnTrue()
    {
        var value = 11;
        var expected = true;

        var result = _primeService.IsPrime(value);

        Assert.AreEqual(expected, result, $"{value} should be prime");
    }

}