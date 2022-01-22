using Attributes_Reflections.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_Reflections
{
    class CamelValidator : Validator
    {
        public override bool IsValid(string newString)
        {
            return Char.IsUpper( newString[0]) ? true : false;
        }
    }
}
