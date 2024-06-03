using System.Text;

namespace ConsoleApp1;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        
        ConferenceRoomComponent basicRoom = new BasicConferenceRoom();
        Console.WriteLine($"Опис: {basicRoom.Description}, Вартість: {basicRoom.Cost}");

        ConferenceRoomComponent audioRoom = new AudioEquipmentDecorator(basicRoom);
        Console.WriteLine($"Опис: {audioRoom.Description}, Вартість: {audioRoom.Cost}");

        ConferenceRoomComponent multimediaRoom = new VideoEquipmentDecorator(audioRoom);
        Console.WriteLine($"Опис: {multimediaRoom.Description}, Вартість: {multimediaRoom.Cost}");
    }
}