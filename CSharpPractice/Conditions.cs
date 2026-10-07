public class Conditions
{
    public static void Run()
    {
        int a = 1;
        int b = 6;

        if (a + b > 10)
        {
            Console.WriteLine($"{a + b} is greater than 10");
        }
        else
        {
            Console.WriteLine($"{a + b} is less than 10");
        }


    }
}