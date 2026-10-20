using typl.src;

namespace typl.tests;

[TestClass]
public sealed class ExampleTest
{
    public required Example example;

    [TestInitialize]
    public void Setup()
    {
        example = new Example();
        
    }

    [TestMethod]
    [DataRow( 1, 2, 3)]
    [DataRow(-1,-1,-2)]
    [DataRow( 0, 0, 0)]
    public void TestAdd(int a, int b, int r)
    {
        int result = example.Add(a, b);
        Assert.AreEqual(r, result);
    }
}
