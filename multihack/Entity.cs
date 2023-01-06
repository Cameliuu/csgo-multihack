using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multihack
{
    public class Entity
    {
        private Int32 _team { get; set; }
        private Int32 _health { get; set; }

        public void SetHealth(Int32 health)
        { this._health = health; }
        public Int32 GetHealth() { return _health; }

        public void SetTeam(Int32 team) { this._team = team; }
        public Int32 GetTeam() { return _team; }
    }
}
