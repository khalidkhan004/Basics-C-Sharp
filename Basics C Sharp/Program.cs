using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_Sharp
{
    class Program
    {
        static void Great()
        {
            Console.WriteLine("good morning khalid");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello Khalid khan");
            Console.WriteLine("I Love C#");


            int temp = 34;
            Console.WriteLine("Hello khalid khan the number is " + temp);


            //Data types Exaples:
            //intergar variables
            //string
            //float
            //boolean
            //chararcter




            /// string first = Console.ReadLine();
            // string last = Console.ReadLine();
            // Console.WriteLine("hellow " +first + last);


            //DataTyep Examples
            int a = 34;
            float b = 34.4F;
            double c = 33.4D;
            bool great = false;
            char d = 'h';
            string e = "this is a string";
            Console.WriteLine( a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(great);
            Console.WriteLine(d);
            Console.WriteLine(e);
            int aa = 44;
            int bb = 10;
            Console.WriteLine("the sum is " + (Convert.ToInt32(aa) + Convert.ToInt32(bb)));
            int aaa = 44;
            int bbb = 10;
            Console.WriteLine("the sum is " + (Convert.ToInt32(aaa) * Convert.ToInt32(bbb)));
          


            //data type Casting Examples
            //also example of explicit casting
            int x = (int)3.6;
            Console.WriteLine(x);


            //implicit cating examoples
            //char to int to long to double
            int z = 'y';
            Console.WriteLine(z);




            /*Operator in C#
             * Arithematic operator
             * Assignment operator
             * logical operator
             * Comparison operator
            */
            // Arithematic operator
            int ab = 4;
            int ac = 3;
            Console.WriteLine("the Sum is:" + (ab + ac));
            Console.WriteLine("the sub is:" + (ab - ac));
            Console.WriteLine("the mul is:" + (ab * ac));
            Console.WriteLine("the div is:" + (ab / ac));


            //Assignment operator
            int g = 4;
            int f = g;
            f += 4;
            f -= 4;
            f *= 4;
            f /= 4;
            Console.WriteLine(f);

            //logical operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            //Comparison operator
            Console.WriteLine(33 > 5);
            Console.WriteLine(5 > 55);





            int s = Math.Max(33, 444);
            double v = Math.Sqrt(77);
            Console.WriteLine(s);
            Console.WriteLine(v);

            string hello = "this is khalid khan";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());



            //Condition
            //if else statement
            //Console.WriteLine("Enter yoyur age");
            //string agestr =Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //if (age<2)
            //{
            //    Console.WriteLine("you are a baby");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("Please finish your high school");
            //}

            //else if (age < 18)
            //{
            //    Console.WriteLine("you are below 18");
            //}
            //else if (age < 75)
            //{
            //    Console.WriteLine("you can drive");
            //}
            //else
            //{
            //    Console.WriteLine("you canoot drive");
            //}




            //loops in c sharp
            //int i = 0;
            //while (i<5)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i > 5);


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i + 1);
            }



            Great();
            Great();



                Console.ReadLine();
        }
    }
}
