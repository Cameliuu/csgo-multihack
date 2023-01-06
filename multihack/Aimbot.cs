using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swed32;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace multihack
{
    public class Aimbot
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public static void Run(Swed swed, IntPtr engine,Entity localPlaer, List<Entity>entities)
        {
            if (GetAsyncKeyState(Keys.F1) < 0)
                if (entities.Count > 0)
                {
                   
                    Aim(swed, engine, localPlaer, entities[0]);
                }
          
            
                            
        }
        public static void Aim(Swed swed,IntPtr engine,Entity localPlayer, Entity ent)
        {
            var playerFeet = localPlayer.GetFeetPos();
            var entHead = ent.GetHeadPos();
            float deltaX = entHead.X - playerFeet.X;
            float deltaY = entHead.Y - playerFeet.Y;
           
            float X = (float)((Math.Atan2(deltaY, deltaX) * 180 / Math.PI));

            float deltaZ = entHead.Z - playerFeet.Z;
       
            float dist = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            float Y = -(float)(Math.Atan2(deltaZ, dist) * 180 / Math.PI);
            var buffer = swed.ReadPointer(engine, Offsets.clientState);
            swed.WriteBytes(buffer, Offsets.viewAngles, BitConverter.GetBytes(Y));
            swed.WriteBytes(buffer, Offsets.viewAngles+0x4, BitConverter.GetBytes(X));

        }
    }
}
