using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Targets;
namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target[] targets = { new Target("dog", 200), new Target("pigeon", 100), new Target("cat", 50) };
            Robot robot = new Robot(100, LaserPower.Kill, targets);
            robot.FireLaserAt(targets[0]);
            Console.ReadKey();
        }
    }
}
