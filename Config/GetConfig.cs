using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Config
{
   public static class GetConfig
    {
        public static Mailgun LoadConfig()
        {
            // /home/ubuntu/workspace/csharp/IPAlert/Config/config.json
            // C:\workspace\csharp\IPAlert\Config\config.json

            using (StreamReader sr = new StreamReader(@"F:\workspace\csharp\IPAlert\Config\config.json"))
            {
                string json = sr.ReadToEnd();
                Mailgun keys = JsonConvert.DeserializeObject<Mailgun>(json);
                return keys;
            }
        }
    }

    public class Mailgun
    {
        public string domain { get; set; }
        public string apiKey { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
