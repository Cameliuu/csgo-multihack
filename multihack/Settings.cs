using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multihack
{
    public class Settings
    {
        private static bool _triggerBot { get; set; }

        public static void toggleTriggerOn()
        {
            _triggerBot = true;
        }
        public static void toggleTriggerOff()
        {
            _triggerBot = false;
        }

    }
}
