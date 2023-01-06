using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swed32;
using System.Threading.Tasks;

namespace multihack
{
    public class Main
    {
        public static void Run()
        {
            Swed swed = new Swed("csgo");
            var client = swed.GetModuleBase("client.dll");
            var engine = swed.GetModuleBase("engine.dll");

            while(true)
            {
                if(TriggerSettings.isTurnedOn())
                {
                    TriggerBot.Run(swed,client,engine);
                }
            }
        }
    }
}
