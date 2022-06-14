using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Targets;
enum LaserPower
{
    Low = 15,
    Medium = 25,
    High = 30,
    Kill = 50,
}
namespace Robot
{
    internal class Robot
    {
        int health;
        LaserPower power;
        Target[] target;
        bool active;
        int indexOfCurrentTarget;
        public bool IsActive { get => this.active; }
        public int GetHealth { get => this.health; set { this.health = value; } }
        public Robot(int health, LaserPower power, Target[] target)
        {
            this.health = health;
            this.power = power;
            this.target = target;
            this.active = true;
            indexOfCurrentTarget = 0;
        }
        public void FireLaserAt(Target target)
        {
            if (target.IsAlive == true && this.IsActive == true)
            {
                target.Health -= (int)power;
                Console.WriteLine($"The robot attacked {target} and dealt {(int)this.power} damage.");
                if (target.Health <= 0)
                {
                    Console.WriteLine("The target was eliminated.");
                    this.NextTarget();
                }
            }
            else
                this.NextTarget();
            if (indexOfCurrentTarget != this.target.Length)
                FireLaserAt(this.target[indexOfCurrentTarget]);
        }
        private void NextTarget()
        {
            indexOfCurrentTarget++;
            if (indexOfCurrentTarget == target.Length)
            {
                this.active = false;
                Console.WriteLine("The robot became inactive.");
                Console.WriteLine("All the targets have been eliminated.");
            }
        }
    }
}