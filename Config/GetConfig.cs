using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Config
{
   public static class GetConfig
    {
        public static List<Mailgun> LoadConfig()
        {
            // /home/ubuntu/workspace/csharp/IPAlert/Config/config.json

            using (StreamReader sr = new StreamReader(@"C:\workspace\csharp\IPAlert\Config\config.json"))
            {
                string json = sr.ReadToEnd();
                List<Mailgun> keys = JsonConvert.DeserializeObject<List<Mailgun>>(json);
                return keys;
            }
        }
    }

    public class Mailgun
    {
        public string domain;
        public string apiKey;
    }
}
