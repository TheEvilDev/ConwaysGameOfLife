using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace MonoGame.ConwaysGameOfLife.Models
{
    public class DeadWithThreeLivingNeighborsRule : IRule
    {
        public bool Apply(Point point, bool isAlive, IEnumerable<Point> livingNeighbors)
        {
            return !isAlive && livingNeighbors.Count() == 3;
        }
    }
}