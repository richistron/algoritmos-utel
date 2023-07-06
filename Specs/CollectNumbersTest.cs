namespace Specs;

public class CollectNumbersTest
{
    private readonly StringWriter _output = new StringWriter(new StringBuilder());
    private readonly Mock<TextReader> _input = new Mock<TextReader>();

    [SetUp]
    public void SetUp()
    {
        Console.SetOut(_output);
        Console.SetIn(_input.Object);
    }

    private void CaptureInputs(params string[] inputs)
    {
        var sequence = new MockSequence();
        foreach (var input in inputs)
            _input.InSequence(sequence)
                .Setup(x => x.ReadLine())
                .Returns(input);
    }

    private string[] GetOutputs() =>
        _output.ToString().Split("\r\n");

    [Test]
    public void ReturnsArrayOfNumbers()
    {
        var inputs = new[] { "10", "20", "x" };
        CaptureInputs(inputs);
        var numbers = CollectNumbers.Collect();
        Assert.That(numbers.ToArray(), Is.EquivalentTo(new[] { 10, 20 }));
    }

    [Test]
    public void IgnoresInvalidValues()
    {
        var inputs = new[] { "1.2", "2", "x" };
        CaptureInputs(inputs);
        var numbers = CollectNumbers.Collect();
        var output = GetOutputs();
        Assert.Multiple(() =>
        {
            StringAssert.Contains("Invalid", output[1]);
            Assert.That(numbers.ToArray(), Is.EquivalentTo(new[] { 2 }));
        });
    }


    [Test]
    public void DoesQuitWithEmptyNumbers()
    {
        var inputs = new[] { "x", "2", "x" };
        CaptureInputs(inputs);
        var numbers = CollectNumbers.Collect();
        Assert.That(numbers.ToArray(), Is.EquivalentTo(new[] { 2 }));
    }
}