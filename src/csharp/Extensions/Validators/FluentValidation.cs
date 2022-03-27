using Extensions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions
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
        public static void deneme(this string param, params Validate[] args)
        {
            Console.WriteLine(args.Length);
            foreach (var item in args)
            {
                Console.WriteLine(item.IsValid(param));
            }

        }

        public static bool IsDigit(this string param)
        {
            return param.IsDigit();
        }

        public static bool IsUpper(this string param)
        {
            return param == param.ToUpper() ? true : false;
        }

        public static bool IsLower(this string param)
        {
            return param == param.ToLower() ? true : false;
        }

    }
}
