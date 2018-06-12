using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABC";
            char[] s_list = s.ToCharArray();
            Perm(s_list);
        }

        static void Perm(char[] list)
        {
            Perm(list, 0, (list.Length - 1));
        }

        static void Perm(char[] list, int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(list); ;
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    //Console.WriteLine("First line: i: "+ i + "  a: "+ a+"  b: "+b);
                    swap(ref list[a], ref list[i]);
                    //Console.WriteLine("Before Perm: i: " + i + "  a: " + a + "  b: " + b);
                    Perm(list, a+1, b);
                    //Console.WriteLine("After Perm: i: " + i + "  a: " + a + "  b: " + b);
                    swap(ref list[a], ref list[i]);
                    //Console.WriteLine("Last line: i: " + i + "  a: " + a + "  b: " + b);
                }
            }
        }

        static void swap(ref char a, ref char b)
        {
            //Console.WriteLine("In swap : a:  "+ a + "  b:  "+b);
            if (a == b)
                return;

            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
