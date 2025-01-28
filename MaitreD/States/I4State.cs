namespace Domain.MaitreD.States;

public interface I4State
{
}

public interface I4RestaurantStates<TState>
{
    static abstract TState InitialState { get; }
    
    static abstract TState FinalState { get; }
}
