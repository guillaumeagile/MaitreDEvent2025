using Domain.MaitreD.Events;
using Domain.MaitreD.States;

namespace Domain.MaitreD;

public record Hostess
{
    public I4State ApplyEvent(I4State etatZero, I4Event eventInitial)
    {
        IsFullyBooked = eventInitial switch
        {
            CapacityAdded capacityAdded => capacityAdded.capacity == 0,
            _ => IsFullyBooked
        };

        return etatZero;
    }

    public bool IsFullyBooked { get; private set; } = true;
}