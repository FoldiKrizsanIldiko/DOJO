// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;
using Sims;

public class Program
{
    //Our job is to check if
    //the house they build is a valid house and count the price of it.
    public static void Main(string[] args)
    {
        List<Room> myHouseRooms = new List<Room>()
        {
            new Bathroom(4,4,new Dictionary<RoomType, int>(){{RoomType.Bathroom, 16}},new List<Furniture>() {new Furniture(RoomType.Bathroom, 100), new Furniture(RoomType.Bathroom,50)}),
            new Bedroom(3,3,new Dictionary<RoomType, int>(){{RoomType.Bedroom, 16}},new List<Furniture>() {new Furniture(RoomType.Bedroom, 100), new Furniture(RoomType.Bedroom,50)}),
            new Kitchen(5,5,new Dictionary<RoomType, int>(){{RoomType.Kitchen, 16}},new List<Furniture>() {new Furniture(RoomType.Kitchen, 100), new Furniture(RoomType.Kitchen,50)}),
        };
        
        House myHouse = new House("MY HOME",myHouseRooms);
        Console.WriteLine(myHouse.IsLivable());
        Console.WriteLine(myHouse.CountPriceOfHouse());
    }

}

