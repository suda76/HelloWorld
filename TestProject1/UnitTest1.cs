using HelloWorld.Models;

namespace HelloWorld.Tests
{
    public class GreetingServiceTests
    {
        [TestCase(5,"おはようございます")]
        [TestCase(11,"こんにちは")]
        [TestCase(18, "こんばんは")]
        [TestCase(4, "こんばんは")]
        public void GetGreeting(int hour,string expected)
        {
            string actual = GreetingService.GetGreeting(hour);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
