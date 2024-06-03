namespace ConsoleApp1;

internal class AudioEquipmentDecorator(ConferenceRoomComponent component) : ConferenceRoomDecorator(component)
{
    public override string Description => $"{Component.Description}, Аудіо обладнання";

    public override double Cost => Component.Cost + 500.0;
}