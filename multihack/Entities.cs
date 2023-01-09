using Swed32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multihack
{
    public class Entities
    {
        private static List<Entity> list { get; set; }
        private static IntPtr client { get; set; }
        private static Swed swed { get; set; }
        private static Entity localPlayer { get; set; }
        private static float aimbotWidth { get; set; }
        private static float aimbotHeight { get; set; }
        private static float aimbotFOV { get; set; }
        public static List<Entity> GetEntitiesList() { return list; }
        public static float GetAimbotFOV() { return aimbotFOV; }
        public static Entity GetLocalPlayer() { return localPlayer; }  
        public static float GetAimbotWidth() {return aimbotWidth;}
        public static float GetAimbotHeight() { return aimbotHeight;}
        public static IntPtr GetClient() { return client; }
        public static Swed GetSwed() { return swed; } 
        public static void SetEntitiesList(List<Entity> ents) { list = ents; }
        public static void SetClient(IntPtr clienT) { clienT =client; }
        public static void SetSwed(Swed s) { swed = s; }    
        public static void SetLocalPlayer(Entity player) { localPlayer = player; }
        public static void SetAimbotWitdh(float aimbotWitdh) { aimbotWidth=aimbotWitdh;}
        public static void SetAimbotHeight(float aimbotheight) { aimbotHeight = aimbotheight; }
        public static void SetAimbotFOV(float fov) { aimbotFOV = fov; }
    }
}
