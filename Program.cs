﻿using System;


namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood analyzer program");
            Console.WriteLine("Type how you feeling right now:");
            string mood = Console.ReadLine();
            MoodAnalyser moodAnalyser = new MoodAnalyser(mood);
            Console.WriteLine("Currently you are: " + moodAnalyser.AnalyseMood());
        }

    }
}
