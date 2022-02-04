namespace Cuebit.Models;

public class Clock
{
    private int _value = 1;
    private int _step = 0;
    
    public int Value
    {
        get { return _value; }
    }
        
    public int Step
    {
        get { return _step; }
    }

    public void Tick()
    {
        _value = _value == 1 ? 0 : 1;
        _step++;
    }
}