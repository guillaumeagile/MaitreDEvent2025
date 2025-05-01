namespace Domain.MaitreD.Events;

public record CapacityAdded(int capacity) : I4Event;

public record BookingAdded(int size) : I4Event;

public record AddMenu : I4Event;