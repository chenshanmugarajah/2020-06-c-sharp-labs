using System;

namespace lab_30_basic_event
{
    class Program
    {
        //1.
        delegate void MyDelegate();
        //2.
        static event MyDelegate MyEvent;


        delegate string MathDelegate(int x, int y);

        static event MathDelegate MathEvent;

        static void Main(string[] args)
        {
            // two types of events
            //user events - onclick
            //data events

            // 1. create delegate
            // 2. create null event
            // 3. Add += or Remove -= methods
            // 4. call event

            //3.
            MyEvent += Method01;
            MyEvent += Method02;
            MyEvent += Method03;

            //4.
            //MyEvent();

            MathEvent += chen1;
            MathEvent += chen2;

            MathEvent(2, 3);

        }

        static string chen1(int i, int j)
        {
            return $"the sum of  {i} and  {j} is {i + j}";
        }

        static string chen2(int i, int j)
        {
            return $"the product of  {i} and  {j} is {i * j}";
        }

        static void Method01()
        {
            Console.WriteLine("running method 01");
        }

        static void Method02()
        {
            Console.WriteLine("running method 02");
        }

        static void Method03()
        {
            Console.WriteLine("running method 03");
        }
    }
}
