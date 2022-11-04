namespace Zoo;

public abstract class Zvire
{
    public string Name;
    public float Weight;
    public DateTime Born;

    public Zvire(string name, float weight, DateTime born)
    {
        Name = name;
        Weight = weight;
        Born = born;
    }

    public void Ingest(float foodMass)
    {
        Weight += foodMass;
    }

    public virtual void Poop()
    {
        if (Weight > 1)
            Weight -= 1;
        else
        {
            Console.WriteLine(Name + "shat themselves out of existence");
            Weight = 0;
        }
    }

    public abstract void MakeSomeNoiiise();
}