using MoodAnalyserProblem;
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
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.ToUpper().Contains("SAD"))
                {
                    Console.WriteLine("Your current mood : SAD");
                    return "SAD";
                }
                else
                {
                    Console.WriteLine("Your current mood : HAPPY");
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Console.WriteLine(exception.Message);
                return exception.Message;
            }
        }
    }

}
