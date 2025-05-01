using Domain.MaitreD.Events;
using Domain.MaitreD.States;

namespace Domain.MaitreD;

public record Hostess
{
    public I4State ApplyEvent(I4State etatZero, I4Event eventInitial)
    {
      _ =  eventInitial switch
        {
            CapacityAdded capacityAdded => CanAcceptGuests = capacityAdded.capacity > 0,
            _ =>  false  // on retourne un bool ici, car void n'est pas un type
        };
        return etatZero;
    }


    public bool CanAcceptGuests { get; private set; } = false;
}