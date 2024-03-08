using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        var env = new Environment();
        env.testing();
        var attri = new Attributes();
        
        if (env.rain)
        {
            attri.mobility -= 1;
            Console.WriteLine("Mobility reduced to " + attri.mobility);
        }
    }
}

abstract class Game
{

    //Function to reset variables after x is done
    // Display  screens(Start screen, Point shop, chimera creator, fight screen, game over screen )

}
class Player
{
    // has a pointpool variablre
    //has a name variable


    //has a method that reads inputs

}
class Attributes
{
    // define general attributes (mobility,defense, etc)
    public int defense = 5;
    public int mobility = 5;
    public int sight = 5;
    public int attack = 5;
    public void Attributetest()
    {

        Console.WriteLine("Defense is " + defense + ", mobility is " + mobility + ", sight is " + sight + ", attack is " + attack);

    }
}
// inherits from the Attributes class
class Modifiers : Attributes
{
    //variable to store pointvalue (neg or pos) for each part
    // Method that would take or add points from the players point pool
    // Method that would check if the player has enough points to choose a modifier
    // Keep attributes blank, set them later in the construction of objects
    // Attributes would add to the Chimera Object's attributes

    // If applicable, method that would do as above states
    // When creating an object, ensure it doesn't already exist in the body section somehow. Either make this a parent class and have its descendants have an array pool of the options or find an alternative
}
// Have the Chimera Class inherit from the attributes class
class Chimera : Attributes
{
    // set the attributes to base value
    // Have a "health"  value  as something as low as "5" health wouldn't work so well.
    // Currently that value is 5 for each attribute
    // Once the Modifier's additions are added to the Chimeras base values...


    // Create a method that would...
    //  convert Mobility to a dodge chance, - Sight as a hitchance / x
    //  convert defense to flat health bonus 
    // If 5 is default "health" attribute, maybe make it equal to 100. Determine a way to add not too much health at a time (i.e if 5x 20 = 100 health, what about 7  x 20. Too big of a difference.)
    // Convert Attack to a damage output out of 40 max, and also convert Attack into an AttackRate
    // Convert 'sight' attribute into a hitchance out of 100%

}

//  Need  some sort of "gamehandler" class that would take dodgechances,hitchances, etc and convert it into something readable/ visual(?). This would create strings that would be easy to follow, maybe add some variations in the way a single action is shown (i.e x Dodged y's swipe! -> x Sidestepped y's Swipe, etc)

class Environment
{
  public bool rain = false;
    public void testing()
    {
        // Add  randomized "Weather" array, and a "Terrain" array
  Random rdm = new Random();
      string[] Weather = { "Rain", "Sunny", "Night Time", "Winter/snow", "Hailing" };
      string[] Terrain = { "Mountain", "Plains", "Beach" };
      int WeatherIndex = rdm.Next(Weather.Length);
      int TerrainIndex = rdm.Next(Terrain.Length);
      Console.WriteLine("The weather is {0}", Weather[WeatherIndex]);
      
      

      if(Weather[WeatherIndex] == "Rain")
    {
      this.rain = true;
      
      
      }
  
      Console.WriteLine("The Terrain is {0}", Terrain[TerrainIndex]);
    if(Terrain[TerrainIndex] == "Mountain"){
      Console.WriteLine("You are in a Mountainous terrain");

  

      
    }
      string[] MountainTerrain = { "Ravine", "Mountain peak", "Cliffside", "Volcano", };
      string[] PlainsTerrain = { "Forest", "Cave", "Hills", "Small lake/river", };
      string[] BeachTerrain = { "Rocky beach", "Desert", "Island", };
    }
    
    

    // Method that, depending on certain modifiers(body parts) would multiply attributes positively or negatively. Check if Modifiers are buffed/debuffed per Body Section(Head,Torso,etc) if the modifiers multiplications apply to terrain/weather

}