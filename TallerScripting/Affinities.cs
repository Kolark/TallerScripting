using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    public static class Stats
    {
        private static float[,] matriz = {
            
          //| Da |Li  |Fi  |Wa  | Wi | Ea |
            {0.5f,2.0f,1.0f,1.0f,1.0f,1.0f}, //Dark
            {2.0f,0.5f,1.0f,1.0f,1.0f,1.0f}, //Light
            {1.0f,1.0f,0.5f,2.0f,1.0f,0.0f}, //Fire
            {1.0f,1.0f,0.5f,0.5f,2.0f,1.0f}, //Water
            {1.0f,1.0f,1.0f,0.5f,0.5f,0.5f}, //Wind
            {1.0f,1.0f,1.0f,1.0f,2.0f,0.5f}  //Earth
        };
        public static float[,] Matriz { get => matriz;}
    }
    public enum Affinity
    {
        Dark, Light, Fire, Water, Wind, Earth
    }
}
