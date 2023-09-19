internal class Program
{
    static void MyThreadTurtle()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Черепаха прошла: " + i);
        }
    }
    private static void Main(string[] args)
    {
        Thread turtle = new(MyThreadTurtle);
        turtle.Start();

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Кролик прошел: " + i);
        }
    }
}