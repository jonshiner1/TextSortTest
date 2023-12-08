//simple test

//Test 

namespace SimpleTest
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string stuff)
        {
            Console.WriteLine(stuff);
        }
    }
    public interface ILogger
        {
            void Log(string stuff);
        }
}
