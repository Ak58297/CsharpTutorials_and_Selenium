namespace SeleniumAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Inside setup method");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Inside setup method 1");
            
        }
        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Inside setup method 2");
        }

        [TearDown]
        public void Teardown()
        {
            TestContext.Progress.WriteLine("Inside Teardown");
        }

    }
}