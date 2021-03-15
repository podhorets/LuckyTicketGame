using System;

namespace LuckyTicketGame
{
    class Ticket
    {
        public void StartLuckyTicketGame()
        {
            string inputValue = this.GetInputValue();
        }

        private string GetInputValue()
        {
            var inputValue = Console.ReadLine();

            return inputValue;
        }
    }
}
