using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Task._9.Task1
{
    class Program1
    {
        public static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            task1.TaskException();
        }

    }

    public class MyException : Exception
    {
        public MyException()
        {

        }

        public MyException(string message) : base(message)
        {


        }

    }

    public class Task1
    {
        internal void TaskException()
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new MyException("Некорректный возраст");
            exceptions[1] = new ArgumentNullException("Аргумент, передаваемый в метод — null");
            exceptions[2] = new DivideByZeroException("Деление на ноль");
            exceptions[3] = new IndexOutOfRangeException("Индекс вне заданных пределов");
            exceptions[4] = new ArgumentOutOfRangeException("Аргумент вне заданных пределов");

            foreach (Exception exception in exceptions)
            {
                try
                {
                    throw exception;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
            }
        }
    }
}