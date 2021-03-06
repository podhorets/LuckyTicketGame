using System;

namespace LuckyTicketGame
{
    class Ticket
    {
        private readonly Calculator calculator = new Calculator();

        public void StartLuckyTicketGame()
        {
            string inputValue = this.GetInputValue();

            bool isInputValueValid = Validator.CheckIfInputIsValid(inputValue);

            if (isInputValueValid)
            {
                bool isNumberLucky = calculator.CheckIfNumberIsLucky(inputValue);

                this.ShowResult(isNumberLucky);
            }
            else
            {
                Message.ShowInvalidValueMessage();
            }
        }

        private string GetInputValue()
        {
            var inputValue = Console.ReadLine();

            return inputValue;
        }

        private void ShowResult(bool isNumberLucky)
        {
            if (isNumberLucky)
            {
                Message.ShowSuccessfulMessage();
            }
            else
            {
                Message.ShowNotSuccessfulMessage();
            }
        }
    }
}
