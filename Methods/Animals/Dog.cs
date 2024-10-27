namespace Methods.Animals;

public class Dog : Animal
{
    public int A {  get; set; }

    public int B { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine("Haf");
    }
}
