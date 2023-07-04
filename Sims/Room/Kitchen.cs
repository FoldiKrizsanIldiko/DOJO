using System.Security.Cryptography.X509Certificates;

namespace Sims;

public class Kitchen:Room
{
    // Kitchen
    // ● Only valid if:
    // 1. Is only made of kitchen tiles
    // 2. Has at least 20 tiles
    // 3. Has at least 4 kitchen furniture
    public Kitchen(int numberOfTiles, int width, Dictionary<RoomType, int> typesOfTiles, List<Furniture> furnitures) : base(numberOfTiles, width, typesOfTiles, furnitures)
    {
    }

    public bool Validator()
    {
       return Validator(RoomType.Kitchen, 20, 4);
    }
}