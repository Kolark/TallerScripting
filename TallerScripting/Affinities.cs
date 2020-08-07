using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    public static class Stats
    {
        private static float[,] matriz = { { 1 }, { 1 } };
        public static float[,] Matriz { get => matriz;}
    }
    public enum Affinity
    {
        Dark, Light, Fire, Water, Wind, Earth
    }
}
