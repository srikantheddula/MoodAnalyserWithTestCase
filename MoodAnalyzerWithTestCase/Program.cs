using System;

namespace MoodAnalyzerWithTestCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Moodanalyzer with test case");
            MoodAnalyser moodAnalyzer = new MoodAnalyser(); //Creating object for a class
            moodAnalyzer.DisplayMoodAnalyzer("I am in Happy mood");
        }
    }
}
