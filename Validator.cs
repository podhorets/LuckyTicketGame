using System.Linq;
using System.Text.RegularExpressions;

namespace LuckyTicketGame
{
    class Validator
    {
        public static bool CheckIfInputIsValid(string inputValue)
        {
            bool isLengthValid = inputValue.Count() > 3 && inputValue.Count() < 9;
            bool areCharachtersValid = new Regex(@"^[0-9]*$").IsMatch(inputValue);

            return isLengthValid && areCharachtersValid;
        }
    }
}
