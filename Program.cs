using System;
using System.Linq;

namespace Theme196;

public static class Program
{	

class Program
{
    static void Main()
    {
        int N = 3; // количество школьников или спортсменов

        // Для школьников
        Schoolchild[] schoolchildren = new Schoolchild[N];
        int boysCount = 0;
        int girlsCount = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Enter information for schoolchild {i + 1}:");
            string fullName = Console.ReadLine();
            string gender = Console.ReadLine();
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            schoolchildren[i] = new Schoolchild(fullName, gender, yearOfBirth);

            if (gender.ToLower() == "male")
                boysCount++;
            else if (gender.ToLower() == "female")
                girlsCount++;
        }

        Console.WriteLine($"Number of boys: {boysCount}");
        Console.WriteLine($"Number of girls: {girlsCount}");
        Console.WriteLine("List of schoolchildren:");
        foreach (var schoolchild in schoolchildren)
        {
            Console.WriteLine($"Name: {schoolchild.FullName}, Gender: {schoolchild.Gender}, Year of Birth: {schoolchild.YearOfBirth}");
        }

        // Для спортсменов
        Athlete[] athletes = new Athlete[N];
        int athletesOver70Kg = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Enter information for athlete {i + 1}:");
            string fullName = Console.ReadLine();
            int height = Convert.ToInt32(Console.ReadLine());
            int weight = Convert.ToInt32(Console.ReadLine());

            athletes[i] = new Athlete(fullName, height, weight);

            if (weight > 70)
                athletesOver70Kg++;
        }

        Console.WriteLine($"Number of athletes with weight over 70kg: {athletesOver70Kg}");
        Console.WriteLine("List of athletes:");
        foreach (var athlete in athletes)
        {
            Console.WriteLine($"Name: {athlete.FullName}, Height: {athlete.Height}, Weight: {athlete.Weight}");
        }
    }
}
}
