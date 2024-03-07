using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Final.Task._9.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEneteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }

                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение!");
                }

            }

        }

        static void ShowNumber(int number)
        {
            string[] strings = { "Зайцев", "Фролов", "Васькин", "Капустин", "Пирожков" };

            switch (number)
            {
                case 1:
                    Array.Sort(strings);
                    string sr = string.Join(",", strings);
                    Console.WriteLine(sr);
                    break;
                case 2:
                    Array.Sort(strings);
                    Array.Reverse(strings);
                    string str = string.Join(",", strings);
                    Console.WriteLine(str);
                    break;

            }

        }
    }
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEneteredEvent;

        public void Read()
        {
            Console.WriteLine("Необходимо ввести значение: либо 1, либо 2");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEneteredEvent?.Invoke(number);
        }
    }
}