using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
            {
                try
                {
                    if (message.ToUpper().Contains("SAD"))
                        return "Sad Mood";
                    else
                        return "Happy Mood";
                }
                catch
                {
                    return "Happy Mood";
                }
         }
    }

}
