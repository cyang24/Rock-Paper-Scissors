using System;
namespace RockPaperScissors
{
    public class CPU_Player
    {
        //member variables

        string cpuName;
        string cpuRace;
        string cpuPlanet;


        //Constructor 

        public CPU_Player()
        {
            cpuName = "Big Boss";
            cpuRace = "Alien";
            cpuPlanet = "Mars";
        }

        //member methods

        public void SetCpuName(string cpuName)
        {
            this.cpuName = cpuName;
        }

        public void SetCpuRace(string cpuRace)
        {
            this.cpuRace = cpuRace;
        }

        public void SetCpuPlanet(string cpuPlanet)
        {
            this.cpuPlanet = cpuPlanet;
        }
    }
}
