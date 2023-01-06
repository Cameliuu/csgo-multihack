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
            {"torso",6 },
            {"right hand", 39 },
            {"left hand",13 },
            {"right leg", 73 },
            {"left leg",66 },
            {"right foot",74 },
            {"left foot",67 },
            {"below legs",1}
        };
        public static void SetBone(string boneName)
        {
            _bone = boneName;
        }
        public static void toggleOn()
        {
            _bone = "head";
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
    public class ESPSettings
    { 
        private static bool _esp { get; set; }
        public static void toggleOff()
        {
            _esp = false;
        }
        public static void toggleOn()
        {
            _esp = true;
        }
        public static bool isTurnedOn()
        { return _esp; }
    }
}
