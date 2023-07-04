namespace Sims;

public class House
{
    //House
    // ● Has a name given by the creator
    // ● Has rooms
    // ● New rooms can be added
    // ● Can check if the House is livable (A house is livable if it has at least 1 valid bedroom,
    //     1 valid bathroom and 1 valid kitchen)
    // ● Can calculate the price of the House (Price is calculated from all the tiles and
    //     furniture used to build the house)

    private static string Name { set; get; }
    public List<Room> Rooms { set; get; }

    public House(string name, List<Room> rooms)
    {
        Name = name;
        Rooms = rooms;
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public bool IsLivable()
    {
        return (Rooms.OfType<Kitchen>().Any(kitchen => kitchen.Validator()) &&
                Rooms.OfType<Bathroom>().Any(bathroom => bathroom.Validator()) &&
                Rooms.OfType<Bedroom>().Any(bedroom => bedroom.Validator()));
    }

    public int CountPriceOfHouse()
    {
        int price = 0;
        foreach (var room in Rooms)
        {
            price += (room.NumberOfTiles * 20);
            foreach (var furniture in room.Furnitures)
            {
                price += furniture.Price;
            }
        }

        return price;
    }
}