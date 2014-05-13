using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace next.etc
{
    class MazeSolution
    {
        //시작점, 종료점 지정
        public static int[] startLoc = new int[2] { 1, 1 }; //현좌표(y,x)
        public static int[] endPoint = new int[2] { 9, 9 }; //출구

        public static string[][] maze;

        //거리
        public static int rightDistance = 0;
        public static int leftDistance = 0;

        //최단경로
        public static string[][] rightRoot;
        public static string[][] leftRoot;

        //길을 찾아 줄 찍찍이
        public static Stack<int[]> mazeRMouse = new Stack<int[]>();
        public static Stack<int[]> mazeLMouse = new Stack<int[]>();

        public static void Main()
        {
            maze = MakeMaze();  //미로 초기화
            FindRightRoot();    //우선법

            Thread.Sleep(500);

            maze = MakeMaze();  //미로 초기화
            FindLeftRoot();     //좌선법

            Thread.Sleep(500);

            Console.Clear();

            PrintBestRoot();    //최단경로 출력
        }

        //미로 string[][] 생성
        public static string[][] MakeMaze()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\maze1.txt");

            List<string> mazeList = new List<string>();

            string[][] maze = new string[11][];

            while (!sr.EndOfStream)
            {
                mazeList.Add(sr.ReadLine());
            }

            for (int i = 0; i < mazeList.Count; i++)
            {
                maze[i] = mazeList[i].Split(' ');
            }

            return maze;
        }

        //미로 출력
        //0 : 가보지 않은 길, 1 : 벽, 2 : 현위치, 3 : 지나온 길, 4 : 막힌 길
        public static void PrintMaze(string[][] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze[i].Length; j++)
                {
                    if (maze[i][j].Equals("1"))
                        Console.Write("■");
                    else if (maze[i][j].Equals("0"))
                        Console.Write("　");
                    else if (maze[i][j].Equals("2"))
                        Console.Write("＠");
                    else if (maze[i][j].Equals("3"))
                        Console.Write("·");
                    else if (maze[i][j].Equals("4"))
                        Console.Write("χ");
                }
                Console.WriteLine();
            }
        }

        //출구 찾기(우선법)
        public static void FindRightRoot()
        {
            int[,] movement = new int[4, 2] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };//우, 하, 좌, 상

            MoveMouse(movement, mazeRMouse, true);
        }

        //출구 찾기(좌선법)
        public static void FindLeftRoot()
        {
            int[,] movement = new int[4, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } };//좌, 하, 우, 상

            MoveMouse(movement, mazeLMouse, false);
        }

        public static void MoveMouse(int[,] movement, Stack<int[]> mazeMouse, bool isRight)
        {
            int[] moveEnd = new int[2] { -1, -1 };
            mazeMouse.Push(moveEnd);

            //시작점 지정
            int[] nowLoc = (int[]) startLoc.Clone();
            maze[nowLoc[0]][nowLoc[1]] = "2";
            int distance = 0;

            while (!nowLoc.SequenceEqual(endPoint))
            {
                Console.Clear();

                for (int i = 0; i < movement.GetLength(0); i++)
                {
                    //해당 방향으로 나아갈 길이 있는가
                    if (maze[nowLoc[0] + movement[i, 0]][nowLoc[1] + movement[i, 1]].Equals("0"))
                    {
                        Console.WriteLine("move!");
                        mazeMouse.Push(new int[2] { nowLoc[0], nowLoc[1] });

                        //빈 공간으로 이동
                        maze[nowLoc[0]][nowLoc[1]] = "3";
                        nowLoc[0] += movement[i, 0];
                        nowLoc[1] += movement[i, 1];
                        maze[nowLoc[0]][nowLoc[1]] = "2";

                        distance++;

                        Console.WriteLine("{0},{1}", nowLoc[0], nowLoc[1]);
                        break;
                    }

                    //모든 길이 막힌 경우
                    if (i == movement.GetLength(0) - 1)
                    {
                        Console.WriteLine("blocked!");

                        //X표를 치고 온 길을 되돌아감
                        maze[nowLoc[0]][nowLoc[1]] = "4";
                        nowLoc = mazeMouse.Pop();

                        if (nowLoc == moveEnd) //출구에 도달할 수 없는 경우
                        {
                            if (isRight)
                                rightDistance = -1;
                            else
                                leftDistance = -1;

                            return;
                        }

                        Console.WriteLine("{0},{1}", nowLoc[0], nowLoc[1]);
                        maze[nowLoc[0]][nowLoc[1]] = "2";

                        distance--;
                    }
                }

                PrintMaze(maze); 
                Console.WriteLine("Distance : {0}", distance);

                Thread.Sleep(100);
            }

            if (isRight)
            {
                rightRoot = (string[][]) maze.Clone();
                rightDistance = distance;
            }
            else
            {
                leftRoot = (string[][]) maze.Clone();
                leftDistance = distance;
            }
        }

        //최단거리 출력
        public static void PrintBestRoot()
        {
            Console.WriteLine("\r\n");

            if (rightDistance == -1 && leftDistance == -1)
                Console.WriteLine("출구에 도달할 수 없습니다.");
            else if (rightDistance > leftDistance)
            {
                if (leftDistance != -1 && rightDistance > leftDistance)
                {
                    PrintMaze(leftRoot);
                    Console.WriteLine("최단거리 : {0}", leftDistance);
                }
            }
            else
            {
                PrintMaze(rightRoot);
                Console.WriteLine("최단거리 : {0}", rightDistance);
            }
        }
    }
}
