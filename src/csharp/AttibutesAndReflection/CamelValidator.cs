using AttibutesAndReflection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutesAndReflection
{
    class CamelValidator : Validator
    {
        public override bool IsValid(string newString)
        {
            return Char.IsUpper( newString[0]) ? true : false;
        }
    }
}
