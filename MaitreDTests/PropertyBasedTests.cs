

using CsCheck;
using Domain.MaitreD;
using Domain.MaitreD.Events;
using FluentAssertions;

namespace MaitreDTests;

public class PropertyBasedTests
{
    [Fact]
    public void Single_Unit_Range()
    {
        Gen.Int.Positive.Sample(i =>
        {
            i.Should().BePositive();            
        });
    }
    
    [Fact]
    public void Single_Unit_Range_For_Capacity()
    {
        var hostess = new Hostess();
        var etatZero = MaitreD.Initial;   
        
        Gen.Int.Positive.Sample(i =>
        {
            var eventInitial = new CapacityAdded ( capacity: i);
            // TODO : add verbosity with OutputHelper
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
            hostess.CanAcceptGuests.Should().Be(true);
        });
    }
}