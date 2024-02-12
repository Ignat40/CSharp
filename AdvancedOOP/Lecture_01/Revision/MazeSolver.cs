namespace MazeNavigation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;

    public class MazeSolver
    {
        private int endX, endY;

        public char[,] ReadMaze(string filePath, out (int, int) start)
        {
            var lines = File.ReadAllLines(filePath);
            char[,] maze = new char[lines.Length, lines[0].Length];
            start = (-1, -1);

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    maze[i, j] = lines[i][j];
                    if (maze[i, j] == 'S')
                    {
                        start = (i, j);
                    }
                    else if (maze[i, j] == 'E')
                    {
                        endX = i;
                        endY = j;
                    }
                }
            }
            return maze;
        }

        public bool FindPathRecursive(char[,] maze, int x, int y, List<(int, int)> path, char direction)
        {
            char[] pathToEnd = new char[maze.GetLength(0) * maze.GetLength(1)];
            int position = 0;

            if ((x < 0) || (y < 0) || (x >= maze.GetLength(0)) || (y >= maze.GetLength(1)))
            {
                //Console.WriteLine("You are out of the maze!");
                return false;
            }

            pathToEnd[position] = direction;
            position++;


            if (maze[x, y] == 'E')
            {
                //Console.WriteLine("Exit found!");
               
                return true;
            }

            if (maze[x, y] == '1' || maze[x, y] == 'v')
            {
                return false;
            }

            maze[x, y] = 'v';
            path.Add((x, y));

            if (FindPathRecursive(maze, x, y - 1, path, 'L') ||
                FindPathRecursive(maze, x - 1, y, path, 'U') ||
                FindPathRecursive(maze, x, y + 1, path, 'R') ||
                FindPathRecursive(maze, x + 1, y, path, 'D'))
            {
                return true;
            }

            maze[x, y] = ' ';
            path.RemoveAt(path.Count - 1);

            position--;

            return false;
        }

        

    }
}