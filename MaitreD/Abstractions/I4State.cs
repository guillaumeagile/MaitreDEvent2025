using Domain.MaitreD.Events;

namespace Domain.MaitreD.States;

public interface I4State
{
    I4State ApplyEvent(I4Event evt);
}

public interface I4RestaurantStates<TState>
{
}
