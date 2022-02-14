using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1ci-versiya
            //int[] Points = { 70, 65, 100, 90, 30, 95, 40 };
            //int Students = Points.Length;
            //int Result = Solve(Points,ref Students );
            //Solve(ref Result,ref Students);

            //Console.WriteLine(Result);
            #endregion

            #region 2ci-versiya
            //int[] Points = { 70, 65, 100, 90, 30, 95, 40 };
            //int Students = Points.Length;
            //int Sum = Solve(Points, ref Students);
            //int Result=Solve(Sum, ref Students);

            //Console.WriteLine(Result);
            #endregion




            #region 3cu versiya
            //int[] Points = { 70, 65, 100, 90, 30, 95, 40 };
            //int Result = Find(Points, Points.Length);
            //Find(ref Result,Points.Length);

            //Console.WriteLine(Result);


            #endregion


        }
        public static int Solve(int[] arr,ref int num)
        {
            int sum = 0;
            for (int i = 0; i <num; i++)
            {
                sum += arr[i];
            }


            return sum;
        }
        public static int Solve(ref int num, ref int num1)
        {
            num /= num1;

            return num;
        }

        public static int Solve(int num, ref int num1)
        {
            num /= num1;

            return num;
        }



        public static int Find(int[] arr,int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }


            return sum;
        }
        public static int Find(ref int num,int num1)
        {
            num /= num1;

            return num;
        }

    }
}
