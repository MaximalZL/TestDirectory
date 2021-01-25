using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double x)
        {
            var first = Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0);
            var second = Math.Cbrt(Math.Log10(Math.Pow(x, 2)));
            var y = first + second;
            return y;
        }

        public static (double x, double y)[] TaskA(double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static (double x, double y)[] TaskB(double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(1.25, 3.25, 0.4);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.84, 2.71, 3.81, 4.56, 5.62 };
            var taskB = TaskB(xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Maksim Zorin");
            Console.WriteLine("-----------------------------------");
            double getSpeed = 45.7;
            double getTimeWay = 12.5;
            Car car1 = new Car();
            if (getSpeed != 0 && getTimeWay == 0)
            {
                car1 = new Car(getSpeed);
            }
            else
            {
                car1 = new Car(getSpeed, getTimeWay);
            }

            Bicycle bicycle1 = new Bicycle(15);
            Console.WriteLine("Bicycle: ");
            Console.WriteLine(bicycle1);
            Console.WriteLine(" ");
            bicycle1.Go();
            Motocycle motocycle1 = new Motocycle(100, 90);
            motocycle1.Go();
            car1.Go();
            Console.WriteLine("Car: ");
            Console.WriteLine($"{car1.GetInfo().Item1} {car1.GetInfo().Item2}");
            car1.Stop();
            Console.WriteLine($"{car1.GetInfo().Item1} {car1.GetInfo().Item2}");
            motocycle1.Stop();
            Console.WriteLine(" ");
            Console.WriteLine("Motocycle: ");
            Console.WriteLine(motocycle1);
            bicycle1.Stop();
            Transport[] elementsOfSuperClass = new Transport[] { car1, bicycle1, motocycle1 };
            foreach (var transport in elementsOfSuperClass)
            {
                transport.MakeSignal();
            }

            Console.WriteLine("-------------------------------------------\n");
            Transport machine = new Car();
            int year = 2001;
            int month = 12;
            int day = 6;
            DateTime birth = new DateTime(year, month, day);
            DateTime now = new DateTime(2020, 12, 8);
            Console.WriteLine(machine.Age(now, birth));
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("------------RPG--------------\n");
            Console.WriteLine("------------------------------\n");
            Game game = new Game();
            game.Launch();
        }
    }
}