﻿namespace MarsRover10;

class Program
{
    static void Main(string[] args)
    {
        int numberOfInstructions = Convert.ToInt32(System.Console.ReadLine());
        string s = System.Console.ReadLine();
        string[] ss = s.Split(' ');
        var rover = new Rover(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
			
        for(int i = 0; i < numberOfInstructions; i++)
        {
            s = System.Console.ReadLine();
            ss = s.Split(' ');
            rover.clean(Convert.ToInt32(ss[1]), ss[0][0]);
        }
			
        System.Console.WriteLine("=> Visited: " + rover.getUniquePlacesVisited());
    }
}