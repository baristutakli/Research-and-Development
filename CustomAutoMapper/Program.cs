﻿using System;
using System.Reflection;
using System.Linq;
namespace CustomAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User user = new User() { Id=1, FirstName="sad", LastName="asdas", Password="asdas", UserName="username",CreatedAt=DateTime.Now };
            Type userObj = user.GetType();
            Type vw = typeof(GetUserViewModel);
            GetUserViewModel newVM = new GetUserViewModel();
            foreach (PropertyInfo property in userObj.GetProperties())
            {
               // Console.WriteLine($"property name: {property.Name} --- {property.GetValue(user)}");
                if (newVM.GetType().GetProperty(property.Name) != null)
                {
                    var prop = vw.GetProperty(property.Name);
                    newVM.GetType().GetProperty(prop.Name).SetValue(newVM, property.GetValue(user));
                   
                }
            }
            Console.WriteLine($"Firstname:{newVM.FirstName} LastName:{newVM.LastName} username:{newVM.UserName}  date:{newVM.CreatedAt}");

        }

  
    }
}
