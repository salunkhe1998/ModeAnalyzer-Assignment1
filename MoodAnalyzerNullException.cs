using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyzerAssignment1
{


    public class MoodAnalyzerNullException : Exception
    {
        Exception_Type type;
        public enum Exception_Type
        {
            EMPTY_MOOD,
            NULL_MOOD
        }

        public MoodAnalyzerNullException(Exception_Type type, string msg) : base(msg)
        {
            this.type = type;
        }
    }

}