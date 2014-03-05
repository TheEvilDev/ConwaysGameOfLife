using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using MonoGame.ConwaysGameOfLife.Extensions;

namespace MonoGame.ConwaysGameOfLife.Models
{
    public class TwoOrThreeLivingNeighborsRule : IRule
    {
        public bool Apply(Point point, bool isAlive, IEnumerable<Point> livingNeighbors)
        {
            return isAlive && livingNeighbors.Count().InBetween(2, 3);
        }
    }
}