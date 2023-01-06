using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swed32;
using System.Threading.Tasks;

namespace multihack
{
    public class TriggerBot
    {
        public static void Run(Swed swed, IntPtr client, IntPtr engine)
        {
            var buffer = swed.ReadPointer(client, Offsets.localPlayer);
            var crosshairid = swed.ReadInt(buffer, Offsets.crosshairId);
            Console.WriteLine($"{buffer}:{crosshairid}");
        }

    }
}
