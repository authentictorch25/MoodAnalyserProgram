using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
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
                        return "SAD";
                    else
                        return "HAPPY";
                }
                catch
                {
                    return "HAPPY";
                }
         }
    }

}
