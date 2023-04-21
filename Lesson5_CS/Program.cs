using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //регулярные выражения
using System.IO;

namespace Lesson5_CS
{
    delegate void myDel(string _text);
    internal class Program
    {
        static void Print(string _text)
        {
            Console.WriteLine(_text);
        }
        static void WriteToFile(string _text)
        {
            string _name = "output.txt";
            var sr = new StreamWriter(_name, true);
            sr.WriteLine(_text);
            sr.Close();
            //using (var sr01 = new StreamWriter(_name))
            //{
            //    sr01.WriteLine(_text, true);
            //}            
        }
        static void Main(string[] args)
        {
            myDel output;
            output = Print;
            output += WriteToFile;
            //output($"Hello! {DateTime.Now}");
            //output.Invoke($"Hello! {DateTime.Now.ToString("HH:mm:ss.fff")}");
            output.Invoke(null);
            output(null);
        }
    }
}
