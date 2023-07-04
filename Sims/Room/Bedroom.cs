namespace Sims;

public class Bedroom:Room
{
    // ● Only valid if:
    // 1. Is only made of bedroom tiles
    // 2. Has at least 30 tiles
    // 3. Has at least 3 bedroom furniture


    public Bedroom(int length, int width, Dictionary<RoomType, int> typesOfTiles, List<Furniture> furnitures) : base(length, width, typesOfTiles, furnitures)
    {
    }

    public bool Validator()
    {
        return Validator(RoomType.Bedroom, 30, 3);
    }
    
}