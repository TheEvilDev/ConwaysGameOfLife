using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace MonoGame.ConwaysGameOfLife.Extensions
{
    public static class PointExtensions
    {
        public static IEnumerable<Point> LivingNeighbors(this Point cell, IEnumerable<Point> allLiving)
        {
            return allLiving.Where(c => Math.Abs(c.X - cell.X) == 1 || Math.Abs(c.Y - cell.Y) == 1);
        } 
    }
}