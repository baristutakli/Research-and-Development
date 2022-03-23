using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAutoMapper
{
   public abstract class Profile
    {
        public TTarget CreateMap<TSource, TTarget>(TSource source)
        {

            Type sourceObj = source.GetType();
            Type targetObjType = typeof(TTarget);
            TTarget targetObj = (TTarget)Activator.CreateInstance(targetObjType);
            
            foreach (PropertyInfo property in sourceObj.GetProperties())
            {
                if (targetObj.GetType().GetProperty(property.Name) != null)
                {
                    var result = property.GetValue(source);
                    targetObj.GetType().GetProperty(property.Name).SetValue(targetObj, result, null);
                }
            }
            return targetObj;
        }
    }
}
