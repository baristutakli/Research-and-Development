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
            Type obj = typeof(Ogrenci);
            Console.WriteLine("Method infos");
            foreach (MethodInfo item in obj.GetMethods())
            {
                Console.WriteLine($"name:{item.Name} parameters:{item.GetParameters().Length} return type: {item.ReturnType}\n" +
                    $"methodBody: {item.GetMethodBody()} ısPrivate: {item.IsPrivate} ısPublic: {item.IsPublic}\n");
                if (item.GetParameters().Length>0)
                {
                    Console.WriteLine("param:"+item.GetParameters()[0]);
                }
                
            }
            Console.WriteLine("----------------------");
            foreach (FieldInfo item in obj.GetFields())
            {
                Console.WriteLine($"fieldtype: {item.FieldType} fieldName: {item.Name}");
            }
            Console.WriteLine("----------------------");
            object newobj = Activator.CreateInstance(obj,5);
            MethodInfo method= obj.GetMethod("Show");

            Console.WriteLine(method.Invoke(newobj, null));


        }
    }

    /// <summary>
    /// Defines the <see cref="Ogrenci" />.
    /// </summary>
    public class Ogrenci
    {
        /// <summary>
        /// Defines the tc.
        /// </summary>
        private string _tc="123456";

        public string FirstName { get; set; }
        public string Tc { get { return _tc; } set { _tc = value; } }
        private int myInt = 0;
        
        public Ogrenci(int newINt)
        {
            myInt = newINt;
        }

        private void Change_tc(string tc)
        {
        
            _tc = tc;
            Console.WriteLine("changed"+_tc);
        }
        public string  ChangeTc(string tc)
        {
            Tc = tc;
            return Tc;
        }
        public int Show()
        {
            
            return myInt;
        }

    }
}
