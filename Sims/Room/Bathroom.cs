namespace Sims;

public class Bathroom:Room
{
    // Bathroom
    // ● Only valid if:
    // 1. Is only made of bathroom tiles
    // 2. Has at least 15 tiles
    // 3. Has at least 2 bathroom furniture

    public Bathroom(int length, int width, Dictionary<RoomType, int> typesOfTiles, List<Furniture> furnitures) : base(length, width, typesOfTiles, furnitures)
    {
    }

    public bool Validator()
    {
        return Validator(RoomType.Bathroom, 15, 2);
    }
}