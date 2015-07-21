using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Framework.ConfigurationModel;

namespace Recipe05.Web.Services
{
    public class HitCounterService
    {
        public int UpdateCount()
        {
            var config = new Configuration();
            config.Add(new MemoryConfigurationSource());
            var KEY = "count";
            var count = 1;
            
            var value = config.Get(KEY);
            if (value != null)
            {
                count = int.Parse(value);
                count++;
            }
            config.Set(KEY, count.ToString());
            return count;

        }
    }
}
