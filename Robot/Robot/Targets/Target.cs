using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Targets
{
    internal class Target
    {
        int health;
        string name;
        public bool IsAlive { get => this.health > 0 ? true : false; }
        public int Health { get => health; set { this.health = value; } }
        public Target(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
