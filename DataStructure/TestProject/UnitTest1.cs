namespace TestProject;
[TestFixture]
public class Tests
{
     Maths Operation=null;
    [SetUp]
    public void Setup()
    {
       Operation=new Maths();
    }

    [Test]
    public void Test1()
    {
        int result=Operation.Addition(10,20);
        Assert.That(result,Is.EqualTo(30));
    }
    [TestCase(10,20,30)]//Multiple test cases input1,input2,output
    [TestCase(1,2,3)]
    public void IsAdditionOk(int value1,int value2,int result)
    {
        int output=Operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase(1.2,2.2,3.4)]
    [TestCase(10.5,20.5,31.0)]
    public void IsAdditionOk(double value1,double value2,double result)
    {
        double output=Operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }

    [TestCase("Ravi","Chandran","RaviChandran")]
    [TestCase("Baskaran","Sethurajan","Baskaran Sethurajan")]
    public void IsAdditionOk(string value1,string value2,string result)
    {
        string output=Operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    
}