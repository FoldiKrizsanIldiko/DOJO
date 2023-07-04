namespace Sims;

public class Room
{
    // ● Has length (in number of tiles)
    //     ● Has width (in number of tiles)
    //     ● Has all the types of tile used for making it (and how many of each)
    //     ● Has furniture
    private int LengthOfHouse;
    private static int WidthOfHouse;
    private Dictionary<RoomType, int> TypesOfTiles;
    public List<Furniture> Furnitures;
    public int NumberOfTiles { get; set; }

    public Room(int length, int width, Dictionary<RoomType, int> typesOfTiles, List<Furniture> furnitures)
    {
        LengthOfHouse = length;
        WidthOfHouse = width;
        TypesOfTiles = typesOfTiles;
        Furnitures = furnitures;
        NumberOfTiles = length * width;
    }

    public bool Validator(RoomType type, int minNoTiles, int minNoFurnitures)
    {
        if (this.TypesOfTiles.ContainsKey(type) && this.TypesOfTiles.Count == 1)
        {
            if (this.NumberOfTiles >= minNoTiles)
            {
                if (this.Furnitures.Count >= minNoFurnitures) 
                    return true;
            }
        }

        return false;
    }
}