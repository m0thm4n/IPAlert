using System;
using System.Net;
using System.Net.NetworkInformation;

namespace IPGetter
{
    public class GrabIP
    {
        public string GetExternalAddress()
        {
            {
                string externalip = new WebClient().DownloadString("http://ipv4.icanhazip.com");
                return externalip;
            }
        }

        public string GetInternalIPAddress()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }

                throw new Exception("No network adapters with an IPv4 Address in the system!");
            }

            throw new Exception("No network connected!");
        }

        public GrabIP()
        {

        }
    }
}
