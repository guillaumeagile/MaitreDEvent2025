using Domain.MaitreD.States;

namespace Domain.MaitreD;

public sealed class MaitreD : I4RestaurantStates<I4State>
{
    public static readonly OpenedBoutiqueRestaurant Initial = new(  );
    
    public static readonly ClosedBoutiqueRestaurant Final = new(  );
}