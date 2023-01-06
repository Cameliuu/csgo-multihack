using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swed32;
using System.Threading.Tasks;
using System.Numerics;

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
                var localPlayer = ReadLocalPlayer(swed, client);
                if(TriggerSettings.isTurnedOn())
                {
                    TriggerBot.Run(swed,client,localPlayer);
                }
               /* if(AimbotSettings.isTurnedOn())
                {
                    Aimbot.Run(swed,client,engine);
                }*/
            }
        }
        public static Entity ReadLocalPlayer(Swed swed, IntPtr client)
        {
            var localPlayer = new Entity();
            var buffer = swed.ReadPointer(client, Offsets.localPlayer);
            var coords = swed.ReadVec(buffer, Offsets.vecOrigin);
            localPlayer.SetFeetPos(coords);
            localPlayer.SetTeam(swed.ReadInt(buffer, Offsets.team));
            localPlayer.SetHealth(swed.ReadInt(buffer, Offsets.health));
            localPlayer.SetCrosshairId(swed.ReadInt(buffer, Offsets.crosshairId));
            return localPlayer;
        }
        public static Entity ReadEnemyFromCrosshairId(Swed swed, IntPtr client, Int32 crosshairId)
        {
            var buffer = swed.ReadPointer(client, Offsets.entityList + (crosshairId - 1) * 0x10);
            Entity enemy = new Entity();
            enemy.SetTeam(swed.ReadInt(buffer, Offsets.team));
            enemy.SetHealth(swed.ReadInt(buffer, Offsets.health));
            return enemy;

        }
    }
}
