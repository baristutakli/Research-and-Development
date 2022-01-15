namespace Attributes_Reflections
{
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

            Console.WriteLine("Let's analyse System.String class\n");
            Type obj = typeof(String);

            string MethodInfoResult = "";
            foreach (MethodInfo item in obj.GetRuntimeMethods())
            {
                MethodInfoResult += $"Name:{item.Name}\tNumberofParameters: {item.GetParameters().Length}\tReturnType: {item.ReturnType}\n" +
                $"DeclaringType: {item.DeclaringType}\tIsPrivate: {item.IsPrivate}\tIsPublic: {item.IsPublic}\n" +
                $"Type: {item.GetType().GetTypeInfo()}";
                if (item.GetParameters().Length > 0)
                {
                    string itemParams = "";
                    foreach (var param in item.GetParameters())
                    {
                        itemParams += $"\nParam: {param}\tParamType: {param.ParameterType}";

                    }
                    MethodInfoResult += itemParams;
                }
                MethodInfoResult += "\n----------------------------------------\n";
            }
            Console.WriteLine(MethodInfoResult);
        }
    }

    /// <summary>
    /// Defines the <see cref="MyAtt" />.
    /// </summary>
    public class MyAtt : Attribute
    {
    }

    /// <summary>
    /// Defines the <see cref="Ogrenci" />.
    /// </summary>
    public class Ogrenci
    {
        /// <summary>
        /// Defines the _tc.
        /// </summary>
        private string _tc = "123456";

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Tc.
        /// </summary>
        public string Tc
        {
            get { return _tc; }
            set { _tc = value; }
        }

        /// <summary>
        /// Defines the myInt.
        /// </summary>
        private int myInt = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ogrenci"/> class.
        /// </summary>
        /// <param name="newINt">The newINt<see cref="int"/>.</param>
        public Ogrenci(int newINt)
        {
            myInt = newINt;
        }

        /// <summary>
        /// The Change_tc.
        /// </summary>
        /// <param name="tc">The tc<see cref="string"/>.</param>
        private void Change_tc(string tc)
        {

            _tc = tc;
            Console.WriteLine("changed" + _tc);
        }

        /// <summary>
        /// The ChangeTc.
        /// </summary>
        /// <param name="tc">The tc<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string ChangeTc(string tc)
        {
            Tc = tc;
            return Tc;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int Show()
        {

            return myInt;
        }
    }
}
