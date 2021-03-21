using System;
using Emailer;

namespace IPAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailIP emailer = new EmailIP();

            emailer.SendEmail("Test.");
        }
    }
}
