namespace HelloWorld.Models
{
    public class GreetingService
    {

        public string GetGreeting(int hour)
        {
            if (hour >= 5 && hour < 11)
            {
                return "おはようございます";
            }
            else if (hour >= 11 && hour < 18)
            {
                return "こんにちは";
            }
            else
            {
                return "こんばんは";
            }
        }
    }
}
