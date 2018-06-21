using System;
namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)
        // create new players

        public Human Human;
        public Computer Computer;

        // constructor


        public GameClass()
        {
            Human = new Human();
            Computer = new Computer();
        }

        // member methods (CAN DO relationship)

        public RunGame();
        { 

        }
    }
}
