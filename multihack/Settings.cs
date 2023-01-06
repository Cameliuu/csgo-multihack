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
        private static string _bone { get; set; }
        private static Dictionary<string, int> _bones = new Dictionary<string, int>()

        {
            {"head",8 },
            {"torso",5 },
            {"legs",1}
        };
        public static void SetBone(string boneName)
        {
            _bone = boneName;
        }
        public static void toggleOn()
        {
            _bone = "legs";
            _aimBot = true;
        }
        public static void toggleOff()
        {
            _aimBot = false;
        }
        public static bool isTurnedOn()
        { return _aimBot; }
        public static int getBoneID(string boneName)
        {
            return _bones[boneName];
        }
        public static string getBone()
        { return _bone; }
        
    }
}
