namespace LuckyTicketGame
{
    class Program
    {
        static void Main()
        {
            Message.ShowWelcomeMessage();

            Ticket ticket = new Ticket();

            while (true)
            {
                ticket.StartLuckyTicketGame();
            }
        }
    }
}
