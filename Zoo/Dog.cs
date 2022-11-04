namespace Zoo;

public class Dog: Zvire
{
    public bool HasObojek;
    
    public Dog(string name, float weight, DateTime born, bool hasObojek) : base(name, weight, born)
    {
        HasObojek = hasObojek;
    }

    public override void MakeSomeNoiiise()
    {
        Console.WriteLine("wůf");
    }
}