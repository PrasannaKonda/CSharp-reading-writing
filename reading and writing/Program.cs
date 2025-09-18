using System;
using System.Threading;

namespace ThreadingExamples
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("The sum is "+ sum);
        }
        public static void Main()
        {
            Console.WriteLine("Please enter a number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);

            Number number = new Number(target,callback);
            //Thread T = new Thread(new ThreadStart(number.SumOfNumbers));
            Thread T = new Thread(number.SumOfNumbers);
            T.Start();
        }
    }

    class Number
    {
        int _target;
        SumOfNumbersCallback _callbackMethod;
        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        public void SumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum += i;
               
            }
            if (_callbackMethod != null)
                _callbackMethod(sum);
        }
    }
}