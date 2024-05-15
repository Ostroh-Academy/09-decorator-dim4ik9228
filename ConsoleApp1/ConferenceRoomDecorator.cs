namespace ConsoleApp1;

internal abstract class ConferenceRoomDecorator(ConferenceRoomComponent component) : ConferenceRoomComponent
{
    protected ConferenceRoomComponent Component = component;

    public override string Description => Component.Description;

    public override double Cost => Component.Cost;
}