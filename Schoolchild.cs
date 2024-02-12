using System;
using System.Linq;

namespace Theme19;
class Schoolchild
{
    public string FullName { get; set; }
    public string Gender { get; set; }
    public int YearOfBirth { get; set; }

    public Schoolchild(string fullName, string gender, int yearOfBirth)
    {
        FullName = fullName;
        Gender = gender;
        YearOfBirth = yearOfBirth;
    }
}

