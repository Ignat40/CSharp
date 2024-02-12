using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace MazeNavigation
{
    class Program
    {
        static void Main()
        {
            MazeSolver solver = new();
            char[,] maze = solver.ReadMaze("maze.txt", out (int, int) start);
            List<(int, int)> path = new List<(int, int)> { };



            if (solver.FindPathRecursive(maze, start.Item1, start.Item2, path, direction: 'S'))
            {
                Console.WriteLine("Path found:");
                AnimatePath(maze, start.Item1, start.Item2, path);
                // foreach (var step in path)
                // {
                //     Console.WriteLine($"({step.Item1}, {step.Item2})");
                // }
            }
            else
            {
                Console.WriteLine("No path found.");
            }
        }

        public static void AnimatePath(char[,] maze, int x, int y, List<(int, int)> path)
        {
            foreach (var step in path)
            {
                Console.Clear();

                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    for (int j = 0; j < maze.GetLength(1); j++)
                    {
                        if (i == step.Item1 && j == step.Item2)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(maze[i, j]);
                        }
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500); 
            }
        }

    }
}
