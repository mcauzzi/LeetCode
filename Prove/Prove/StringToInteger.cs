using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Prove
{
    class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            int result = 0;
            if (str.Length == 0)
            {
                return 0;
            }
            str=str.TrimStart(' ');
            Regex reg = new Regex(@"(^[\+-]*[0-9]+)");
            var s = reg.Match(str).ToString();
            if (s.Contains(" "))
            {
                return 0;
            }
            bool neg = false;

            if (s.Count() == 0)
            {
                return 0;
            }

            for (int i = 0; (s.ElementAt(0) == '-' || s.ElementAt(0) == '+'); i++)
            {
                if (i == 1) { return 0; }
                if (s.ElementAt(0) == '-')
                {
                    neg = true;
                    s = s.Remove(0, 1);
                }
                else if (s.ElementAt(0) == '+')
                {
                    s = s.Remove(0, 1);
                }
            }

            s = s.TrimStart('0');
            int len = s.Count();

            foreach (char c in s)
            {
                try
                {
                    result = checked(result + (c - '0') * (int)Math.Pow(10, (--len)));
                }
                catch (Exception)
                {
                    if (neg)
                    {
                        return int.MinValue;
                    }
                    else
                    {
                        return int.MaxValue;
                    }
                }
            }

            if (neg)
            {
                result *= -1;
            }

            return result;
        }

    }
}
