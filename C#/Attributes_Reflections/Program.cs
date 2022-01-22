namespace Attributes_Reflections
{
    using Attributes_Reflections.Abstract;
    using System;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            //Type obj = typeof(Ogrenci);
            //Console.WriteLine("Method infos");
            //foreach (MethodInfo item in obj.GetMethods())
            //{
            //    Console.WriteLine($"name:{item.Name} parameters:{item.GetParameters().Length} return type: {item.ReturnType}\n" +
            //        $"methodBody: {item.GetMethodBody()} ısPrivate: {item.IsPrivate} ısPublic: {item.IsPublic}\n");
            //    if (item.GetParameters().Length>0)
            //    {
            //        Console.WriteLine("param:"+item.GetParameters()[0]);
            //    }

            //}
            //Console.WriteLine("----------------------");
            //foreach (FieldInfo item in obj.GetFields())
            //{
            //    Console.WriteLine($"fieldtype: {item.FieldType} fieldName: {item.Name}");
            //}
            //Console.WriteLine("----------------------");
            //object newobj = Activator.CreateInstance(obj,5);
            //MethodInfo method= obj.GetMethod("Show");

            //Console.WriteLine(method.Invoke(newobj, null));


            //Console.WriteLine("Let's analyse System.String class\n");
            //Type obj = typeof(String);

            //string MethodInfoResult = "";
            //foreach (MethodInfo item in obj.GetRuntimeMethods())
            //{
            //    MethodInfoResult += $"Name:{item.Name}\tNumberofParameters: {item.GetParameters().Length}\tReturnType: {item.ReturnType}\n" +
            //    $"DeclaringType: {item.DeclaringType}\tIsPrivate: {item.IsPrivate}\tIsPublic: {item.IsPublic}\n" +
            //    $"Type: {item.GetType().GetTypeInfo()}";
            //    if (item.GetParameters().Length > 0)
            //    {
            //        string itemParams = "";
            //        foreach (var param in item.GetParameters())
            //        {
            //            itemParams += $"\nParam: {param}\tParamType: {param.ParameterType}";

            //        }
            //        MethodInfoResult += itemParams;
            //    }
            //    MethodInfoResult += "\n----------------------------------------\n";
            //}
            //Console.WriteLine(MethodInfoResult);


            string str = "aaaaaaaaaaaaaaaaassssaaaaa";
            Console.WriteLine(str.Validate(new Validator[1]{new LengthValidator() }));
            string str2 = "assss";
            Console.WriteLine(str2.Validate(new Validator[2] { new CamelValidator(), new LengthValidator() }));



            //Console.WriteLine("Let's analyse Attribute abstract class under System.Reflection class\n");
            //Type obj = typeof(Attribute);

            //string MethodInfoResult = "";
            //foreach (MethodInfo item in obj.GetRuntimeMethods())
            //{
            //    MethodInfoResult += $"Name:{item.Name}\tNumberofParameters: {item.GetParameters().Length}\tReturnType: {item.ReturnType}\n" +
            //    $"DeclaringType: {item.DeclaringType}\tIsPrivate: {item.IsPrivate}\tIsPublic: {item.IsPublic}\n" +
            //    $"Type: {item.GetType().GetTypeInfo()}";
            //    if (item.GetParameters().Length > 0)
            //    {
            //        string itemParams = "";
            //        foreach (var param in item.GetParameters())
            //        {
            //            itemParams += $"\nParam: {param}\tParamType: {param.ParameterType}";

            //        }
            //        MethodInfoResult += itemParams;
            //    }
            //    MethodInfoResult += "\n----------------------------------------\n";
            //}
            //Console.WriteLine(MethodInfoResult);


            //Console.WriteLine("Let's analyse System.Type derived from IReflect and MemberInfo  class\n");
            //Type obj = typeof(Type);

            //string MethodInfoResult = "";
            //foreach (MethodInfo item in obj.GetRuntimeMethods())
            //{
            //    MethodInfoResult += $"Name:{item.Name}\tNumberofParameters: {item.GetParameters().Length}\tReturnType: {item.ReturnType}\n" +
            //    $"DeclaringType: {item.DeclaringType}\tIsPrivate: {item.IsPrivate}\tIsPublic: {item.IsPublic}\n" +
            //    $"Type: {item.GetType().GetTypeInfo()}";
            //    if (item.GetParameters().Length > 0)
            //    {
            //        string itemParams = "";
            //        foreach (var param in item.GetParameters())
            //        {
            //            itemParams += $"\nParam: {param}\tParamType: {param.ParameterType}";

            //        }
            //        MethodInfoResult += itemParams;
            //    }
            //    MethodInfoResult += "\n----------------------------------------\n";
            //}
            //Console.WriteLine(MethodInfoResult);

            //Calculator cl = new Calculator();
            //cl.Square(2);
            //Console.WriteLine(cl.Square(2)+" --" +cl.Cube(2));

            //Console.WriteLine("Let's analyse Calculator  class\n");
            //Type calculator = typeof(Calculator);

            //string MethodInfoResult = "";
            //foreach (MethodInfo item in calculator.GetRuntimeMethods())
            //{
            //    MethodInfoResult += $"Name: {item.Name}";
            //    MethodInfoResult += $"\nIsPublic: {item.IsPublic}\n----- parameters-----";
            //    if (item.GetParameters().Length>0&& item.ReturnParameter!=null)
            //    {
            //        foreach (var param in item.GetParameters())
            //        {

            //            MethodInfoResult += $"\nParameter: {param}\tParameterType: {param.ParameterType}";
            //            MethodInfoResult += $"\nReturnType: {item.ReturnType}\tReturnValue:{item.ReturnParameter}";

            //        }
            //    }
            //    else
            //    {
            //        MethodInfoResult += "\nParameters not found";
            //        MethodInfoResult += $"\nThis is a public method: {item.IsPublic}";

            //    }

            //    MethodInfoResult += "\n----------------------------------------\n";
            //}
            //MethodInfoResult += $"\n--------Fields-----";

            //foreach (var fields in calculator.GetFields())
            //{
            //    MethodInfoResult += $"\nPropertyName: {fields.Name}\tPropertyType: {fields.FieldType}";

            //}

            //Console.WriteLine(MethodInfoResult);
        }
    }

    /// <summary>
    /// Defines the <see cref="MyAtt" />.
    /// </summary>
    public class MyAtt : Attribute
    {
        public string Value { get; set; }
        public MyAtt(string value)
        {
            Value = value;
        }
    }
}
