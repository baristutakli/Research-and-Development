using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_Reflections.Abstract
{
    public class LengthValidator : Validator
    {
        public override bool IsValid(string newString)
        {
            return newString.Length > 15 ? true : false;
        }
    }
}
