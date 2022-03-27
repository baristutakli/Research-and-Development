using AttibutesAndReflection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutesAndReflection
{
    public static class Extensions
    {
        public static bool Validate(this string str, params Validator[] validators)
        {
           
            foreach (var validator in validators)
            {
                
                if (!validator.IsValid(str))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
