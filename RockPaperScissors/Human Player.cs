using System;
namespace RockPaperScissors
{
    public class Human_Player
    {

        //member variables

        string playerName;
        string playerRace;
        string playerPlanet;


        //Constructor 

        public Human_Player()
        {
            playerName = "playerName";
            playerRace = "human";
            playerPlanet = "Earth";
        }

        //member methods

        public void SetPLayerName(string playerName) 
        {
            this.playerName = playerName;
        }

        public void SetPlayerRace(string playerRace)
        {
            this.playerRace = playerRace;
        }

        public void SetPlayerPlanet(string playerPlanet)
        {
            this.playerPlanet = playerPlanet;
        }
    }
}


