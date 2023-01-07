using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace multihack
{
    public class Entity
    {
        private Int32 _team { get; set; }
        private IntPtr _baseAdress { get; set; }
        private Int32 _health { get; set; }
        private Vector3 _feetPos { get; set; }
        private Int32 _crosshairId { get; set; }
        private float _magnitude { get; set; }
        private Vector3 _headPos { get; set; }
        private Int32 _dormant { get; set; }
        private Point top { get; set; }
        private Point bot {get; set;}
        private Int32 glowIndex { get; set; }
        public Rectangle rect()
        {
            return new Rectangle
            {
                Location = new Point(bot.X - (bot.Y - top.Y) / 4, top.Y),
                Size = new Size((bot.Y - top.Y) / 2, (bot.Y - top.Y))
            };
        }
        public void SetHealth(Int32 health) { this._health = health; }
        public void SetTop(Point topp) { top = topp; }
        public void SetGlowIndex(Int32 glow) { glowIndex = glow; }
        public void SetBot(Point topp) { bot = topp; }
        public void SetMagnitude(float mag) { this._magnitude = mag; }
        public void SetFeetPos(Vector3 pos) { this._feetPos = pos; }
        public void SetHeadPos(Vector3 headPos) { this._headPos = headPos; }
        public void SetTeam(Int32 team) { this._team = team; }
        public void SetCrosshairId(Int32 crosshirid) { this._crosshairId = crosshirid; }
        public void SetBaseAdress(IntPtr baseA) { this._baseAdress = baseA; }
        public void SetDormant(Int32 d) { this._dormant = d; }
        
        public Int32 GetHealth() { return _health; }
        public Int32 GetTeam() { return _team; }
        public Vector3 GetHeadPos() { return this._headPos;}
        public Vector3 GetFeetPos() { return this._feetPos;}
        public Int32 GetCrosshairId() { return this._crosshairId;  }
        public IntPtr GetBaseAdress() { return this._baseAdress; }
        public float GetMagnitude() { return this._magnitude; }
        public Int32 GetDormant() { return this._dormant; }
        public Point GetTop() { return top; }
        public Point GetBot() { return bot; }
        public Int32 GetGlowIndex() { return glowIndex; }

    }
}   
