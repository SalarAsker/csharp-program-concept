/// A house structure. It is important to have this one to control the
/// boundries as well as creating a relationship between the
/// rooms and the house.
string[,] house = {
                    {"","f","","","",""},
                    {"","","","f","",""},
                    { "","","","","",""},
                    {"","f","","","",""},
                    {"","","f","","","",}
                };

/// You can also create the same structure using the following code. All the other places in the
/// array are automatically assigned en empty-string
/// 
/// string[,] hus = new string[5,6];
/// hus[0, 1] = "mat";
/// hus[1, 3] = "mat";
/// hus[3, 1] = "mat";
/// hus[4, 2] = "mat";
/// 

Console.Write($"Rum1-x: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write($"Rum1-y: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write($"Rum2-x: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write($"Rum2-y: ");
int y2 = int.Parse(Console.ReadLine());

// House boundries
/* if x is row, then 0 <= x <= 4  */
/* if y is column then 0 <= y <= 5 */

// Check if the cat is not directed outside of the house.

if(x1 >= 0 && x1 < house.GetLength(0) &&
    x2 >= 0 && x2 < house.GetLength(0) &&
      y1 >= 0 && y1 < house.GetLength(1) &&
       y2 >= 0 && y2 < house.GetLength(1) )
{
    // Process the room's coordinates.
    if (house[x1, y1] == "f" && house[x2, y2] == "f")
    {
        Console.WriteLine($"Cat lives!");
    }
    else
    {
        Console.WriteLine($"Cat dies!");
    }
}
else
{
    // Cat dies if directed outside of the house.
    Console.WriteLine($"Cat dies!");
}