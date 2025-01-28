using Domain.MaitreD.States;

namespace Domain.MaitreD;

public sealed class MaitreD : I4RestaurantStates<I4State>
{
    public static I4State InitialState => new OpenedBoutiqueRestaurant(4);
    public static I4State FinalState  => new ClosedBoutiqueRestaurant(0);

    public static readonly OpenedBoutiqueRestaurant Initial = new( 0 );
}