using System;

namespace LuckyTicketGame
{
    class Ticket
    {
        public void StartLuckyTicketGame()
        {
            string inputValue = this.GetInputValue();

            bool isInputValueValid = Validator.CheckIfInputIsValid(inputValue);

            if (isInputValueValid)
            {
                
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
    }
}
