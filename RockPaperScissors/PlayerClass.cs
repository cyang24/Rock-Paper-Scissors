using System;
namespace RockPaperScissors
{
    public class PlayerClass
    {

        public Human Player1;
        public Human Player2;


        string playerName;




        //Constructors

        public PlayerClass()
        {
            Player1 = new Human();
        }  

        //Member Functions (Can Do)

        public void SetPLayerName(string playerName)
        {
            this.playerName = playerName;
        }

        public void ThrowGestureHuman(MainMenu()){
            Console.WriteLine("You threw " + MainMenu());
        }

        public void ThrowGestureComputer(MainMenu())
        {
        Console.WriteLine("Computer throws " + MainMenu());
        }
    }
}
