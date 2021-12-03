using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int q1, q2, q3, mt, f;
            // getting scores for demo program 
            Console.WriteLine("First Quiz grade");
            q1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second Quiz grade");
            q2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Third Quiz grade");
            q3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mid-term grade");
            mt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Final Exam grade");
            f = Int32.Parse(Console.ReadLine());

            // creating the student object 
            StudentRecord s1 = new StudentRecord(q1, q2, q3, mt, f);

            // displaying the tostring
            Console.WriteLine(s1.ToString());

            Console.ReadLine();
        }
    }
}
