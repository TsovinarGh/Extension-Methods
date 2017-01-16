using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool IsPolindrom(this string str, bool ignorUpperCase)
        {
            string temp;
            if (ignorUpperCase)
            {
                temp = str.ToLower();
            }
            else
            {
                temp = str;
            }
            var strbld = new StringBuilder();

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                strbld.Append(temp[i]);
            }
            return (temp == strbld.ToString());
        }

        public static int SumOfDigets(this int a)
        {
            int sum = 0;
            while (a / 10 != 0)
            {
                sum = (sum + a % 10);
                a = a / 10;
            }
            return (sum + a);
        }

        public static bool IsPrime(this int a)
        {
            int temp = a;
            if (a == 0 || a == 1)
                return false;
            if (a < 0)
            {
                temp = a * (-1);
            }
            for (int j = 2; j <= temp / 2; j++)
            {
                if (a % j == 0)
                    return false;
            }
            return true;
        }

        //Կատարյալ թիվ, այն բնական թիվն է, որը հավասար է իրենից բացի, իր բոլոր բաժանարարների գումարին։
        public static bool IsPerfect(this int num)
        {
            int sum = 0;
            if (num == 0 || num == 1)
                return false;
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum + 1 == num)
                {
                    return true;
                }
                else
                    return false;
            }
        }

    }

}

