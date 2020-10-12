using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
   public  class MoodAnalyserCustomException: Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE
        }
        public readonly ExceptionType type;

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
