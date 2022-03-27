using Extensions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class LengthValidator : Validate
    {
        public override bool IsValid(string str)
        {
            return str.Length > 15 ? true : false;
        }
    }
}
