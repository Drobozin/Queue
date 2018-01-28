using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Список ComplexClass: ");
            List complexList = new List();
            complexList.Enqueue(new ComplexClass(2, 6));
            complexList.Enqueue(new ComplexClass(4, 7));
            complexList.Enqueue(new ComplexClass(8, 5));
            complexList.Enqueue(new ComplexClass(3, 2));
            complexList.Print();
            Console.WriteLine("\n");
            complexList.Deque();
            complexList.Print();

            Console.WriteLine($"\nКоличество чисел в списке: {complexList.Count}\n");
            Console.WriteLine($"\nПервое число в списке: {complexList.Peek()}\n");

            Console.ReadLine();
        }
    }
}
