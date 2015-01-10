using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static int Main(string[] args)
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int compare = DateTime.Compare(birthday, now);
            int result = 0;
            if (compare > 0)
            {
                Console.WriteLine("You are not born!");
            }
            else
            {
                if (now.Month > birthday.Month)
                {
                    result = now.Year - birthday.Year;
                }
                else if (now.Month == birthday.Month && now.Day >= birthday.Day)
                {
                    result = now.Year - birthday.Year;
                }
                else
                    result = now.Year - birthday.Year - 1;
            }
            Console.WriteLine("You are {0} years old!",result);
            Console.WriteLine("After 10 years you will be {0} years old", result + 10);
            return result;

           
        }
    }
}
