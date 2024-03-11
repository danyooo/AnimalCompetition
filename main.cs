using System;
class Program{
public static void Main(string[] args)  {
  // work on player name storage
  Player Player1 = new Player();
  // Console.WriteLine("Please enter your name");
  // while (Player1.name !=""){
  // Player1.readInput();
  // Console.WriteLine("you pressed " + Player1.keyInput);
  //   }
  // create an array to cycle through
string[] testArray = {"a","b","c","d","e"};
int arrayReader = testArray.Length -3;
  // create a bool and while loop to debug with
  bool arrayCycle = true;
while(arrayCycle == true){
  Player1.readInput();
// Add a linebreak 
  Console.WriteLine("\n you pressed " + Player1.keyInput);
 
  Player1.cycleChoices(testArray,ref arrayReader);
    }
}
  
}


abstract class Game{

//Function to reset variables after x is done
// Display  screens(Start screen, Point shop, chimera creator, fight screen, game over screen )
  
}
class Player{
// has a pointpool variable
protected int pointpool = 15;
//has a name variable
  public string name; // to be entered by the player
  // Create a keyInput variable to return the pressed key to
 public char keyInput;
//has a method that reads inputs
  public void readInput(){
    //  ConsoleKeyInfo is the only variable that can take an input from the 'Console.ReadKey' method
 ConsoleKeyInfo keyPress = Console.ReadKey();
    // Set the keyInput value to the key that was pressed
    keyInput = keyPress.KeyChar;
  }
  // create a method that would detect inputs to cycle through an array of choices
  // "ref" allows things to modify  original variables
  public void cycleChoices(string[] arrayName, ref int arrayReader){
    // If A is pressed...
    //  As long as the arrayreader is greater than
  if(this.keyInput == 'a' && arrayReader > 0){
    Console.WriteLine(" A Was Pressed!");
    arrayReader = arrayReader -1;
    Console.WriteLine("You went down 1 , now at " +  arrayName[arrayReader]);
  }
    else if(this.keyInput=='d' && arrayReader!=arrayName.Length  - 1){
    arrayReader = arrayReader + 1;
      Console.WriteLine("You went up 1 , now at " +  arrayName[arrayReader]);
    }
  }
}
abstract class Attributes{
// define general attributes (mobility,defense, etc)


}
// inherits from the Attributes class
class Modifiers : Attributes{
//variable to store pointvalue (neg or pos) for each part
int pointvalue;
  // Method that would check if the player has enough points to choose a modifier
  // check every time a player confirms their modifier selection
  public void checkPoints(){}
  
// Keep attributes blank, set them later in the construction of objects
  // Method that would take or add points from the players point pool
// Attributes would add to the Chimera Object's attributes

  // If applicable, method that would do as above states
  // When creating an object, ensure it doesn't already exist in the body section somehow. Either make this a parent class and have its descendants have an array pool of the options or find an alternative
}
// Have the Chimera Class inherit from the attributes class
class Chimera:Attributes {
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

class Environment{ 
// Add "Weather" array, and a "Terrain" array

  // Method that, depending on certain modifiers(body parts) would multiply attributes positively or negatively. Check if Modifiers are buffed/debuffed per Body Section(Head,Torso,etc) if the modifiers multiplications apply to terrain/weather
}


