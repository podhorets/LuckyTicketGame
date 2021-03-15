using System.Linq;

namespace LuckyTicketGame
{
    class Calculator
    {
        public bool CheckIfNumberIsLucky(string inputValue)
        {
            string number = this.GetEvenNumber(inputValue);

            int lengthOfHalfNumber = number.Count() / 2;

            int sumOfLeftHalf = this.GetSumOfLeftHalf(number, lengthOfHalfNumber);
            int sumOfRightHalf = this.GetSumOfRightHalf(number, lengthOfHalfNumber);

            return sumOfLeftHalf == sumOfRightHalf;
        }

        private int GetSumOfLeftHalf(string number, int lengthOfHalfNumber)
        {
            string leftHalfOfNumber = number.Substring(0, lengthOfHalfNumber);

            int leftHalfSum = this.GetSum(leftHalfOfNumber);

            return leftHalfSum;
        }

        private int GetSumOfRightHalf(string number, int lengthOfHalfNumber)
        {
            string rightHalfOfNumber = number.Substring(number.Length - lengthOfHalfNumber, lengthOfHalfNumber);

            int rightHalfSum = this.GetSum(rightHalfOfNumber);

            return rightHalfSum;
        }

        private int GetSum(string halfInput)
        {
            int halfSum = halfInput.Select(num => (int)num).Sum();

            return halfSum;
        }

        private string GetEvenNumber(string number)
        {
            bool isNumberOdd = number.Count() % 2 != 0;

            if (isNumberOdd)
            {
                const string zero = "0";

                string evenNumber = number.Insert(0, zero);

                return evenNumber;
            }

            return number;
        }
    }
}
