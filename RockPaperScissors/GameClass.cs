using System;
namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)
        // create new players

        public Clock clock;
        public Radio radio;

        // constructor
        public ClockRadio()
        {


            clock = new Clock();
            radio = new Radio("620 AM");
        }

        // member methods (CAN DO relationship)
        public void MainMenu()
        {
            Console.WriteLine("Please choose 1)rock, 2)paper, 3)scissors, 4)spock or 5)lizard!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    clock.DisplayTimeAndDate();
                    break;
                case "2":
                    clock.SetTimeAndDate();
                    break;
                case "3":
                    radio.DisplayRadioStation();
                    break;
                case "4":
                    radio.SetRadioStation();
                    break;
                case "5":
                    clock.alarm.DisplayAlarmStatus();
                    break;
                case "6":
                    break;
                default:
                    break;
            }
            MainMenu();
        }
    }
}
