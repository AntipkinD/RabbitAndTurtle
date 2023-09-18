using RabbitandTurtle;

internal class Program
{
    private static void Main(string[] args)
    {
        AnimalThread Trtl = new AnimalThread("черепаха", ThreadPriority.Normal);
        AnimalThread Rbbt = new AnimalThread("кролик", ThreadPriority.Lowest);
        
        RabbitAndTurtle turt = new RabbitAndTurtle(Trtl.name, Rbbt.name, Trtl.priority, Rbbt.priority);
        /*RabbitAdTurtle tut = new RabbitAdTurtle(Trtl.name, Trtl.priority);
        RabbitndTurtle tt = new RabbitndTurtle(Rbbt.name, Rbbt.priority);*/
    }
}