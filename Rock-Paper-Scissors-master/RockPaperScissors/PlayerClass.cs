using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public abstract class PlayerClass
    {
        //Member Variables

        public string playerName;
        public double playerScore;
        public string gestureInput;
        UserGestures human;
        //Can Do's

        public void SetPlayerName(string playerName)
        {
            this.playerName = playerName;
        }
        public string GetPlayerName()
        {
            return playerName;
        }

        public void SetPlayerScore(double playerScore)
        {
            this.playerScore = playerScore;
        }

        public double GetPlayerScore()
        {
            return playerScore;
        }

        public void GetGestureInput(string gestureInput)
        {
            this.gestureInput = gestureInput;
        }
        public string GetGestureInput()
        {
            return gestureInput;
        }
    }
  }  
