using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class UserInputConverter
    {
        public static long? GetNumberFromUserInput(string userInput)
        {
            long result;

            bool isParsed = long.TryParse(userInput, out result);

            if (isParsed && result > 0)
                return result;

            return null;
        }

        public static bool PlayAgain(string userInput)
        {
            long result;

            bool isParsed = long.TryParse(userInput,out result);

            if (isParsed && result > 0)
                return true;

            return false;
        }
    }
}
