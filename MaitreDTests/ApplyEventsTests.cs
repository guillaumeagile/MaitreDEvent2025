using Domain.MaitreD;
using Domain.MaitreD.Events;
using FluentAssertions;
using LanguageExt;

namespace MaitreDTests
{
    public class ApplyEventsTests
    {
        [Fact]
        public void Test0()
        {
            var eventInitial = new CapacityAdded ( capacity: 0);
            
            var hostess = new Hostess();
            
            hostess.IsFullyBooked.Should().Be(true);
        }
        
        
        [Fact]
        public void Test1()
        {
            var eventInitial = new CapacityAdded ( capacity: 4);
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
           var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.IsFullyBooked.Should().Be(false);
        }
        
        
        [Fact]
        public void EventAddMenuShouldNotChangeCapacity()
        {
            var eventInitial = new AddMenu ( );
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.IsFullyBooked.Should().Be(true);
        }
        
        //  essayer du PBT avec https://github.com/AnthonyLloyd/CsCheck
        
        
        [Fact]
        public void Test2()
        {
            var eventInitial = new CapacityAdded ( capacity: 0);
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.IsFullyBooked.Should().Be(true);
        }
    }

    public record AddMenu : I4Event;
}
