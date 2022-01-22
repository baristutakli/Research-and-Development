using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_Reflections.Abstract
{
    public abstract class Validator
    {
        public abstract bool IsValid(string newString);
    }
}
