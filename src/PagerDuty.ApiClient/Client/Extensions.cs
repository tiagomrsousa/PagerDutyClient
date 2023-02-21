using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagerDuty.ApiClient.Client
{
    public static class Extensions
    {
        public static Dictionary<String, String> AddOrUpdate(this Dictionary<String, String> target, string key, string value)
        {
            if(target.ContainsKey(key))
            {
                target[key] = value;
            }
            else
            {
                target.Add(key, value);
            }
            return target;
        }
    }
}
