using System;
using Cuebit.Models;
using NUnit.Framework;
using Shouldly;

namespace Cuebit.UnitTests;

public class Tests
{
    
    [Test]
    public void AliceMeasuringZShouldResetOtherAxes()
    {
        var rng = new Random();
        
        var alice = new Qubit(rng);
        var bob = new Qubit(rng);

        alice.EntangledQubit = bob;
        bob.EntangledQubit = alice;

        var val = alice.MeasureZ();
        alice.ZIsRandom.ShouldBeFalse();
        alice.XIsRandom.ShouldBeTrue();
        alice.YIsRandom.ShouldBeTrue();
        
        bob.ZIsRandom.ShouldBeFalse();
        bob.XIsRandom.ShouldBeTrue();
        bob.YIsRandom.ShouldBeTrue();

        bob.Z.ShouldBe(alice.Z == 1 ? 0 : 1);
    }
    
    [Test]
    public void AliceMeasuringXShouldResetOtherAxes()
    {
        var rng = new Random();
        
        var alice = new Qubit(rng);
        var bob = new Qubit(rng);

        alice.EntangledQubit = bob;
        bob.EntangledQubit = alice;

        var val = alice.MeasureX();
        alice.ZIsRandom.ShouldBeTrue();
        alice.XIsRandom.ShouldBeFalse();
        alice.YIsRandom.ShouldBeTrue();
        
        bob.ZIsRandom.ShouldBeTrue();
        bob.XIsRandom.ShouldBeFalse();
        bob.YIsRandom.ShouldBeTrue();
        
        bob.X.ShouldBe(alice.X == 1 ? 0 : 1);
    }
    
    [Test]
    public void AliceMeasuringYShouldResetOtherAxes()
    {
        var rng = new Random();
        
        var alice = new Qubit(rng);
        var bob = new Qubit(rng);

        alice.EntangledQubit = bob;
        bob.EntangledQubit = alice;

        var val = alice.MeasureY();
        alice.ZIsRandom.ShouldBeTrue();
        alice.XIsRandom.ShouldBeTrue();
        alice.YIsRandom.ShouldBeFalse();
        
        bob.ZIsRandom.ShouldBeTrue();
        bob.XIsRandom.ShouldBeTrue();
        bob.YIsRandom.ShouldBeFalse();
        
        bob.Y.ShouldBe(alice.Y == 1 ? 0 : 1);
    }
}