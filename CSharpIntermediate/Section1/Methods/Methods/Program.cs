
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        private const int NSteps = 1000000000;

        private static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            double serialPi = SerialEstimationOfPi();
            s1.Stop();
            System.Console.WriteLine("Serial: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double naiveParallelPi = NaiveParallelPi();
            s1.Stop();
            System.Console.WriteLine("Naive Parallel: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double parallelpi = ParallelPi();
            s1.Stop();
            System.Console.WriteLine("Parallel: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double parallelPartitionerPi = ParallelPartitionerPi();
            s1.Stop();
            System.Console.WriteLine("Parallel with partitioner: {0}", s1.ElapsedMilliseconds);
            
        }

        private static double SerialEstimationOfPi()
        {
            double sum = 0.0;
            double step = 1.0/(double) NSteps;

            for (int i = 0; i < NSteps; i++)
            {
                double x = (i + 0.5)*step;
                double partial = 4.0/(1.0 + x*x);
                sum += partial;
            }
            return step*sum;
        }

        private static double NaiveParallelPi()
        {
            double sum = 0.0;
            double step = 1.0/(double) NSteps;
            object obj = new object();
            Parallel.For(0, NSteps, i =>
            {
                double x = (i + 0.5)*step;
                double partial = 4.0/(1.0 + x*x);
                lock (obj) sum += partial;
            });
            return step*sum;
        }

        private static double ParallelPi()
        {
            double sum = 0.0;
            double step = 1.0/(double) NSteps;
            object obj = new object();
            Parallel.For(0, NSteps,
                () => 0.0,
                (i, state, partial) =>
                {
                    double x = (i + 0.5)*step;
                    return partial + 4.0/(1.0 + x*x);
                },
                partial => { lock (obj) sum += partial; });
            return step*sum;
        }

        private static double ParallelPartitionerPi()
        {
            double sum = 0.0;
            double step = 1.0/(double) NSteps;
            object obj = new object();
            Parallel.ForEach(Partitioner.Create(0, NSteps),
                () => 0.0,
                (range, state, partial) =>
                {
                    for (int i = range.Item1; i < range.Item2; i++)
                    {
                        double x = (i + 0.5)*step;
                        partial += 4.0/(1.0 + x*x);
                    }
                    return partial;
                },
                partial => { lock (obj) sum += partial; });


            return step*sum;

            //    static void UseOutModifier()
            //{
            //    try
            //    {
            //        var num = int.Parse("abc");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Conversion failed.");
            //    }


            //    int number;
            //    var result = int.TryParse("abc", out number);
            //    if (result)
            //        Console.WriteLine(number);
            //    else
            //        Console.WriteLine("Conversion failed.");

            //}

            //static void UseParams()
            //{
            //    var calculator = new Calculator();
            //    Console.WriteLine(calculator.Add(1, 2));
            //    Console.WriteLine(calculator.Add(1, 2, 3));
            //    Console.WriteLine(calculator.Add(1, 2, 3, 4));
            //    Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
            //}

            //static void UsePoints()
            //{
            //    try
            //    {
            //        var point = new Point(10, 20);
            //        point.Move(null);
            //        Console.WriteLine($"Point is at ({point.X}, {point.Y})" );

            //        point.Move(100, 200);
            //        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("An unexpected error occured.");
            //    }
            //}
        }
    }
}
