using FluentAssertions;

namespace FluentAssertionsTestProject;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethod()
    {
        var expected = new ClassToTest() { MyObject = new MyClass() };

        var actual = new ClassToTest() { MyObject = new MyClass() };

        actual.Should().BeEquivalentTo(expected);
    }
}
