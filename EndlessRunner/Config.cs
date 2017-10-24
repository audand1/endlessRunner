using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Config
    {
        private static Config singletonInstance;
        private Config() {}

       public static Config getInstance
       {
          get 
          {
              if (singletonInstance == null)
             {
                 singletonInstance = new Config();
             }
              return singletonInstance;
          }
       }


       public void readConfigFile()
       {
           Console.WriteLine("read config file");
       }
       public void writeConfigFile()
       {
           Console.WriteLine("write config file");
       }
    }
}
