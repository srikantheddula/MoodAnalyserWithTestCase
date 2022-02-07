using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerWithTestCase
{
     public class MoodAnalyser
    {
        public string Message;
        public string DisplayMoodAnalyzer(string message) //Creating a constructer 
        {
            Message = message;
            if (Message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
