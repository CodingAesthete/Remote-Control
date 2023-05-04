using System;
using System.Globalization;
using System.Text;

namespace RemoteControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetTV();
            PowerButton powBut = new PowerButton(TV);
            VolumeButton volBut = new VolumeButton(TV);
            powBut.Execute();
            if (powBut.IsOn())
            {
                volBut.Execute();
                volBut.Undo();
            }
            powBut.Undo();

            //IDrivable car = new Vehicle("Mercedes", 4, 200);
            //Console.WriteLine(car.Speed);
            //Console.WriteLine(car.Wheels);
            //car.Move();
            //car.Stop();

            //Shape shape = new Rectangle(5,6);
            //Console.WriteLine(shape.Area());
            //shape.GetInfo();


            //Animal animal = new Cat("Dog", "Bau", "Cow");
            //animal.MakeSound();
            //Animal animal2 = new Cat("Cat", "Meow");
            //animal2.MakeSound();
            ////Animal animal3 = new Cat("Shery");
            ////animal3.MakeSound();
            ////Animal animal4 = new Cat();
            ////animal4.MakeSound();
            //Console.WriteLine(animal.Name);
            //Console.WriteLine(animal.Sound);
            //Console.WriteLine(Animal.NumberOfAnimals);
            //Console.WriteLine(animal.Owner);
            //animal.Owner = "Mira";
            //Console.WriteLine(animal.Owner);
            //Console.WriteLine(animal.id);
            ////animal.Sound2 = "Grrr";
            ////Console.WriteLine(animal.Sound2);

            //Console.WriteLine(ShapeMath.GetArea("triangle", 3, 4));

        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with code {(int)cc}.");
        }

        public enum CarColor:byte
        {
            Orange=1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void DateTime()
        {
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine(awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine(awesomeDate.DayOfWeek);
            Console.WriteLine(awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine(lunchTime.ToString());
        }

        static void MethodOverLoading()
        {
            SayHello();
            Console.WriteLine(DefineAge(1998));
            GetExpAfter10Years(1, out int solution);
            Console.WriteLine(solution);
            int num = 1;
            RefFunc(ref num);
            Console.WriteLine(num);
            Console.WriteLine(GetMore(1, 2));
            SheryCat(num: 4, name: "Shery");

            Console.WriteLine(GetNum(1, 2));
            Console.WriteLine(GetNum("1", "2"));
        }

        static int GetNum(int first, int second)
        {
            return first + second;
        }

        static int GetNum(string first, string second)
        {
            return int.Parse(first) + int.Parse(second);
        }

        static void SheryCat(string name, int num)
        {
            Console.WriteLine($"Name: {name}, Num: {num}");
        }
        static void RefFunc(ref int num)
        {
            num *= 2;
        }

        static void GetExpAfter10Years(int x, out int solution)
        {
            solution = x + 10;
        } 

        private static void SayHello()
        {
            string name = "";
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        private static double GetMore(params double[] nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }
            return sum;
        }

        private static string DefineAge(int yearOfBirth, int currYear = 2022)
        {
            int age = currYear - yearOfBirth;
            return string.Format($"Your age is: {age}.");
        }

        static void Random()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);
            int myNum = 0;

            do
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                myNum = int.Parse(Console.ReadLine());
            }
            while (rndNum != myNum);

            Console.WriteLine($"You guessed it right! It was {rndNum}.");
        }

        static void TryCatchFinally()
        {
            int num1 = 5;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }
        }

        static void ArraysAndMatrixes()
        {
            string[,] matrix = new string[2, 2]
            {
                {"Bob", "Smith" },
                { "Luca", "Marin"}
            };

            Console.WriteLine(matrix[0, 1]);
            Console.WriteLine(matrix.GetValue(0, 1));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }

            int[] arr = { 1, 4, 5, 9 };
            PrintArray(arr, "Num");

            Array.Sort(arr);
            Array.Reverse(arr);
            //Console.WriteLine(Array.IndexOf(arr, 5));

            int[] srcArr = { 1, 5, 7, 3 };
            int[] destArr = new int[3];
            Array.Copy(srcArr, 0, destArr, 0, 3);

            foreach (var num in destArr)
            {
                Console.WriteLine(num);
            }

            int[] srcArr2 = { 1, 5, 7, 3 };
            Array instArr = Array.CreateInstance(typeof(int), 10);
            srcArr2.CopyTo(instArr, 4);

            foreach (var num in instArr)
            {
                Console.WriteLine(num);
            }
        }

        static void PrintArray(int[] arr, string msg)
        {
            foreach (var num in arr)
            {
                Console.WriteLine($"{msg}: {num}");
            }
        }
    }
}
