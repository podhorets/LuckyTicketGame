using System;

namespace LuckyTicketGame
{
    class Message
    {
        public const string welcomeMessage = "\nHi! Welcome to the game \"Lucky ticket\"!\n" +
            "Write a number from 4 to 8 digits and click on \"Enter\" to check if your ticket is lucky.\n";

        public const string successfulMessage = "\nHey, this ticket is lucky. Do yo have any more tickets?\n" +
            "Enter a new ticket number:\n";

        public const string notSuccessfulMessage = "\nUnfortunately this ticket is unlucky. Just try again!\n" +
            "Enter a new ticket number:\n";

        public const string invalidValueMessage = "\nWrite a number from 4 to 8 digits!\n";

        public static void ShowWelcomeMessage()
        {
            Console.WriteLine(welcomeMessage);
        }

        public static void ShowSuccessfulMessage()
        {
            Console.WriteLine(successfulMessage);
        }

        public static void ShowNotSuccessfulMessage()
        {
            Console.WriteLine(notSuccessfulMessage);
        }

        public static void ShowInvalidValueMessage()
        {
            Console.WriteLine(invalidValueMessage);
        }
    }
}
