namespace Cuebit.Models;

public class Qubit
{
    private readonly Random _random;
    
    public Qubit? EntangledQubit { get; set; }

    public bool ZIsRandom { get; set; } = true;
    public bool XIsRandom { get; set; } = true;
    public bool YIsRandom { get; set; } = true;

    public int Z { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Qubit():this(new Random()){}

    public Qubit(Random rng)
    {
        _random = rng;
    }

    public int MeasureZ()
    {
        XIsRandom = true;
        YIsRandom = true;

        if (ZIsRandom)
        {
            Z=_random.Next(0, 2);
            ZIsRandom = false;
        }

        if (EntangledQubit == null) return Z;
        
        EntangledQubit.ZIsRandom = false;
        EntangledQubit.XIsRandom = true;
        EntangledQubit.YIsRandom = true;
        EntangledQubit.Z = Z == 1 ? 0 : 1;

        return Z;
    }
    
    public int MeasureX()
    {
        ZIsRandom = true;
        YIsRandom = true;

        if (XIsRandom)
        {
            X=_random.Next(0, 2);
            XIsRandom = false;
        }

        if (EntangledQubit == null) return X;
        
        EntangledQubit.ZIsRandom = true;
        EntangledQubit.XIsRandom = false;
        EntangledQubit.YIsRandom = true;
        EntangledQubit.X = X == 1 ? 0 : 1;

        return X;
    }
    
    public int MeasureY()
    {
        ZIsRandom = true;
        XIsRandom = true;

        if (YIsRandom)
        {
            Y=_random.Next(0, 2);
            YIsRandom = false;
        }

        if (EntangledQubit == null) return Y;
        
        EntangledQubit.ZIsRandom = true;
        EntangledQubit.XIsRandom = true;
        EntangledQubit.YIsRandom = false;
        
        EntangledQubit.Y = Y == 1 ? 0 : 1;

        return Y;
    }
}