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
        /// <summary>
        /// This method takes one object as a paramater and returns the target object.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public TTarget CreateMap<TSource, TTarget>(TSource source)
        {
            // gets the type of the target object
            Type targetObjType = typeof(TTarget);
            // creates an instance of the target object
            TTarget targetObj = (TTarget)Activator.CreateInstance(targetObjType);
            // loop through the properties
            foreach (PropertyInfo property in source.GetType().GetProperties())
            {
                if (targetObj.GetType().GetProperty(property.Name) != null)
                {
                    // sets value 
                    targetObj.GetType().GetProperty(property.Name).SetValue(targetObj, property.GetValue(source), null);
                }
            }
            return targetObj;
        }

    }
}
