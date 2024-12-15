using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region 11 - Write a program to input the month number and print the number of days in that month.
            //int num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter a number from 1 to 12");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}while (!flag);

            //switch (num)
            //{ 
            //    case 1:Console.WriteLine(31);
            //        break;
            //    case 2:
            //        Console.WriteLine(29);
            //        break;
            //    case 3:
            //        Console.WriteLine(31);
            //        break;
            //    case 4:
            //        Console.WriteLine(30);
            //        break;
            //    case 5:
            //        Console.WriteLine(31);
            //        break;
            //    case 6:
            //        Console.WriteLine(30);
            //        break;
            //    case 7:
            //        Console.WriteLine(31);
            //        break;
            //    case 8:
            //        Console.WriteLine(31);
            //        break;  
            //    case 9:
            //        Console.WriteLine(30);
            //        break;
            //    case 10:
            //        Console.WriteLine(31);

            //        break;

            //    case 11:
            //        Console.WriteLine(30);
            //        break;
            //    case 12:
            //        Console.WriteLine(31);
            //        break;

            //    default:
            //        Console.WriteLine("number out of range");
            //        break;
            //}
            #endregion
            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //double x1 = ReadCoordinate("x1");
            //double y1 = ReadCoordinate("y1");


            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double x2 = ReadCoordinate("x2");
            //double y2 = ReadCoordinate("y2");


            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double x3 = ReadCoordinate("x3");
            //double y3 = ReadCoordinate("y3");

            //double sum = 0.5 * (x1 * (y2 - y3)+x2 * (y3-y1)+x3 * (y1-y2));
            //if ( Math.Abs(sum) == 0)
            //    Console.WriteLine("these points lie on a single straight line");

            //else
            //    Console.WriteLine("these points is not lie on a single straight line");




            #endregion
            #region  18 - Within a company, the efficiency of workers is evaluated based on the
            //double num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    flag = double.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //if (num >= 2 && num < 3)
            //    Console.WriteLine(" they are considered highly efficient");
            //else if (num >= 3 && num < 4)
            //    Console.WriteLine(" they are instructed to increase their speed. ");
            //else if (num >= 4 && num <= 5)
            //    Console.WriteLine("they are provided with training to enhance their speed.");
            //else if (num > 5)
            //    Console.WriteLine("hey are required to leave the company. ");
            //else
            //    Console.WriteLine("Time is too short to evaluate efficiency.");




            #endregion
            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int a = 10;
            //int b = a;
            //a = 20;
            // assign in b value of a just copy to its value and modfication in a not effect b b still 10 and a after modifyication become 20


            #endregion
            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //    point pt1 = new point { x = 1, y = 2 };
            //    point pt2 = new point {x = 3, y = 4};
            //    pt2 = pt1;
            //    pt1.x = 5;
            //// reference of pt1 point to object in heap and pt2 point to another object in heap after assignment pt2 point to same
            //// object and its old object become non reachable object and if change in pt1 will effect pt2 also
            #endregion
            #region Which of the following statements is correct about the C#.NET code snippet given below?

            //A value 1 will be assigned to d.

            #endregion
            #region Which of the following is the correct output for the C# code given below?
            //6 1


            #endregion
            #region What will be the output of the C# code given below?
            // 7 7

            #endregion
        }

        static double ReadCoordinate(string coordinateName)
        {
            double coordinate;
            bool isValid;

            do
            {
                Console.Write($"Enter {coordinateName}: ");
                isValid = double.TryParse(Console.ReadLine(), out coordinate);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            } while (!isValid);

            return coordinate;
        }
        static int Pow(int n,int ex)
        {
            if (ex == 0) return 1;
         return n *Pow(n, --ex);
        }
    }
}
