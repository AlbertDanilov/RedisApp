using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisApp
{
    public static class RedisHelper
    {
        public static void SaveDate(string host, string key, string value) 
        {
            using (RedisClient client = new RedisClient(host))
            {
                if (client.Get(key) == null)
                {
                    client.Set(key, value);
                }
            }            
        }

        public static string ReadData(string host, string key)
        {
            using (RedisClient client = new RedisClient(host))
            {
                return client.Get<string>(key);
            }
        }
    }
}
