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
        public static void Run(Swed swed, IntPtr client, Entity localPlayer)
        {

            var enemy = Main.ReadEnemyFromCrosshairId(swed, client, localPlayer.GetCrosshairId());
            var eH = enemy.GetHealth();
            var eT = enemy.GetTeam();
            if (eH > 0 && eH <= 100 && eT != localPlayer.GetTeam())
            {
                Console.WriteLine($"[ + ] SHOOTING ENEMY WITH cID {localPlayer.GetCrosshairId()}");
                swed.WriteInt(client, Offsets.forceAttack, 5);
                Thread.Sleep(3);
                swed.WriteInt(client, Offsets.forceAttack, 4);
            }
        }

    }
}
