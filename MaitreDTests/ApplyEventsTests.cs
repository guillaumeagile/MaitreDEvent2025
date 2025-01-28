using FluentAssertions;
using LanguageExt;
using KataMaitreD;

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
        public void Test2()
        {
            var eventInitial = new CapacityAdded ( capacity: 0);
            
            var hostess = new Hostess();

            var etatZero = MaitreD.Initial;   
            
            var newState = hostess.ApplyEvent( etatZero,  eventInitial);
         
            hostess.IsFullyBooked.Should().Be(true);
        }
    }
}
