namespace KataMaitreD;

public record Hostess
{
    public I4State ApplyEvent(I4State etatZero, I4Event eventInitial)
    {
        throw new NotImplementedException();
    }

    public bool IsFullyBooked { get; } = true;
}