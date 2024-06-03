namespace ConsoleApp1;

internal class VideoEquipmentDecorator(ConferenceRoomComponent component) : ConferenceRoomDecorator(component)
{
    public override string Description => $"{Component.Description}, Відео обладнання";

    public override double Cost => Component.Cost + 1000.0;
}