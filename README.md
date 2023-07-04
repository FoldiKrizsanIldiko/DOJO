# DOJO
11. Sims

    We are working on a videogame where the users can create houses. Our job is to check if
    the house they build is a valid house and count the price of it.

    House
    ● Has a name given by the creator
    ● Has rooms
    ● New rooms can be added
    ● Can check if the House is livable (A house is livable if it has at least 1 valid bedroom,
        1 valid bathroom and 1 valid kitchen)
    ● Can calculate the price of the House (Price is calculated from all the tiles and
        furniture used to build the house)

    Room
    ● Has length (in number of tiles)
    ● Has width (in number of tiles)
    ● Has all the types of tile used for making it (and how many of each)
    ● Has furniture

    Bedroom
    ● Only valid if:
    Is only made of bedroom tiles
    Has at least 30 tiles
    Has at least 3 bedroom furniture

    Bathroom
    ●   Only valid if:
    Is only made of bathroom tiles
    Has at least 15 tiles
    Has at least 2 bathroom furniture

    Kitchen
    ● Only valid if:
    Is only made of kitchen tiles
    Has at least 20 tiles
    Has at least 4 kitchen furniture

    Furniture
    ● Has a price
    ● Has a type of Room