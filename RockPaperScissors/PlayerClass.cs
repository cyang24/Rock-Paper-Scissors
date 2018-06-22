using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public abstract class PlayerClass
    {
        //Member Variables

        public string playerName;

        //Can Do's

        public void SetPLayerName(string playerName)
        {
            this.playerName = playerName;
        }
        public string GetPlayerName()
        {
            return playerName;
        }
    }
  }  
