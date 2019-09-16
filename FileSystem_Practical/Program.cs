using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem_Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //string path = "D:\\7\\1.txt";
            //MyInfo info = new MyInfo();
            //using (var str = new StreamWriter(path))
            //{
            //    str.WriteLine(info.Name);
            //    str.WriteLine(info.Surname);
            //    str.WriteLine(info.Age);
            //}

            //задание 2
            int AllSymbolsCount = 256;
            char[] AllSymbols = new char[AllSymbolsCount];
            for (int i = 0; i < AllSymbols.Length; i++)
            {
                AllSymbols[i] = (char)(i);
            }
            byte[] byteSymbols;
            using (FileStream stream = new FileStream("D:\\7\\2.txt", FileMode.OpenOrCreate))
            {
                byteSymbols = new byte[stream.Length];
                stream.Read(byteSymbols, 0, byteSymbols.Length);
            }
            for(int i = 0; i < AllSymbols.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < byteSymbols.Length; j++)
                {
                    if (AllSymbols[i] == (char)byteSymbols[j])
                    {
                        count++;
                    }    
                }
                Console.WriteLine(AllSymbols[i] + " - " + count);
            }
            Console.ReadLine();
        }
    }
}
