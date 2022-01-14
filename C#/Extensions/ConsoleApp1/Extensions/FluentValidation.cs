using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class FluentValidation
    {
        public static bool IsNotNullAndNotEmpty(this string email)
        {
            
            return email is not null && email != "";
        }

        public static bool IsLongEnough(this string email)
        {
            return email.Length > 15 ? true:false;
        }
        public static bool IsStrongEnough(this string email)
        {
            bool IsStrong = true;
            List<string> patterns= new List<string> { @"[A-Z]", @"[a-z]", @"[0-9]", @"\W" };
          
            MatchCollection regex;
            patterns.ForEach(pattern =>
            {
                regex = Regex.Matches(email, pattern);
                if (regex.Count==0)
                {
                    IsStrong = false;
                }
            }

            );

            return email.IsLongEnough() && IsStrong ? true : false;


        }
    }
}
