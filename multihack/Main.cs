using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swed32;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;

namespace multihack
{
    public class Main
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public static void Run()
        {
            Swed swed = new Swed("csgo");
            var client = swed.GetModuleBase("client.dll");
            Entities.SetClient(client);
            Entities.SetSwed(swed); 
            var engine = swed.GetModuleBase("engine.dll");

            while(true)
            {
                var localPlayer = ReadLocalPlayer(swed, client);
                Entities.SetLocalPlayer(localPlayer);
                var entities = ReadEntities(swed, client, localPlayer);
                entities = entities.OrderBy(x => x.GetXDist()).ToList();
                
                Entities.SetEntitiesList(entities);
                if(TriggerSettings.isTurnedOn())
                {
                    TriggerBot.Run(swed,client,localPlayer);
                }
               if(AimbotSettings.isTurnedOn())
                {
                    Aimbot.Run(swed,engine,localPlayer,entities);
                }
            }
        }
        public static Entity ReadLocalPlayer(Swed swed, IntPtr client)
        {
            var localPlayer = new Entity();
            var buffer = swed.ReadPointer(client, Offsets.localPlayer);
            var coords = swed.ReadVec(buffer, Offsets.vecOrigin);
            coords.Z += BitConverter.ToSingle(swed.ReadBytes(buffer, Offsets.viewOffset + 0x8 ,4),0);
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
        public static Entity ReadEntity(Swed swed,IntPtr ptrBase, Entity localPlayer, IntPtr client)
        {
            var glowManager = swed.ReadPointer(client, Offsets.glowObjectManager);
         
            var ent = new Entity();
            
            ent.SetBaseAdress(ptrBase);
            if(AimbotSettings.isTurnedOn())
                ent.SetHeadPos(GetHead(swed, ent.GetBaseAdress(),AimbotSettings.getBoneID(AimbotSettings.getBone())));
            ent.SetHealth(swed.ReadInt(ent.GetBaseAdress(), Offsets.health));
            var vect = ent.GetFeetPos();
            vect.Z += 58;
            ent.SetTeam(swed.ReadInt(ent.GetBaseAdress(), Offsets.team));
            ent.SetFeetPos(swed.ReadVec(ent.GetBaseAdress(), Offsets.vecOrigin));
            ent.SetTop(World2Screen(ReadViewMatrix(swed, client), ent.GetHeadPos(), (int)Entities.GetAimbotWidth(), (int)Entities.GetAimbotHeight()));
            ent.SetBot(World2Screen(ReadViewMatrix(swed, client), ent.GetFeetPos(), (int)Entities.GetAimbotWidth(), (int)Entities.GetAimbotHeight()));

            ent.SetXDist(CalcDist(ent));
           
            ent.SetMagnitude(CalcMag(localPlayer.GetFeetPos(), ent.GetHeadPos()));
            ent.SetDormant(swed.ReadInt(ent.GetBaseAdress(), Offsets.dormant));
           
            ent.SetGlowIndex(swed.ReadInt(ent.GetBaseAdress(), Offsets.glowIndex));
            if (ESPSettings.isTurnedOn())
            {

                if (ent.GetTeam() == localPlayer.GetTeam())
                {
                    var teamGlow = ESPSettings.GetTeamGlow();
                    GlowTeam(swed, glowManager, ent, teamGlow[0], teamGlow[1], teamGlow[2], teamGlow[3]);

                }
                else
                {
                    var enemyGlow = ESPSettings.GetEnemyGlow();
                    GlowEnemy(swed, glowManager, ent, enemyGlow[0], enemyGlow[1], enemyGlow[2], enemyGlow[3]);
                    Console.WriteLine($"GLOWIN ENEMY:{enemyGlow[0]},{enemyGlow[1]},{enemyGlow[2]},{enemyGlow[3]}");
                }

            }
          
            return ent;
        }
      
        public static void GlowEnemy(Swed swed, IntPtr glowManager, Entity ent, float r, float g, float b, float a)
        {
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x8, r);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0xC, g);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x10, b);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x14, a);

            swed.WriteBytes(glowManager + (ent.GetGlowIndex() * 0x38) + 0x27, BitConverter.GetBytes(true));
            swed.WriteBytes(glowManager + (ent.GetGlowIndex() * 0x38) + 0x28, BitConverter.GetBytes(true));
        }
        public static void GlowTeam(Swed swed, IntPtr glowManager, Entity ent, float r, float g, float b, float a)
        {
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x8, r);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0xC, g);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x10, b);
            swed.WriteFloat(glowManager + (ent.GetGlowIndex() * 0x38) + 0x14, a);

            swed.WriteBytes(glowManager + (ent.GetGlowIndex() * 0x38) + 0x27, BitConverter.GetBytes(true));
            swed.WriteBytes(glowManager + (ent.GetGlowIndex() * 0x38) + 0x28, BitConverter.GetBytes(true));
        }
        public static bool isAlive(Entity ent)
        { 
            return (ent.GetHealth() > 0) && (ent.GetHealth() <= 100);
        }
        public static float CalcMag(Vector3 player, Vector3 target)
        {

            return (float)Math.Sqrt(
                Math.Pow(target.X - player.X, 2) +
                Math.Pow(target.Y - player.Y, 2) +
                Math.Pow(target.Z - player.Z, 2));

        }
        public static Vector3 GetHead(Swed swed,IntPtr entPointer,int boneID)
        {
            var bones = swed.ReadPointer(entPointer, Offsets.boneMatrix);
            var bone = swed.ReadBytes(bones, 0x30 * boneID, 0x30);
            Vector3 vector3vector = new Vector3();
            vector3vector.X = BitConverter.ToSingle(bone, 0xC);
            vector3vector.Y = BitConverter.ToSingle(bone, 0x1C);
            vector3vector.Z = BitConverter.ToSingle(bone, 0x2C);

            return vector3vector;
            
        }
        public static List<Entity> ReadEntities(Swed swed,IntPtr client, Entity localPlayer)
        {
            var glowObjectManger = swed.ReadPointer(client, Offsets.glowObjectManager);
            var entities = new List<Entity>();
            for (int i = 1; i < 32; i++)
            {
                var buffer = swed.ReadPointer(client, Offsets.entityList + i * 0x10);
                var ent = ReadEntity(swed, buffer, localPlayer,client);
                
               
                if (ent.GetHealth() < 2 || ent.GetDormant() != 0)
                    continue;
                if (ent.GetTeam() != localPlayer.GetTeam() && ent.GetFeetPos()!=Vector3.Zero && isAlive(ent))
               {
                    
                    entities.Add(ent);
                }
            }

          
            
            return entities;
        }
      
        public static Point World2Screen(ViewMatrix mtx, Vector3 pos, int width, int height)
        {
           
            var twoD = new Point();
            float screenW=(mtx.m41 * pos.X)+ (mtx.m42 * pos.Y) + (mtx.m43 * pos.Z) + mtx.m44;
           
            if (screenW > 0.001f)
            {
             
                float screenX = (mtx.m11 * pos.X) + (mtx.m12 * pos.Y) + (mtx.m13 * pos.Z) + (mtx.m14);

                float screenY = (mtx.m21 * pos.X) + ((mtx.m22 * pos.Y)) + (mtx.m23 * pos.Z) + mtx.m24;

                float camX = width / 2f;
                float camY = height / 2f;


                float X = camX + (camX * screenX / screenW);
                float Y = camY - (camY * screenY / screenW);

                twoD.X =(int)X;
                twoD.Y =(int)Y;
               
                return twoD;
                
            }
            return new Point(-99,-99);
        }
        public static float CalcDist(Entity ent)
        {
            float xx = Entities.GetAimbotWidth() / 2;
            float xy = Entities.GetAimbotHeight() / 2;
            
            return (float)Math.Sqrt(Math.Pow(xx - ent.GetTop().X, 2) + Math.Pow(xy - ent.GetTop().Y, 2));
        }
        public static ViewMatrix ReadViewMatrix(Swed swed, IntPtr client)
        {
            var mtx = new ViewMatrix();
            var buffer = new byte[16 * 4];
            buffer = swed.ReadBytes(client,Offsets.viewMatrix,buffer.Length);

            mtx.m11 = BitConverter.ToSingle(buffer, 0 * 4);
            mtx.m12 = BitConverter.ToSingle(buffer, 1 * 4);
            mtx.m13 = BitConverter.ToSingle(buffer, 2 * 4);
            mtx.m14 = BitConverter.ToSingle(buffer, 3 * 4);

            mtx.m21 = BitConverter.ToSingle(buffer, 4 * 4);
            mtx.m22 = BitConverter.ToSingle(buffer, 5 * 4);
            mtx.m23 = BitConverter.ToSingle(buffer, 6 * 4);
            mtx.m24 = BitConverter.ToSingle(buffer, 7 * 4);

            mtx.m31 = BitConverter.ToSingle(buffer, 8 * 4);
            mtx.m32 = BitConverter.ToSingle(buffer, 9 * 4);
            mtx.m33 = BitConverter.ToSingle(buffer, 10 * 4);
            mtx.m34 = BitConverter.ToSingle(buffer, 11 * 4);

            mtx.m41 = BitConverter.ToSingle(buffer, 12 * 4);
            mtx.m42 = BitConverter.ToSingle(buffer, 13 * 4);
            mtx.m43 = BitConverter.ToSingle(buffer, 14 * 4);
            mtx.m44 = BitConverter.ToSingle(buffer, 15 * 4);

            return mtx;
        }
        public static Rectangle CalcRect(Point feet, Point head)
        {
            var rect = new Rectangle();
            rect.X = head.X - (feet.Y - head.Y) / 4;
            rect.Y = head.Y;
            rect.Width = (feet.Y - head.Y) / 2;
            rect.Height = (feet.Y - head.Y);
            return rect;
        }
    }
}
