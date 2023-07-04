namespace Sims;

public class Furniture
{
    // Furniture
    // ● Has a price
    // ● Has a type of Room
    private static RoomType Tipe;
   public  int Price;

    public Furniture(RoomType tipe, int price)
    {
        Tipe = tipe;
        Price = price;
    }
}