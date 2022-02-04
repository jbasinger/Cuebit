namespace Cuebit.Models;

public class TickData
{
    public int A0X { get; set; }
    public int A0Z { get; set; }
    public int A1X { get; set; }
    public int A1Z { get; set; }
    
    public int B0X { get; set; }
    public int B0Z { get; set; }
    public int B1X { get; set; }
    public int B1Z { get; set; }
    
    public int ClockStep;
    public int ClockValue;
}