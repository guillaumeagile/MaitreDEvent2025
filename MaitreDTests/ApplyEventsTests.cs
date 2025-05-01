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
            
            hostess.CanAcceptGuests.Should().Be(false);
        }
        
        
        [Fact]
        public void AddedCapaCityToFourShouldAcceptGuest()
        {
            var eventInitial = new CapacityAdded ( capacity: 4);
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
           var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.CanAcceptGuests.Should().Be(true);
        }
        
        
        [Fact]
        public void EventAddMenuShouldNotChangeCapacity()
        {
            var eventInitial = new AddMenu ( );
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.CanAcceptGuests.Should().Be(false);
        }
        
        //  essayer du PBT avec https://github.com/AnthonyLloyd/CsCheck
        
        
        [Fact]
        public void AddedCapaCityToZeroShouldNotAcceptGuest()
        {
            var eventInitial = new CapacityAdded ( capacity: 0);
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.CanAcceptGuests.Should().Be(false);
        }
        
        
        [Fact]
        public void AddedBookingMaxCapacityShouldNotAcceptGuest()
        {
            var eventInitial = new CapacityAdded ( capacity: 4);
            var hostess = new Hostess();
            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
            var eventBooking = new BookingAdded ( size: 4);
             newState = hostess.ApplyEvent( etatZero,  eventBooking);
         
            hostess.CanAcceptGuests.Should().Be(false);
        }
    }

    public record BookingAdded(int size) : I4Event;

    public record AddMenu : I4Event;
}
