using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P011
{
    class P11
    {
        private const int PathLength = 4;
        static void Main(string[] args)
        {
            var grid = Grid2d.Parse(Properties.Resources.GridP11);

            var allPaths = new IEnumerable<int[]>[]{
                GetHorizontalPaths(grid),
                GetVerticalPaths(grid),
                GetDiagonalNESWPaths(grid),
                GetDiagonalNWSEPaths(grid)
            }.SelectMany(e => e);

            var result = allPaths.Select(
                path=>path[0]*path[1]*path[2]*path[3]
                ).Max();

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static IEnumerable<int[]> GetHorizontalPaths(Grid2d grid)
        {
            for (int x = 0; x < grid.Width - PathLength + 1; x++)
            {
                for (int y = 0; y < grid.Height; y++)
                {
                    yield return new int[PathLength] {
                        grid[x,y],
                        grid[x+1,y],
                        grid[x+2,y],
                        grid[x+3,y]
                    };
                }
            }
        }
        private static IEnumerable<int[]> GetVerticalPaths(Grid2d grid)
        {
            for (int x = 0; x < grid.Width; x++)
            {
                for (int y = 0; y < grid.Height - PathLength + 1; y++)
                {
                    yield return new int[PathLength] {
                        grid[x,y],
                        grid[x,y+1],
                        grid[x,y+2],
                        grid[x,y+3]
                    };
                }
            }
        }
        private static IEnumerable<int[]> GetDiagonalNWSEPaths(Grid2d grid)
        {
            for (int x = 0; x < grid.Width - PathLength + 1; x++)
            {
                for (int y = 0; y < grid.Height - PathLength + 1; y++)
                {
                    yield return new int[PathLength] {
                        grid[x,y],
                        grid[x+1,y+1],
                        grid[x+2,y+2],
                        grid[x+3,y+3]
                    };
                }
            }
        }
        private static IEnumerable<int[]> GetDiagonalNESWPaths(Grid2d grid)
        {
            for (int x = 0; x < grid.Width - PathLength + 1; x++)
            {
                for (int y = PathLength-1; y < grid.Height; y++)
                {
                    yield return new int[PathLength] {
                        grid[x,y],
                        grid[x+1,y-1],
                        grid[x+2,y-2],
                        grid[x+3,y-3]
                    };
                }
            }
        }
    }
}
