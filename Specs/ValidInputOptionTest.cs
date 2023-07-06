namespace Specs;


public class ValidInputOptionTest
{
    [Test]
    public void InvalidValues()
    {
        var values = new[] { " ", "adasdf", "b12", "10.5" };
        foreach (var value in values)
        {
            ValidInputOption inputOption = new(value);
            Assert.Multiple(() =>
            {
                Assert.That(inputOption.Valid, Is.False);
                Assert.That(inputOption.Value, Is.EqualTo(0));
                Assert.That(inputOption.Quit, Is.False);
            });
        }
    }

    [Test]
    public void QuitValue()
    {
        var values = new[] { "X", "x" };
        foreach (var value in values)
        {
            ValidInputOption inputOption = new(value);
            Assert.Multiple(() =>
            {
                Assert.That(inputOption.Quit, Is.True);
                Assert.That(inputOption.Valid, Is.False);
                Assert.That(inputOption.Value, Is.EqualTo(0));
            });
        }
    }

    [Test]
    public void ValidValues()
    {
        var values = new[] { "2", "10", "2147483647" };
        foreach (var value in values)
        {
            ValidInputOption inputOption = new(value);
            Assert.Multiple(() =>
            {
                Assert.That(inputOption.Quit, Is.False);
                Assert.That(inputOption.Valid, Is.True);
                Assert.That(inputOption.Value, Is.EqualTo(int.Parse(value)));
            });
        }
    }


    [Test]
    public void NumberIsNotInt32()
    {
        var values = new[] { "2147483648", "-2147483649" };
        foreach (var value in values)
        {
            ValidInputOption inputOption = new(value);
            Assert.That(inputOption.Valid, Is.False);
        }
    }
}