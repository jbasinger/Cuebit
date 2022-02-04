using Cuebit.Models;
using NUnit.Framework;
using Shouldly;

namespace Cuebit.UnitTests;

public class ClockTests
{
    [Test]
    public void ClockShouldToggleValue()
    {
        var clk = new Clock();
        clk.Value.ShouldBe(1);
        clk.Tick();
        clk.Value.ShouldBe(0);
    }

    [Test]
    public void ClockShouldIncrementSteps()
    {
        var clk = new Clock();
        clk.Step.ShouldBe(0);
        clk.Tick();
        clk.Step.ShouldBe(1);
    }
}