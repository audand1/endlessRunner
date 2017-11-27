using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    class Config
    {
        public int points = 0;
        public int counter = 0;
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
 
       public Memento CreateMemento()
       {
           Console.WriteLine("Saving points...");
           return (new Memento(points));
       }
       public void SetMemento(Memento memento)
       {
           Console.WriteLine("Restoring points...");
           points = memento.GetPoints();
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
