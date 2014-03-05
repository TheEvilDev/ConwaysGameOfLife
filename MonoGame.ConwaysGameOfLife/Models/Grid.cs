using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using MonoGame.ConwaysGameOfLife.Extensions;

namespace MonoGame.ConwaysGameOfLife.Models
{
    public class Grid
    {
        public IEnumerable<Point> Cells { get; private set; }
        
        public int Size { get; private set; }

        public Grid(IEnumerable<Point> initialState, int size)
        {
            Cells = initialState;
            Size = size;
        }

        public Grid Next(IEnumerable<IRule> rules)
        {
            var newCells = new List<Point>();

            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    var point = new Point(x, y);

                    var lives = rules.Any(r => r.Apply(point, Cells.Contains(point), point.LivingNeighbors(Cells)));

                    if (lives)
                    {
                        newCells.Add(point);
                    }
                }
            }

            return new Grid(newCells, Size);
        }
    }
}