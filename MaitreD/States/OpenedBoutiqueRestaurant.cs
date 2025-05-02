using Domain.MaitreD.Events;

namespace Domain.MaitreD.States;

public record OpenedBoutiqueRestaurant(int Capacity)  : I4State
{
    public bool CanAcceptGuests = true;
    public I4State ApplyEvent(I4Event evt)
    {
        throw new NotImplementedException();
    }
}