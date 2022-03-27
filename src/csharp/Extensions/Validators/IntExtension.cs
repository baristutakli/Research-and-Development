using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int i, int number) {
            return i > number;
        }
    }
}
