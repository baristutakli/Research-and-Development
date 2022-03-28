using System;
using System.Reflection;

namespace CustomAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            //    User user = new User() { Id = 1, firstName = "sad", LastName = "asdas", Password = "asdas", UserName = "username", CreatedAt = DateTime.Now };
            //    User user2 = new User() { Id = 2, firstName = "saasdasdad", LastName = "adsdasasdas", Password = "aadasdassdas", UserName = "username", CreatedAt = DateTime.Now };
            //    Type userObj = user.GetType();
            //    Type vw = typeof(GetUserViewModel);
            //    GetUserViewModel newVM = new GetUserViewModel();
            //    foreach (PropertyInfo property in userObj.GetProperties())
            //    {
            //        if (newVM.GetType().GetProperty(property.Name) != null)
            //        {
            //            var prop = vw.GetProperty(property.Name);
            //            newVM.GetType().GetProperty(prop.Name).SetValue(newVM, property.GetValue(user));

            //        }
            //    }
            //    Console.WriteLine($"Firstname:{newVM.FirstName} LastName:{newVM.LastName} username:{newVM.UserName}  date:{newVM.CreatedAt}");

            //    UserProfile profile = new UserProfile();
            //    var newVM = profile.CreateMap<User, GetUserViewModel>(user);
            //    Console.WriteLine($"Firstname:{newVM.FirstName} LastName:{newVM.LastName} username:{newVM.UserName}  date:{newVM.CreatedAt}");
            //    var newVM2 = profile.CreateMap<User, GetUserViewModel>(user2);
            //    Console.WriteLine($"Firstname:{newVM2.FirstName} LastName:{newVM2.LastName} username:{newVM2.UserName}  date:{newVM.CreatedAt}");

            //   // Bu assembly de olan dosyaları buluyor
            //    Type[] assembly = Assembly.GetExecutingAssembly().GetTypes();
            //    foreach (var item in assembly)
            //    {
            //        if (item.IsClass && item.BaseType.Name == "Profile")
            //            Console.WriteLine("Name: " + item);
            //    }


            //    User user = new User() { Id = 1, firstName = "sad", LastName = "asdas", Password = "asdas", UserName = "username", CreatedAt = DateTime.Now };
            //    Type userObj = user.GetType();
            //    Type vw = typeof(GetUserViewModel);
            //    GetUserViewModel newVM = new GetUserViewModel();

            //    if (userObj.GetProperties().Length > 0)
            //    {
            //        foreach (var property in userObj.GetProperties())
            //        {

            //            if (property.GetCustomAttributes(false).Length > 0)
            //            {
            //                var props = property.GetCustomAttribute<DisplayAttribute>().GetName();

            //                if (newVM.GetType().GetProperty(props) != null)
            //                {
            //                    var prop = vw.GetProperty(property.Name);
            //                    newVM.GetType().GetProperty(props).SetValue(newVM, property.GetValue(user));

            //                }
            //            }
            //            else
            //            {
            //                if (newVM.GetType().GetProperty(property.Name) != null)
            //                {
            //                    var prop = vw.GetProperty(property.Name);
            //                    newVM.GetType().GetProperty(prop.Name).SetValue(newVM, property.GetValue(user));

            //                }
            //            }

            //        }
            //    }

            //    Console.WriteLine($"Firstname:{newVM.FirstName} LastName:{newVM.LastName} username:{newVM.UserName}  date:{newVM.CreatedAt}");
            //}



        }
    }
}
