using System;

namespace LuckyTicketGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();

            while (true)
            {
                ticket.StartLuckyTicketGame();
            }
        }
    }
}
