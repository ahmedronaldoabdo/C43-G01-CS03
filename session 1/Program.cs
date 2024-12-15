using System.ComponentModel;
using System.Reflection.Metadata;

namespace session_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region q1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion
            #region Q2-Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            //int num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //if (num == 0)
            //    Console.WriteLine("zero");
            //else if (num > 0)
            //    Console.WriteLine("postive");
            //else
            //    Console.WriteLine("negative");
            #endregion
            #region q3-Write a program that takes 3 integers from the user then prints the max element and the min element.

            //int num = 0, sec_num = 0, th_num = 0;

            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter three number");
            //    flag = int.TryParse(Console.ReadLine(), out num) && int.TryParse(Console.ReadLine(), out sec_num) && int.TryParse(Console.ReadLine(), out th_num);
            //} while (!flag);
            //int mx = 0, mn = 0;
            //if (num > sec_num && num > th_num)
            //    mx = num;
            //else if (sec_num >num && sec_num > th_num)
            //    mx = sec_num;
            //else
            //    mx = th_num;

            //if (num <sec_num && num < th_num)
            //    mn = num;
            //else if (sec_num < num && sec_num < th_num)
            //    mn = sec_num;
            //else

            //    mn = th_num;
            //Console.WriteLine($"\r\n    Max element = {mx}");
            //Console.WriteLine($"Min element = {mn}");
            #endregion
            #region q4-Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int num = 0;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter  number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //if (num % 2 == 0)
            //{

            //    Console.WriteLine("EVEN");
            //}
            //else
            //    Console.WriteLine("odd");
            #endregion
            #region  q5 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant)

            //char chr;
            //Console.WriteLine("Please enter char");
            //chr = (char)Console.Read();
            //if (chr == 'e' || chr == 'E' || chr == 'o' || chr == 'O' || chr == 'i' || chr == 'I' || chr == 'a' || chr == 'A' || chr == 'U' || chr == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");


            #endregion
            #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //int num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //for(int i = 1; i <=12; i++)
            //{
            //    Console.WriteLine(num * i);
            //}
            #endregion
            #region q9- Write a program that takes two integers then prints the power.
            //int num = 0, sec_num = 0;

            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter two number");
            //    flag = int.TryParse(Console.ReadLine(), out num) && int.TryParse(Console.ReadLine(), out sec_num);
            //} while (!flag);
            //if (sec_num < 0)
            //{
            //    Console.WriteLine((float)1 / Pow(num, -1* sec_num));

            //}
            //else
            //   Console.WriteLine( Pow(num, sec_num));

            #endregion
            #region -10 Write a program to enter marks of five subjects and calculate total, average and percentage.


            //int num = 0, sec_num = 0, th_num = 0,fo_num=0,fth_num=0;

            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter marks of 5  subject");
            //    flag = int.TryParse(Console.ReadLine(), out num) && int.TryParse(Console.ReadLine(), out sec_num) && int.TryParse(Console.ReadLine(), out th_num)
            //        && int.TryParse(Console.ReadLine(), out fo_num) && int.TryParse(Console.ReadLine(), out fth_num);
            //} while (!flag);
            //float sum = 0, avg = 0, precentage = 0;
            //sum += num + sec_num + th_num + fo_num + fth_num;
            //avg = sum / 5;
            //precentage = (sum / 500) * 100;
            //Console.WriteLine($"Total marks = {sum}");
            //Console.WriteLine($" Average Marks = {avg}");
            //Console.WriteLine($"Percentage = {precentage}");
            #endregion
        }
        public  static int Pow(int n,int ex)
        {
            if (ex == 0) return 1;
         return n *Pow(n, --ex);
        }
    }
}
