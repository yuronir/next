using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace next._0509_10week
{
    class FileTest
    {
        public static void Main()
        {
            //ReadFile("sevenbit.txt");
            WriteFile(@"C:\bird\birdIsCheckCheck.txt", true, "bye"); // 앞의 @는 경로라는 뜻.(\때문에 쓴다. \를 다 \\라고 써도 됨.)
        }

        //파일을 읽는 순서 : 연다->읽는다->닫는다! (꼭 닫아라!)
        public static void ReadFile(string name)
        {
            string dir = Directory.GetCurrentDirectory();
            string fullname = dir + "\\" + name; //\\라고 써야 \가 입력된다.(특수문자라서)
            int lineNum = 1;
            Console.WriteLine(fullname);
            
            StreamReader r = new StreamReader(fullname, Encoding.GetEncoding("euc-kr")); //한글이 깨지지 않게 인코딩 유형 지정

            //while(r.Peek() != -1) : 아래와 같은 것.
            while (!r.EndOfStream)
            {
                int x = r.Peek();
                Console.WriteLine(x + " : " + lineNum + "th Line : " + r.ReadLine());
                lineNum++;
            }

            r.Close(); //닫아주지 않으면 메모리 릭 발생할 수 있다.
        }

        public static void WriteFile(string fullpath, bool append, string end) //이미 파일명이 존재할 시 : append가 true -> 기존 파일을 날리고 새로 만듦
        {
            int lineNum = 1;

            try
            {
                StreamReader r = new StreamReader(fullpath, Encoding.GetEncoding("euc-kr"));

                while (!r.EndOfStream)
                {
                    r.ReadLine();
                    lineNum++;
                }

                r.Close();
            }
            catch { }
  
            StreamWriter sw = new StreamWriter(fullpath, append,
                Encoding.GetEncoding("euc-kr"));

            while (true)
            {
                Console.Write("Yawol $ ");
                string comment = Console.ReadLine();
                
                if (comment == end) 
                    break;

                sw.WriteLine(lineNum + "th comment : " + comment);
                lineNum++;
            }

            sw.Close();
        }
    }
}
