namespace Zoo;

public class Koczka : Zvire
{
    public int Lives = 9;

    public Koczka(string name, float weight, DateTime born) : base(name, weight, born)
    {
    }

    public bool IsAlive()
    {
        return Lives > 0;
    }

    public void FallAndFuckingDie()
    {
        Lives--;
    }

    public override void Poop()
    {
        if (Weight > 1)
            Weight -= 1;
        else
        {
            Lives--;
        }

        if (!IsAlive())
        {
            Console.WriteLine(Name + "shat themselves out of existence");
            Weight = 0;
        }
    }

    public override void MakeSomeNoiiise()
    {
        Console.WriteLine("ňa");
    }
}