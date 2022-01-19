using ConsoleApp1.Extensions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public class LengthValidator : Validate
    {
        public override bool IsValid(string str)
        {
            return str.Length > 15 ? true : false;
        }
    }
}
