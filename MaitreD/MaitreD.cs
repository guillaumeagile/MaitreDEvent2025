using Domain.MaitreD.States;

namespace Domain.MaitreD;

public sealed class MaitreD : I4RestaurantStates<I4State>
{
    public static readonly NotInitializedBoutiqueRestaurant Initial = new(  );
    
    public static readonly ClosedBoutiqueRestaurant Final = new(  );
}