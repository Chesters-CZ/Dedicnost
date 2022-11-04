namespace Zoo;

public class Kachna : Zvire
{
    public Kachna(string name, float weight, DateTime born) : base(name, weight, born)
    {
    }

    public bool CanFly()
    {
        return Weight < 1.6;
    }

    public override void MakeSomeNoiiise()
    {
        Console.WriteLine("nevim jakej zvuk dělá kachna");
    }
}