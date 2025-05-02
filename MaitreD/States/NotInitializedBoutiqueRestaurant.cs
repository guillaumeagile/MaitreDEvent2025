using Domain.MaitreD.Events;

namespace Domain.MaitreD.States;

public record NotInitializedBoutiqueRestaurant() : I4State
{
    
    public I4State ApplyEvent(I4Event evt)
    {
        return  evt switch
        {
            CapacityAdded capacityAdded =>   Decide(capacityAdded),
            _ =>   this 
        };
      
    }

    private static I4State Decide(CapacityAdded capacityAdded)
    {
        if (capacityAdded.capacity > 0)
            return new OpenedBoutiqueRestaurant(capacityAdded.capacity);
        return new NotInitializedBoutiqueRestaurant();
    }

    public bool CanAcceptGuests { get; private set; } = false;
}