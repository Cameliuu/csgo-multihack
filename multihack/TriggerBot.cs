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
            Entity player = new Entity();
            Entity ene= new Entity();
            var buffer = swed.ReadPointer(client, Offsets.localPlayer);
            var crosshairid = swed.ReadInt(buffer, Offsets.crosshairId);
            player.SetTeam(swed.ReadInt(buffer, Offsets.team));
            player.SetHealth(swed.ReadInt(buffer, Offsets.health));


            var enemy = swed.ReadPointer(client, Offsets.entityList + (crosshairid - 1) * 0x10);
            ene.SetTeam(swed.ReadInt(enemy,Offsets.team));
            ene.SetHealth(swed.ReadInt(enemy, Offsets.health));

            var eH = ene.GetHealth();
            var eT = ene.GetTeam();
            if (eH > 0 && eH <= 100 && eT != player.GetTeam())
            {
                swed.WriteInt(client, Offsets.forceAttack, 5);
                Thread.Sleep(1);
                swed.WriteInt(client, Offsets.forceAttack, 4);
            }
        }

    }
}
