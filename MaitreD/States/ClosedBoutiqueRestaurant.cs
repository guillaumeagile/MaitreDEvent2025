using Domain.MaitreD.Events;

namespace Domain.MaitreD.States;

public record ClosedBoutiqueRestaurant( )  : I4State
{
    public I4State ApplyEvent(I4Event evt)
    {
        throw new NotImplementedException();
    }
}