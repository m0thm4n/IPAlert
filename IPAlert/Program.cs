using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Emailer;
using System.Threading.Tasks;
using IPGetter;

namespace IPAlert
{
    class Program
    {
        static async Task Main(string[] args)
        {
            EmailIP emailer = new EmailIP();

            GrabIP grabIP = new GrabIP();

            string internalIP = grabIP.GetInternalIPAddress();
            string externalIP = grabIP.GetExternalAddress();

            emailer.SendEmail("Your Internal IP is: " + internalIP + "\nYour External IP is: " + externalIP);
        }
    }
}
