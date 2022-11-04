Door d = new Door();
d.RightClick();
d.RightClick();
d.RightClick();
d.LeftMouse();
d.RedstonePowered();
d.RedstonePowered();
d.RedstonePowered();

Bed b = new Bed();
b.RightClick();
b.LeftMouse();

CommandBlock cb = new CommandBlock("/give @a minecraft:torch");
cb.RedstonePowered();
cb.LeftMouse();

abstract class Block
{
    public string BreakingSound;
    public int Hardness;

    public Block(string breakingSound, int hardness)
    {
        BreakingSound = breakingSound;
        Hardness = hardness;
    }

    public void LeftMouse()
    {
        for (int i = 0; i < Hardness; i++)
            Console.Write(BreakingSound);
        Console.WriteLine();
    }
}

interface IRightClickAction
{
    public void RightClick();
}

interface IRedstonePoweredAction
{
    public void RedstonePowered();
}

class Door : Block, IRightClickAction, IRedstonePoweredAction
{
    public string OpenSound = "vrz";
    public string CloseSound = "klap";
    public bool IsOpen = false;

    public Door() : base("du", 3)
    {
    }

    public void RightClick()
    {
        if (IsOpen)
        {
            Console.WriteLine(CloseSound);
        }
        else
        {
            Console.WriteLine(OpenSound);
        }

        IsOpen = !IsOpen;
    }

    public void RedstonePowered()
    {
        RightClick();
    }
}

class Bed : Block, IRightClickAction
{
    public Bed() : base("plonk!", 1)
    {
    }

    public void RightClick()
    {
        Console.WriteLine("Zzz...");
    }
}

class CommandBlock : Block, IRedstonePoweredAction
{
    public string Command;

    public CommandBlock(string command) : base(".", 99)
    {
        Command = command;
    }

    public void RedstonePowered()
    {
        Console.WriteLine(Command);
    }
}