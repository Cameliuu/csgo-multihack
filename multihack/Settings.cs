using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multihack
{
    public class TriggerSettings
    {
        private static bool _triggerBot { get; set; }
        private static int _intensity { get; set; }
        public static void toggleOn()
        {
            _triggerBot = true;
        }
        public static void toggleOff()
        {
            _triggerBot = false;
        }
        public static bool isTurnedOn()
        { return _triggerBot; }

        public static int getIntensity() { return _intensity; }
        public static void setIntensity(int intensity) { _intensity = intensity; }
    }
    public class AimbotSettings
    {
        private static bool _aimBot { get; set; }

        public static void toggleOn()
        {
            _aimBot = true;
        }
        public static void toggleOff()
        {
            _aimBot = false;
        }
        public static bool isTurnedOn()
        { return _aimBot; }
    }
}
