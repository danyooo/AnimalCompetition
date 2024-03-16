using System;

// Access system.collections.generic to be able to create lists
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {


        // var Player1 = new Player();
        // // Create a list to store player inputs in while selecting a name
        // // Create a 'PlayerName' list to store each character a player inputs during         name selection
        // List<char> PlayerName = new List<char>();
        // // While player name is not selected...
        // Console.WriteLine("Please enter your name");
        // while (Player1.name == "")
        // {

        //     Player1.readInput();
        //     Player1.selectName(PlayerName);
        //     // once player name is selected, break the loop
        //     if (Player1.name != "")
        //     {
        //         break;
        //     }
        // }
        // // once player name is set, cycle array
        // if (Player1.name != "")
        // {
        //         string[] testArray = { "a", "b", "c", "d", "e" };
        //         int arrayReader = testArray.Length - 3;
        //     while (Player1.name != "")
        //     {
        //         // create an array to cycle through
        //         Player1.readInput();
        //         // Add a linebreak 
        //         Console.WriteLine("\n you pressed " + Player1.keyInput);

        //         Player1.cycleChoices(testArray, ref arrayReader);

        //     }
        // }
        // // WEATHER TEST CODE
        // Console.WriteLine("Hello World");
        // var env = new Environment();
        // env.testing();
        // var attri = new Attributes();

        // if (env.rain)
        // {
        //     attri.mobility -= 1;
        //     Console.WriteLine("Mobility reduced to " + attri.mobility);
        // }

        // if (env.NightVision)
        // {

        //     attri.sight += 1;
        //     Console.WriteLine("Vision increased to " + attri.sight);
        // }
        // if (env.Snowing)
        // {

        //     attri.attack += 1;
        //     Console.WriteLine("Attack increased to " + attri.attack);
        // }
        // if (env.Hailing)
        // {

        //     attri.defense -= 1;
        //     Console.WriteLine("Health decreased by 1 ");
        // }
    }
}





abstract class Game
{

    //Function to reset variables after x is done
    // Display  screens(Start screen, Point shop, chimera creator, fight screen, game over screen )

}
class Player
{
    // has a pointpool variable
    protected int pointpool = 15;
    //has a name variable
    public string name = ""; // to be entered by the player. Set to "" so the While Loops can detect whether it is empty or not
                             // Create a keyInput variable to return the pressed key to
    public char keyInput;
    //has a method that reads inputs
    public void readInput()
    {
        //  ConsoleKeyInfo is the only variable that can take an input from the 'Console.ReadKey' method
        ConsoleKeyInfo keyPress = Console.ReadKey();
        // Set the keyInput value to the key that was pressed
        keyInput = keyPress.KeyChar;
    }
    // create a method that would detect inputs to cycle through an array of choices
    // "ref" allows things to modify original variables
    public void cycleChoices(string[] arrayName, ref int arrayReader)
    {
        // If A is pressed...
        //  As long as the arrayreader is greater than
        if (this.keyInput == 'a' && arrayReader > 0)
        {
            Console.WriteLine(" A Was Pressed!");
            arrayReader = arrayReader - 1;
            Console.WriteLine("You went down 1 , now at " + arrayName[arrayReader]);
        }
        else if (this.keyInput == 'd' && arrayReader != arrayName.Length - 1)
        {
            arrayReader = arrayReader + 1;
            Console.WriteLine("You went up 1 , now at " + arrayName[arrayReader]);
        }
    }
    // Method to Select Name
    public void selectName(List<char> listName)
    {

        listName.Add(this.keyInput);
        // If enter is pressed..
        if (this.keyInput == (char)(13))
        {

            //  Convert & Merge each character typed into one string to form a                       name
            this.name = string.Concat(listName);
            Console.WriteLine("You pressed enter! \n" + "Your name is " + this.name);
            //
        }
    }
}

class Attributes
{
    // define general attributes (mobility,defense, etc)
  // Set the attributes to a default value of 5
    protected int defense = 5;
    protected int mobility = 5;
    protected int sight = 5;
    protected int attack = 5;
    protected void Attributetest()
    {
        Console.WriteLine("Defense is " + defense + ", mobility is " + mobility + ", sight is " + sight + ", attack is " + attack);

    }
}
// inherits from the Attributes class
class Modifiers : Attributes
{
    //variable to store pointvalue (neg or pos) for each part
    int pointvalue;
    bool choosable;
    // Method that would check if the player has enough points to choose a modifier
    // check every time a player confirms their modifier selection
    public void checkPoints(int playerpoints)
    {
        // If the playerpoints are greater than 0
        // The modifier is choosable
        // Otherwise, it isn't
        if (playerpoints > 0)
        {
            this.choosable = true;
        }
        else
        {
            this.choosable = false;
        }

    }

    // Keep attributes blank, set them later in the construction of objects  (as  an additive bonus)
  public new int defense = 0;
  public new int attack = 0;
  public new int mobility = 0;
  public new int sight = 0;
  
    // Method that would take or add points from the players point pool
  public void pointPay(int playerpoints){
    // Point value would be a negative if the cost would take player points, and positive if the player would gain points from choosing the object
    playerpoints += this.pointvalue;
  }
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
    public bool rain, NightVision, Snowing, Hailing = false;

    public void testing()
    {
        // Add  randomized "Weather" array, and a "Terrain" array
        Random rdm = new Random();
        string[] Weather = { "Rain", "Sunny", "Night Time", "Winter/snow", "Hailing" };
        string[] Terrain = { "Mountain", "Plains", "Beach" };
        string[] MountainTerrain = { "Ravine", "Mountain peak", "Cliffside", "Volcano", };
        string[] PlainsTerrain = { "Forest", "Cave", "Hills", "Small lake/river", };
        string[] BeachTerrain = { "Rocky beach", "Desert", "Island", };
        int WeatherIndex = rdm.Next(Weather.Length);
        int TerrainIndex = rdm.Next(Terrain.Length);
        int MountainTerrainIndex = rdm.Next(MountainTerrain.Length);
        int PlainsTerrainIndex = rdm.Next(PlainsTerrain.Length);
        int BeachTerrainIndex = rdm.Next(BeachTerrain.Length);
        Console.WriteLine("The weather is {0}", Weather[WeatherIndex]);



        if (Weather[WeatherIndex] == "Rain")
        {
            this.rain = true;


        }
        if (Weather[WeatherIndex] == "Night Time")
        {
            this.NightVision = true;


        }

        if (Weather[WeatherIndex] == "Winter/snow")
        {
            this.Snowing = true;


        }

        if (Weather[WeatherIndex] == "Hailing")
        {
            this.Hailing = true;


        }

        if (Terrain[TerrainIndex] == "Mountain")
        {
            Console.WriteLine("You are in a Mountainous environment");
        }
        if (Terrain[TerrainIndex] == "Plains")
        {
            Console.WriteLine("You are in a Plains environment");
        }
        if (Terrain[TerrainIndex] == "Beach")
        {
            Console.WriteLine("You are in a Beach evironment");
        }
        if (Terrain[TerrainIndex] == "Mountain" && MountainTerrain[MountainTerrainIndex] == "Ravine")
        {
            Console.WriteLine("You are in a Ravine terrain");
        }
        if (Terrain[TerrainIndex] == "Mountain" && MountainTerrain[MountainTerrainIndex] == "Mountain peak")
        {
            Console.WriteLine("You are in a Mountain Peak terrain");
        }
        if (Terrain[TerrainIndex] == "Mountain" && MountainTerrain[MountainTerrainIndex] == "Cliffside")
        {
            Console.WriteLine("You are in a Cliffside terrain");
        }
        if (Terrain[TerrainIndex] == "Mountain" && MountainTerrain[MountainTerrainIndex] == "Volcano")
        {
            Console.WriteLine("You are in a Volcano terrain");


        }
        if (Terrain[TerrainIndex] == "Plains" && PlainsTerrain[PlainsTerrainIndex] == "Forest")
        {
            Console.WriteLine("You are in a Forest terrain");
        }
        if (Terrain[TerrainIndex] == "Plains" && PlainsTerrain[PlainsTerrainIndex] == "Cave")
        {
            Console.WriteLine("You are in a Cave terrain");
        }
        if (Terrain[TerrainIndex] == "Plains" && PlainsTerrain[PlainsTerrainIndex] == "Hills")
        {
            Console.WriteLine("You are in a Hill terrain");
        }
        if (Terrain[TerrainIndex] == "Plains" && PlainsTerrain[PlainsTerrainIndex] == "Small lake/river")
        {
            Console.WriteLine("You are in a lake/river terrain");


        }
        if (Terrain[TerrainIndex] == "Beach" && BeachTerrain[BeachTerrainIndex] == "Rocky Beach")
        {
            Console.WriteLine("You are in a Rocky Beach terrain");
        }
        if (Terrain[TerrainIndex] == "Beach" && BeachTerrain[BeachTerrainIndex] == "Desert")
        {
            Console.WriteLine("You are in a Desert terrain");
        }
        if (Terrain[TerrainIndex] == "Beach" && BeachTerrain[BeachTerrainIndex] == "Island")
        {
            Console.WriteLine("You are in a Island terrain");
        }




    }

}



// Method that, depending on certain modifiers(body parts) would multiply attributes positively or negatively. Check if Modifiers are buffed/debuffed per Body Section(Head,Torso,etc) if the modifiers multiplications apply to terrain/weather





