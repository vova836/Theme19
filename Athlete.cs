using System;
using System.Linq;

namespace Theme19;

class Athlete
{
    public string FullName { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public Athlete(string fullName, int height, int weight)
    {
        FullName = fullName;
        Height = height;
        Weight = weight;
    }
}
