using Domain.MaitreD;
using Domain.MaitreD.Events;
using Domain.MaitreD.States;
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
            var etatZero = MaitreD.Initial;   
            
           var newState = etatZero.ApplyEvent( eventInitial);
         
            newState.Should().BeAssignableTo<OpenedBoutiqueRestaurant>()
                .Subject.CanAcceptGuests.Should().BeTrue();
            (newState as OpenedBoutiqueRestaurant).Capacity .Should().Be(4);
          
        }
        
        
        [Fact]
        public void EventAddMenuShouldNotChangeCapacity()
        {
            var eventInitial = new AddMenu ( );
           
            var etatZero = MaitreD.Initial;   
            
            var newState = etatZero.ApplyEvent( eventInitial);
         
            newState.Should().BeAssignableTo<NotInitializedBoutiqueRestaurant>()
                .Subject.CanAcceptGuests.Should().BeFalse();
        }
        
        //  essayer du PBT avec https://github.com/AnthonyLloyd/CsCheck
        
        
        [Fact]
        public void AddedCapaCityToZeroShouldNotAcceptGuest()
        {
            var eventInitial = new CapacityAdded ( capacity: 0);
            var etatZero = MaitreD.Initial;   
            
            var newState = etatZero.ApplyEvent(  eventInitial);
         
            newState.Should().BeAssignableTo<NotInitializedBoutiqueRestaurant>()
                .Subject.CanAcceptGuests.Should().BeFalse();
        }
        
        
        [Fact]
        public void AddedBookingMaxCapacityShouldNotAcceptGuest()
        {
            var eventInitial = new CapacityAdded ( capacity: 4);
            var etatZero = MaitreD.Initial;   
            
            var newState = etatZero.ApplyEvent( eventInitial);
            var eventBooking = new BookingAdded ( size: 4);
             newState = newState.ApplyEvent( eventBooking);
         
             newState.Should().BeAssignableTo<OpenedBoutiqueRestaurant>()
                 .Subject.CanAcceptGuests.Should().BeFalse();
        }
    }
}
