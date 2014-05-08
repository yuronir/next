using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace next._0502_9week
{
    class Timer
    {
        //sec를 받아서 타이머기능해주는 것.
        public static void PrintSec(int sec)
        {
            int i = 0;
            while (i < sec)
            {
                Console.WriteLine(++i);
                Thread.Sleep(1000);   
            }
        }

        //hour, min, sec을 받아서 타이머기능.
        public static void printTimer(int hour, int min, int sec)
        {
            for (int h = hour; h >= 0; h--)
            {
                for (int m = min; m >= 0; m--)
                {
                    for (int s = sec; s >= 0; s--)
                    {
                        Console.WriteLine("남은 시간 : {0}시 {1}분 {2}초", h, m, s);
                        Thread.Sleep(500);
                    }
                    sec = 59;
                }
                min = 59;
            }
            Console.WriteLine("시간이 종료되었습니다 !");
        }

        //스탑워치(시작만 함)
        public static void printStopWatch()
        {
            int m = 0;
            int s = 500;

            while (true)
            {
                Console.WriteLine("{0}분 {1}.{2}초", m, s/10, s%10);
                Thread.Sleep(100);
                s += 1;
                if (s == 600)
                {
                    m += 1;
                    s = 0;
                }
            }
        }

        //초단위로 현재시간 출력
        public static void printTime()
        {
            while (true)
            {
                int h = DateTime.Now.Hour;
                int m = DateTime.Now.Minute;
                int s = DateTime.Now.Second;

                Thread.Sleep(1000);
                Console.WriteLine("{0}시 {1}분 {2}초", h, m, s);
            }
        }

        public static void Main()
        {
            //Timer.PrintSec(10);
            Console.WriteLine("Bye");
            //printTimer(1, 1, 20);
            printStopWatch();
            //printTime();
        }
    }
}
