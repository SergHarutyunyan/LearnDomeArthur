namespace Methods.Cars;

public class BMW : Car
{
    public int Speed { get; set; }

    public override void MakeMove()
    {
        Console.WriteLine("BMW");
        Console.WriteLine($"Speed is {Speed}");
    }
}
