using System;

namespace Config
{
   public static class GetConfig
    {
        public static List<Key> LoadConfig()
        {
            using (StreamReader sr = new StreamReader(@"/home/ubuntu/workspace/csharp/IPAlert/Config/config.json"))
            {
                string json = sr.ReadToEnd();
                List<Key> keys = JsonConvert.DeserializeObject<List<Key>>(json);
                return keys;
            }
        }
    }

    public class MailGun
    {
        public string domain;
        public string apiKey;
    }
}
