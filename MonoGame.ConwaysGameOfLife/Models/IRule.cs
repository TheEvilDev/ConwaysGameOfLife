using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MonoGame.ConwaysGameOfLife.Models
{
    public interface IRule
    {
        bool Apply(Point point, bool isAlive, IEnumerable<Point> livingNeighbors);
    }
}