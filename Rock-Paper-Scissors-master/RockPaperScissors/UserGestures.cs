﻿using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class UserGestures
    {   
        public string userInput;

   
        public virtual void MainMenu()
        {   
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }
    }
}
